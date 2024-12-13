namespace Kino
{
    partial class Form3
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
            System.Windows.Forms.Button LogiSisse_btn;
            this.LoginKasutajanimi_lbl = new System.Windows.Forms.TextBox();
            this.Loginsalasona_lbl = new System.Windows.Forms.TextBox();
            this.LoginKasutajanimi_txb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            LogiSisse_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogiSisse_btn
            // 
            LogiSisse_btn.BackColor = System.Drawing.Color.PaleVioletRed;
            LogiSisse_btn.Location = new System.Drawing.Point(390, 267);
            LogiSisse_btn.Name = "LogiSisse_btn";
            LogiSisse_btn.Size = new System.Drawing.Size(75, 24);
            LogiSisse_btn.TabIndex = 2;
            LogiSisse_btn.Text = "logi sisse";
            LogiSisse_btn.UseVisualStyleBackColor = false;
            LogiSisse_btn.Click += new System.EventHandler(this.LogiSisse_btn_Click);
            // 
            // LoginKasutajanimi_lbl
            // 
            this.LoginKasutajanimi_lbl.Location = new System.Drawing.Point(375, 161);
            this.LoginKasutajanimi_lbl.Name = "LoginKasutajanimi_lbl";
            this.LoginKasutajanimi_lbl.Size = new System.Drawing.Size(100, 20);
            this.LoginKasutajanimi_lbl.TabIndex = 0;
            // 
            // Loginsalasona_lbl
            // 
            this.Loginsalasona_lbl.Location = new System.Drawing.Point(375, 217);
            this.Loginsalasona_lbl.Name = "Loginsalasona_lbl";
            this.Loginsalasona_lbl.Size = new System.Drawing.Size(100, 20);
            this.Loginsalasona_lbl.TabIndex = 1;
            // 
            // LoginKasutajanimi_txb
            // 
            this.LoginKasutajanimi_txb.AutoSize = true;
            this.LoginKasutajanimi_txb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginKasutajanimi_txb.Location = new System.Drawing.Point(306, 161);
            this.LoginKasutajanimi_txb.Name = "LoginKasutajanimi_txb";
            this.LoginKasutajanimi_txb.Size = new System.Drawing.Size(66, 13);
            this.LoginKasutajanimi_txb.TabIndex = 3;
            this.LoginKasutajanimi_txb.Text = "Kasutajanimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(320, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "salasõna";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginKasutajanimi_txb);
            this.Controls.Add(LogiSisse_btn);
            this.Controls.Add(this.Loginsalasona_lbl);
            this.Controls.Add(this.LoginKasutajanimi_lbl);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginKasutajanimi_lbl;
        private System.Windows.Forms.TextBox Loginsalasona_lbl;
        private System.Windows.Forms.Label LoginKasutajanimi_txb;
        private System.Windows.Forms.Label label2;
    }
}