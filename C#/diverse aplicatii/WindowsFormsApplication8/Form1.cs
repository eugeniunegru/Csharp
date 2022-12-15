using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        RichTextBox rich;
        int page = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            page++;
            tabControl1.TabPages.Add("Document" + page);
            TabPage t = tabControl1.TabPages[page-1];
            tabControl1.SelectedTab = t;
            rich = new RichTextBox();
            rich.Dock = DockStyle.Fill;
            tabControl1.TabPages[page - 1].Controls.Add(rich);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex =0;
            
            openFileDialog1.Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
 
           if(tabControl1.Controls.Count>0) 
               if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Length>0)
            {
                saveFileDialog1.FileName = openFileDialog1.FileName;
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                rich.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog1.FileName.Length > 0)
                rich.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            else
            {
                if(saveFileDialog1.ShowDialog()==DialogResult.OK)
                    rich.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                rich.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rich.SelectAll();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                rich.SelectionBackColor = colorDialog1.Color;
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                rich.SelectionColor = colorDialog1.Color;
        }

        private void fontTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                rich.SelectionFont = fontDialog1.Font;
        }
    }
}
