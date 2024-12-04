using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241202w13_paint
{
    public partial class frmCanvas : Form
    {
        private void newCanvas()
        {
            pbxMain.Image = new Bitmap(800, 600);
            Graphics graphics = Graphics.FromImage(pbxMain.Image);
            graphics.Clear(Color.White);
            /* ezonesoft:
             * 我們先建置一個 800 x 600 點的點陣圖物件作為 pbxMain 的 Image。
             * 接著宣告一個稱為 graphics 的繪圖物件(Graphics)，
             * 此物件來自於(也就是會執行繪圖動作於)pictureBox1.Image，
             * 最後使用 graphics 將 Image 清除為白底(背景色)的狀況。
             */
        }

    public frmCanvas()
        {
            InitializeComponent();
        }

        private void frmCanvas_Load(object sender, EventArgs e)
        {
            newCanvas();
        }

        int x0, y0;
        private void pbxMain_MouseDown(object sender, MouseEventArgs e)
        {
            x0 = e.X;
            y0 = e.Y;
        }

        private void pbxMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics graphics = Graphics.FromImage(pbxMain.Image);
                graphics.DrawLine(Pens.Black, x0, y0, e.X, e.Y);
                x0 = e.X;
                y0 = e.Y;
                pbxMain.Refresh();
            }
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            newCanvas();

            // frmCanvas_Load(sender, e)
            /* ezonesoft:
             * 是不是與前一單元的 SizeImage 等自訂副程式用法很像？
             * 就是執行到此時去呼叫『開新檔案』的程式，請記得小括號內的參數必須照寫，
             * 但物件型態名稱(object 與 EventArgs)則必須刪掉。
             * 這也告訴我們其實事件副程式與一般自訂副程式沒有甚麼不同，也可以直接呼叫的 ！
             */

        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpenJPG.ShowDialog() == DialogResult.OK)
            {
                string currentFileName = dlgOpenJPG.FileName;

                pbxMain.Load(currentFileName);
                tsslFileName.Text = currentFileName;
            }
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            if (dlgSaveJPG.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pbxMain.Image);
                bmp.Save(dlgSaveJPG.FileName);
                /* ezonesoft:
                 * 上述程式中的 Bitmap bmp = new Bitmap(pictureBox1.Image)
                 * 是宣告一個稱為 bmp 的Bitmap(點陣圖)物件，
                 * 內容與 pictureBox1.Image 相同；
                 * 接下來將此物件儲存(Save)為選定檔名 saveFileDialog1.FileName。
                 * 此動作似乎有些多餘，
                 * 但是直接用 pictureBox1.Image.Save 這樣的語法卻會產生「GDI+泛型錯誤」，
                 * 同樣.NET Framework 版本的 VB 這樣寫卻是可以的！
                 * 只能說是 C#語法比較嚴謹吧？
                 */
            }
        }

        private void tsmiQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
