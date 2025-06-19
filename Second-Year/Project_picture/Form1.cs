using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipXY);

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image != null)
            {

                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
                pictureBox1.Refresh();
                //pictureBox1.Image.PixelFormat()

            }

        }
        private Image ZoomImage(Image img, float scale)
        {
            Bitmap bmp = new Bitmap(img, new Size((int)(img.Width * scale), (int)(img.Height * scale)));
            return bmp;
        }
        private void ZoomOut(object sender, EventArgs e)
        {
            pictureBox1.Image = ZoomImage(pictureBox1.Image, 0.8f);
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ZoomImage(pictureBox1.Image, 1.2f);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ZoomImage(pictureBox1.Image, 0.9f);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                int new_Width ;
                int new_Height;
                Image originalimage = pictureBox1.Image;
                int oldwidth=originalimage.Width;
                int oldheight=originalimage.Height;
                if (oldwidth < 500 || oldheight <500)
                {
                    new_Width = oldwidth + 10;
                    new_Height = oldheight + 10;
                    using (Bitmap resizedimage = new Bitmap(originalimage, new Size(new_Width, new_Height)))
                    {
                        pictureBox1.Image = (Image)resizedimage.Clone();
                    }
                }
                else
                {
                    MessageBox.Show("Can not move image ,this is minimum size");

                }
                
               
            }
            else
            {
                MessageBox.Show("not found image");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                int new_Width;
                int new_Height;
                Image originalimage = pictureBox1.Image;
                int oldwidth = originalimage.Width;
                int oldheight = originalimage.Height;
                if (oldwidth > 50 || oldheight > 50)
                {
                    new_Width = oldwidth - 10;
                    new_Height = oldheight - 10;
                    using (Bitmap resizedimage = new Bitmap(originalimage, new Size(new_Width, new_Height)))
                    {
                        pictureBox1.Image = (Image)resizedimage.Clone();
                    }
                }
                else
                {
                    MessageBox.Show("Can not move image ,this is minimum size");

                }


            }
            else
            {
                MessageBox.Show("not found image");

            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                int new_Width;
                int new_Height;
                Image originalimage = pictureBox1.Image;
                int oldwidth = originalimage.Width;
                int oldheight = originalimage.Height;
                if (oldwidth < 500 || oldheight < 500)
                {
                    new_Width = oldwidth + 10;
                    new_Height = oldheight + 10;
                    using (Bitmap resizedimage = new Bitmap(originalimage, new Size(new_Width, new_Height)))
                    {
                        pictureBox1.Image = (Image)resizedimage.Clone();
                    }
                }
                else
                {
                    MessageBox.Show("Can not move image ,this is minimum size");

                }


            }
            else
            {
                MessageBox.Show("not found image");

            }
        }
    }
}



/*
public class MainForm : Form
{
    private PictureBox pictureBox;
    private Button buttonZoomIn;
    private Button buttonZoomOut;
    private Image originalImage;

    public MainForm()
    {
        // Initialize PictureBox
        //pict/ureBox = new PictureBox();
        originalImage = Image.FromFile("path_to_your_image.jpg");
        pictureBox.Image = new Bitmap(originalImage);
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox.Dock = DockStyle.Fill;

        // Initialize Zoom In Button
        buttonZoomIn = new Button();
        buttonZoomIn.Text = "Zoom In";
        buttonZoomIn.Dock = DockStyle.Top;
        buttonZoomIn.Click += ZoomIn;

        // Initialize Zoom Out Button
        buttonZoomOut = new Button();
        buttonZoomOut.Text = "Zoom Out";
        buttonZoomOut.Dock = DockStyle.Top;
        buttonZoomOut.Click += ZoomOut;

        // Add controls to the form
        Controls.Add(pictureBox);
        Controls.Add(buttonZoomIn);
        Controls.Add(buttonZoomOut);
    }

    private void ZoomIn(object sender, EventArgs e)
    {
        pictureBox.Image = ZoomImage(pictureBox.Image, 1.2f);
    }

    private void ZoomOut(object sender, EventArgs e)
    {
        pictureBox.Image = ZoomImage(pictureBox.Image, 0.8f);
    }

    private Image ZoomImage(Image img, float scale)
    {
        Bitmap bmp = new Bitmap(img, new Size((int)(img.Width * scale), (int)(img.Height * scale)));
        return bmp;
    }

    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new MainForm());
    }
}

*/