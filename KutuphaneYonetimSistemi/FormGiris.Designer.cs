namespace KutuphaneYonetimSistemi
{
    partial class FormGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxKulAd = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxKulAd
            // 
            this.textBoxKulAd.Location = new System.Drawing.Point(307, 147);
            this.textBoxKulAd.Name = "textBoxKulAd";
            this.textBoxKulAd.Size = new System.Drawing.Size(184, 23);
            this.textBoxKulAd.TabIndex = 0;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(307, 238);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(184, 23);
            this.textBoxSifre.TabIndex = 1;
            this.textBoxSifre.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(349, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(101, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı  Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(191, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKulAd);
            this.Name = "FormGiris";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxKulAd;
        private TextBox textBoxSifre;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}