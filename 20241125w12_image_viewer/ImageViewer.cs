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
        // Note: tsslImageSize and tsslPictBoxSize's .Visible and .Enabled properties is set to False 
        private List<int> zoomPercents = new List<int> {10, 25, 50, 75, 90, 100, 110, 125, 150, 175, 200, 250, 300, 400, 500, 750, 1000};
        private int currentZoomLevel = 5; // Initial zoom level
        //private bool aspect_rotated = false;

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
                /*if (aspect_rotated)
                {
                    pbxMain.Width = (int)(pbxMain.Image.Height * zoomPercent / 100);
                    pbxMain.Height = (int)(pbxMain.Image.Width * zoomPercent / 100);
                }
                else
                {*/
                    pbxMain.Width = (int)(pbxMain.Image.Width * zoomPercent / 100);
                    pbxMain.Height = (int)(pbxMain.Image.Height * zoomPercent / 100);
                //}
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
            currentZoomLevel = 5;
            pbxMain.Width = pbxMain.Image.Width;
            pbxMain.Height = pbxMain.Image.Height;
            tsslZoomRate.Text = "100%";
            CenterPictureBox();
        }

        private void tsmiRotateClockwise_Click(object sender, EventArgs e)
        {
            int original_width = pbxMain.Image.Width;
            pbxMain.Width = pbxMain.Height;
            pbxMain.Height = original_width;
            pbxMain.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            CenterPictureBox();
            pbxMain.Refresh();
            //tsslImageSize.Text = "Image:" + pbxMain.Image.Width + ", " + pbxMain.Image.Height;
            //tsslPictBoxSize.Text = "PictBox:" + pbxMain.Width + ", " + pbxMain.Height;
        }

        private void tsmiRotate180_Click(object sender, EventArgs e)
        {
            pbxMain.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            CenterPictureBox();
            pbxMain.Refresh();
        }

        private void tsmiRotateAntiClockwise_Click(object sender, EventArgs e)
        {
            int original_width = pbxMain.Image.Width;
            pbxMain.Width = pbxMain.Height;
            pbxMain.Height = original_width;
            pbxMain.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            CenterPictureBox();
            pbxMain.Refresh();
        }

        private void tsmiFilpHorizontally_Click(object sender, EventArgs e)
        {
            pbxMain.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            CenterPictureBox();
            pbxMain.Refresh();
        }

        private void tsmiFilpVertically_Click(object sender, EventArgs e)
        {
            pbxMain.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            CenterPictureBox();
            pbxMain.Refresh();
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
