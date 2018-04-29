using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace digitalimageproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // our group use this function to open image in picture box 
        void openImage() {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK) {

                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = file;
                opened = true;
            }
        
        }
        
        //this function is to save the image 
        void saveImage() {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;|*.jpg;|*.bmp;"; //our app read only these formats of images
            ImageFormat form =  ImageFormat.Png; // our resulted pic will save in png format
            if(sfd.ShowDialog()==System.Windows.Forms.DialogResult.OK){
                
                string ext =Path.GetExtension(sfd.FileName);
                switch(ext)
                {
                    case ".jpg":
                        form=ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        form=ImageFormat.Bmp;
                        break;
                
                }
                pictureBox1.Image.Save(sfd.FileName,form);
            }

  }

        void reloadImage() {

            if (!opened)
            {
                MessageBox.Show("open an image first");
            }

            else { 
            
            if(opened){

                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = file;
                opened = true;
            }
            }
        
        }

        void filter1() {
            if (!opened) {
                MessageBox.Show("open an image first");
            }

            Image img = pictureBox1.Image;
            Bitmap bmp = new Bitmap(img.Width,img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cm = new ColorMatrix( new float[][] { new float[] {.393f,.349f+0.5f,.272f,0,0},//red
             new float[] {.769f+0.3f,.686f,.534f,0,0},// for green
             new float[] {.189f,.168f,.131f+0.5f,0,0},// blue
             new float[] {0,0,0,1,0},
             new float[] {0,0,0,0,1}  });
            ia.SetColorMatrix(cm);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img , new Rectangle(0 , 0 , img.Width , img.Height),0 , 0 ,img.Width,img.Height,GraphicsUnit.Pixel,ia);

            g.Dispose();
            pictureBox1.Image = bmp;
        
        }


        void filter2()
        {
            if (!opened)
            {
                MessageBox.Show("open an image first");
            }

            Image img = pictureBox1.Image;
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cm = new ColorMatrix(new float[][] { new float[] {.53f,.39f,0,0,0},//red
             new float[] {.769f+0.3f,.986f,.534f,0,0},// for green
             new float[] {.189f,2.168f,0,0,0},// blue
             new float[] {0,0,0,1,0},
             new float[] {0,0,0,0,1}  });
            ia.SetColorMatrix(cm);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            g.Dispose();
            pictureBox1.Image = bmp;

        }

        void filter3()
        {
            if (!opened)
            {
                MessageBox.Show("open an image first");
            }

            Image img = pictureBox1.Image;
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cm = new ColorMatrix(new float[][] {  new float[]{0.299f, 0.299f, 0.299f, 0, 0},
                    new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                    new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 0} });
            ia.SetColorMatrix(cm);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            g.Dispose();
            pictureBox1.Image = bmp;

        }


        void filter4()
        {
            if (!opened)
            {
                MessageBox.Show("open an image first");
            }

            Image img = pictureBox1.Image;
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cm = new ColorMatrix(new float[][] { new float[]{1+0.9f, 0, 0, 0, 0},
            new float[]{0, 1+1.5f, 0, 0, 0},
            new float[]{0, 0, 1+1.3f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1} });
            ia.SetColorMatrix(cm);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            g.Dispose();
            pictureBox1.Image = bmp;

        }


        void filter5()
        {
            if (!opened)
            {
                MessageBox.Show("open an image first");
            }

            Image img = pictureBox1.Image;
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cm = new ColorMatrix(new float[][] {new float[]{.393f, .349f, .272f, 0, 0},
            new float[]{.769f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1} });
            ia.SetColorMatrix(cm);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            g.Dispose();
            pictureBox1.Image = bmp;

        }


        void filter6()
        {
            if (!opened)
            {
                MessageBox.Show("open an image first");
            }

            Image img = pictureBox1.Image;
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cm = new ColorMatrix(new float[][] {new float[]{1+0.3f, 0, 0, 0, 0},
            new float[]{0, 1+0f, 0, 0, 0},
            new float[]{0, 0, 1+5f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1} });
            ia.SetColorMatrix(cm);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            g.Dispose();
            pictureBox1.Image = bmp;

        }


        void hue()
        {
            if (!opened)
            {
                MessageBox.Show("open an image first");
            }

            Image img = pictureBox1.Image;
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cm = new ColorMatrix(new float[][] { new float[] {1+(trackBar1.Value*0.1f),0,0,0,0},//red
             new float[] {0,1+(trackBar2.Value*0.1f),0,0,0},// for green
             new float[] {0,0,1+(trackBar3.Value*0.1f),0,0},// blue
             new float[] {0,0,0,1,0},
             new float[] {0,0,0,0,1}  });
            ia.SetColorMatrix(cm);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            g.Dispose();
            pictureBox1.Image = bmp;

        }

         
        Image file;
        bool opened = false;

        private void button4_Click(object sender, EventArgs e)
        {
            reloadImage();
            filter3();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openImage(); // our group created the function above and use that function on open image button event to open image 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // this button is to save image 
            saveImage();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            reloadImage();
            filter1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;
            reloadImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reloadImage();
            filter2();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            hue();
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            hue();
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            hue();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reloadImage();
            filter4();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reloadImage();
            filter5();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reloadImage();
            filter6();
        }
    }
}
