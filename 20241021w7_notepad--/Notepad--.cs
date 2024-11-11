using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241021w7_notepad__
{
    public partial class frmNotepadMinusMinus : Form
    {
        private string openedFilePath;

        private void saveAs()
        {
            if (dlgSaveAs.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlgSaveAs.FileName, textBox.Text, Encoding.Default);
            }
        }

        private void saveChanges()
        {
            if (!string.IsNullOrEmpty(openedFilePath))
            {
                File.WriteAllText(openedFilePath, textBox.Text, Encoding.Default);
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
            // Call the base class's implementation of OnFormClosing to handle default behavior
            base.OnFormClosing(e);
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            textBox.Clear();
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
                textBox.Text = File.ReadAllText(openedFilePath, Encoding.Default);
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

        private void tsmiUndo_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void tsmiRedo_Click(object sender, EventArgs e)
        {
            textBox.ClearUndo();
        }

        private void tsmiCut_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        private void tsmiFindAndReplace_Click(object sender, EventArgs e)
        {
            pnlFindAndReplace.Visible = true;
        }

        private void btnClosePnlFindAndReplace_Click(object sender, EventArgs e)
        {
            pnlFindAndReplace.Visible = false;
        }
    }
}