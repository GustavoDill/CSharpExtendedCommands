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
            remoteDesktop1.StartRemoteDesktop();
            //remoteDesktop1.LoadCommunication();
        }
        private void sTopToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            remoteDesktop1.StopRemoteDesktop();
        }

        private void pauseViewToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            remoteDesktop1.ShutdownRemoteDesktop();
        }
    }
}
