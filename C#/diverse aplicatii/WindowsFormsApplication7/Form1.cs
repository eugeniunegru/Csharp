using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Drawing2D;
namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {

        ArrayList alist = new ArrayList();
        int i = 0;
        int filelength = 0;
        private Image imgOriginal;
        Size size;
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        
            System.IO.DirectoryInfo inputDir = new System.IO.DirectoryInfo("C:\\Users\\romanciucanton\\Desktop\\photo");
            try
            {
                if ((inputDir.Exists))
                {
                    //Get Each files 
                    System.IO.FileInfo file = null;
                    foreach (System.IO.FileInfo eachfile in inputDir.GetFiles())
                    {
                        file = eachfile;
                        if (file.Extension == ".JPG")
                        {
                            alist.Add(file.FullName); 
                            filelength = filelength + 1;
                        }
                    }
                    pictureBox1.Image = Image.FromFile(alist[0].ToString()); 
                    i = 0;
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(Convert.ToString(ex));
            }
        }
      
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (i + 1 < filelength)
            {
                pictureBox1.Image = Image.FromFile(alist[i + 1].ToString());
                i = i + 1;
            }
        }
    
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (i - 1 >= 0)
            {
                pictureBox1.Image = Image.FromFile(alist[i - 1].ToString());
                i = i - 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            size = new System.Drawing.Size();
            size.Width = 2;
            size.Height = 2;
            Bitmap bm = new Bitmap(pictureBox1.Image, Convert.ToInt32(pictureBox1.Image.Width / size.Width), Convert.ToInt32(pictureBox1.Image.Height / size.Height));
            Graphics grap = Graphics.FromImage(bm);
            grap.InterpolationMode = InterpolationMode.HighQualityBicubic;
            pictureBox1.Image = bm;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            size = new System.Drawing.Size();
            size.Width = 2;
            size.Height = 2;
            Bitmap bm = new Bitmap(pictureBox1.Image, Convert.ToInt32(pictureBox1.Image.Width * size.Width), Convert.ToInt32(pictureBox1.Image.Height * size.Height));
            Graphics grap = Graphics.FromImage(bm);
            grap.InterpolationMode = InterpolationMode.HighQualityBicubic;
            pictureBox1.Image = bm;
        }

        private void curentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
            }
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == '\\')
                {
                    path = path.Insert(i, "\\");
                    i++;
                }
            }
            //MessageBox.Show(path);
            System.IO.DirectoryInfo inputDir = new System.IO.DirectoryInfo(path);
            
            try
            {
                filelength = 0;
                if ((inputDir.Exists))
                {
                    //Get Each files 
                    System.IO.FileInfo file = null;
                    foreach (System.IO.FileInfo eachfile in inputDir.GetFiles())
                    {
                        file = eachfile;
                        if (file.Extension == ".jpg")
                        {
                            alist.Add(file.FullName);
                            filelength = filelength + 1;
                        }
                    }
                    pictureBox1.Image = Image.FromFile(alist[0].ToString());
                    i = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
    }
}