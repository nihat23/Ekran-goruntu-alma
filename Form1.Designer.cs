namespace Ekran_Görüntüsü_alma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1EkranGoruntusu = new System.Windows.Forms.Button();
            this.button1Kaydet = new System.Windows.Forms.Button();
            this.button1Sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(-171, -58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1600, 800);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1EkranGoruntusu
            // 
            this.button1EkranGoruntusu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1EkranGoruntusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1EkranGoruntusu.Location = new System.Drawing.Point(2, 2);
            this.button1EkranGoruntusu.Name = "button1EkranGoruntusu";
            this.button1EkranGoruntusu.Size = new System.Drawing.Size(106, 30);
            this.button1EkranGoruntusu.TabIndex = 1;
            this.button1EkranGoruntusu.Text = "Görüntüsü Al";
            this.button1EkranGoruntusu.UseVisualStyleBackColor = false;
            this.button1EkranGoruntusu.Click += new System.EventHandler(this.button1EkranGoruntusu_Click);
            // 
            // button1Kaydet
            // 
            this.button1Kaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1Kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1Kaydet.Location = new System.Drawing.Point(114, 2);
            this.button1Kaydet.Name = "button1Kaydet";
            this.button1Kaydet.Size = new System.Drawing.Size(67, 30);
            this.button1Kaydet.TabIndex = 2;
            this.button1Kaydet.Text = "Kaydet";
            this.button1Kaydet.UseVisualStyleBackColor = false;
            this.button1Kaydet.Click += new System.EventHandler(this.button1Kaydet_Click);
            // 
            // button1Sil
            // 
            this.button1Sil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1Sil.Location = new System.Drawing.Point(187, 2);
            this.button1Sil.Name = "button1Sil";
            this.button1Sil.Size = new System.Drawing.Size(67, 30);
            this.button1Sil.TabIndex = 3;
            this.button1Sil.Text = "Sil";
            this.button1Sil.UseVisualStyleBackColor = false;
            this.button1Sil.Click += new System.EventHandler(this.button1Sil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 33);
            this.Controls.Add(this.button1Sil);
            this.Controls.Add(this.button1Kaydet);
            this.Controls.Add(this.button1EkranGoruntusu);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ekran Görüntüsünü alma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1EkranGoruntusu;
        private System.Windows.Forms.Button button1Kaydet;
        private System.Windows.Forms.Button button1Sil;
    }
}

