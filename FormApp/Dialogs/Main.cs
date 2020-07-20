using CSharpExtendedCommands.DataTypes;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace FormApp.Dialogs
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            //server = new RemoteDesktopServer();
            //server.DisplayImage += Server_DisplayImage;
            //server.Display += Server_Display;
            //Shown += delegate (object sender, EventArgs e)
            //{
            //    new Thread(() => server.StartListening(54782)).Start();
            //};
            new Client().Show();
        }

        private void toolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            remoteDesktopServer1.Start();
            //remoteDesktop1.StartRemoteDesktop();
            //remoteDesktop1.LoadCommunication();
        }
        private void sTopToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            remoteDesktopServer1.Stop();
            //remoteDesktop1.StopRemoteDesktop();
        }

        private void pauseViewToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var data = new BinaryData(Convert.ToString(510892, 2));
            MessageBox.Show(data);
            MessageBox.Show((new BinaryData("a") > "b").ToString());
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            remoteDesktopServer1.Initialize();
        }

        private void sendMessageBoxToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Action<object> action = (t) => MessageBox.Show(t.ToString());
            object p = Interaction.InputBox("Message", "Send MessageBox");
            object[] send = new object[] { "MethodInvoke", action, p };
            if (p.ToString() != "")
                remoteDesktopServer1.Send(send);
        }
    }
}
