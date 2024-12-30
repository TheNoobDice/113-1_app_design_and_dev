namespace _20241223w16_image_processor
{
    partial class frmImageProcessor
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
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tssFileExit = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOriginalSize = new System.Windows.Forms.ToolStripMenuItem();
            this.tssViewRotate = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRotateClockwise = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRotate180 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRotateAntiClockwise = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBrighter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDarker = new System.Windows.Forms.ToolStripMenuItem();
            this.tssFilter = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiGrayScale = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBlackAndWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBlackAndWhiteV1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBlackAndWhiteV2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBlackAndWhiteV3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tssFilterChannels = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRedChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGreenChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBlueChannel = new System.Windows.Forms.ToolStripMenuItem();
            this.tssFilterInvert = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiInvertColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tssFilterReset = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiResetFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProcessing = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDownsample2x = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpsample2x = new System.Windows.Forms.ToolStripMenuItem();
            this.tssProcessFilp = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFilpHorizontally = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilpVertically = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxMain = new System.Windows.Forms.PictureBox();
            this.dlgOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslZoomRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslImageSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPictBoxSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.dlgSaveImage = new System.Windows.Forms.SaveFileDialog();
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
            this.tsmiView,
            this.tsmiFilters,
            this.tsmiProcessing});
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
            this.tsmiSaveAs,
            this.tssFileExit,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(54, 29);
            this.tsmiFile.Text = "File";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(237, 34);
            this.tsmiOpen.Text = "Open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSaveAs.Size = new System.Drawing.Size(237, 34);
            this.tsmiSaveAs.Text = "Save As";
            this.tsmiSaveAs.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // tssFileExit
            // 
            this.tssFileExit.Name = "tssFileExit";
            this.tssFileExit.Size = new System.Drawing.Size(234, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.tsmiExit.Size = new System.Drawing.Size(237, 34);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiZoomIn,
            this.tsmiZoomOut,
            this.tsmiOriginalSize,
            this.tssViewRotate,
            this.tsmiRotateClockwise,
            this.tsmiRotate180,
            this.tsmiRotateAntiClockwise});
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(65, 29);
            this.tsmiView.Text = "View";
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
            this.tsmiZoomOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.tsmiZoomOut.Size = new System.Drawing.Size(343, 34);
            this.tsmiZoomOut.Text = "Zoom Out";
            this.tsmiZoomOut.Click += new System.EventHandler(this.tsmiZoomOut_Click);
            // 
            // tsmiOriginalSize
            // 
            this.tsmiOriginalSize.Name = "tsmiOriginalSize";
            this.tsmiOriginalSize.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.tsmiOriginalSize.Size = new System.Drawing.Size(343, 34);
            this.tsmiOriginalSize.Text = "Original Size";
            this.tsmiOriginalSize.Click += new System.EventHandler(this.tsmiOriginalSize_Click);
            // 
            // tssViewRotate
            // 
            this.tssViewRotate.Name = "tssViewRotate";
            this.tssViewRotate.Size = new System.Drawing.Size(340, 6);
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
            this.tsmiRotate180.Size = new System.Drawing.Size(343, 34);
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
            // tsmiFilters
            // 
            this.tsmiFilters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBrighter,
            this.tsmiDarker,
            this.tssFilter,
            this.tsmiGrayScale,
            this.tsmiBlackAndWhite,
            this.tssFilterChannels,
            this.tsmiRedChannel,
            this.tsmiGreenChannel,
            this.tsmiBlueChannel,
            this.tssFilterInvert,
            this.tsmiInvertColor,
            this.tssFilterReset,
            this.tsmiResetFilters});
            this.tsmiFilters.Name = "tsmiFilters";
            this.tsmiFilters.Size = new System.Drawing.Size(74, 29);
            this.tsmiFilters.Text = "Filters";
            // 
            // tsmiBrighter
            // 
            this.tsmiBrighter.Name = "tsmiBrighter";
            this.tsmiBrighter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.tsmiBrighter.Size = new System.Drawing.Size(284, 34);
            this.tsmiBrighter.Text = "Brighter";
            this.tsmiBrighter.Click += new System.EventHandler(this.tsmiBrighter_Click);
            // 
            // tsmiDarker
            // 
            this.tsmiDarker.Name = "tsmiDarker";
            this.tsmiDarker.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.tsmiDarker.Size = new System.Drawing.Size(284, 34);
            this.tsmiDarker.Text = "Darker";
            this.tsmiDarker.Click += new System.EventHandler(this.tsmiDarker_Click);
            // 
            // tssFilter
            // 
            this.tssFilter.Name = "tssFilter";
            this.tssFilter.Size = new System.Drawing.Size(281, 6);
            // 
            // tsmiGrayScale
            // 
            this.tsmiGrayScale.Name = "tsmiGrayScale";
            this.tsmiGrayScale.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D3)));
            this.tsmiGrayScale.Size = new System.Drawing.Size(284, 34);
            this.tsmiGrayScale.Text = "Gray Scale";
            this.tsmiGrayScale.Click += new System.EventHandler(this.tsmiGrayScale_Click);
            // 
            // tsmiBlackAndWhite
            // 
            this.tsmiBlackAndWhite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBlackAndWhiteV1,
            this.tsmiBlackAndWhiteV2,
            this.tsmiBlackAndWhiteV3});
            this.tsmiBlackAndWhite.Name = "tsmiBlackAndWhite";
            this.tsmiBlackAndWhite.Size = new System.Drawing.Size(284, 34);
            this.tsmiBlackAndWhite.Text = "Black && White";
            // 
            // tsmiBlackAndWhiteV1
            // 
            this.tsmiBlackAndWhiteV1.Name = "tsmiBlackAndWhiteV1";
            this.tsmiBlackAndWhiteV1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D4)));
            this.tsmiBlackAndWhiteV1.Size = new System.Drawing.Size(354, 34);
            this.tsmiBlackAndWhiteV1.Text = "Black && White V1";
            this.tsmiBlackAndWhiteV1.Click += new System.EventHandler(this.tsmiBlackAndWhiteV1_Click);
            // 
            // tsmiBlackAndWhiteV2
            // 
            this.tsmiBlackAndWhiteV2.Name = "tsmiBlackAndWhiteV2";
            this.tsmiBlackAndWhiteV2.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D4)));
            this.tsmiBlackAndWhiteV2.Size = new System.Drawing.Size(354, 34);
            this.tsmiBlackAndWhiteV2.Text = "Black && White V2";
            this.tsmiBlackAndWhiteV2.Click += new System.EventHandler(this.tsmiBlackAndWhiteV2_Click);
            // 
            // tsmiBlackAndWhiteV3
            // 
            this.tsmiBlackAndWhiteV3.Name = "tsmiBlackAndWhiteV3";
            this.tsmiBlackAndWhiteV3.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D4)));
            this.tsmiBlackAndWhiteV3.Size = new System.Drawing.Size(354, 34);
            this.tsmiBlackAndWhiteV3.Text = "Black && White V3";
            this.tsmiBlackAndWhiteV3.Click += new System.EventHandler(this.tsmiBlackAndWhiteV3_Click);
            // 
            // tssFilterChannels
            // 
            this.tssFilterChannels.Name = "tssFilterChannels";
            this.tssFilterChannels.Size = new System.Drawing.Size(281, 6);
            // 
            // tsmiRedChannel
            // 
            this.tsmiRedChannel.Name = "tsmiRedChannel";
            this.tsmiRedChannel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D5)));
            this.tsmiRedChannel.Size = new System.Drawing.Size(284, 34);
            this.tsmiRedChannel.Text = "Red Channel";
            this.tsmiRedChannel.Click += new System.EventHandler(this.tsmiRedChannel_Click);
            // 
            // tsmiGreenChannel
            // 
            this.tsmiGreenChannel.Name = "tsmiGreenChannel";
            this.tsmiGreenChannel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D6)));
            this.tsmiGreenChannel.Size = new System.Drawing.Size(284, 34);
            this.tsmiGreenChannel.Text = "Green Channel";
            this.tsmiGreenChannel.Click += new System.EventHandler(this.tsmiGreenChannel_Click);
            // 
            // tsmiBlueChannel
            // 
            this.tsmiBlueChannel.Name = "tsmiBlueChannel";
            this.tsmiBlueChannel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D7)));
            this.tsmiBlueChannel.Size = new System.Drawing.Size(284, 34);
            this.tsmiBlueChannel.Text = "Blue Channel";
            this.tsmiBlueChannel.Click += new System.EventHandler(this.tsmiBlueChannel_Click);
            // 
            // tssFilterInvert
            // 
            this.tssFilterInvert.Name = "tssFilterInvert";
            this.tssFilterInvert.Size = new System.Drawing.Size(281, 6);
            // 
            // tsmiInvertColor
            // 
            this.tsmiInvertColor.Name = "tsmiInvertColor";
            this.tsmiInvertColor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D8)));
            this.tsmiInvertColor.Size = new System.Drawing.Size(284, 34);
            this.tsmiInvertColor.Text = "Invert Color";
            this.tsmiInvertColor.Click += new System.EventHandler(this.tsmiInvertColor_Click);
            // 
            // tssFilterReset
            // 
            this.tssFilterReset.Name = "tssFilterReset";
            this.tssFilterReset.Size = new System.Drawing.Size(281, 6);
            // 
            // tsmiResetFilters
            // 
            this.tsmiResetFilters.Name = "tsmiResetFilters";
            this.tsmiResetFilters.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D0)));
            this.tsmiResetFilters.Size = new System.Drawing.Size(284, 34);
            this.tsmiResetFilters.Text = "Reset Filters";
            this.tsmiResetFilters.Click += new System.EventHandler(this.tsmiResetFilters_Click);
            // 
            // tsmiProcessing
            // 
            this.tsmiProcessing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDownsample2x,
            this.tsmiUpsample2x,
            this.tssProcessFilp,
            this.tsmiFilpHorizontally,
            this.tsmiFilpVertically});
            this.tsmiProcessing.Name = "tsmiProcessing";
            this.tsmiProcessing.Size = new System.Drawing.Size(113, 29);
            this.tsmiProcessing.Text = "Processing";
            // 
            // tsmiDownsample2x
            // 
            this.tsmiDownsample2x.Name = "tsmiDownsample2x";
            this.tsmiDownsample2x.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiDownsample2x.Size = new System.Drawing.Size(313, 34);
            this.tsmiDownsample2x.Text = "Downsample (2x)";
            this.tsmiDownsample2x.Click += new System.EventHandler(this.tsmiDownsample2x_Click);
            // 
            // tsmiUpsample2x
            // 
            this.tsmiUpsample2x.Name = "tsmiUpsample2x";
            this.tsmiUpsample2x.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.tsmiUpsample2x.Size = new System.Drawing.Size(313, 34);
            this.tsmiUpsample2x.Text = "Upsample (2x)";
            this.tsmiUpsample2x.Click += new System.EventHandler(this.tsmiUpsample2x_Click);
            // 
            // tssProcessFilp
            // 
            this.tssProcessFilp.Name = "tssProcessFilp";
            this.tssProcessFilp.Size = new System.Drawing.Size(310, 6);
            // 
            // tsmiFilpHorizontally
            // 
            this.tsmiFilpHorizontally.Name = "tsmiFilpHorizontally";
            this.tsmiFilpHorizontally.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.tsmiFilpHorizontally.Size = new System.Drawing.Size(313, 34);
            this.tsmiFilpHorizontally.Text = "Filp Horizontally";
            this.tsmiFilpHorizontally.Click += new System.EventHandler(this.tsmiFilpHorizontally_Click);
            // 
            // tsmiFilpVertically
            // 
            this.tsmiFilpVertically.Name = "tsmiFilpVertically";
            this.tsmiFilpVertically.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.tsmiFilpVertically.Size = new System.Drawing.Size(313, 34);
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
            this.pbxMain.Click += new System.EventHandler(this.pbxMain_Click);
            // 
            // dlgOpenImage
            // 
            this.dlgOpenImage.Filter = "Image Files|*.bmp;*.png;*.jpg;*.jpeg;*.gif";
            this.dlgOpenImage.Title = "Choose an image to open!";
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
            this.tsslImageSize.Name = "tsslImageSize";
            this.tsslImageSize.Size = new System.Drawing.Size(98, 25);
            this.tsslImageSize.Text = "Image Size";
            // 
            // tsslPictBoxSize
            // 
            this.tsslPictBoxSize.Name = "tsslPictBoxSize";
            this.tsslPictBoxSize.Size = new System.Drawing.Size(105, 25);
            this.tsslPictBoxSize.Text = "PictBox Size";
            // 
            // dlgSaveImage
            // 
            this.dlgSaveImage.Filter = "Image Files|*.bmp;*.png;*.jpg;*.jpeg;*.gif";
            this.dlgSaveImage.Title = "How do you want to save your image?";
            // 
            // frmImageProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pbxMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmImageProcessor";
            this.Text = "Image Processor";
            this.SizeChanged += new System.EventHandler(this.frmImageProcessor_SizeChanged);
            this.Click += new System.EventHandler(this.frmImageProcessor_Click);
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
        private System.Windows.Forms.ToolStripSeparator tssFileExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.PictureBox pbxMain;
        private System.Windows.Forms.OpenFileDialog dlgOpenImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiZoomIn;
        private System.Windows.Forms.ToolStripMenuItem tsmiOriginalSize;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslFileName;
        private System.Windows.Forms.ToolStripStatusLabel tsslZoomRate;
        private System.Windows.Forms.ToolStripMenuItem tsmiRotateClockwise;
        private System.Windows.Forms.ToolStripSeparator tssViewRotate;
        private System.Windows.Forms.ToolStripMenuItem tsmiRotate180;
        private System.Windows.Forms.ToolStripMenuItem tsmiRotateAntiClockwise;
        private System.Windows.Forms.ToolStripStatusLabel tsslImageSize;
        private System.Windows.Forms.ToolStripStatusLabel tsslPictBoxSize;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.SaveFileDialog dlgSaveImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilters;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrayScale;
        private System.Windows.Forms.ToolStripMenuItem tsmiBlackAndWhite;
        private System.Windows.Forms.ToolStripMenuItem tsmiRedChannel;
        private System.Windows.Forms.ToolStripMenuItem tsmiGreenChannel;
        private System.Windows.Forms.ToolStripMenuItem tsmiBlueChannel;
        private System.Windows.Forms.ToolStripSeparator tssFilterChannels;
        private System.Windows.Forms.ToolStripMenuItem tsmiBrighter;
        private System.Windows.Forms.ToolStripMenuItem tsmiDarker;
        private System.Windows.Forms.ToolStripSeparator tssFilter;
        private System.Windows.Forms.ToolStripSeparator tssFilterInvert;
        private System.Windows.Forms.ToolStripMenuItem tsmiInvertColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiProcessing;
        private System.Windows.Forms.ToolStripMenuItem tsmiDownsample2x;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpsample2x;
        private System.Windows.Forms.ToolStripSeparator tssProcessFilp;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilpHorizontally;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilpVertically;
        private System.Windows.Forms.ToolStripSeparator tssFilterReset;
        private System.Windows.Forms.ToolStripMenuItem tsmiResetFilters;
        private System.Windows.Forms.ToolStripMenuItem tsmiZoomOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiBlackAndWhiteV2;
        private System.Windows.Forms.ToolStripMenuItem tsmiBlackAndWhiteV1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBlackAndWhiteV3;
    }
}

