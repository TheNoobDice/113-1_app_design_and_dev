using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20241007w5_browser
{
    public partial class formBrowserAlpha : Form
    {
        public formBrowserAlpha()
        {
            InitializeComponent();

            // Configure the top TableLayoutPanel
            tlpTop.Dock = DockStyle.Top;

            // Configure the left FlowLayoutPanel
            flpTopLeft.Dock = DockStyle.Left;

            // Configure the right FlowLayoutPanel
            flpTopRight.Dock = DockStyle.Right;

            // Configure the WebBrowser control to fill in rest of the app
            webBrowser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void tbxURL_KeyDown(object sender, KeyEventArgs e)
        {
            // Press [Enter] to navigate after typing url in the tbxURL
            if (e.KeyCode == Keys.Enter)
            {
                navigate_to_tbxURL();
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            navigate_to_tbxURL();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        private void navigate_to_tbxURL()
        {
            string url = tbxURL.Text;

            // Automally add "http://" before url if not added
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }
            webBrowser.Navigate(url);
        }

        private void formBrowserAlpha_Load(object sender, EventArgs e)
        {

        }
    }
}