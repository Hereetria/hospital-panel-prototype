namespace Hastane_Application
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddtc = new System.Windows.Forms.Label();
            this.ddadsoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ddetay = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ddrandevuliste = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ddcikis = new System.Windows.Forms.Button();
            this.ddduyurular = new System.Windows.Forms.Button();
            this.ddduzenle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddrandevuliste)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ddtc);
            this.groupBox1.Controls.Add(this.ddadsoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(308, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ddtc
            // 
            this.ddtc.AutoSize = true;
            this.ddtc.Location = new System.Drawing.Point(133, 69);
            this.ddtc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ddtc.Name = "ddtc";
            this.ddtc.Size = new System.Drawing.Size(100, 23);
            this.ddtc.TabIndex = 10;
            this.ddtc.Text = "000000000";
            // 
            // ddadsoyad
            // 
            this.ddadsoyad.AutoSize = true;
            this.ddadsoyad.Location = new System.Drawing.Point(133, 127);
            this.ddadsoyad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ddadsoyad.Name = "ddadsoyad";
            this.ddadsoyad.Size = new System.Drawing.Size(76, 23);
            this.ddadsoyad.TabIndex = 9;
            this.ddadsoyad.Text = "Null Null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tc No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ddetay);
            this.groupBox2.Location = new System.Drawing.Point(14, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 188);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // ddetay
            // 
            this.ddetay.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.ddetay.Location = new System.Drawing.Point(9, 30);
            this.ddetay.Name = "ddetay";
            this.ddetay.Size = new System.Drawing.Size(296, 152);
            this.ddetay.TabIndex = 0;
            this.ddetay.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ddrandevuliste);
            this.groupBox3.Location = new System.Drawing.Point(341, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(477, 437);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
            // 
            // ddrandevuliste
            // 
            this.ddrandevuliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ddrandevuliste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddrandevuliste.Location = new System.Drawing.Point(3, 27);
            this.ddrandevuliste.Name = "ddrandevuliste";
            this.ddrandevuliste.Size = new System.Drawing.Size(471, 407);
            this.ddrandevuliste.TabIndex = 0;
            this.ddrandevuliste.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ddrandevuliste_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ddcikis);
            this.groupBox4.Controls.Add(this.ddduyurular);
            this.groupBox4.Controls.Add(this.ddduzenle);
            this.groupBox4.Location = new System.Drawing.Point(14, 412);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 100);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // ddcikis
            // 
            this.ddcikis.Location = new System.Drawing.Point(9, 67);
            this.ddcikis.Name = "ddcikis";
            this.ddcikis.Size = new System.Drawing.Size(293, 30);
            this.ddcikis.TabIndex = 2;
            this.ddcikis.Text = "Çıkış";
            this.ddcikis.UseVisualStyleBackColor = true;
            this.ddcikis.Click += new System.EventHandler(this.ddcikis_Click);
            // 
            // ddduyurular
            // 
            this.ddduyurular.Location = new System.Drawing.Point(166, 31);
            this.ddduyurular.Name = "ddduyurular";
            this.ddduyurular.Size = new System.Drawing.Size(136, 30);
            this.ddduyurular.TabIndex = 1;
            this.ddduyurular.Text = "Duyurular";
            this.ddduyurular.UseVisualStyleBackColor = true;
            this.ddduyurular.Click += new System.EventHandler(this.ddduyurular_Click);
            // 
            // ddduzenle
            // 
            this.ddduzenle.Location = new System.Drawing.Point(9, 31);
            this.ddduzenle.Name = "ddduzenle";
            this.ddduzenle.Size = new System.Drawing.Size(136, 30);
            this.ddduzenle.TabIndex = 0;
            this.ddduzenle.Text = "Bilgi Düzenle";
            this.ddduzenle.UseVisualStyleBackColor = true;
            this.ddduzenle.Click += new System.EventHandler(this.ddduzenle_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(830, 524);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ddrandevuliste)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ddtc;
        private System.Windows.Forms.Label ddadsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView ddrandevuliste;
        private System.Windows.Forms.RichTextBox ddetay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ddcikis;
        private System.Windows.Forms.Button ddduyurular;
        private System.Windows.Forms.Button ddduzenle;
    }
}