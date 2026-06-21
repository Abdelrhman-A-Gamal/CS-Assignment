namespace WaterMarkApplication
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtWatermark = new System.Windows.Forms.TextBox();
            this.trackAlpha = new System.Windows.Forms.TrackBar();
            this.trackBeta = new System.Windows.Forms.TrackBar();
            this.lblAlpha = new System.Windows.Forms.Label();
            this.lblBeta = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBeta)).BeginInit();

            this.SuspendLayout();

            // pictureBox1
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;

            // pictureBox2
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(400, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;

            // lblText
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(20, 340);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(93, 16);
            this.lblText.Text = "Watermark:";

            // txtWatermark
            this.txtWatermark.Location = new System.Drawing.Point(120, 337);
            this.txtWatermark.Name = "txtWatermark";
            this.txtWatermark.Size = new System.Drawing.Size(250, 22);
            this.txtWatermark.TabIndex = 2;
            this.txtWatermark.Text = "My Watermark";

            // lblAlpha
            this.lblAlpha.AutoSize = true;
            this.lblAlpha.Location = new System.Drawing.Point(20, 380);
            this.lblAlpha.Name = "lblAlpha";
            this.lblAlpha.Size = new System.Drawing.Size(135, 16);
            this.lblAlpha.Text = "Original Weight: 80%";

            // trackAlpha
            this.trackAlpha.Location = new System.Drawing.Point(170, 370);
            this.trackAlpha.Maximum = 100;
            this.trackAlpha.Minimum = 0;
            this.trackAlpha.Name = "trackAlpha";
            this.trackAlpha.Size = new System.Drawing.Size(250, 56);
            this.trackAlpha.TabIndex = 3;
            this.trackAlpha.TickFrequency = 10;
            this.trackAlpha.Value = 80;
            this.trackAlpha.Scroll += new System.EventHandler(this.trackAlpha_Scroll);

            // lblBeta
            this.lblBeta.AutoSize = true;
            this.lblBeta.Location = new System.Drawing.Point(20, 430);
            this.lblBeta.Name = "lblBeta";
            this.lblBeta.Size = new System.Drawing.Size(152, 16);
            this.lblBeta.Text = "Watermark Weight: 20%";

            // trackBeta
            this.trackBeta.Location = new System.Drawing.Point(170, 420);
            this.trackBeta.Maximum = 100;
            this.trackBeta.Minimum = 0;
            this.trackBeta.Name = "trackBeta";
            this.trackBeta.Size = new System.Drawing.Size(250, 56);
            this.trackBeta.TabIndex = 4;
            this.trackBeta.TickFrequency = 10;
            this.trackBeta.Value = 20;
            this.trackBeta.Scroll += new System.EventHandler(this.trackBeta_Scroll);

            // btnLoad
            this.btnLoad.Location = new System.Drawing.Point(470, 350);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 40);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load Image";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // btnApply
            this.btnApply.Location = new System.Drawing.Point(610, 350);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(140, 40);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply Watermark";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(540, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtWatermark);
            this.Controls.Add(this.lblAlpha);
            this.Controls.Add(this.trackAlpha);
            this.Controls.Add(this.lblBeta);
            this.Controls.Add(this.trackBeta);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watermark Application";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBeta)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtWatermark;
        private System.Windows.Forms.TrackBar trackAlpha;
        private System.Windows.Forms.TrackBar trackBeta;
        private System.Windows.Forms.Label lblAlpha;
        private System.Windows.Forms.Label lblBeta;
        private System.Windows.Forms.Label lblText;
    }
}