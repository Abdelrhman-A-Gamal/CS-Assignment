using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogoInsertionApp
{
    public partial class Form1 : Form
    {
        private Bitmap mainImage;
        private Bitmap logoImage;
        private Bitmap resultImage;

        public Form1()
        {
            InitializeComponent();
        }

     
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                mainImage = new Bitmap(ofd.FileName);
                pictureBoxMain.Image = mainImage;
            }
        }
        private void btnLoadLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.png;*.jpg;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                logoImage = new Bitmap(ofd.FileName);
                pictureBoxLogo.Image = logoImage;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (mainImage == null || logoImage == null)
            {
                MessageBox.Show("Please load both main image and logo.");
                return;
            }

            resultImage = new Bitmap(mainImage);

            using (Graphics g = Graphics.FromImage(resultImage))
            {
                int margin = 10;

                int x = 0;
                int y = 0;

                int logoWidth = logoImage.Width;
                int logoHeight = logoImage.Height;

                string corner = comboCorner.SelectedItem.ToString();

                switch (corner)
                {
                    case "Top Left":
                        x = margin;
                        y = margin;
                        break;

                    case "Top Right":
                        x = resultImage.Width - logoWidth - margin;
                        y = margin;
                        break;

                    case "Bottom Left":
                        x = margin;
                        y = resultImage.Height - logoHeight - margin;
                        break;

                    case "Bottom Right":
                        x = resultImage.Width - logoWidth - margin;
                        y = resultImage.Height - logoHeight - margin;
                        break;
                }

                g.DrawImage(logoImage, x, y, logoWidth, logoHeight);
            }

            pictureBoxResult.Image = resultImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (resultImage == null)
            {
                MessageBox.Show("No image to save.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                resultImage.Save(sfd.FileName);
                MessageBox.Show("Image saved successfully!");
            }
        }

        private void comboCorner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mainImage != null && logoImage != null)
            {
                btnApply.PerformClick();
            }
        }
    }
}