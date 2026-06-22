namespace LogoInsertionApp
{
    partial class Form1
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
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxResult = new System.Windows.Forms.PictureBox();

            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnLoadLogo = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();

            this.comboCorner = new System.Windows.Forms.ComboBox();
            this.lblCorner = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).BeginInit();

            this.SuspendLayout();

            // pictureBoxMain
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMain.Location = new System.Drawing.Point(20, 20);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(300, 250);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // pictureBoxLogo
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLogo.Location = new System.Drawing.Point(340, 20);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // pictureBoxResult
            this.pictureBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResult.Location = new System.Drawing.Point(20, 290);
            this.pictureBoxResult.Name = "pictureBoxResult";
            this.pictureBoxResult.Size = new System.Drawing.Size(470, 250);
            this.pictureBoxResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // lblCorner
            this.lblCorner.AutoSize = true;
            this.lblCorner.Location = new System.Drawing.Point(340, 190);
            this.lblCorner.Name = "lblCorner";
            this.lblCorner.Size = new System.Drawing.Size(90, 16);
            this.lblCorner.Text = "Logo Corner:";

            // comboCorner
            this.comboCorner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCorner.FormattingEnabled = true;
            this.comboCorner.Items.AddRange(new object[] {
                "Top Left",
                "Top Right",
                "Bottom Left",
                "Bottom Right"
            });
            this.comboCorner.Location = new System.Drawing.Point(340, 210);
            this.comboCorner.Name = "comboCorner";
            this.comboCorner.Size = new System.Drawing.Size(150, 24);
            this.comboCorner.SelectedIndex = 3; 

            // btnLoadImage
            this.btnLoadImage.Location = new System.Drawing.Point(20, 560);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(110, 40);
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);

            // btnLoadLogo
            this.btnLoadLogo.Location = new System.Drawing.Point(140, 560);
            this.btnLoadLogo.Name = "btnLoadLogo";
            this.btnLoadLogo.Size = new System.Drawing.Size(110, 40);
            this.btnLoadLogo.Text = "Load Logo";
            this.btnLoadLogo.UseVisualStyleBackColor = true;
            this.btnLoadLogo.Click += new System.EventHandler(this.btnLoadLogo_Click);

            // btnApply
            this.btnApply.Location = new System.Drawing.Point(260, 560);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(110, 40);
            this.btnApply.Text = "Apply Logo";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(380, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 40);
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 620);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxResult);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.btnLoadLogo);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboCorner);
            this.Controls.Add(this.lblCorner);

            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logo Insertion Application";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResult)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxResult;

        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnLoadLogo;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.ComboBox comboCorner;
        private System.Windows.Forms.Label lblCorner;
    }
}