namespace Kino
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.ValiFilm_cmbx = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Valikoht_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OstaPilet_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vali film";
            // 
            // ValiFilm_cmbx
            // 
            this.ValiFilm_cmbx.FormattingEnabled = true;
            this.ValiFilm_cmbx.Location = new System.Drawing.Point(179, 85);
            this.ValiFilm_cmbx.Name = "ValiFilm_cmbx";
            this.ValiFilm_cmbx.Size = new System.Drawing.Size(121, 21);
            this.ValiFilm_cmbx.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(330, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 160);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Valikoht_btn
            // 
            this.Valikoht_btn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Valikoht_btn.Location = new System.Drawing.Point(353, 304);
            this.Valikoht_btn.Name = "Valikoht_btn";
            this.Valikoht_btn.Size = new System.Drawing.Size(75, 23);
            this.Valikoht_btn.TabIndex = 3;
            this.Valikoht_btn.Text = "Vali koht";
            this.Valikoht_btn.UseVisualStyleBackColor = false;
            this.Valikoht_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // OstaPilet_btn
            // 
            this.OstaPilet_btn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.OstaPilet_btn.Location = new System.Drawing.Point(561, 78);
            this.OstaPilet_btn.Name = "OstaPilet_btn";
            this.OstaPilet_btn.Size = new System.Drawing.Size(75, 23);
            this.OstaPilet_btn.TabIndex = 6;
            this.OstaPilet_btn.Text = "Osta pilet";
            this.OstaPilet_btn.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(291, 268);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.OstaPilet_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Valikoht_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ValiFilm_cmbx);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ValiFilm_cmbx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Valikoht_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OstaPilet_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}