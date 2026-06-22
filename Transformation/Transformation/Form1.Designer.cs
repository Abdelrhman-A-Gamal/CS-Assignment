namespace Transformation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxStep = new System.Windows.Forms.PictureBox();
            this.pictureBoxMatrix = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnMatrix = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lblStep = new System.Windows.Forms.Label();
            this.lblMatrix = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatrix)).BeginInit();
            this.SuspendLayout();

            // pictureBoxOriginal 
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(20, 40);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;

            // pictureBoxStep
            this.pictureBoxStep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxStep.Location = new System.Drawing.Point(290, 40);
            this.pictureBoxStep.Name = "pictureBoxStep";
            this.pictureBoxStep.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxStep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStep.TabIndex = 1;
            this.pictureBoxStep.TabStop = false;

            // pictureBoxMatrix
            this.pictureBoxMatrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMatrix.Location = new System.Drawing.Point(560, 40);
            this.pictureBoxMatrix.Name = "pictureBoxMatrix";
            this.pictureBoxMatrix.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxMatrix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMatrix.TabIndex = 2;
            this.pictureBoxMatrix.TabStop = false;

            // btnLoad 
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLoad.Location = new System.Drawing.Point(80, 320);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(140, 40);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load Image";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnStep
            // 
            this.btnStep.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnStep.Location = new System.Drawing.Point(260, 320);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(170, 40);
            this.btnStep.TabIndex = 4;
            this.btnStep.Text = "Step-by-Step";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);

            // btnMatrix 
            this.btnMatrix.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMatrix.Location = new System.Drawing.Point(460, 320);
            this.btnMatrix.Name = "btnMatrix";
            this.btnMatrix.Size = new System.Drawing.Size(170, 40);
            this.btnMatrix.TabIndex = 5;
            this.btnMatrix.Text = "Single Matrix";
            this.btnMatrix.UseVisualStyleBackColor = true;
            this.btnMatrix.Click += new System.EventHandler(this.btnMatrix_Click);

            // btnSave
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSave.Location = new System.Drawing.Point(660, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // lblOriginal
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOriginal.Location = new System.Drawing.Point(85, 15);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(109, 23);
            this.lblOriginal.TabIndex = 7;
            this.lblOriginal.Text = "Original Image";

            // lblStep
            this.lblStep.AutoSize = true;
            this.lblStep.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStep.Location = new System.Drawing.Point(325, 15);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(172, 23);
            this.lblStep.TabIndex = 8;
            this.lblStep.Text = "Step-by-Step Result";

            // lblMatrix
            this.lblMatrix.AutoSize = true;
            this.lblMatrix.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMatrix.Location = new System.Drawing.Point(590, 15);
            this.lblMatrix.Name = "lblMatrix";
            this.lblMatrix.Size = new System.Drawing.Size(159, 23);
            this.lblMatrix.TabIndex = 9;
            this.lblMatrix.Text = "Single Matrix Result";

            // Form1 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 390);
            this.Controls.Add(this.lblMatrix);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.lblOriginal);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMatrix);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pictureBoxMatrix);
            this.Controls.Add(this.pictureBoxStep);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geometric Image Transformations";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMatrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxStep;
        private System.Windows.Forms.PictureBox pictureBoxMatrix;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnMatrix;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.Label lblMatrix;
    }
}