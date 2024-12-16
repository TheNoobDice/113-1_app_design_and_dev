namespace _20241125w12_image_viewer
{
    partial class frmImageViewer
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
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOriginalSize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRotateClockwise = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRotate180 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRotateAntiClockwise = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFilpHorizontally = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilpVertically = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxMain = new System.Windows.Forms.PictureBox();
            this.dlgOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslZoomRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslImageSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPictBoxSize = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.tsmiFile,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(54, 32);
            this.tsmiFile.Text = "File";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(223, 34);
            this.tsmiOpen.Text = "Open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.tsmiExit.Size = new System.Drawing.Size(223, 34);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiZoomIn,
            this.tsmiZoomOut,
            this.tsmiOriginalSize,
            this.toolStripSeparator2,
            this.tsmiRotateClockwise,
            this.tsmiRotate180,
            this.tsmiRotateAntiClockwise,
            this.toolStripSeparator3,
            this.tsmiFilpHorizontally,
            this.tsmiFilpVertically});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // tsmiZoomIn
            // 
            this.tsmiZoomIn.Name = "tsmiZoomIn";
            this.tsmiZoomIn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.tsmiZoomIn.Size = new System.Drawing.Size(343, 34);
            this.tsmiZoomIn.Text = "Zoom In";
            this.tsmiZoomIn.Click += new System.EventHandler(this.tsmiZoomIn_Click);
            // 
            // tsmiZoomOut
            // 
            this.tsmiZoomOut.Name = "tsmiZoomOut";
            this.tsmiZoomOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmiZoomOut.Size = new System.Drawing.Size(343, 34);
            this.tsmiZoomOut.Text = "Zoom Out";
            this.tsmiZoomOut.Click += new System.EventHandler(this.tsmiZoomOut_Click);
            // 
            // tsmiOriginalSize
            // 
            this.tsmiOriginalSize.Name = "tsmiOriginalSize";
            this.tsmiOriginalSize.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.tsmiOriginalSize.Size = new System.Drawing.Size(366, 34);
            this.tsmiOriginalSize.Text = "Original Size";
            this.tsmiOriginalSize.Click += new System.EventHandler(this.tsmiOriginalSize_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(363, 6);
            // 
            // tsmiRotateClockwise
            // 
            this.tsmiRotateClockwise.Name = "tsmiRotateClockwise";
            this.tsmiRotateClockwise.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.tsmiRotateClockwise.Size = new System.Drawing.Size(343, 34);
            this.tsmiRotateClockwise.Text = "Rotate Clockwise";
            this.tsmiRotateClockwise.Click += new System.EventHandler(this.tsmiRotateClockwise_Click);
            // 
            // tsmiRotate180
            // 
            this.tsmiRotate180.Name = "tsmiRotate180";
            this.tsmiRotate180.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.tsmiRotate180.Size = new System.Drawing.Size(366, 34);
            this.tsmiRotate180.Text = "Rotate 180°";
            this.tsmiRotate180.Click += new System.EventHandler(this.tsmiRotate180_Click);
            // 
            // tsmiRotateAntiClockwise
            // 
            this.tsmiRotateAntiClockwise.Name = "tsmiRotateAntiClockwise";
            this.tsmiRotateAntiClockwise.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.tsmiRotateAntiClockwise.Size = new System.Drawing.Size(343, 34);
            this.tsmiRotateAntiClockwise.Text = "Rotate Anti-Clockwise";
            this.tsmiRotateAntiClockwise.Click += new System.EventHandler(this.tsmiRotateAntiClockwise_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(363, 6);
            // 
            // tsmiFilpHorizontally
            // 
            this.tsmiFilpHorizontally.Name = "tsmiFilpHorizontally";
            this.tsmiFilpHorizontally.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.tsmiFilpHorizontally.Size = new System.Drawing.Size(366, 34);
            this.tsmiFilpHorizontally.Text = "Filp Horizontally";
            this.tsmiFilpHorizontally.Click += new System.EventHandler(this.tsmiFilpHorizontally_Click);
            // 
            // tsmiFilpVertically
            // 
            this.tsmiFilpVertically.Name = "tsmiFilpVertically";
            this.tsmiFilpVertically.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.tsmiFilpVertically.Size = new System.Drawing.Size(366, 34);
            this.tsmiFilpVertically.Text = "Filp Vertically";
            this.tsmiFilpVertically.Click += new System.EventHandler(this.tsmiFilpVertically_Click);
            // 
            // pbxMain
            // 
            this.pbxMain.Location = new System.Drawing.Point(12, 36);
            this.pbxMain.Name = "pbxMain";
            this.pbxMain.Size = new System.Drawing.Size(100, 50);
            this.pbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMain.TabIndex = 1;
            this.pbxMain.TabStop = false;
            this.pbxMain.Click += new System.EventHandler(this.tsmiZoomOut_Click);
            // 
            // dlgOpenImage
            // 
            this.dlgOpenImage.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFileName,
            this.tsslZoomRate,
            this.tsslImageSize,
            this.tsslPictBoxSize});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslFileName
            // 
            this.tsslFileName.Name = "tsslFileName";
            this.tsslFileName.Size = new System.Drawing.Size(90, 25);
            this.tsslFileName.Text = "File Name";
            // 
            // tsslZoomRate
            // 
            this.tsslZoomRate.Name = "tsslZoomRate";
            this.tsslZoomRate.Size = new System.Drawing.Size(100, 25);
            this.tsslZoomRate.Text = "Zoom Rate";
            // 
            // tsslImageSize
            // 
            this.tsslImageSize.Enabled = false;
            this.tsslImageSize.Name = "tsslImageSize";
            this.tsslImageSize.Size = new System.Drawing.Size(98, 25);
            this.tsslImageSize.Text = "Image Size";
            this.tsslImageSize.Visible = false;
            // 
            // tsslPictBoxSize
            // 
            this.tsslPictBoxSize.Enabled = false;
            this.tsslPictBoxSize.Name = "tsslPictBoxSize";
            this.tsslPictBoxSize.Size = new System.Drawing.Size(105, 25);
            this.tsslPictBoxSize.Text = "PictBox Size";
            this.tsslPictBoxSize.Visible = false;
            // 
            // frmImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pbxMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmImageViewer";
            this.Text = "Image Viewer";
            this.ResizeEnd += new System.EventHandler(this.frmImageViewer_ResizeEnd);
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
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.PictureBox pbxMain;
        private System.Windows.Forms.OpenFileDialog dlgOpenImage;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiZoomIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiZoomOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiOriginalSize;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslFileName;
        private System.Windows.Forms.ToolStripStatusLabel tsslZoomRate;
        private System.Windows.Forms.ToolStripMenuItem tsmiRotateClockwise;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiRotate180;
        private System.Windows.Forms.ToolStripMenuItem tsmiRotateAntiClockwise;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilpHorizontally;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilpVertically;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel tsslImageSize;
        private System.Windows.Forms.ToolStripStatusLabel tsslPictBoxSize;
    }
}

