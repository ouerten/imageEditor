using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string FileName;
        public Bitmap temp=null;
        public Bitmap temp2 = null;
        public int rbutton=0, gbutton = 0, bbutton = 0,orj=0;
        public void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Chose Image";
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                FileName = open.FileName;
                Bitmap img = new Bitmap(open.OpenFile());
                temp = img;
                temp2 = img;
                pictureBox1.Image = img;
            }

        }

        public void button2_Click(object sender, EventArgs e)
        {
            
            Bitmap bmp = new Bitmap(temp);
            Bitmap bmp2 = new Bitmap(temp2);
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap rotatedBmp = new Bitmap(height, width);
            Bitmap rotatedBmp2 = new Bitmap(height, width);
            for (int y = 0;y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    Color p2 = bmp2.GetPixel(x, y);
                   

                    rotatedBmp.SetPixel((height - 1) - y, x, p);
                    rotatedBmp2.SetPixel((height - 1) - y, x, p2);
                }
            }

            temp = rotatedBmp;
            temp2 = rotatedBmp2;
            pictureBox1.Image = rotatedBmp;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int w, h;
            w = Convert.ToInt32(Interaction.InputBox("Width:", "Giris", "", 960, 540));
            h = Convert.ToInt32(Interaction.InputBox("Height:", "Giris", "", 960, 540));
            Bitmap bmp = new Bitmap(temp);
            Bitmap bmp2 = new Bitmap(temp2);

            Bitmap newbmp = new Bitmap(bmp, w, h);
            Bitmap newbmp2 = new Bitmap(bmp2, w, h);
            temp = newbmp;
            temp2 = newbmp2;

            pictureBox1.Image = newbmp;
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(temp2);
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap bbmp = new Bitmap(bmp);
            bbutton = 1;
    
           
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;


                   if (bbutton == 1 && gbutton == 1 && rbutton == 1)
                    {
                        bbmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                        orj = 1;

                    }
                    else if (bbutton == 1 && gbutton == 1)
                    {
                        bbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, b));
                    }
                    else if (bbutton == 1 && rbutton == 1)
                    {
                        bbmp.SetPixel(x, y, Color.FromArgb(a, r, 0, b));
                    }
                    else if (bbutton == 1)
                    {
                        bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));
                    }

                }
            }
            if (orj == 1)
            {
                rbutton = 0;
                gbutton = 0;
                bbutton = 0;
                orj = 0;
            }
            temp = bbmp;
            pictureBox1.Image = bbmp;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(temp);
            Bitmap bmp2 = new Bitmap(temp2);
            Bitmap newbmp = new Bitmap(bmp, 1600, 900);
            Bitmap newbmp2 = new Bitmap(bmp2, 1600, 900);
            temp = newbmp;
            temp2 = newbmp2;
            pictureBox1.Image = newbmp;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(temp);
            Bitmap bmp2 = new Bitmap(temp2);

            int width = bmp.Width;
            int height = bmp.Height;

            Bitmap bmp3 = new Bitmap(width, height);
            Bitmap bmp4 = new Bitmap(width, height);


            for (int y = 0; y < height; y++)
            {
                for (int lx = 0, rx = width - 1; lx < width; lx++, rx--)
                {
                    Color p = bmp.GetPixel(lx, y);
                    Color p2 = bmp2.GetPixel(lx, y);

                    bmp3.SetPixel(rx, y, p);
                    bmp4.SetPixel(rx, y, p2);
                }
            }
            temp = bmp3;
            temp2 = bmp4;
            pictureBox1.Image = bmp3;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(temp);
            Bitmap bmp2 = new Bitmap(temp2);

            int width = bmp.Width;
            int height = bmp.Height;


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    Color p2 = bmp2.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    int a2 = p2.A;
                    int r2 = p2.R;
                    int g2 = p2.G;
                    int b2 = p2.B;
                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;
                    r2 = 255 - r2;
                    g2 = 255 - g2;
                    b2 = 255 - b2;

                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                    bmp2.SetPixel(x, y, Color.FromArgb(a2, r2, g2, b2));
                }
            }
            temp = bmp;
            temp2 = bmp2;
            pictureBox1.Image = bmp;



        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(temp);
            Bitmap bmp2 = new Bitmap(temp2);

            int width = bmp.Width;
            int height = bmp.Height;


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    Color p2 = bmp2.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    int a2 = p2.A;
                    int r2 = p2.R;
                    int g2 = p2.G;
                    int b2 = p2.B;
                    int avg = (r + g + b) / 3;
                    int avg2 = (r2 + g2 + b2) / 3;
                    bmp.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                    bmp2.SetPixel(x, y, Color.FromArgb(a2, avg2, avg2, avg2));
                }
            }
            temp = bmp;
            temp2 = bmp2;
            pictureBox1.Image = bmp;


           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(FileName);
            Bitmap bmp = new Bitmap(img);
            pictureBox1.Image = bmp;
            rbutton = 0;
            gbutton = 0;
            bbutton = 0;
            orj = 0;
            temp = bmp;
            temp2 = bmp;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(temp2);

            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap gbmp = new Bitmap(bmp);
            gbutton = 1;
        
           
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;


                    if (gbutton == 1 && bbutton == 1 && rbutton == 1)
                    {
                        gbmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                        orj = 1;
                    }
                    else if (gbutton == 1 && bbutton == 1)
                    {
                        gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, b));
                    }
                    else if (gbutton == 1 && rbutton == 1)
                    {
                        gbmp.SetPixel(x, y, Color.FromArgb(a, r, g, 0));
                    }
                    else if(gbutton == 1)
                    {
                        gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
                    }

                }

            }
            if (orj == 1)
            {
                rbutton = 0;
                gbutton = 0;
                bbutton = 0;
                orj = 0;

            }
            temp = gbmp;
            pictureBox1.Image = gbmp;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save Image";
            save.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";


            Image img = pictureBox1.Image;
            
            if (save.ShowDialog() == DialogResult.OK)
            {
                    img.Save(save.FileName);
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(temp2);
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap rbmp = new Bitmap(bmp);
            rbutton = 1;
    
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    if (rbutton == 1 && bbutton == 1 && gbutton == 1)
                    {
                        rbmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                        orj = 1;
                    }
                    else if (rbutton == 1 && bbutton == 1)
                    {
                        rbmp.SetPixel(x, y, Color.FromArgb(a, r, 0, b));
                    }
                    else if (rbutton == 1 && gbutton == 1)
                    {
                        rbmp.SetPixel(x, y, Color.FromArgb(a, r, g, 0));
                    }
                    else if(rbutton == 1)
                    {
                        rbmp.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));
                    }


                }
            }
            if(orj==1)
            {
                rbutton = 0;
                gbutton = 0;
                bbutton = 0;
           
                orj = 0;

            }
            temp = rbmp;
            pictureBox1.Image = rbmp;

        }

        private void button13_Click(object sender, EventArgs e)
        {
    
            Bitmap bmp = new Bitmap(temp);
            Bitmap bmp2 = new Bitmap(temp2);

            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap rotatedBmp = new Bitmap(height, width);
            Bitmap rotatedBmp2 = new Bitmap(height, width);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);

                    Color p2 = bmp2.GetPixel(x, y);

                    rotatedBmp.SetPixel(y, (width - 1) - x, p);
                    rotatedBmp2.SetPixel(y, (width - 1) - x, p2);
                }
            }
            temp = rotatedBmp;
            temp2 = rotatedBmp2;
            pictureBox1.Image = rotatedBmp;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.chart5.Series["Red"].Points.Clear();
            frm3.chart6.Series["Green"].Points.Clear();
            frm3.chart7.Series["Blue"].Points.Clear();
            frm3.chart8.Series["Grey"].Points.Clear();


            Image img = pictureBox1.Image;
            Bitmap bmp = new Bitmap(img);
            int width = bmp.Width;
            int height = bmp.Height;
            int[] red = new int[256];
            int[] green = new int[256];
            int[] blue = new int[256];
            int[] grey = new int[256];


            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
               
                    Color p = bmp.GetPixel(x, y);

                    red[p.R]++;
                    green[p.G]++;
                    blue[p.B]++;
                    int avg = (p.R + p.G + p.B) / 3;
                    grey[avg]++;

                }
            }

            
            for (int i = 0; i < red.Length; i++)
            {
                frm3.chart5.Series["Red"].Points.AddXY(i,red[i]);
            }
            for (int i = 0; i < green.Length; i++)
            {
                frm3.chart6.Series["Green"].Points.AddXY(i,green[i]);
            }
            for (int i = 0; i < blue.Length; i++)
            {
                frm3.chart7.Series["Blue"].Points.AddXY(i, blue[i]);
            }
            for (int i = 0; i < grey.Length; i++)
            {
                frm3.chart8.Series["Grey"].Points.AddXY(i,grey[i]);
            }
            frm3.Show();
        }
    }
}
   