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
            this.ai_pierdut = new System.Windows.Forms.PictureBox();
            this.iesire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.puncte = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ai_castigat = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lasere = new System.Windows.Forms.Label();
            this.laser2 = new System.Windows.Forms.PictureBox();
            this.laser3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.racheta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai_pierdut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai_castigat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laser3)).BeginInit();
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
            this.a.Location = new System.Drawing.Point(192, -11);
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
            this.a2.Location = new System.Drawing.Point(395, 12);
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
            this.laser.Location = new System.Drawing.Point(-10, 370);
            this.laser.Name = "laser";
            this.laser.Size = new System.Drawing.Size(10, 33);
            this.laser.TabIndex = 6;
            this.laser.TabStop = false;
            this.laser.Visible = false;
            // 
            // ai_pierdut
            // 
            this.ai_pierdut.Image = global::R_Simu_Mircea.Properties.Resources.cooltext366769381640059;
            this.ai_pierdut.Location = new System.Drawing.Point(-2, 182);
            this.ai_pierdut.Name = "ai_pierdut";
            this.ai_pierdut.Size = new System.Drawing.Size(489, 137);
            this.ai_pierdut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ai_pierdut.TabIndex = 7;
            this.ai_pierdut.TabStop = false;
            this.ai_pierdut.Visible = false;
            // 
            // iesire
            // 
            this.iesire.BackColor = System.Drawing.Color.Red;
            this.iesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iesire.Location = new System.Drawing.Point(301, 353);
            this.iesire.Name = "iesire";
            this.iesire.Size = new System.Drawing.Size(153, 77);
            this.iesire.TabIndex = 8;
            this.iesire.Text = "Ieșire";
            this.iesire.UseVisualStyleBackColor = false;
            this.iesire.Visible = false;
            this.iesire.Click += new System.EventHandler(this.iesire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Punctaj:   ";
            // 
            // puncte
            // 
            this.puncte.AutoSize = true;
            this.puncte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puncte.Location = new System.Drawing.Point(426, 509);
            this.puncte.Name = "puncte";
            this.puncte.Size = new System.Drawing.Size(18, 16);
            this.puncte.TabIndex = 10;
            this.puncte.Text = "0 ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-2, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ieșire";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // ai_castigat
            // 
            this.ai_castigat.Image = global::R_Simu_Mircea.Properties.Resources.cooltext366770368074755;
            this.ai_castigat.Location = new System.Drawing.Point(-2, 208);
            this.ai_castigat.Name = "ai_castigat";
            this.ai_castigat.Size = new System.Drawing.Size(489, 98);
            this.ai_castigat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ai_castigat.TabIndex = 12;
            this.ai_castigat.TabStop = false;
            this.ai_castigat.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "/100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lasere ramase:";
            // 
            // lasere
            // 
            this.lasere.AutoSize = true;
            this.lasere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lasere.Location = new System.Drawing.Point(111, 491);
            this.lasere.Name = "lasere";
            this.lasere.Size = new System.Drawing.Size(15, 16);
            this.lasere.TabIndex = 15;
            this.lasere.Text = "3";
            // 
            // laser2
            // 
            this.laser2.BackColor = System.Drawing.Color.Red;
            this.laser2.Location = new System.Drawing.Point(-10, 394);
            this.laser2.Name = "laser2";
            this.laser2.Size = new System.Drawing.Size(10, 31);
            this.laser2.TabIndex = 16;
            this.laser2.TabStop = false;
            this.laser2.Visible = false;
            // 
            // laser3
            // 
            this.laser3.BackColor = System.Drawing.Color.Red;
            this.laser3.Location = new System.Drawing.Point(-10, 380);
            this.laser3.Name = "laser3";
            this.laser3.Size = new System.Drawing.Size(10, 31);
            this.laser3.TabIndex = 17;
            this.laser3.TabStop = false;
            this.laser3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::R_Simu_Mircea.Properties.Resources.outer_space;
            this.ClientSize = new System.Drawing.Size(484, 534);
            this.Controls.Add(this.laser3);
            this.Controls.Add(this.laser2);
            this.Controls.Add(this.lasere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ai_castigat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.puncte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iesire);
            this.Controls.Add(this.ai_pierdut);
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
            ((System.ComponentModel.ISupportInitialize)(this.ai_pierdut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ai_castigat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laser3)).EndInit();
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
        private System.Windows.Forms.PictureBox ai_pierdut;
        private System.Windows.Forms.Button iesire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label puncte;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox ai_castigat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lasere;
        private System.Windows.Forms.PictureBox laser2;
        private System.Windows.Forms.PictureBox laser3;
    }
}

