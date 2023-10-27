namespace R_Simu_Mircea
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
            this.components = new System.ComponentModel.Container();
            this.racheta = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.a = new System.Windows.Forms.PictureBox();
            this.a2 = new System.Windows.Forms.PictureBox();
            this.a3 = new System.Windows.Forms.PictureBox();
            this.vieti_ramase = new System.Windows.Forms.Label();
            this.lbl_vieti = new System.Windows.Forms.Label();
            this.laser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.racheta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laser)).BeginInit();
            this.SuspendLayout();
            // 
            // racheta
            // 
            this.racheta.BackColor = System.Drawing.Color.Transparent;
            this.racheta.Image = global::R_Simu_Mircea.Properties.Resources._486c34cf5b3b4badd52bc427dbeb44a1_rocket_cartoon_by_vexels;
            this.racheta.Location = new System.Drawing.Point(204, 431);
            this.racheta.Name = "racheta";
            this.racheta.Size = new System.Drawing.Size(77, 76);
            this.racheta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racheta.TabIndex = 0;
            this.racheta.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.Transparent;
            this.a.Image = global::R_Simu_Mircea.Properties.Resources.asteroid2;
            this.a.Location = new System.Drawing.Point(213, 102);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(16, 45);
            this.a.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.a.TabIndex = 1;
            this.a.TabStop = false;
            this.a.Tag = "asteroid";
            // 
            // a2
            // 
            this.a2.BackColor = System.Drawing.Color.Transparent;
            this.a2.Image = global::R_Simu_Mircea.Properties.Resources.asteroid2;
            this.a2.Location = new System.Drawing.Point(380, 22);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(92, 36);
            this.a2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.a2.TabIndex = 2;
            this.a2.TabStop = false;
            this.a2.Tag = "asteroid";
            // 
            // a3
            // 
            this.a3.BackColor = System.Drawing.Color.Transparent;
            this.a3.Image = global::R_Simu_Mircea.Properties.Resources.asteroid2;
            this.a3.Location = new System.Drawing.Point(39, 182);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(82, 87);
            this.a3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.a3.TabIndex = 3;
            this.a3.TabStop = false;
            this.a3.Tag = "asteroid";
            // 
            // vieti_ramase
            // 
            this.vieti_ramase.AutoSize = true;
            this.vieti_ramase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vieti_ramase.Location = new System.Drawing.Point(12, 509);
            this.vieti_ramase.Name = "vieti_ramase";
            this.vieti_ramase.Size = new System.Drawing.Size(86, 16);
            this.vieti_ramase.TabIndex = 4;
            this.vieti_ramase.Text = "Vieti ramase:";
            // 
            // lbl_vieti
            // 
            this.lbl_vieti.AutoSize = true;
            this.lbl_vieti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vieti.Location = new System.Drawing.Point(97, 509);
            this.lbl_vieti.Name = "lbl_vieti";
            this.lbl_vieti.Size = new System.Drawing.Size(15, 16);
            this.lbl_vieti.TabIndex = 5;
            this.lbl_vieti.Text = "5";
            // 
            // laser
            // 
            this.laser.BackColor = System.Drawing.Color.Red;
            this.laser.Location = new System.Drawing.Point(-2, -11);
            this.laser.Name = "laser";
            this.laser.Size = new System.Drawing.Size(10, 17);
            this.laser.TabIndex = 6;
            this.laser.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::R_Simu_Mircea.Properties.Resources.outer_space;
            this.ClientSize = new System.Drawing.Size(484, 534);
            this.Controls.Add(this.laser);
            this.Controls.Add(this.lbl_vieti);
            this.Controls.Add(this.vieti_ramase);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a);
            this.Controls.Add(this.racheta);
            this.Name = "Form1";
            this.Text = "Racheta";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.racheta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox racheta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox a;
        private System.Windows.Forms.PictureBox a2;
        private System.Windows.Forms.PictureBox a3;
        private System.Windows.Forms.Label vieti_ramase;
        private System.Windows.Forms.Label lbl_vieti;
        private System.Windows.Forms.PictureBox laser;
    }
}

