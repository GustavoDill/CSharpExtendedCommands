using CSharpExtendedCommands.Info;
using CSharpExtendedCommands.Web.Communication;
using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace FormApp.Dialogs
{
    public class RemoteDesktop
    {
        public OperationMode Mode { get; private set; }
        public RemoteDesktopPorts Ports { get; private set; }
        public IPAddress Ip { get; private set; }

        public struct RemoteDesktopPorts
        {
            public RemoteDesktopPorts(ushort viewerPort)
            {
                ViewerPort = viewerPort;
            }
            public ushort ViewerPort { get; set; }
        }
        public enum OperationMode
        {
            Client,
            Server
        }
        public void Constructor(OperationMode mode, IPAddress ip, RemoteDesktopPorts ports)
        {
            Mode = mode;
            Ip = ip;
            Ports = ports;
        }
        public RemoteDesktop(OperationMode mode, string ip, RemoteDesktopPorts ports)
        {
            Constructor(mode, IPAddress.Parse(ip), ports);
        }
        public RemoteDesktop(OperationMode mode, RemoteDesktopPorts ports)
        {
            Constructor(mode, null, ports);
        }
        public RemoteDesktopViewer Viewer { get; private set; }
        public void InitializeViewer()
        {
            switch (Mode)
            {
                case OperationMode.Client:
                    Viewer = new RemoteDesktopViewer(Mode, Ip, Ports.ViewerPort);
                    break;
                case OperationMode.Server:
                    Viewer = new RemoteDesktopViewer(Mode, Ports.ViewerPort);
                    Viewer.ViewDesktop += delegate (Image img) { ViewDesktop?.Invoke(img); };
                    break;
            }
        }
        public event RemoteDesktopViewer.ViewDesktopHandler ViewDesktop;

        public class RemoteDesktopViewer
        {
            TcpListener listener;
            TcpClient client;
            NetworkStream mainStream;
            Action Start;
            public void StartViewer()
            {
                Start.Invoke();
            }
            void Constructor(OperationMode mode, IPAddress ip, ushort port)
            {
                Mode = mode;
                BinaryFormatter formatter = new BinaryFormatter();
                switch (mode)
                {
                    case OperationMode.Client:
                        client = new TcpClient();
                        var t = new Thread(() =>
                        {
                            client.Connect(ip, port);
                            while (client.Connected)
                            {
                                mainStream = client.GetStream();
                                formatter.Serialize(mainStream, ComputerInfo.Screenshot);
                            }

                        });
                        Start = () => { t.Start(); };
                        break;
                    case OperationMode.Server:
                        listener = new TcpListener(port);
                        var t2 = new Thread(() =>
                        {
                            listener.Start();
                            var client = listener.AcceptTcpClient();
                            while (client.Connected)
                            {
                                mainStream = client.GetStream();
                                ViewDesktop?.Invoke((Image)formatter.Deserialize(mainStream));
                            }
                        });
                        Start = () => { t2.Start(); };
                        break;
                }
            }
            public delegate void ViewDesktopHandler(Image desktopImage);
            public event ViewDesktopHandler ViewDesktop;
            public RemoteDesktopViewer(OperationMode mode, ushort port)
            {
                Constructor(mode, null, port);
            }
            public RemoteDesktopViewer(OperationMode mode, string host, ushort port)
            {
                Constructor(mode, Dns.GetHostAddresses(host)[0], port);
            }
            public RemoteDesktopViewer(OperationMode mode, IPAddress ip, ushort port)
            {
                Constructor(mode, ip, port);
            }

            public OperationMode Mode { get; private set; }
        }
    }
    public class RemoteDesktopServer
    {
        public TCPServer server;
        private NetworkStream stream;
        public delegate void DisplayHandler(TCPClient client);
        public event DisplayHandler Display;
        public void StartListening(ushort port)
        {
            server?.Shutdown();
            server = new TCPServer(port);
            server.Start();
            server.ClientConnected += Server_ClientConnected;
        }

        private void Server_ClientConnected1(object sender, TCPServer.ClientConnectionArgs e)
        {

        }

        private bool Server_ClientTryConnect(object sender, TCPServer.ClientConnectionArgs e)
        {
            return true;
        }
        public class RemoteDesktopDisplayArgs : EventArgs
        {
            public RemoteDesktopDisplayArgs(Image img)
            {
                Image = img;
            }

            public Image Image { get; }
        }
        public event EventHandler<RemoteDesktopDisplayArgs> DisplayImage;
        private void Server_ClientConnected(object sender, TCPServer.ClientConnectionArgs e)
        {
            Display.Invoke(e.Client);
            //new Thread(new ParameterizedThreadStart(ReceiveStream)).Start(e.Client);
        }
        void ReceiveStream(object p)
        {
            var client = (TCPClient)p;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            while (client.Connected)
            {
                stream = client.GetStream();
                DisplayImage?.Invoke(this, new RemoteDesktopDisplayArgs((Image)binaryFormatter.Deserialize(stream)));
            }
        }
    }
    public class RemoteDesktopClient
    {
        TCPClient client;
        public void Connect(string host, ushort port)
        {
            client = new TCPClient(host, port);
            client.Connect();
        }
        System.Threading.Timer timer;
        public void StartStream()
        {
            timer = new System.Threading.Timer(SendImage, null, 10, 10);
        }
        void SendImage(object p)
        {
            SendDesktopImage();
        }
        public void StopStream()
        {
            timer.Dispose();
        }
        public static Image DesktopImage
        {
            get
            {
                Rectangle bound = Screen.PrimaryScreen.Bounds;
                Bitmap bmp = new Bitmap(bound.Width, bound.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                Graphics graph = Graphics.FromImage(bmp);
                graph.CopyFromScreen(bound.X, bound.Y, 0, 0, bound.Size, CopyPixelOperation.SourceCopy);
                return bmp;
            }
        }
        NetworkStream mainStream;
        int port;
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        public void SendDesktopImage()
        {
            mainStream = client.GetStream();
            binaryFormatter.Serialize(mainStream, DesktopImage);

        }
    }
    //public class TCPClient : System.Net.Sockets.TcpClient
    //{
    //    public void SetConnectionServer(string host, ushort port)
    //    {
    //        Ip = IPAddress.Parse(host);
    //        Port = port;
    //    }
    //    internal virtual void Setup()
    //    {
    //        //ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    //    }
    //    public virtual void Connect()
    //    {
    //        if (!Connected)
    //        { try { ClientSocket.Connect(Ip, Port); } catch (Exception ex) { throw ex; } }
    //    }
    //    public virtual void Disconnect()
    //    {
    //        Disconnect(true);
    //    }
    //    public virtual void Shutdown()
    //    {
    //        Shutdown(SocketShutdown.Both);
    //    }
    //    public virtual void Shutdown(SocketShutdown shutdown)
    //    {
    //        if (Connected)
    //        {
    //            ClientSocket.Shutdown(shutdown);
    //        }
    //    }
    //    public virtual void ShutdownAndClose()
    //    {
    //        ShutdownAndClose(SocketShutdown.Both);
    //    }
    //    public virtual void ShutdownAndClose(SocketShutdown shutdown)
    //    {
    //        if (Connected)
    //        {
    //            ClientSocket.Shutdown(shutdown);
    //            ClientSocket.Close();
    //        }
    //    }
    //    public virtual void BeginConnect(AsyncCallback callback, object state)
    //    {
    //        ClientSocket.BeginConnect(Ip, Port, callback, state);
    //    }
    //    public virtual void BeginConnect(AsyncCallback callback)
    //    {
    //        BeginConnect(callback, null);
    //    }
    //    public virtual void EndConnect(IAsyncResult result)
    //    {
    //        ClientSocket.EndConnect(result);
    //    }
    //    public virtual void Disconnect(bool reuseSocket)
    //    {
    //        ClientSocket.Disconnect(reuseSocket);
    //    }
    //    public virtual void EndDisconnect(IAsyncResult result)
    //    {
    //        ClientSocket.EndDisconnect(result);
    //    }
    //    public virtual void BeginDisconnect(bool reuseSocket, AsyncCallback callback)
    //    {
    //        BeginDisconnect(reuseSocket, callback);
    //    }
    //    public virtual void BeginDisconnect(bool reuseSocket, AsyncCallback callback, object state)
    //    {
    //        ClientSocket.BeginDisconnect(reuseSocket, callback, state);
    //    }
    //    public virtual AddressFamily AddressFamily { get => ClientSocket.AddressFamily; }
    //    public virtual int Avaliable { get => ClientSocket.Available; }
    //    public virtual bool EnableBroadcast { get => ClientSocket.EnableBroadcast; set => ClientSocket.EnableBroadcast = value; }

    //    public virtual Stream ReceiveFile()
    //    {
    //        var package = ReceivePackage();
    //        var buffer = package.Data;
    //        return new MemoryStream(buffer);
    //    }
    //    public virtual void ReceiveFile(string destPath)
    //    {
    //        byte[] buffer;
    //        int mustReceive = 8;
    //        List<byte> data = new List<byte>();
    //        while (mustReceive != 0)
    //        {
    //            buffer = new byte[mustReceive];
    //            var rec = ClientSocket.Receive(buffer, mustReceive, SocketFlags.None);
    //            mustReceive -= rec;
    //            if (rec != 0)
    //            {
    //                byte[] copy = new byte[rec];
    //                Array.Copy(buffer, copy, rec);
    //                data.AddRange(copy);
    //            }
    //        }
    //        string sizeData = Encoding.ASCII.GetString(data.ToArray());
    //        data.Clear();
    //        var size = Convert.ToInt32("0x" + sizeData, 16);
    //        mustReceive = size;
    //        if (mustReceive == 0)
    //            return;
    //        BinaryWriter writer = new BinaryWriter(File.OpenWrite(destPath));
    //        while (mustReceive != 0)
    //        {
    //            buffer = new byte[2048];
    //            int rec;
    //            if (mustReceive > 2048)
    //                rec = ClientSocket.Receive(buffer, 2048, SocketFlags.None);
    //            else
    //                rec = ClientSocket.Receive(buffer, mustReceive, SocketFlags.None);
    //            mustReceive -= rec;
    //            if (rec != 0)
    //            {
    //                byte[] copy = new byte[rec];
    //                Array.Copy(buffer, copy, rec);
    //                writer.Write(copy);
    //            }
    //        }
    //        writer.Close();
    //    }
    //    public virtual byte[] Receive()
    //    {
    //        return Receive(2048);
    //    }
    //    public virtual byte[] Receive(int bufferSize)
    //    {
    //        var buffer = new byte[bufferSize];
    //        int received = ClientSocket.Receive(buffer, SocketFlags.None);
    //        if (received == 0) return null;
    //        var data = new byte[received];
    //        Array.Copy(buffer, data, received);
    //        return data;
    //    }
    //    public virtual void SendPackage(TcpPackage package)
    //    {
    //        ClientSocket.Send(package.RawData, package.Size + 8, SocketFlags.None);
    //    }
    //    public virtual void SendPackage(TcpPackage package, SocketFlags flags)
    //    {
    //        ClientSocket.Send(package.RawData, package.Size + 8, flags);
    //    }
    //    public virtual void SendPackage(TcpPackage package, SocketFlags flags, out SocketError errorCode)
    //    {
    //        ClientSocket.Send(package.RawData, 0, package.Size + 8, flags, out errorCode);
    //    }
    //    public virtual byte[] ReceiveExact(int size)
    //    {
    //        int mustReceive = size;
    //        byte[] buffer;
    //        List<byte> data = new List<byte>();
    //        while (mustReceive != 0)
    //        {
    //            buffer = new byte[mustReceive];
    //            var rec = ClientSocket.Receive(buffer, mustReceive, SocketFlags.None);
    //            mustReceive -= rec;
    //            if (rec != 0)
    //            {
    //                byte[] copy = new byte[rec];
    //                Array.Copy(buffer, copy, rec);
    //                data.AddRange(copy);
    //            }
    //        }
    //        return data.ToArray();
    //    }
    //    public virtual TcpPackage ReceivePackage(int receiveBytesRate)
    //    {
    //        byte[] buffer;
    //        int mustReceive = 8;
    //        List<byte> data = new List<byte>();
    //        while (mustReceive != 0)
    //        {
    //            buffer = new byte[mustReceive];
    //            var rec = ClientSocket.Receive(buffer, mustReceive, SocketFlags.None);
    //            mustReceive -= rec;
    //            if (rec != 0)
    //            {
    //                byte[] copy = new byte[rec];
    //                Array.Copy(buffer, copy, rec);
    //                data.AddRange(copy);
    //            }
    //        }
    //        string sizeData = Encoding.ASCII.GetString(data.ToArray());
    //        var size = Convert.ToInt32("0x" + sizeData, 16);
    //        data.Clear();
    //        mustReceive = size;
    //        while (mustReceive != 0)
    //        {
    //            buffer = new byte[receiveBytesRate];
    //            int rec;
    //            if (mustReceive >= receiveBytesRate)
    //                rec = ClientSocket.Receive(buffer, receiveBytesRate, SocketFlags.None);
    //            else
    //                rec = ClientSocket.Receive(buffer, mustReceive, SocketFlags.None);
    //            mustReceive -= rec;
    //            if (rec != 0)
    //            {
    //                byte[] copy = new byte[rec];
    //                Array.Copy(buffer, copy, rec);
    //                data.AddRange(copy);
    //            }
    //        }
    //        return new TcpPackage(data.ToArray());
    //    }
    //    public virtual TcpPackage ReceivePackage()
    //    {
    //        byte[] buffer;
    //        int mustReceive = 8;
    //        List<byte> data = new List<byte>();
    //        while (mustReceive != 0)
    //        {
    //            buffer = new byte[mustReceive];
    //            var rec = ClientSocket.Receive(buffer, mustReceive, SocketFlags.None);
    //            mustReceive -= rec;
    //            if (rec != 0)
    //            {
    //                byte[] copy = new byte[rec];
    //                Array.Copy(buffer, copy, rec);
    //                data.AddRange(copy);
    //            }
    //        }
    //        string sizeData = Encoding.ASCII.GetString(data.ToArray());
    //        var size = Convert.ToInt32("0x" + sizeData, 16);
    //        data.Clear();
    //        mustReceive = size;
    //        while (mustReceive != 0)
    //        {
    //            buffer = new byte[mustReceive];
    //            var rec = ClientSocket.Receive(buffer, mustReceive, SocketFlags.None);
    //            mustReceive -= rec;
    //            if (rec != 0)
    //            {
    //                byte[] copy = new byte[rec];
    //                Array.Copy(buffer, copy, rec);
    //                data.AddRange(copy);
    //            }
    //        }
    //        return new TcpPackage(data.ToArray());
    //    }
    //    public virtual string ReceiveString()
    //    {
    //        return ReceiveString(2048);
    //    }
    //    public virtual string ReceiveString(int bufferSize)
    //    {
    //        string text = Encoding.ASCII.GetString(Receive(bufferSize));
    //        return text;
    //    }
    //    public virtual int Send(byte[] buffer)
    //    {
    //        return ClientSocket.Send(buffer);
    //    }
    //    public virtual int Send(byte[] buffer, SocketFlags flags)
    //    {
    //        return ClientSocket.Send(buffer, flags);
    //    }
    //    public virtual int Send(byte[] buffer, int size, SocketFlags flags)
    //    {
    //        return ClientSocket.Send(buffer, size, flags);
    //    }
    //    public virtual int Send(byte[] buffer, int offset, int size, SocketFlags flags)
    //    {
    //        return ClientSocket.Send(buffer, offset, size, flags);
    //    }
    //    public virtual int Send(byte[] buffer, int offset, int size, SocketFlags flags, out SocketError errorCode)
    //    {
    //        return ClientSocket.Send(buffer, offset, size, flags, out errorCode);
    //    }
    //    public virtual int SendString(string text)
    //    {
    //        return Send(Encoding.ASCII.GetBytes(text));
    //    }
    //    public virtual void SendFile(string file, SocketFlags flags, out SocketError errorCode)
    //    {
    //        var reader = new BinaryReader(File.OpenRead(file));
    //        var buffer = reader.ReadBytes((int)reader.BaseStream.Length);
    //        reader.Close();
    //        SendPackage(new TcpPackage(buffer), flags, out errorCode);
    //    }
    //    public virtual void SendFile(string file, SocketFlags flags)
    //    {
    //        SendFile(file, flags, out SocketError _);
    //    }
    //    public virtual void SendFile(string file)
    //    {
    //        SendFile(file, SocketFlags.None, out SocketError _);
    //    }
    //    public Socket ClientSocket { get => Client; }
    //    public IPAddress Ip { get; set; }

    //    internal ushort _port;

    //    public ushort Port
    //    {
    //        get { return _port; }
    //        set
    //        {
    //            if (value != 0)
    //                _port = value;
    //            else
    //                _port = _port == 0 ? ushort.Parse(new Random().Next(888, int.Parse(ushort.MaxValue.ToString())).ToString()) : _port;
    //        }
    //    }
    //}
}
