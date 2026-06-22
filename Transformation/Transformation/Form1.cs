using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Transformation
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        private Bitmap stepResult;
        private Bitmap matrixResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(open.FileName);

                pictureBoxOriginal.Image = originalImage;
                pictureBoxStep.Image = null;
                pictureBoxMatrix.Image = null;
            }
        }
        private void btnStep_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Load an image first.");
                return;
            }

            stepResult = ApplyStepTransform(originalImage);

            pictureBoxStep.Image = stepResult;
        }
        private void btnMatrix_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Load an image first.");
                return;
            }

            matrixResult = ApplyMatrixTransform(originalImage);

            pictureBoxMatrix.Image = matrixResult;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Bitmap img = matrixResult ?? stepResult;

            if (img == null)
            {
                MessageBox.Show("No transformed image to save.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG Image|*.png|JPEG Image|*.jpg";

            if (save.ShowDialog() == DialogResult.OK)
            {
                img.Save(save.FileName);
                MessageBox.Show("Image saved successfully.");
            }
        }

        private Bitmap ApplyStepTransform(Bitmap image)
        {
            Bitmap result = new Bitmap(600, 600);

            using (Graphics g = Graphics.FromImage(result))
            {
                g.Clear(Color.White);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.TranslateTransform(result.Width / 2f, result.Height / 2f);
                g.TranslateTransform(30, 30);
                g.ScaleTransform(0.75f, 0.75f);
                g.RotateTransform(-90);
                g.DrawImage(image,
                    -image.Width / 2f,
                    -image.Height / 2f,
                    image.Width,
                    image.Height);
            }
            return result;
        }

       
        private Bitmap ApplyMatrixTransform(Bitmap image)
        {
            Bitmap result = new Bitmap(600, 600);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.Clear(Color.White);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                Matrix m = new Matrix();
                m.Translate(result.Width / 2f, result.Height / 2f);
                m.Rotate(-90);
                m.Scale(0.75f, 0.75f);
                m.Translate(30, 30);
                g.Transform = m;
                g.DrawImage(image,
                    -image.Width / 2f,
                    -image.Height / 2f,
                    image.Width,
                    image.Height);
            }
            return result;
        }
    }
}
