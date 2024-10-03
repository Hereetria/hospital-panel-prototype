namespace Hastane_Application
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.kyttc = new System.Windows.Forms.MaskedTextBox();
            this.kytsifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kyttel = new System.Windows.Forms.MaskedTextBox();
            this.kytsoyad = new System.Windows.Forms.TextBox();
            this.kytad = new System.Windows.Forms.TextBox();
            this.kytcinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kytbuton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kyttc
            // 
            this.kyttc.Location = new System.Drawing.Point(107, 98);
            this.kyttc.Name = "kyttc";
            this.kyttc.Size = new System.Drawing.Size(115, 31);
            this.kyttc.TabIndex = 3;
            this.kyttc.ValidatingType = typeof(int);
            // 
            // kytsifre
            // 
            this.kytsifre.Location = new System.Drawing.Point(106, 172);
            this.kytsifre.Name = "kytsifre";
            this.kytsifre.Size = new System.Drawing.Size(115, 31);
            this.kytsifre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tc No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tel No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ad:";
            // 
            // kyttel
            // 
            this.kyttel.Location = new System.Drawing.Point(106, 135);
            this.kyttel.Name = "kyttel";
            this.kyttel.Size = new System.Drawing.Size(116, 31);
            this.kyttel.TabIndex = 4;
            // 
            // kytsoyad
            // 
            this.kytsoyad.Location = new System.Drawing.Point(106, 59);
            this.kytsoyad.Name = "kytsoyad";
            this.kytsoyad.Size = new System.Drawing.Size(115, 31);
            this.kytsoyad.TabIndex = 2;
            // 
            // kytad
            // 
            this.kytad.Location = new System.Drawing.Point(107, 22);
            this.kytad.Name = "kytad";
            this.kytad.Size = new System.Drawing.Size(115, 31);
            this.kytad.TabIndex = 1;
            // 
            // kytcinsiyet
            // 
            this.kytcinsiyet.FormattingEnabled = true;
            this.kytcinsiyet.Location = new System.Drawing.Point(106, 209);
            this.kytcinsiyet.Name = "kytcinsiyet";
            this.kytcinsiyet.Size = new System.Drawing.Size(116, 31);
            this.kytcinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cinsiyet:";
            // 
            // kytbuton
            // 
            this.kytbuton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kytbuton.Location = new System.Drawing.Point(106, 246);
            this.kytbuton.Name = "kytbuton";
            this.kytbuton.Size = new System.Drawing.Size(116, 33);
            this.kytbuton.TabIndex = 12;
            this.kytbuton.Text = "Kayit Yap";
            this.kytbuton.UseVisualStyleBackColor = false;
            this.kytbuton.Click += new System.EventHandler(this.kytbuton_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.kytbuton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(286, 327);
            this.Controls.Add(this.kytbuton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.kytcinsiyet);
            this.Controls.Add(this.kytad);
            this.Controls.Add(this.kytsoyad);
            this.Controls.Add(this.kyttel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kytsifre);
            this.Controls.Add(this.kyttc);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox kyttc;
        private System.Windows.Forms.TextBox kytsifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox kyttel;
        private System.Windows.Forms.TextBox kytsoyad;
        private System.Windows.Forms.TextBox kytad;
        private System.Windows.Forms.ComboBox kytcinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button kytbuton;
    }
}