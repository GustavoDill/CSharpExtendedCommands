using CSharpExtendedCommands.Web.Communication;
using System;
using System.Windows.Forms;

namespace FormApp.Dialogs
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            Load += Client_Load;
        }

        private void Client_Load(object sender, EventArgs e)
        {
            remoteDesktopClient1.Initialize();
        }

        //RemoteDesktop remoteDesktop;
        private void button1_Click(object sender, EventArgs e)
        {
            //remoteDesktop = new RemoteDesktop(RemoteDesktop.OperationMode.Client, "127.0.0.1", new RemoteDesktop.RemoteDesktopPorts(54781, 54780));
            ////remoteDesktop.LoadCommunication();
            //remoteDesktop.InitializeViewer();
            //remoteDesktop.Viewer.StartViewer();
            //client = new RemoteDesktopClient();
            //var ip = Interaction.InputBox("Server host", "Input host", "127.0.0.1");
            //if (ip != "")
            //{
            //    var port = Interaction.InputBox("Server port", "Input port", "54782");
            //    if (port != "")
            //    {
            //        client.Connect(ip, ushort.Parse(port));
            //        client.StartStream();
            //    }
            //}
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TCPClient client = new TCPClient("127.0.0.1", 54782);
            client.Connect();
            //remoteDesktopClient1.StartStream();
        }

        private void pauseStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            remoteDesktopClient1.StopStream();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            remoteDesktopClient1.Shutdown();
        }
    }
}
