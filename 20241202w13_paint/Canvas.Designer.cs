namespace _20241202w13_paint
{
    partial class frmCanvas
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxMain = new System.Windows.Forms.PictureBox();
            this.dlgOpenJPG = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.dlgSaveJPG = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSaveAs,
            this.toolStripSeparator1,
            this.tsmiQuit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiNew.Size = new System.Drawing.Size(270, 34);
            this.tsmiNew.Text = "New";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(270, 34);
            this.tsmiOpen.Text = "Open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSaveAs.Size = new System.Drawing.Size(270, 34);
            this.tsmiSaveAs.Text = "Save as...";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.tsmiQuit.Size = new System.Drawing.Size(270, 34);
            this.tsmiQuit.Text = "Quit";
            this.tsmiQuit.Click += new System.EventHandler(this.tsmiQuit_Click);
            // 
            // pbxMain
            // 
            this.pbxMain.Location = new System.Drawing.Point(12, 36);
            this.pbxMain.Name = "pbxMain";
            this.pbxMain.Size = new System.Drawing.Size(100, 50);
            this.pbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxMain.TabIndex = 1;
            this.pbxMain.TabStop = false;
            this.pbxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxMain_MouseDown);
            this.pbxMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxMain_MouseMove);
            // 
            // dlgOpenJPG
            // 
            this.dlgOpenJPG.Filter = "JPG|*.jpg";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFileName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslFileName
            // 
            this.tsslFileName.Name = "tsslFileName";
            this.tsslFileName.Size = new System.Drawing.Size(90, 25);
            this.tsslFileName.Text = "File Name";
            // 
            // dlgSaveJPG
            // 
            this.dlgSaveJPG.Filter = "JPG|*.jpg";
            // 
            // frmCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pbxMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCanvas";
            this.Text = "Canvas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCanvas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        private System.Windows.Forms.PictureBox pbxMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog dlgOpenJPG;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslFileName;
        private System.Windows.Forms.SaveFileDialog dlgSaveJPG;
    }
}

