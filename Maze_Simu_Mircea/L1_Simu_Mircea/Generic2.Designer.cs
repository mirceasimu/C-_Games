namespace L1_Simu_Mircea
{
    partial class Generic2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iesire = new System.Windows.Forms.Button();
            this.incepe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::L1_Simu_Mircea.Properties.Resources.cooltext366766520287146;
            this.pictureBox1.Location = new System.Drawing.Point(65, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // iesire
            // 
            this.iesire.BackColor = System.Drawing.Color.Red;
            this.iesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iesire.Location = new System.Drawing.Point(113, 256);
            this.iesire.Name = "iesire";
            this.iesire.Size = new System.Drawing.Size(219, 115);
            this.iesire.TabIndex = 29;
            this.iesire.Text = "Ieșire";
            this.iesire.UseVisualStyleBackColor = false;
            this.iesire.Click += new System.EventHandler(this.iesire_Click);
            // 
            // incepe
            // 
            this.incepe.BackColor = System.Drawing.Color.Red;
            this.incepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incepe.Location = new System.Drawing.Point(470, 256);
            this.incepe.Name = "incepe";
            this.incepe.Size = new System.Drawing.Size(219, 115);
            this.incepe.TabIndex = 30;
            this.incepe.Text = "Începe";
            this.incepe.UseVisualStyleBackColor = false;
            this.incepe.Click += new System.EventHandler(this.incepe_Click);
            // 
            // Generic2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::L1_Simu_Mircea.Properties.Resources.generic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.incepe);
            this.Controls.Add(this.iesire);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Generic2";
            this.Text = "Generic2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button iesire;
        private System.Windows.Forms.Button incepe;
    }
}