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
       
        public Notepad()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt|*.txt";
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = File.ReadAllText(filename);
            RichTextBox1.Text = fileText;
            MessageBox.Show("File is open");



        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, RichTextBox1.Text,Encoding.GetEncoding("utf-8"));
            MessageBox.Show("Фаил Сахронен");
        }

        private void фаилToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
         



        }

        private void отменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( RichTextBox1.TextLength > 0)
            {
                if (RichTextBox1.TextLength > 0)
                {
                    RichTextBox1.();
                }
            }
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RichTextBox1.TextLength > 0)
            {
                RichTextBox1.Cut();
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RichTextBox1.TextLength > 0)
            {
                RichTextBox1.Copy();
            }
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RichTextBox1.TextLength > 0)
            {
                RichTextBox1.Paste();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RichTextBox1.TextLength > 0)
            {
                RichTextBox1.DeselectAll();
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            RichTextBox1.Font = fontDialog1.Font;
        }

        private void выделитьСвеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RichTextBox1.TextLength > 0)
            {
                RichTextBox1.SelectAll();
            }
        }

        private void фонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            RichTextBox1.BackColor = colorDialog1.Color;

        }

        private void справкиToolStripMenuItem_Click(object sender, EventArgs e)
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
            FilePath = string.Empty;
            RichTextBox1.Clear();
        }
    }
}
