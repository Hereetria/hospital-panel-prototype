namespace Hastane_Application
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sdsektc = new System.Windows.Forms.Label();
            this.sdsekadsoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sdolustur = new System.Windows.Forms.Button();
            this.sdduyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sdkaydet = new System.Windows.Forms.Button();
            this.sddurum = new System.Windows.Forms.CheckBox();
            this.sdtc = new System.Windows.Forms.MaskedTextBox();
            this.sddoktor = new System.Windows.Forms.ComboBox();
            this.sdbrans = new System.Windows.Forms.ComboBox();
            this.sdsaat = new System.Windows.Forms.MaskedTextBox();
            this.sdtarih = new System.Windows.Forms.MaskedTextBox();
            this.sdid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.sddocpanel = new System.Windows.Forms.Button();
            this.sdbranspanel = new System.Windows.Forms.Button();
            this.sdrandevuliste = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sdsektc);
            this.groupBox1.Controls.Add(this.sdsekadsoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.s);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // sdsektc
            // 
            this.sdsektc.AutoSize = true;
            this.sdsektc.Location = new System.Drawing.Point(115, 46);
            this.sdsektc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.sdsektc.Name = "sdsektc";
            this.sdsektc.Size = new System.Drawing.Size(100, 23);
            this.sdsektc.TabIndex = 14;
            this.sdsektc.Text = "000000000";
            // 
            // sdsekadsoyad
            // 
            this.sdsekadsoyad.AutoSize = true;
            this.sdsekadsoyad.Location = new System.Drawing.Point(115, 82);
            this.sdsekadsoyad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.sdsekadsoyad.Name = "sdsekadsoyad";
            this.sdsekadsoyad.Size = new System.Drawing.Size(76, 23);
            this.sdsekadsoyad.TabIndex = 13;
            this.sdsekadsoyad.Text = "Null Null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ad Soyad:";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(28, 46);
            this.s.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(60, 23);
            this.s.TabIndex = 11;
            this.s.Text = "Tc No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sdolustur);
            this.groupBox2.Controls.Add(this.sdduyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // sdolustur
            // 
            this.sdolustur.Location = new System.Drawing.Point(6, 191);
            this.sdolustur.Name = "sdolustur";
            this.sdolustur.Size = new System.Drawing.Size(242, 34);
            this.sdolustur.TabIndex = 1;
            this.sdolustur.Text = "Oluştur";
            this.sdolustur.UseVisualStyleBackColor = true;
            this.sdolustur.Click += new System.EventHandler(this.sdolustur_Click);
            // 
            // sdduyuru
            // 
            this.sdduyuru.Location = new System.Drawing.Point(6, 30);
            this.sdduyuru.Name = "sdduyuru";
            this.sdduyuru.Size = new System.Drawing.Size(242, 155);
            this.sdduyuru.TabIndex = 0;
            this.sdduyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sdkaydet);
            this.groupBox3.Controls.Add(this.sddurum);
            this.groupBox3.Controls.Add(this.sdtc);
            this.groupBox3.Controls.Add(this.sddoktor);
            this.groupBox3.Controls.Add(this.sdbrans);
            this.groupBox3.Controls.Add(this.sdsaat);
            this.groupBox3.Controls.Add(this.sdtarih);
            this.groupBox3.Controls.Add(this.sdid);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(266, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 374);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // sdkaydet
            // 
            this.sdkaydet.Location = new System.Drawing.Point(84, 303);
            this.sdkaydet.Name = "sdkaydet";
            this.sdkaydet.Size = new System.Drawing.Size(131, 36);
            this.sdkaydet.TabIndex = 15;
            this.sdkaydet.Text = "Kaydet";
            this.sdkaydet.UseVisualStyleBackColor = true;
            this.sdkaydet.Click += new System.EventHandler(this.sdkaydet_Click);
            // 
            // sddurum
            // 
            this.sddurum.AutoSize = true;
            this.sddurum.Location = new System.Drawing.Point(84, 270);
            this.sddurum.Name = "sddurum";
            this.sddurum.Size = new System.Drawing.Size(84, 27);
            this.sddurum.TabIndex = 14;
            this.sddurum.Text = "Durum";
            this.sddurum.UseVisualStyleBackColor = true;
            // 
            // sdtc
            // 
            this.sdtc.Location = new System.Drawing.Point(83, 232);
            this.sdtc.Mask = "00000000000";
            this.sdtc.Name = "sdtc";
            this.sdtc.Size = new System.Drawing.Size(110, 31);
            this.sdtc.TabIndex = 13;
            this.sdtc.ValidatingType = typeof(int);
            // 
            // sddoktor
            // 
            this.sddoktor.FormattingEnabled = true;
            this.sddoktor.Location = new System.Drawing.Point(84, 190);
            this.sddoktor.Name = "sddoktor";
            this.sddoktor.Size = new System.Drawing.Size(110, 31);
            this.sddoktor.TabIndex = 12;
            // 
            // sdbrans
            // 
            this.sdbrans.FormattingEnabled = true;
            this.sdbrans.Location = new System.Drawing.Point(84, 153);
            this.sdbrans.Name = "sdbrans";
            this.sdbrans.Size = new System.Drawing.Size(110, 31);
            this.sdbrans.TabIndex = 11;
            this.sdbrans.SelectedIndexChanged += new System.EventHandler(this.sdbrans_SelectedIndexChanged);
            // 
            // sdsaat
            // 
            this.sdsaat.Location = new System.Drawing.Point(84, 116);
            this.sdsaat.Mask = "00:00";
            this.sdsaat.Name = "sdsaat";
            this.sdsaat.Size = new System.Drawing.Size(109, 31);
            this.sdsaat.TabIndex = 9;
            this.sdsaat.ValidatingType = typeof(System.DateTime);
            // 
            // sdtarih
            // 
            this.sdtarih.Location = new System.Drawing.Point(84, 79);
            this.sdtarih.Mask = "00/00/0000";
            this.sdtarih.Name = "sdtarih";
            this.sdtarih.Size = new System.Drawing.Size(109, 31);
            this.sdtarih.TabIndex = 8;
            this.sdtarih.ValidatingType = typeof(System.DateTime);
            // 
            // sdid
            // 
            this.sdid.Location = new System.Drawing.Point(83, 38);
            this.sdid.Name = "sdid";
            this.sdid.Size = new System.Drawing.Size(110, 31);
            this.sdid.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tc:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Saat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "id:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(515, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(311, 216);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(305, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(518, 247);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(308, 247);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(302, 217);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.sddocpanel);
            this.groupBox6.Controls.Add(this.sdbranspanel);
            this.groupBox6.Controls.Add(this.sdrandevuliste);
            this.groupBox6.Location = new System.Drawing.Point(12, 397);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(497, 97);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // sddocpanel
            // 
            this.sddocpanel.Location = new System.Drawing.Point(6, 40);
            this.sddocpanel.Name = "sddocpanel";
            this.sddocpanel.Size = new System.Drawing.Size(109, 32);
            this.sddocpanel.TabIndex = 4;
            this.sddocpanel.Text = "Doktor Paneli";
            this.sddocpanel.UseVisualStyleBackColor = true;
            this.sddocpanel.Click += new System.EventHandler(this.sddocpanel_Click);
            // 
            // sdbranspanel
            // 
            this.sdbranspanel.Location = new System.Drawing.Point(256, 40);
            this.sdbranspanel.Name = "sdbranspanel";
            this.sdbranspanel.Size = new System.Drawing.Size(109, 32);
            this.sdbranspanel.TabIndex = 3;
            this.sdbranspanel.Text = "Branş Paneli";
            this.sdbranspanel.UseVisualStyleBackColor = true;
            this.sdbranspanel.Click += new System.EventHandler(this.sdbranspanel_Click);
            // 
            // sdrandevuliste
            // 
            this.sdrandevuliste.Location = new System.Drawing.Point(132, 40);
            this.sdrandevuliste.Name = "sdrandevuliste";
            this.sdrandevuliste.Size = new System.Drawing.Size(109, 32);
            this.sdrandevuliste.TabIndex = 2;
            this.sdrandevuliste.Text = "Randevu Liste";
            this.sdrandevuliste.UseVisualStyleBackColor = true;
            this.sdrandevuliste.Click += new System.EventHandler(this.sdrandevuliste_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Duyurular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(828, 504);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sdsektc;
        private System.Windows.Forms.Label sdsekadsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sdolustur;
        private System.Windows.Forms.RichTextBox sdduyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox sddurum;
        private System.Windows.Forms.MaskedTextBox sdtc;
        private System.Windows.Forms.ComboBox sddoktor;
        private System.Windows.Forms.ComboBox sdbrans;
        private System.Windows.Forms.MaskedTextBox sdsaat;
        private System.Windows.Forms.MaskedTextBox sdtarih;
        private System.Windows.Forms.TextBox sdid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sdkaydet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button sddocpanel;
        private System.Windows.Forms.Button sdbranspanel;
        private System.Windows.Forms.Button sdrandevuliste;
        private System.Windows.Forms.Button button1;
    }
}