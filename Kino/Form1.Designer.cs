namespace Kino
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
            this.Kava_btn = new System.Windows.Forms.Button();
            this.OstaPilet_btn = new System.Windows.Forms.Button();
            this.LogiSisse_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Kasutajanimi_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Kava_btn
            // 
            this.Kava_btn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Kava_btn.Location = new System.Drawing.Point(286, 298);
            this.Kava_btn.Name = "Kava_btn";
            this.Kava_btn.Size = new System.Drawing.Size(75, 23);
            this.Kava_btn.TabIndex = 0;
            this.Kava_btn.Text = "Kava";
            this.Kava_btn.UseVisualStyleBackColor = false;
            this.Kava_btn.Click += new System.EventHandler(this.Kava_btn_Click);
            // 
            // OstaPilet_btn
            // 
            this.OstaPilet_btn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.OstaPilet_btn.Location = new System.Drawing.Point(386, 298);
            this.OstaPilet_btn.Name = "OstaPilet_btn";
            this.OstaPilet_btn.Size = new System.Drawing.Size(75, 23);
            this.OstaPilet_btn.TabIndex = 1;
            this.OstaPilet_btn.Text = "Osta pilet";
            this.OstaPilet_btn.UseVisualStyleBackColor = false;
            this.OstaPilet_btn.Click += new System.EventHandler(this.OstaPilet_btn_Click);
            // 
            // LogiSisse_btn
            // 
            this.LogiSisse_btn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.LogiSisse_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogiSisse_btn.Location = new System.Drawing.Point(654, 32);
            this.LogiSisse_btn.Name = "LogiSisse_btn";
            this.LogiSisse_btn.Size = new System.Drawing.Size(75, 23);
            this.LogiSisse_btn.TabIndex = 2;
            this.LogiSisse_btn.Text = "Logi sisse";
            this.LogiSisse_btn.UseVisualStyleBackColor = false;
            this.LogiSisse_btn.Click += new System.EventHandler(this.LogiSisse_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(286, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 239);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Kasutajanimi_lbl
            // 
            this.Kasutajanimi_lbl.AutoSize = true;
            this.Kasutajanimi_lbl.Location = new System.Drawing.Point(583, 37);
            this.Kasutajanimi_lbl.Name = "Kasutajanimi_lbl";
            this.Kasutajanimi_lbl.Size = new System.Drawing.Size(65, 13);
            this.Kasutajanimi_lbl.TabIndex = 4;
            this.Kasutajanimi_lbl.Text = "kasutajanimi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Kasutajanimi_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LogiSisse_btn);
            this.Controls.Add(this.OstaPilet_btn);
            this.Controls.Add(this.Kava_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Kava_btn;
        private System.Windows.Forms.Button OstaPilet_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Kasutajanimi_lbl;
        public System.Windows.Forms.Button LogiSisse_btn;
    }
}

