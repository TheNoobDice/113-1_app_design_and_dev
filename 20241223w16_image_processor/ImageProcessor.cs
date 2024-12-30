using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
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
        public frmImageProcessor()
        {
            InitializeComponent();
            menuStrip1.BringToFront();
        }

        //
        // Variables Definition 
        //
        private List<int> zoomPercents = new List<int> {10, 25, 50, 75, 90, 100, 110, 125, 150, 175, 200, 250, 300, 400, 500, 750, 1000};
        private int currentZoomLevel = 5;  // Initial zoom level: 100%
        //private bool aspect_rotated = false;

        Bitmap bmpOpened;

        // Define All Color Filter Types for ApplyColorFilter() Function
        private enum ColorFilterType
        {
            GrayScale,
            BlackAndWhite,
            BlackAndWhiteV2,
            BlackAndWhiteV3,
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
        private void UpdateTsslSize()
        {
            tsslImageSize.Text = "Image:" + pbxMain.Image.Width + "x" + pbxMain.Image.Height;
            tsslPictBoxSize.Text = "PictBox:" + pbxMain.Width + "x" + pbxMain.Height;
        }

        private void CenterPictureBox()
        {
            pbxMain.Left = (this.ClientSize.Width - pbxMain.Width) / 2;
            pbxMain.Top = (this.ClientSize.Height - pbxMain.Height) / 2;
        }

        private void ResizePictureBox(Bitmap bmpImage = null)
        {   
            if (bmpImage == null) {bmpImage = (Bitmap)pbxMain.Image;}

            if (bmpImage != null)
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

                pbxMain.Width = (int)(bmpImage.Width * zoomPercent / 100);
                pbxMain.Height = (int)(bmpImage.Height * zoomPercent / 100);
                tsslZoomRate.Text = zoomPercent + "%";

                // Maintain aspect ratio and center the image
                pbxMain.SizeMode = PictureBoxSizeMode.Zoom;

                UpdateTsslSize();
                CenterPictureBox();
            }
        }

        private double CalculateBlockAverageLuminance(Bitmap bmpImage, int startX = 0, int startY = 0, int blockWidth = 0, int blockHeight = 0)
        {
            if (blockWidth == 0) {blockWidth = bmpImage.Width; }
            if (blockHeight == 0) {blockHeight = bmpImage.Height;}

            double totalLuminance = 0;
            int pixelCount = 0;

            for (int y = startY; y < startY + blockHeight && y < bmpImage.Height; y++)
            {
                for (int x = startX; x < startX + blockWidth && x < bmpImage.Width; x++)
                {
                    Color pixelColor = bmpImage.GetPixel(x, y);
                    totalLuminance += (0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);
                    pixelCount++;
                }
            }

            return pixelCount > 0 ? totalLuminance / pixelCount : 0;
        }

        // Handles All Color Filter Events
        private void ApplyColorFilter(ColorFilterType colorFilterType)
        {
            if (pbxMain.Image != null)
            {
                Bitmap filteredImage = new Bitmap(bmpOpened.Width, bmpOpened.Height);

                // Initialize variables, ensures that they always have a defined value.
                // to avoid compile scold "Use of unassigned local variable 'threshold'" error to you
                double threshold = 128;

                // BlackAndWhiteV2: threshold = average luminance of the image
                if (colorFilterType == ColorFilterType.BlackAndWhiteV2)
                {
                    threshold = CalculateBlockAverageLuminance(bmpOpened);
                }

                // BlackAndWhiteV3: threshold = average luminance for each 40x40 block
                if (colorFilterType == ColorFilterType.BlackAndWhiteV3)
                {
                    int blockWidth = 40;
                    int blockHeight = 40;

                    for (int y = 0; y < bmpOpened.Height; y += blockHeight)
                    {
                        for (int x = 0; x < bmpOpened.Width; x += blockWidth)
                        {
                            // Calculate average luminance for the current block
                            double blockAvgLuminance = CalculateBlockAverageLuminance(bmpOpened, x, y, blockWidth, blockHeight);

                            // Process pixels within the block
                            for (int j = y; j < Math.Min(y + blockHeight, bmpOpened.Height); j++)
                            {
                                for (int i = x; i < Math.Min(x + blockHeight, bmpOpened.Width); i++)
                                {
                                    Color clrOrigin = bmpOpened.GetPixel(i, j);
                                    double luminance = 0.299 * clrOrigin.R + 0.587 * clrOrigin.G + 0.114 * clrOrigin.B;

                                    threshold = (byte)blockAvgLuminance;
                                    luminance = luminance >= threshold ? 255 : 0;

                                    filteredImage.SetPixel(i, j, Color.FromArgb(clrOrigin.A, (byte)luminance, (byte)luminance, (byte)luminance));
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int x = 0; x < bmpOpened.Width; x++)
                    {
                        for (int y = 0; y < bmpOpened.Height; y++)
                        {
                            Color clrOrigin = bmpOpened.GetPixel(x, y);

                            // Initialize variables, ensures that they always have a defined value.
                            // to avoid compile scold "Use of unassigned local variable '[variable]'" error to you
                            int red = clrOrigin.R, green = clrOrigin.G, blue = clrOrigin.B;

                            // Formula based on the relative luminance of human perception for red, green, and blue.
                            // The coefficients (0.299, 0.587, and 0.114) represent the relative importance of each color channel to human perception of brightness.
                            double luminance = 0.299 * red + 0.587 * green + 0.114 * blue;

                            switch (colorFilterType)
                            {
                                case ColorFilterType.GrayScale:
                                    red = green = blue = (byte)luminance;
                                    break;
                                case ColorFilterType.BlackAndWhite:
                                case ColorFilterType.BlackAndWhiteV2:
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
                Bitmap bmpToSave = new Bitmap((string)dlgOpenImage.FileName);
                bmpToSave.Save(dlgSaveImage.FileName, ImageFormat.Png);

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

            UpdateTsslSize();
            CenterPictureBox();
        }

        private void tsmiRotateClockwise_Click(object sender, EventArgs e)
        {
            int original_width = pbxMain.Width;
            pbxMain.Width = pbxMain.Height;
            pbxMain.Height = original_width;
            pbxMain.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);

            UpdateTsslSize();
            CenterPictureBox();
            pbxMain.Refresh();
        }

        private void tsmiRotate180_Click(object sender, EventArgs e)
        {
            pbxMain.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);

            UpdateTsslSize();
            CenterPictureBox();
            pbxMain.Refresh();
        }

        private void tsmiRotateAntiClockwise_Click(object sender, EventArgs e)
        {
            int original_width = pbxMain.Width;
            pbxMain.Width = pbxMain.Height;
            pbxMain.Height = original_width;
            pbxMain.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);

            UpdateTsslSize();
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

        private void tsmiBlackAndWhiteV1_Click(object sender, EventArgs e)
        {
            ApplyColorFilter(ColorFilterType.BlackAndWhite);
        }

        private void tsmiBlackAndWhiteV2_Click(object sender, EventArgs e)
        {
            ApplyColorFilter(ColorFilterType.BlackAndWhiteV2);
        }

        private void tsmiBlackAndWhiteV3_Click(object sender, EventArgs e)
        {
            ApplyColorFilter(ColorFilterType.BlackAndWhiteV3);
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
        private void frmImageProcessor_SizeChanged(object sender, EventArgs e)
        {
            CenterPictureBox();
        }

        private void frmImageProcessor_Click(object sender, EventArgs e)
        {
            CenterPictureBox();
        }

        private void pbxMain_Click(object sender, EventArgs e)
        {
            CenterPictureBox();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
