
namespace yolo_image_detection
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
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBox_image = new System.Windows.Forms.PictureBox();
            this.btn_Image = new System.Windows.Forms.Button();
            this.btn_Detect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox_image
            // 
            this.pBox_image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pBox_image.Location = new System.Drawing.Point(12, 12);
            this.pBox_image.Name = "pBox_image";
            this.pBox_image.Size = new System.Drawing.Size(943, 582);
            this.pBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox_image.TabIndex = 3;
            this.pBox_image.TabStop = false;
            // 
            // btn_Image
            // 
            this.btn_Image.Location = new System.Drawing.Point(12, 600);
            this.btn_Image.Name = "btn_Image";
            this.btn_Image.Size = new System.Drawing.Size(236, 43);
            this.btn_Image.TabIndex = 4;
            this.btn_Image.Text = "Fotoğraf Seç";
            this.btn_Image.UseVisualStyleBackColor = true;
            this.btn_Image.Click += new System.EventHandler(this.btn_Image_Click);
            // 
            // btn_Detect
            // 
            this.btn_Detect.Location = new System.Drawing.Point(254, 600);
            this.btn_Detect.Name = "btn_Detect";
            this.btn_Detect.Size = new System.Drawing.Size(227, 43);
            this.btn_Detect.TabIndex = 5;
            this.btn_Detect.Text = "Tanımla";
            this.btn_Detect.UseVisualStyleBackColor = true;
            this.btn_Detect.Click += new System.EventHandler(this.btn_Detect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 652);
            this.Controls.Add(this.btn_Detect);
            this.Controls.Add(this.btn_Image);
            this.Controls.Add(this.pBox_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Obje Tanımlama";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox_image;
        private System.Windows.Forms.Button btn_Image;
        private System.Windows.Forms.Button btn_Detect;
    }
}

