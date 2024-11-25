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
    public partial class ImageViewer : Form
    {
        public ImageViewer()
        {
            InitializeComponent();
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                //pbxMain.Load(dlgOpenImage.FileName);  // Unable to handle .gif
                Bitmap bmp =  new Bitmap(dlgOpenImage.FileName);  // Read image to Bitmap object
                pbxMain.Image = bmp;  // Assign Bitmap object to Image property of the PictureBox
            }
        }
    }
}
