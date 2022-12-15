using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MiniPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = pnl_Draw.CreateGraphics();
        }
        bool startPaint = false;
        Graphics g;
        
        int? initX = null;
        int? initY = null;
        bool drawSquare = false;
        bool drawRectangle = false;
        bool drawCircle = false;
       
        private void pnl_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
            
                Pen p = new Pen(btn_PenColor.BackColor, float.Parse(cmb_PenSize.Text));
                
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            }
        }
       
        private void pnl_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
            if (drawSquare)
            {
               
                SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
               
               if(txt_ShapeSize.Text!="") g.FillRectangle(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
               
                startPaint = false;
                drawSquare = false;
            }
            if (drawRectangle)
            {
                SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
              
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                startPaint = false;
                drawRectangle = false;
            }
            if (drawCircle)
            {
                SolidBrush sb = new SolidBrush(btn_PenColor.BackColor);
                g.FillEllipse(sb, e.X, e.Y, int.Parse(txt_ShapeSize.Text), int.Parse(txt_ShapeSize.Text));
                startPaint = false;
                drawCircle = false;
            }
        }
      
        private void pnl_Draw_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
      
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                btn_PenColor.BackColor = c.Color;
            }
        }
      
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            g.Clear(pnl_Draw.BackColor);
   
            pnl_Draw.BackColor = Color.White;
            btn_CanvasColor.BackColor = Color.White;
        }
   
        private void btn_CanvasColor_Click_1(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                pnl_Draw.BackColor = c.Color;
                btn_CanvasColor.BackColor = c.Color;
            }
        }
        private void btn_Square_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }
        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
        }
        private void btn_Circle_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // if (MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Image";
            openFileDialog1.Filter = "All|*.jpg;*.bmp;*.gif;*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                pnl_Draw.SizeMode = PictureBoxSizeMode.Zoom;
                pnl_Draw.Image = Image.FromFile(openFileDialog1.FileName);

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.Filter = "All|*.jpg;*.bmp;*.gif;*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
            if (saveFileDialog1.FileName.Length > 0)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                pnl_Draw.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)                 
                pnl_Draw.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
           
        }
     
       
    }
}