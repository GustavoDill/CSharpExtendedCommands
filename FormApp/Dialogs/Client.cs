using System;
using System.Windows.Forms;

namespace FormApp.Dialogs
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        RemoteDesktopClient client;
        RemoteDesktop remoteDesktop;
        private void button1_Click(object sender, EventArgs e)
        {
            remoteDesktop = new RemoteDesktop(RemoteDesktop.OperationMode.Client, "127.0.0.1", new RemoteDesktop.RemoteDesktopPorts(54782));
            remoteDesktop.InitializeViewer();
            remoteDesktop.Viewer.StartViewer();
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
    }
}
