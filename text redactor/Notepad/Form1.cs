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

namespace Notepad
{
    public partial class Notepad : Form
    {
        public string FilePath;
        public Notepad()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt|*.txt";
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            RichTextBox1.Text = fileText;
            MessageBox.Show("File is open");



        }

        private void SaveasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, RichTextBox1.Text,Encoding.GetEncoding("utf-8"));
            MessageBox.Show("File Saved");
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            //  return;
            // string filename = saveFileDialog1.FileName;
            // File.WriteAllText(filename, RichTextBox1.Text, Encoding.GetEncoding("utf-8"));
            if (string.IsNullOrEmpty(FilePath))
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Document|*.txt", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            sw.WriteLineAsync(RichTextBox1.Text);
                        }
                    }
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(FilePath))
                {
                    sw.WriteLineAsync(RichTextBox1.Text);
                }
            }

        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( RichTextBox1.TextLength > 0)
            {
                if (RichTextBox1.TextLength > 0)
                {
                    RichTextBox1.Undo();
                }
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RichTextBox1.TextLength > 0)
            {
                RichTextBox1.Cut();
            }
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RichTextBox1.TextLength > 0)
            {
                RichTextBox1.Copy();
            }
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RichTextBox1.TextLength > 0)
            {
                RichTextBox1.Paste();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RichTextBox1.SelectedText = "";
            
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            RichTextBox1.Font = fontDialog1.Font;
        }

        private void SelectallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RichTextBox1.TextLength > 0)
            {
                RichTextBox1.SelectAll();
            }
        }

        private void BackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            RichTextBox1.BackColor = colorDialog1.Color;

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elaborated by Denis Cozma", "About Program", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


     
        

        private void contextMenuStrip2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RichTextBox1.ContextMenuStrip = contextMenuStrip2;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ПравкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilePath = string.Empty;
            RichTextBox1.Clear();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UndoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (RichTextBox1.TextLength > 0)
            {
                RichTextBox1.Undo();
            }
        }

        private void CutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (RichTextBox1.TextLength > 0)
            {
                RichTextBox1.Cut();
            }
        }

        private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (RichTextBox1.TextLength > 0)
            {
                RichTextBox1.Copy();
            }
        }

        private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (RichTextBox1.TextLength > 0)
            {
                RichTextBox1.Paste();
            }
        }

        private void ContextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void FormatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SelectallToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordWrapToolStripMenuItem.Checked = !wordWrapToolStripMenuItem.Checked;
            RichTextBox1.WordWrap = wordWrapToolStripMenuItem.Checked;
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s = RichTextBox1.SelectedText;
            RichTextBox1.SelectionFont = new Font(RichTextBox1.Font, FontStyle.Bold);
            RichTextBox1.SelectedText = s;
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s = RichTextBox1.SelectedText;
            RichTextBox1.SelectionFont = new Font(RichTextBox1.Font, FontStyle.Italic);
            RichTextBox1.SelectedText = s;
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s = RichTextBox1.SelectedText;
            RichTextBox1.SelectionFont = new Font(RichTextBox1.Font, FontStyle.Regular);
            RichTextBox1.SelectedText = s;
        }

        private void alignLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void alignRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void alignCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
    }
}
