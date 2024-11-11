namespace _20241007w5_browser
{
    partial class formBrowserAlpha
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbxURL = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.flpTopLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTopRight = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.flpTopLeft.SuspendLayout();
            this.flpTopRight.SuspendLayout();
            this.tlpTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(4, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 33);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(124, 4);
            this.btnForward.Margin = new System.Windows.Forms.Padding(4);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(112, 33);
            this.btnForward.TabIndex = 3;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(244, 4);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 33);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbxURL
            // 
            this.tbxURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxURL.Location = new System.Drawing.Point(368, 6);
            this.tbxURL.Margin = new System.Windows.Forms.Padding(4);
            this.tbxURL.Name = "tbxURL";
            this.tbxURL.Size = new System.Drawing.Size(341, 29);
            this.tbxURL.TabIndex = 0;
            this.tbxURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxURL_KeyDown);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(4, 4);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(112, 33);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(124, 4);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(112, 33);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(0, 45);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser.MinimumSize = new System.Drawing.Size(30, 30);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(962, 688);
            this.webBrowser.TabIndex = 2;
            // 
            // flpTopLeft
            // 
            this.flpTopLeft.Controls.Add(this.btnBack);
            this.flpTopLeft.Controls.Add(this.btnForward);
            this.flpTopLeft.Controls.Add(this.btnRefresh);
            this.flpTopLeft.Location = new System.Drawing.Point(0, 0);
            this.flpTopLeft.Margin = new System.Windows.Forms.Padding(0);
            this.flpTopLeft.Name = "flpTopLeft";
            this.flpTopLeft.Size = new System.Drawing.Size(364, 41);
            this.flpTopLeft.TabIndex = 4;
            // 
            // flpTopRight
            // 
            this.flpTopRight.Controls.Add(this.btnGo);
            this.flpTopRight.Controls.Add(this.btnHome);
            this.flpTopRight.Location = new System.Drawing.Point(713, 0);
            this.flpTopRight.Margin = new System.Windows.Forms.Padding(0);
            this.flpTopRight.Name = "flpTopRight";
            this.flpTopRight.Size = new System.Drawing.Size(249, 41);
            this.flpTopRight.TabIndex = 5;
            // 
            // tlpTop
            // 
            this.tlpTop.ColumnCount = 3;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTop.Controls.Add(this.flpTopLeft, 0, 0);
            this.tlpTop.Controls.Add(this.tbxURL, 1, 0);
            this.tlpTop.Controls.Add(this.flpTopRight, 2, 0);
            this.tlpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpTop.Location = new System.Drawing.Point(0, 0);
            this.tlpTop.Margin = new System.Windows.Forms.Padding(4);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpTop.Size = new System.Drawing.Size(962, 41);
            this.tlpTop.TabIndex = 6;
            // 
            // formBrowserAlpha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 735);
            this.Controls.Add(this.tlpTop);
            this.Controls.Add(this.webBrowser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formBrowserAlpha";
            this.Text = "Browser Alpha";
            this.flpTopLeft.ResumeLayout(false);
            this.flpTopRight.ResumeLayout(false);
            this.tlpTop.ResumeLayout(false);
            this.tlpTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbxURL;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.FlowLayoutPanel flpTopLeft;
        private System.Windows.Forms.FlowLayoutPanel flpTopRight;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
    }
}

