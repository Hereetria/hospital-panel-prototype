namespace Hastane_Application
{
    partial class FrmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDuzenle));
            this.kytbuton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.kytcinsiyet = new System.Windows.Forms.ComboBox();
            this.kytad = new System.Windows.Forms.TextBox();
            this.kytsoyad = new System.Windows.Forms.TextBox();
            this.kyttel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kytsifre = new System.Windows.Forms.TextBox();
            this.kyttc = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // kytbuton
            // 
            this.kytbuton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kytbuton.Location = new System.Drawing.Point(115, 250);
            this.kytbuton.Name = "kytbuton";
            this.kytbuton.Size = new System.Drawing.Size(116, 33);
            this.kytbuton.TabIndex = 25;
            this.kytbuton.Text = "Güncelle";
            this.kytbuton.UseVisualStyleBackColor = false;
            this.kytbuton.Click += new System.EventHandler(this.kytbuton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cinsiyet:";
            // 
            // kytcinsiyet
            // 
            this.kytcinsiyet.FormattingEnabled = true;
            this.kytcinsiyet.Location = new System.Drawing.Point(115, 213);
            this.kytcinsiyet.Name = "kytcinsiyet";
            this.kytcinsiyet.Size = new System.Drawing.Size(116, 31);
            this.kytcinsiyet.TabIndex = 6;
            // 
            // kytad
            // 
            this.kytad.Location = new System.Drawing.Point(116, 26);
            this.kytad.Name = "kytad";
            this.kytad.Size = new System.Drawing.Size(115, 31);
            this.kytad.TabIndex = 1;
            // 
            // kytsoyad
            // 
            this.kytsoyad.Location = new System.Drawing.Point(115, 63);
            this.kytsoyad.Name = "kytsoyad";
            this.kytsoyad.Size = new System.Drawing.Size(115, 31);
            this.kytsoyad.TabIndex = 2;
            // 
            // kyttel
            // 
            this.kyttel.Location = new System.Drawing.Point(115, 139);
            this.kyttel.Mask = "(999) 000-0000";
            this.kyttel.Name = "kyttel";
            this.kyttel.Size = new System.Drawing.Size(116, 31);
            this.kyttel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 23);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tel No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tc No:";
            // 
            // kytsifre
            // 
            this.kytsifre.Location = new System.Drawing.Point(115, 176);
            this.kytsifre.Name = "kytsifre";
            this.kytsifre.Size = new System.Drawing.Size(115, 31);
            this.kytsifre.TabIndex = 5;
            // 
            // kyttc
            // 
            this.kyttc.Location = new System.Drawing.Point(116, 102);
            this.kyttc.Name = "kyttc";
            this.kyttc.Size = new System.Drawing.Size(115, 31);
            this.kyttc.TabIndex = 3;
            this.kyttc.ValidatingType = typeof(int);
            // 
            // FrmBilgiDuzenle
            // 
            this.AcceptButton = this.kytbuton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(301, 326);
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
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmBilgiDuzenle";
            this.Text = "Bilgi Güncelle";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kytbuton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox kytcinsiyet;
        private System.Windows.Forms.TextBox kytad;
        private System.Windows.Forms.TextBox kytsoyad;
        private System.Windows.Forms.MaskedTextBox kyttel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kytsifre;
        private System.Windows.Forms.MaskedTextBox kyttc;
    }
}