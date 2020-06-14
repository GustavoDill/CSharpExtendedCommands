using CSharpExtendedCommands.Web.Communication;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace FormApp.Dialogs
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            remoteDesktop = new RemoteDesktop(RemoteDesktop.OperationMode.Server, new RemoteDesktop.RemoteDesktopPorts(54782));
            remoteDesktop.InitializeViewer();
            remoteDesktop.Viewer.StartViewer();
            remoteDesktop.ViewDesktop += RemoteDesktop_ViewDesktop;
            //server = new RemoteDesktopServer();
            //server.DisplayImage += Server_DisplayImage;
            //server.Display += Server_Display;
            //Shown += delegate (object sender, EventArgs e)
            //{
            //    new Thread(() => server.StartListening(54782)).Start();
            //};
        }

        private void RemoteDesktop_ViewDesktop(Image desktopImage)
        {
            pictureBox1.Image = desktopImage;
        }

        RemoteDesktop remoteDesktop;

        private NetworkStream mainStream;
        private void Server_Display(TCPClient client)
        {
            new Thread(new ParameterizedThreadStart(Display)).Start(client);
        }
        void Display(object p)
        {
            var ct = (TCPClient)p;
            BinaryFormatter formatter = new BinaryFormatter();
            while (ct.Connected)
            {
                mainStream = ct.GetStream();
                pictureBox1.Image = (Image)formatter.Deserialize(mainStream);
            }
        }
        private void Server_DisplayImage(object sender, RemoteDesktopServer.RemoteDesktopDisplayArgs e)
        {
            pictureBox1.Image = e.Image;
        }
    }
}
