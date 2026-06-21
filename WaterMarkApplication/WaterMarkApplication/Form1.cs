using System.Drawing;
using System.Drawing;
using System.Windows.Forms;


namespace WaterMarkApplication
{

    public partial class Form1 
    {


        Bitmap originalImage;
        Bitmap resultImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.png;*.bmp";
            if (open.ShowDialog()== DialogResult.OK){
                originalImage = new Bitmap(open.FileName);
                pictureBox1.Image = originalImage;
            }
        }
        

        private Bitmap CreateWatermark(Bitmap image, string text)
        {
            Bitmap watermark = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(watermark)){
                g.Clear(Color.Black);
                Font font = new Font("Arial", 40, FontStyle.Bold);
                SizeF size = g.MeasureString(text, font);

                float x = (image.Width - size.Width) / 2;
                float y = (image.Height - size.Height) / 2;

                g.DrawString(text, font, Brushes.White, x, y);
            }
            return watermark;
        }

        private Bitmap Blend(Bitmap img1, Bitmap img2, float alpha, float beta)
        {
            Bitmap result = new Bitmap(img1.Width, img1.Height);
            for (int y = 0; y < img1.Height; y++)
            {
                for (int x = 0; x < img1.Width; x++)
                {
                    Color c1 = img1.GetPixel(x, y);
                    Color c2 = img2.GetPixel(x, y);

                    int r = (int)(alpha * c1.R + beta * c2.R);
                    int g = (int)(alpha * c1.G + beta * c2.G);
                    int b = (int)(alpha * c1.B + beta * c2.B);

                    r = Math.Min(255, r);
                    g = Math.Min(255, g);
                    b = Math.Min(255, b);

                    result.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return result;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Load an image first.");
                return;
            }
            Bitmap watermark = CreateWatermark(originalImage, txtWatermark.Text);
            float alpha = trackAlpha.Value / 100f;
            float beta = trackBeta.Value / 100f;
            resultImage = Blend(originalImage, watermark, alpha, beta);
            pictureBox2.Image = resultImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
            if (save.ShowDialog() == DialogResult.OK)
            {
                resultImage.Save(save.FileName);
            }
        }

        private void trackAlpha_Scroll(object sender, EventArgs e)
        {
            lblAlpha.Text = "Original Weight: " + trackAlpha.Value + "%";
        }

        private void trackBeta_Scroll(object sender, EventArgs e)
        {
            lblBeta.Text = "Watermark Weight: " + trackBeta.Value + "%";
        }

    }
}
