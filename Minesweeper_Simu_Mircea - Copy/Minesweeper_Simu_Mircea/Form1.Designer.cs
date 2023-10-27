namespace Minesweeper_Simu_Mircea
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
            this.start_gri = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.start_verde = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.start_gri)).BeginInit();
            this.SuspendLayout();
            // 
            // start_gri
            // 
            this.start_gri.Image = global::Minesweeper_Simu_Mircea.Properties.Resources.start_minesweeper_gri;
            this.start_gri.Location = new System.Drawing.Point(204, 8);
            this.start_gri.Name = "start_gri";
            this.start_gri.Size = new System.Drawing.Size(100, 31);
            this.start_gri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.start_gri.TabIndex = 1;
            this.start_gri.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(99, 56);
            this.listBox1.TabIndex = 2;
            // 
            // start_verde
            // 
            this.start_verde.BackgroundImage = global::Minesweeper_Simu_Mircea.Properties.Resources.start_minesweeper_verde;
            this.start_verde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start_verde.Location = new System.Drawing.Point(204, 8);
            this.start_verde.Name = "start_verde";
            this.start_verde.Size = new System.Drawing.Size(100, 31);
            this.start_verde.TabIndex = 3;
            this.start_verde.UseVisualStyleBackColor = true;
            this.start_verde.Click += new System.EventHandler(this.start_verde_Click_1);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(12, 12);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 4;
            this.show.Text = "button1";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Minesweeper_Simu_Mircea.Properties.Resources.minesweeper_format;
            this.ClientSize = new System.Drawing.Size(496, 314);
            this.Controls.Add(this.show);
            this.Controls.Add(this.start_verde);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.start_gri);
            this.Name = "Form1";
            this.Text = "Minesweeper";
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.start_gri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox start_gri;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button start_verde;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Timer timer1;
    }
}

