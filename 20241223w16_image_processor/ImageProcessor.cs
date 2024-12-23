using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* How to copy project and rename it without issues
 * 1. Create a new empty project
 * 2. Copy old "{name}.cs", "{name}.Designer.cs" and "{name}.resx" file
 * 3. Paste the files into new project folder
 * 4. Solution Explorer -> Right click your new project -> Add Existing Item -> Select the files you copied
 * 5. Delete the corresponding files created with new project
 * 6. In Program.cs: Rename namespace and 
 * 7. -------------> Rename Line 19 formName: Application.Run(new {formName}());
 * And you should be good to go! (At least after I run though these steps there's no more issues...)
 */

namespace _20241223w16_image_processor
{
    public partial class frmImageProcessor : Form
    {
        // Note: tsslImageSize and tsslPictBoxSize's .Visible and .Enabled properties is set to False

        public frmImageProcessor()
        {
            InitializeComponent();
        }

        //
        // Variables Definition 
        //
        private List<int> zoomPercents = new List<int> {10, 25, 50, 75, 90, 100, 110, 125, 150, 175, 200, 250, 300, 400, 500, 750, 1000};
        private int currentZoomLevel = 5;  // Initial zoom level
        //private bool aspect_rotated = false;

        Bitmap bmpOpened;

        // Define All Color Filter Types for ApplyColorFilter() Function
        private enum ColorFilterType
        {
            GrayScale,
            BlackAndWhite,
            Invert,
            RedChannel,
            GreenChannel,
            BlueChannel,
            Brighter,
            Darker
        }

        //
        // Functions Definition
        //
        private void CenterPictureBox()
        {
            pbxMain.Left = (this.ClientSize.Width - pbxMain.Width) / 2;
            pbxMain.Top = (this.ClientSize.Height - pbxMain.Height) / 2;
        }

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

                CenterPictureBox();
            }
        }

        // Handles All Color Filter Events
        private void ApplyColorFilter(ColorFilterType colorFilterType)
        {
            if (pbxMain.Image != null)
            {
                Bitmap filteredImage = new Bitmap(bmpOpened.Width, bmpOpened.Height);

                for (int x = 0; x < bmpOpened.Width; x++)
                {
                    for (int y = 0; y < bmpOpened.Height; y++)
                    {
                        Color clrOrigin = bmpOpened.GetPixel(x, y);
                        // Initialize variables, ensures that they always have a defined value.
                        int red = clrOrigin.R, green = clrOrigin.G, blue = clrOrigin.B;
                        byte luminance = (byte)(0.299 * red + 0.587 * green + 0.114 * blue);

                        switch (colorFilterType)
                        {
                            case ColorFilterType.GrayScale:
                                // Formula based on the relative luminance of human perception for red, green, and blue.
                                // The coefficients (0.299, 0.587, and 0.114) represent the relative importance of each color channel to human perception of brightness.
                                red = green = blue = luminance;
                                break;
                            case ColorFilterType.BlackAndWhite:
                                byte threshold = 128;
                                red = green = blue = luminance >= threshold ? (byte)255 : (byte)0;
                                break;
                            case ColorFilterType.Invert:
                                red = (byte)(255 - red);
                                green = (byte)(255 - green);
                                blue = (byte)(255 - blue);
                                break;
                            case ColorFilterType.RedChannel:
                                green = blue = 0;
                                break;
                            case ColorFilterType.GreenChannel:
                                red = blue = 0;
                                break;
                            case ColorFilterType.BlueChannel:
                                red = green = 0;
                                break;
                            case ColorFilterType.Brighter:
                                red += 32;
                                green += 32;
                                blue += 32;
                                break;
                            case ColorFilterType.Darker:
                                red -= 32;
                                green -= 32;
                                blue -= 32;
                                break;
                        }

                        red = Clamp(red, 0, 255);
                        green = Clamp(green, 0, 255);
                        blue = Clamp(blue, 0, 255);

                        Color filteredColor = Color.FromArgb(clrOrigin.A, red, green, blue);
                        filteredImage.SetPixel(x, y, filteredColor);
                    }
                }

                pbxMain.Image = filteredImage;
            }
        }

        private Bitmap DownsampleImage(Bitmap originalImage)
        {
            int newWidth = (int)Math.Ceiling((double)originalImage.Width / 2.0);
            int newHeight = (int)Math.Ceiling((double)originalImage.Height / 2.0);
            Bitmap downsampledImage = new Bitmap(newWidth, newHeight);

            for (int x = 0; x < newWidth; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    int x1 = x * 2;
                    int y1 = y * 2;
                    int x2 = Math.Min(x1 + 1, originalImage.Width - 1);
                    int y2 = Math.Min(y1 + 1, originalImage.Height - 1);

                    // Average the colors of 4 pixels in the original image
                    Color color1 = originalImage.GetPixel(x1, y1);
                    Color color2 = originalImage.GetPixel(x2, y1);
                    Color color3 = originalImage.GetPixel(x1, y2);
                    Color color4 = originalImage.GetPixel(x2, y2);

                    int red = (color1.R + color2.R + color3.R + color4.R) / 4;
                    int green = (color1.G + color2.G + color3.G + color4.G) / 4;
                    int blue = (color1.B + color2.B + color3.B + color4.B) / 4;

                    downsampledImage.SetPixel(x, y, Color.FromArgb(color1.A, red, green, blue));
                }
            }

            return downsampledImage;
        }

        private Bitmap UpsampleImage(Bitmap originalImage)
        {
            int newWidth = originalImage.Width * 2;
            int newHeight = originalImage.Height * 2;
            Bitmap upsampledImage = new Bitmap(newWidth, newHeight);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);

                    // Set the corresponding 2x2 block in the upsampled image
                    int x1 = x * 2;
                    int y1 = y * 2;
                    int x2 = x1 + 1;
                    int y2 = y1 + 1;

                    upsampledImage.SetPixel(x1, y1, pixelColor);
                    upsampledImage.SetPixel(x2, y1, pixelColor);
                    upsampledImage.SetPixel(x1, y2, pixelColor);
                    upsampledImage.SetPixel(x2, y2, pixelColor);
                }
            }

            return upsampledImage;
        }

        // Function to Clamp a value between a range
        private int Clamp(int value, int min, int max)
        {
            return Math.Max(min, Math.Min(value, max));
        }

        //
        // File Events Definition
        //
        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                string currentFileName = dlgOpenImage.FileName;

                //pbxMain.Load(currentFileName);  // Unable to handle .gif

                bmpOpened = new Bitmap(currentFileName);  // Read image to Bitmap object
                pbxMain.Image = bmpOpened;  // Assign Bitmap object to Image property of the PictureBox
                tsslFileName.Text = currentFileName;

                currentZoomLevel = 5;
                ResizePictureBox();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgSaveImage.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmpToSave = new Bitmap(dlgSaveImage.FileName);
                bmpToSave.Save(dlgSaveImage.FileName/*, System.Drawing.Imaging.ImageFormat.Jepg*/);

                bmpToSave.Dispose();  // Dispose object after saving to release resources
            }
        }

        //
        // View Events Definition
        //
        private void tsmiZoomIn_Click(object sender, EventArgs e)
        {
            currentZoomLevel++;
            ResizePictureBox();
        }
        private void tsmiZoomOut_Click(object sender, EventArgs e)
        {
            currentZoomLevel--;
            ResizePictureBox();
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
            int original_width = pbxMain.Width;
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
            int original_width = pbxMain.Width;
            pbxMain.Width = pbxMain.Height;
            pbxMain.Height = original_width;
            pbxMain.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            CenterPictureBox();
            pbxMain.Refresh();
        }

        //
        // Filter Events Definition
        //
        private void tsmiBrighter_Click(object sender, EventArgs e)
        {
            ApplyColorFilter(ColorFilterType.Brighter);
        }

        private void tsmiDarker_Click(object sender, EventArgs e)
        {
            ApplyColorFilter(ColorFilterType.Darker);
        }

        private void tsmiGrayScale_Click(object sender, EventArgs e)
        {
            ApplyColorFilter(ColorFilterType.GrayScale);
        }

        private void tsmiBlackAndWhite_Click(object sender, EventArgs e)
        {
            ApplyColorFilter(ColorFilterType.BlackAndWhite);
        }

        private void tsmiRedChannel_Click(object sender, EventArgs e)
        {
            ApplyColorFilter(ColorFilterType.RedChannel);
        }

        private void tsmiGreenChannel_Click(object sender, EventArgs e)
        {
            ApplyColorFilter(ColorFilterType.GreenChannel);
        }

        private void tsmiBlueChannel_Click(object sender, EventArgs e)
        {
            ApplyColorFilter(ColorFilterType.BlueChannel);
        }

        private void tsmiInvertColor_Click(object sender, EventArgs e)
        {
            ApplyColorFilter(ColorFilterType.Invert);
        }

        private void tsmiResetFilters_Click(object sender, EventArgs e)
        {
            if (bmpOpened != null)
            {
                pbxMain.Image = bmpOpened;
            }
        }

        //
        // Processing Event Definition
        //
        private void tsmiDownsample2x_Click(object sender, EventArgs e)
        {
            if (pbxMain.Image != null)
            {
                Bitmap originalImage = (Bitmap)pbxMain.Image;
                Bitmap downsampledImage = DownsampleImage(originalImage);
                pbxMain.Image = downsampledImage;
                ResizePictureBox();
                pbxMain.Refresh();
            }
        }

        private void tsmiUpsample2x_Click(object sender, EventArgs e)
        {
            if (pbxMain.Image != null)
            {
                Bitmap originalImage = (Bitmap)pbxMain.Image;
                Bitmap upsampledImage = UpsampleImage(originalImage);
                pbxMain.Image = upsampledImage;
                ResizePictureBox();
                pbxMain.Refresh();
            }
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

        //
        // Other Events Definition
        //
        private void frmImageProcessor_Click(object sender, EventArgs e)
        {
            CenterPictureBox();
        }

        private void pbxMain_Click(object sender, EventArgs e)
        {
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
