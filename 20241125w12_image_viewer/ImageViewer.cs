using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241125w12_image_viewer
{
    public partial class frmImageViewer : Form
    {
        private List<int> zoomPercents = new List<int> {10, 25, 50, 75, 90, 100, 110, 125, 150, 175, 200, 250, 300, 400, 500, 750, 1000};
        private int currentZoomLevel = 5; // Initial zoom level

        private void ResizePictureBox()
        {
            if (pbxMain.Image != null)
            {
                if (currentZoomLevel < 0)
                {
                    currentZoomLevel = 0;
                }
                else if (currentZoomLevel >= zoomPercents.Count)
                {
                    currentZoomLevel = zoomPercents.Count - 1;
                }

                int zoomPercent = zoomPercents[currentZoomLevel];

                // Set the new size of the PictureBox
                pbxMain.Width = (int)(pbxMain.Image.Width * zoomPercent / 100);
                pbxMain.Height = (int)(pbxMain.Image.Height * zoomPercent / 100);
                tsslZoomRate.Text = zoomPercent + "%";

                // Maintain aspect ratio and center the image
                pbxMain.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void CenterPictureBox()
        {
            pbxMain.Left = (this.ClientSize.Width - pbxMain.Width) / 2;
            pbxMain.Top = (this.ClientSize.Height - pbxMain.Height) / 2;
        }

        public frmImageViewer()
        {
            InitializeComponent();
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                string currentFileName = dlgOpenImage.FileName;

                //pbxMain.Load(currentFileName);  // Unable to handle .gif

                Bitmap bmp =  new Bitmap(currentFileName);  // Read image to Bitmap object
                pbxMain.Image = bmp;  // Assign Bitmap object to Image property of the PictureBox
                tsslFileName.Text = currentFileName;

                currentZoomLevel = 5;
                ResizePictureBox();
                CenterPictureBox();
            }
        }

        private void tsmiZoomIn_Click(object sender, EventArgs e)
        {
            currentZoomLevel++;
            ResizePictureBox();
            CenterPictureBox();
        }

        private void tsmiZoomOut_Click(object sender, EventArgs e)
        {
            currentZoomLevel--;
            ResizePictureBox();
            CenterPictureBox();
        }

        private void tsmiOriginalSize_Click(object sender, EventArgs e)
        {
            pbxMain.Width = pbxMain.Image.Width;
            pbxMain.Height = pbxMain.Image.Height;
            CenterPictureBox();
        }

        private void frmImageViewer_ResizeEnd(object sender, EventArgs e)
        {
            CenterPictureBox();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
