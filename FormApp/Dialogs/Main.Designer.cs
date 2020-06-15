namespace FormApp.Dialogs
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteDesktop1 = new CSharpExtendedCommands.Web.Communication.RemoteDesktop();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remoteDesktop1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(128)))), ((int)(((byte)(162)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.sTopToolStripMenuItem,
            this.pauseViewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 343);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem1.Text = "Start";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // sTopToolStripMenuItem
            // 
            this.sTopToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sTopToolStripMenuItem.Name = "sTopToolStripMenuItem";
            this.sTopToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sTopToolStripMenuItem.Text = "Stop";
            this.sTopToolStripMenuItem.Click += new System.EventHandler(this.sTopToolStripMenuItem_Click);
            // 
            // pauseViewToolStripMenuItem
            // 
            this.pauseViewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pauseViewToolStripMenuItem.Name = "pauseViewToolStripMenuItem";
            this.pauseViewToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.pauseViewToolStripMenuItem.Text = "Shutdown";
            this.pauseViewToolStripMenuItem.Click += new System.EventHandler(this.pauseViewToolStripMenuItem_Click);
            // 
            // remoteDesktop1
            // 
            this.remoteDesktop1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remoteDesktop1.Initializations = new string[] {
        "All",
        "Viewer",
        "LifetimeService"};
            this.remoteDesktop1.Location = new System.Drawing.Point(0, 0);
            this.remoteDesktop1.Mode = CSharpExtendedCommands.Web.Communication.RemoteDesktop.OperationMode.Server;
            this.remoteDesktop1.Name = "remoteDesktop1";
            this.remoteDesktop1.Size = new System.Drawing.Size(534, 340);
            this.remoteDesktop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.remoteDesktop1.TabIndex = 0;
            this.remoteDesktop1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 367);
            this.Controls.Add(this.remoteDesktop1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remoteDesktop1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CSharpExtendedCommands.Web.Communication.RemoteDesktop remoteDesktop1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseViewToolStripMenuItem;
    }
}