using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics; // Debug.WriteLine("Debug String");
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20241021w7_notepad__
{
    public partial class frmNotepadMinusMinus : Form
    {
        private string openedFilePath;
        private string lastTextFind;
        private int lastFoundEndIndex;

        private bool saveNecessariness()
        {
            //
            return true;
        }

        private void saveAs()
        {
            if (dlgSaveAs.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlgSaveAs.FileName, tbxMain.Text, Encoding.Default);
            }
        }

        private void saveChanges()
        {
            if (!string.IsNullOrEmpty(openedFilePath))
            {
                File.WriteAllText(openedFilePath, tbxMain.Text, Encoding.Default);
            }
            else
            {
                saveAs();
            }
        }

        public frmNotepadMinusMinus()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // If user clicked the upper-right corner red X
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (saveNecessariness())
                {
                    // Check if the user wants to save changes
                    DialogResult result = MessageBox.Show("Do you want to save your changes?", "Save and Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    switch (result)
                    {
                        case DialogResult.Yes:
                            // If the user wants to save, call the save method
                            saveChanges();
                            break;
                        case DialogResult.No:
                            // If the user doesn't want to save, proceed with closing
                            break;
                        case DialogResult.Cancel:
                            // If the user cancels, prevent closing
                            e.Cancel = true;
                            break;
                    }
                }
            }
            // Call the base class's implementation of OnFormClosing to handle default behavior
            base.OnFormClosing(e);
        }

        private void tbxMain_TextChanged(object sender, EventArgs e)
        {
            lastTextFind = null;
            lastFoundEndIndex = 0;
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            tbxMain.Clear();
            if (dlgNewFile.ShowDialog() == DialogResult.OK)
            {
                openedFilePath = dlgNewFile.FileName;
                File.WriteAllText(openedFilePath, string.Empty);
            }
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpenTxtFile.ShowDialog() == DialogResult.OK)
            {
                openedFilePath = dlgOpenTxtFile.FileName;
                tbxMain.Text = File.ReadAllText(openedFilePath, Encoding.Default);
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            saveChanges();
        }

        private void tsmiSaveAs_Click(object sender, EventArgs e)
        {
            saveAs();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {   
            if (saveNecessariness())
            {
                // Check if the user wants to save changes
                DialogResult result = MessageBox.Show("Do you want to save your changes?", "Save and Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:
                        // If the user wants to save, call the save method
                        saveChanges();
                        Application.Exit();
                        break;
                    case DialogResult.No:
                        // If the user doesn't want to save, exit the application
                        Application.Exit();
                        break;
                    case DialogResult.Cancel:
                        // If the user cancels, do nothing
                        break;
                }
            }
            else
            {
                Application.Exit();
            }
        }

        private void tsmiRageQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiUndo_Click(object sender, EventArgs e)
        {
            tbxMain.Undo();
        }

        private void tsmiCut_Click(object sender, EventArgs e)
        {
            tbxMain.Cut();
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            tbxMain.Copy();
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            tbxMain.Paste();
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            tbxMain.SelectAll();
        }

        private void tsmiFindAndReplace_Click(object sender, EventArgs e)
        {
            pnlFindAndReplace.Visible = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string textToFind = tbxFind.Text;
            int startIndex;
            if (textToFind == lastTextFind)
            {
                startIndex = lastFoundEndIndex;
            }
            else
            {
                startIndex = 0;
            }
            int index = tbxMain.Text.IndexOf(textToFind, startIndex);

            if (index >= 0)
            {
                tbxMain.Select(index, textToFind.Length);  // Highlight the found text
                lastFoundEndIndex = index + textToFind.Length;
                tbxMain.Focus(); // Ensure the TextBox has focus, which is necessary for the selection to be visible.
                tbxMain.ScrollToCaret();  // Scroll the found text
            }
            else
            {
                MessageBox.Show("Text not found.");
                lastFoundEndIndex = 0;
            }
            lastTextFind = textToFind;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (tbxMain.SelectedText == tbxFind.Text)
            {
                tbxMain.SelectedText = tbxReplace.Text;
            }
        }

        private int mouseDownX, mouseDownY;

        private void pnlFindAndReplace_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownX = e.X;
            mouseDownY = e.Y;
        }

        private void pnlFindAndReplace_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pnlFindAndReplace.Left += e.X - mouseDownX;
                pnlFindAndReplace.Top += e.Y - mouseDownY;
            }
        }

        private void btnClosePnlFindAndReplace_Click(object sender, EventArgs e)
        {
            pnlFindAndReplace.Visible = false;
        }
    }
}