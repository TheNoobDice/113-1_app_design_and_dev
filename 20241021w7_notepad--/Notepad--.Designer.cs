namespace _20241021w7_notepad__
{
    partial class frmNotepadMinusMinus
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
            this.tbxMain = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRageQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFindAndReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenTxtFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveAs = new System.Windows.Forms.SaveFileDialog();
            this.dlgNewFile = new System.Windows.Forms.SaveFileDialog();
            this.pnlFindAndReplace = new System.Windows.Forms.Panel();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbxReplace = new System.Windows.Forms.TextBox();
            this.tbxFind = new System.Windows.Forms.TextBox();
            this.btnClosePnlFindAndReplace = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip.SuspendLayout();
            this.pnlFindAndReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxMain
            // 
            this.tbxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMain.Location = new System.Drawing.Point(0, 33);
            this.tbxMain.Multiline = true;
            this.tbxMain.Name = "tbxMain";
            this.tbxMain.Size = new System.Drawing.Size(677, 417);
            this.tbxMain.TabIndex = 0;
            this.tbxMain.TextChanged += new System.EventHandler(this.tbxMain_TextChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(677, 33);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.toolStripSeparator3,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.toolStripSeparator4,
            this.tsmiExit,
            this.tsmiRageQuit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(54, 29);
            this.tsmiFile.Text = "File";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiNew.Size = new System.Drawing.Size(283, 34);
            this.tsmiNew.Text = "New";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(283, 34);
            this.tsmiOpen.Text = "Open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(280, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(283, 34);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiSaveAs.Size = new System.Drawing.Size(283, 34);
            this.tsmiSaveAs.Text = "Save As...";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(280, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.tsmiExit.Size = new System.Drawing.Size(283, 34);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiRageQuit
            // 
            this.tsmiRageQuit.Name = "tsmiRageQuit";
            this.tsmiRageQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.tsmiRageQuit.Size = new System.Drawing.Size(283, 34);
            this.tsmiRageQuit.Text = "Rage Quit";
            this.tsmiRageQuit.Click += new System.EventHandler(this.tsmiRageQuit_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.toolStripSeparator1,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste,
            this.toolStripSeparator2,
            this.tsmiSelectAll,
            this.tsmiFindAndReplace});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(58, 29);
            this.tsmiEdit.Text = "Edit";
            // 
            // tsmiUndo
            // 
            this.tsmiUndo.Name = "tsmiUndo";
            this.tsmiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmiUndo.Size = new System.Drawing.Size(308, 34);
            this.tsmiUndo.Text = "Undo";
            this.tsmiUndo.Click += new System.EventHandler(this.tsmiUndo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(305, 6);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.ShortcutKeyDisplayString = "Ctrl+X";
            this.tsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCut.Size = new System.Drawing.Size(308, 34);
            this.tsmiCut.Text = "Cut";
            this.tsmiCut.Click += new System.EventHandler(this.tsmiCut_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.ShortcutKeyDisplayString = "Ctrl+C";
            this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopy.Size = new System.Drawing.Size(308, 34);
            this.tsmiCopy.Text = "Copy";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.ShortcutKeyDisplayString = "Ctrl+V";
            this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiPaste.Size = new System.Drawing.Size(308, 34);
            this.tsmiPaste.Text = "Paste";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(305, 6);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.ShortcutKeyDisplayString = "Ctrl+A";
            this.tsmiSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiSelectAll.Size = new System.Drawing.Size(308, 34);
            this.tsmiSelectAll.Text = "Select All";
            this.tsmiSelectAll.Click += new System.EventHandler(this.tsmiSelectAll_Click);
            // 
            // tsmiFindAndReplace
            // 
            this.tsmiFindAndReplace.Name = "tsmiFindAndReplace";
            this.tsmiFindAndReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmiFindAndReplace.Size = new System.Drawing.Size(308, 34);
            this.tsmiFindAndReplace.Text = "Find and Replace";
            this.tsmiFindAndReplace.Click += new System.EventHandler(this.tsmiFindAndReplace_Click);
            // 
            // dlgOpenTxtFile
            // 
            this.dlgOpenTxtFile.Filter = "Text Files|*.txt";
            // 
            // dlgSaveAs
            // 
            this.dlgSaveAs.Filter = "Text File|*.txt";
            // 
            // dlgNewFile
            // 
            this.dlgNewFile.FileName = "New Text File";
            this.dlgNewFile.Filter = "Text File|*.txt";
            // 
            // pnlFindAndReplace
            // 
            this.pnlFindAndReplace.Controls.Add(this.btnReplace);
            this.pnlFindAndReplace.Controls.Add(this.btnFind);
            this.pnlFindAndReplace.Controls.Add(this.tbxReplace);
            this.pnlFindAndReplace.Controls.Add(this.tbxFind);
            this.pnlFindAndReplace.Controls.Add(this.btnClosePnlFindAndReplace);
            this.pnlFindAndReplace.Location = new System.Drawing.Point(388, 33);
            this.pnlFindAndReplace.Name = "pnlFindAndReplace";
            this.pnlFindAndReplace.Size = new System.Drawing.Size(289, 191);
            this.pnlFindAndReplace.TabIndex = 2;
            this.pnlFindAndReplace.Visible = false;
            this.pnlFindAndReplace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFindAndReplace_MouseDown);
            this.pnlFindAndReplace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlFindAndReplace_MouseMove);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(180, 78);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(90, 29);
            this.btnReplace.TabIndex = 4;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(180, 21);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(90, 29);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbxReplace
            // 
            this.tbxReplace.Location = new System.Drawing.Point(18, 78);
            this.tbxReplace.Name = "tbxReplace";
            this.tbxReplace.Size = new System.Drawing.Size(143, 29);
            this.tbxReplace.TabIndex = 2;
            // 
            // tbxFind
            // 
            this.tbxFind.Location = new System.Drawing.Point(18, 23);
            this.tbxFind.Name = "tbxFind";
            this.tbxFind.Size = new System.Drawing.Size(143, 29);
            this.tbxFind.TabIndex = 1;
            // 
            // btnClosePnlFindAndReplace
            // 
            this.btnClosePnlFindAndReplace.Location = new System.Drawing.Point(111, 131);
            this.btnClosePnlFindAndReplace.Name = "btnClosePnlFindAndReplace";
            this.btnClosePnlFindAndReplace.Size = new System.Drawing.Size(75, 29);
            this.btnClosePnlFindAndReplace.TabIndex = 0;
            this.btnClosePnlFindAndReplace.Text = "Close";
            this.btnClosePnlFindAndReplace.UseVisualStyleBackColor = true;
            this.btnClosePnlFindAndReplace.Click += new System.EventHandler(this.btnClosePnlFindAndReplace_Click);
            // 
            // frmNotepadMinusMinus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 450);
            this.Controls.Add(this.pnlFindAndReplace);
            this.Controls.Add(this.tbxMain);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmNotepadMinusMinus";
            this.Text = "Notepad--";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnlFindAndReplace.ResumeLayout(false);
            this.pnlFindAndReplace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMain;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.OpenFileDialog dlgOpenTxtFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.SaveFileDialog dlgNewFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiFindAndReplace;
        private System.Windows.Forms.Panel pnlFindAndReplace;
        private System.Windows.Forms.Button btnClosePnlFindAndReplace;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbxReplace;
        private System.Windows.Forms.TextBox tbxFind;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRageQuit;
    }
}

