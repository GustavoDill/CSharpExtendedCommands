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
            this.remoteDesktopServer1 = new FormApp.Dialogs.RemoteDesktopServer();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMessageBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remoteDesktopServer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(128)))), ((int)(((byte)(162)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.sTopToolStripMenuItem,
            this.pauseViewToolStripMenuItem,
            this.actionsToolStripMenuItem});
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
            // remoteDesktopServer1
            // 
            this.remoteDesktopServer1.BackColor = System.Drawing.Color.Black;
            this.remoteDesktopServer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remoteDesktopServer1.Location = new System.Drawing.Point(0, 0);
            this.remoteDesktopServer1.Name = "remoteDesktopServer1";
            this.remoteDesktopServer1.Port = 54782;
            this.remoteDesktopServer1.Size = new System.Drawing.Size(534, 343);
            this.remoteDesktopServer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.remoteDesktopServer1.TabIndex = 2;
            this.remoteDesktopServer1.TabStop = false;
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendMessageBoxToolStripMenuItem});
            this.actionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // sendMessageBoxToolStripMenuItem
            // 
            this.sendMessageBoxToolStripMenuItem.Name = "sendMessageBoxToolStripMenuItem";
            this.sendMessageBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sendMessageBoxToolStripMenuItem.Text = "Send MessageBox";
            this.sendMessageBoxToolStripMenuItem.Click += new System.EventHandler(this.sendMessageBoxToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 367);
            this.Controls.Add(this.remoteDesktopServer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remoteDesktopServer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseViewToolStripMenuItem;
        private RemoteDesktopServer remoteDesktopServer1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendMessageBoxToolStripMenuItem;
    }
}