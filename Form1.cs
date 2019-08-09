using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ChoosButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void SmallerButton_Click(object sender, EventArgs e)
        {
            System.Drawing.Rectangle screenSize = new System.Drawing.Rectangle();

            screenSize.Width = SystemInformation.VirtualScreen.Width;
            screenSize.Height = SystemInformation.VirtualScreen.Height;

            int zoomFactor = 2;

            Image img = pictureBox1.Image;
            Bitmap bitMapImg = new Bitmap(img);

            Size newSize = new Size((int)(bitMapImg.Width / zoomFactor), (int)(bitMapImg.Height / zoomFactor));
            Bitmap bmp = new Bitmap(bitMapImg, newSize);

            this.pictureBox1.Image = (Image)bmp;
        }

        private void BiggerButton_Click(object sender, EventArgs e)
        {
            System.Drawing.Rectangle screenSize = new System.Drawing.Rectangle();

            screenSize.Width = SystemInformation.VirtualScreen.Width;
            screenSize.Height = SystemInformation.VirtualScreen.Height;

            int zoomFactor = 2;

            Image img = pictureBox1.Image;
            Bitmap bitMapImg = new Bitmap(img);

            Size newSize = new Size((int)(bitMapImg.Width * zoomFactor), (int)(bitMapImg.Height * zoomFactor));
            Bitmap bmp = new Bitmap(bitMapImg, newSize);

            this.pictureBox1.Image = (Image)bmp;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
