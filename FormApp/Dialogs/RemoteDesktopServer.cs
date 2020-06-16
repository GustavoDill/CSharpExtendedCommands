using CSharpExtendedCommands.Info;
using CSharpExtendedCommands.Web.Communication;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace FormApp.Dialogs
{
    public class RemoteDesktopServer : PictureBox
    {
        #region Fields
        TcpClient client;
        TcpListener listener;
        BinaryFormatter binaryFormatter;
        Thread ClientUpdater;
        NetworkStream mainStream;
        #endregion

        #region Properties
        public int Port { get; set; } = 54782;
        [Browsable(false), CompilerGenerated]
        public bool Enabled { get; private set; }
        #endregion

        #region Constructors
        public RemoteDesktopServer()
        {
            Constructor(54782);
        }

        void Constructor(int port)
        {
            Port = port;
            SizeMode = PictureBoxSizeMode.Zoom;
        }
        #endregion

        #region Initialization
        protected override void InitLayout()
        {
            base.InitLayout();
            Initialize();
        }
        public void Initialize()
        {
            listener = new TcpListener(Port);
            ClientUpdater = new Thread(OnClientUpdate);
            binaryFormatter = new BinaryFormatter();
        }
        #endregion

        TCPClient cs_tcp;
        void OnClientUpdate()
        {
            if (client == null)
            {
                client = listener.AcceptTcpClient();
                cs_tcp = new TCPClient(client);
            }
            while (client.Connected)
            {
                try
                {
                    if (!Enabled)
                        goto Jmp;
                    mainStream = client.GetStream();
                    var obj = binaryFormatter.Deserialize(mainStream);
                    if (obj != null)
                        OnClientDataReceived(obj);
                    Jmp:;
                }
                catch { }
            }
        }
        void OnClientDataReceived(object data)
        {
            if (data is Image)
                Image = (Image)data;
        }
        public void Send(object send)
        {
            //bool flag = Enabled;
            //if (Enabled)
            //    Enabled = false;
            mainStream = client.GetStream();
            Try(() => binaryFormatter.Serialize(mainStream, send));
            //if (flag)
            //    Enabled = true;
        }

        public void Start()
        {
            if (Enabled)
                return;
            if (client is null)
                listener.Start();
            if (!ClientUpdater.IsAlive)
                ClientUpdater.Start();
#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning restore CS0618 // Type or member is obsolete
            Enabled = true;
        }
        public void Stop()
        {
            if (!Enabled)
                return;
            Enabled = false;
        }
        void Try(Action action) { try { action.Invoke(); } catch { } }
        public void Shutdown()
        {
            if (ClientUpdater.IsAlive)
                ClientUpdater.Abort();
            Try(() => listener.Server.Shutdown(SocketShutdown.Both));
            Try(() => listener.Server.Close());
            Try(() => listener.Server.Dispose());
            Try(() => client.Client.Shutdown(SocketShutdown.Both));
            Try(() => client.Client.Close());
            Try(() => client.Client.Dispose());
        }
    }
    public class Message
    {
        public Message(Action action)
        {
            Action = action;
        }
        public Message(Action<object> pAction, object parameter)
        {
            ParamAction = pAction;
            Parameter = parameter;
        }

        public Message(Enum enumerator)
        {
            Enumerator = enumerator;
        }

        public Message(int number)
        {
            Number = number;
        }

        public Message(string text)
        {
            Text = text;
        }
        public Message(object parameter)
        {
            Parameter = parameter;
        }
        public void Execute()
        {
            if (Action != null)
                Action.Invoke();
            if (ParamAction != null && Parameter != null)
                ParamAction.Invoke(Parameter);
        }
        public Action Action { get; set; }
        public Action<object> ParamAction { get; set; }
        public string Text { get; set; }
        public int Number { get; set; }
        public Enum Enumerator { get; set; }
        public object Parameter { get; set; }
    }
    public class RemoteDesktopClient : Component
    {
        #region Fields
        TcpClient client;
        NetworkStream mainStream;
        Thread ClientStreamer;
        Thread Receiver;
        bool desktopStreamDelay = false;
        private BinaryFormatter binaryFormatter;
        #endregion

        #region Properties
        private bool _canReceive;

        public bool CanReceive
        {
            get { return _canReceive; }
            set { if (!Enabled) _canReceive = value; }
        }

        public bool IsShutdown { get; private set; }
        public int Port { get; set; } = 54782;
        [Browsable(false)]
        public bool Enabled { get; private set; }
        [Browsable(false)]
        private IPAddress HostIp { get; set; } = IPAddress.Parse("127.0.0.1");//{ get { try { return IPAddress.Parse(Host); } catch { return null; } } }
        public string Host
        {
            get { return HostIp.ToString(); }
            set { try { HostIp = IPAddress.Parse(value); } catch { } }
        }
        #endregion

        #region Constructors
        public RemoteDesktopClient() { }
        public RemoteDesktopClient(string host, int port)
        {
            Constructor(host, port);
        }
        void Constructor(string host, int port)
        {
            HostIp = Dns.GetHostAddresses(host)[0];
            Port = port;
        }
        #endregion

        #region Initialialization
        public void Initialize()
        {
            binaryFormatter = new BinaryFormatter();
            ClientStreamer = new Thread(Stream);
            Receiver = new Thread(Receive);
            client = new TcpClient();
        }
        #endregion
        bool CheckMessage(object[] obj, string check)
        {
            if (!(obj.Length > 0))
                return false;
            if (!(obj[0] is string))
                return false;
            return obj[0].ToString() == check;
        }
        void InvokeMethod(object[] msg)
        {
            if (msg[1] is Action<object>)
                ((Action<object>)msg[1]).Invoke(msg[2]);
            else
                ((Action)msg[1]).Invoke();
        }
        void Receive()
        {
            while (client.Connected)
            {
                try
                {
                    mainStream = client.GetStream();
                    var obj = binaryFormatter.Deserialize(mainStream);
                    if (obj is Action)
                        ((Action)obj).Invoke();
                    if (obj is object[])
                        if (CheckMessage((object[])obj, "MethodInvoke"))
                            InvokeMethod((object[])obj);
                }
                catch { }
            }
        }

        public void Stream(object send)
        {
            while (client.Connected)
            {
                try
                {

                    mainStream = client.GetStream();
                    if (send != null)
                        binaryFormatter.Serialize(mainStream, send);
                    else if (Enabled)
                        binaryFormatter.Serialize(mainStream, ComputerInfo.Screenshot);
                }
                catch { }
                if (desktopStreamDelay)
                    Thread.Sleep(1);
            }
        }

        public void Shutdown()
        {
            StopStream();
            if (ClientStreamer.IsAlive)
                ClientStreamer.Abort();
            Try(() => client.Client.Shutdown(SocketShutdown.Both));
            Try(() => client.Client.Close());
            Try(() => client.Client.Dispose());
            IsShutdown = true;
        }

        void Try(Action action) { try { action.Invoke(); } catch { } }

        public void StartStream()
        {
            if (IsShutdown)
                throw new ObjectDisposedException("RemoteDesktop object already shutdown!");
            if (!client.Connected)
                client.Connect(Host, Port);
            if (!ClientStreamer.IsAlive)
                ClientStreamer.Start();
            if (CanReceive && !Receiver.IsAlive)
                Receiver.Start();
            Enabled = true;
        }
        public void StopStream()
        {
            if (!Enabled)
                return;
            Enabled = false;
        }
        public void StopReceiveing()
        {
            if (Receiver.IsAlive)
                Receiver.Abort();
        }
    }
}
