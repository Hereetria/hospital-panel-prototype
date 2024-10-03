namespace Hastane_Application
{
    partial class FrmDoktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDuzenle));
            this.dbdad = new System.Windows.Forms.TextBox();
            this.dbdsoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dbdtc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dbdsifre = new System.Windows.Forms.TextBox();
            this.dbdbrans = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dbdguncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dbdad
            // 
            this.dbdad.Location = new System.Drawing.Point(110, 26);
            this.dbdad.Name = "dbdad";
            this.dbdad.Size = new System.Drawing.Size(115, 31);
            this.dbdad.TabIndex = 28;
            // 
            // dbdsoyad
            // 
            this.dbdsoyad.Location = new System.Drawing.Point(109, 63);
            this.dbdsoyad.Name = "dbdsoyad";
            this.dbdsoyad.Size = new System.Drawing.Size(115, 31);
            this.dbdsoyad.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tc No:";
            // 
            // dbdtc
            // 
            this.dbdtc.Location = new System.Drawing.Point(110, 102);
            this.dbdtc.Mask = "00000000000";
            this.dbdtc.Name = "dbdtc";
            this.dbdtc.Size = new System.Drawing.Size(115, 31);
            this.dbdtc.TabIndex = 23;
            this.dbdtc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Sifre:";
            // 
            // dbdsifre
            // 
            this.dbdsifre.Location = new System.Drawing.Point(109, 180);
            this.dbdsifre.Name = "dbdsifre";
            this.dbdsifre.Size = new System.Drawing.Size(115, 31);
            this.dbdsifre.TabIndex = 29;
            // 
            // dbdbrans
            // 
            this.dbdbrans.FormattingEnabled = true;
            this.dbdbrans.Location = new System.Drawing.Point(110, 139);
            this.dbdbrans.Name = "dbdbrans";
            this.dbdbrans.Size = new System.Drawing.Size(114, 31);
            this.dbdbrans.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Branş:";
            // 
            // dbdguncelle
            // 
            this.dbdguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dbdguncelle.Location = new System.Drawing.Point(110, 226);
            this.dbdguncelle.Name = "dbdguncelle";
            this.dbdguncelle.Size = new System.Drawing.Size(115, 37);
            this.dbdguncelle.TabIndex = 33;
            this.dbdguncelle.Text = "Güncelle";
            this.dbdguncelle.UseVisualStyleBackColor = false;
            this.dbdguncelle.Click += new System.EventHandler(this.dbdguncelle_Click);
            // 
            // FrmDoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(264, 275);
            this.Controls.Add(this.dbdguncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dbdbrans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dbdsifre);
            this.Controls.Add(this.dbdad);
            this.Controls.Add(this.dbdsoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbdtc);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorBilgiDuzenle";
            this.Text = "FrmDoktorBilgiDuzenle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dbdad;
        private System.Windows.Forms.TextBox dbdsoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox dbdtc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dbdsifre;
        private System.Windows.Forms.ComboBox dbdbrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dbdguncelle;
    }
}