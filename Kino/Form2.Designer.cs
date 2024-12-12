namespace Kino
{
    partial class Form2
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
            this.LisaFilm_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.KustutaFilm_btn = new System.Windows.Forms.Button();
            this.Aasta_txb = new System.Windows.Forms.TextBox();
            this.FilmiNimi_txb = new System.Windows.Forms.TextBox();
            this.nimi_lb = new System.Windows.Forms.Label();
            this.aasta_lb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LisaFilm_btn
            // 
            this.LisaFilm_btn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.LisaFilm_btn.Location = new System.Drawing.Point(683, 215);
            this.LisaFilm_btn.Name = "LisaFilm_btn";
            this.LisaFilm_btn.Size = new System.Drawing.Size(75, 23);
            this.LisaFilm_btn.TabIndex = 0;
            this.LisaFilm_btn.Text = "Lisa film";
            this.LisaFilm_btn.UseVisualStyleBackColor = false;
            this.LisaFilm_btn.Click += new System.EventHandler(this.LisaFilm_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(323, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 168);
            this.dataGridView1.TabIndex = 1;
            // 
            // KustutaFilm_btn
            // 
            this.KustutaFilm_btn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.KustutaFilm_btn.Location = new System.Drawing.Point(683, 254);
            this.KustutaFilm_btn.Name = "KustutaFilm_btn";
            this.KustutaFilm_btn.Size = new System.Drawing.Size(75, 23);
            this.KustutaFilm_btn.TabIndex = 2;
            this.KustutaFilm_btn.Text = "Kustuta";
            this.KustutaFilm_btn.UseVisualStyleBackColor = false;
            // 
            // Aasta_txb
            // 
            this.Aasta_txb.Location = new System.Drawing.Point(489, 173);
            this.Aasta_txb.Name = "Aasta_txb";
            this.Aasta_txb.Size = new System.Drawing.Size(100, 20);
            this.Aasta_txb.TabIndex = 4;
            // 
            // FilmiNimi_txb
            // 
            this.FilmiNimi_txb.Location = new System.Drawing.Point(383, 173);
            this.FilmiNimi_txb.Name = "FilmiNimi_txb";
            this.FilmiNimi_txb.Size = new System.Drawing.Size(100, 20);
            this.FilmiNimi_txb.TabIndex = 5;
            // 
            // nimi_lb
            // 
            this.nimi_lb.AutoSize = true;
            this.nimi_lb.ForeColor = System.Drawing.Color.Transparent;
            this.nimi_lb.Location = new System.Drawing.Point(380, 157);
            this.nimi_lb.Name = "nimi_lb";
            this.nimi_lb.Size = new System.Drawing.Size(48, 13);
            this.nimi_lb.TabIndex = 6;
            this.nimi_lb.Text = "Filmi nimi";
            // 
            // aasta_lb
            // 
            this.aasta_lb.AutoSize = true;
            this.aasta_lb.ForeColor = System.Drawing.Color.Transparent;
            this.aasta_lb.Location = new System.Drawing.Point(486, 157);
            this.aasta_lb.Name = "aasta_lb";
            this.aasta_lb.Size = new System.Drawing.Size(34, 13);
            this.aasta_lb.TabIndex = 7;
            this.aasta_lb.Text = "Aasta";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(60, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 294);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.aasta_lb);
            this.Controls.Add(this.nimi_lb);
            this.Controls.Add(this.FilmiNimi_txb);
            this.Controls.Add(this.Aasta_txb);
            this.Controls.Add(this.KustutaFilm_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.LisaFilm_btn);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form2";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LisaFilm_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button KustutaFilm_btn;
        private System.Windows.Forms.TextBox Aasta_txb;
        private System.Windows.Forms.TextBox FilmiNimi_txb;
        private System.Windows.Forms.Label nimi_lb;
        private System.Windows.Forms.Label aasta_lb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}