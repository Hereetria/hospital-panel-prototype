namespace Hastane_Application
{
    partial class FrmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpad = new System.Windows.Forms.TextBox();
            this.dpsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dpbrans = new System.Windows.Forms.ComboBox();
            this.dptc = new System.Windows.Forms.MaskedTextBox();
            this.dpsifre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dpekle = new System.Windows.Forms.Button();
            this.dpsil = new System.Windows.Forms.Button();
            this.dpguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // dpad
            // 
            this.dpad.Location = new System.Drawing.Point(83, 12);
            this.dpad.Name = "dpad";
            this.dpad.Size = new System.Drawing.Size(121, 31);
            this.dpad.TabIndex = 1;
            // 
            // dpsoyad
            // 
            this.dpsoyad.Location = new System.Drawing.Point(83, 49);
            this.dpsoyad.Name = "dpsoyad";
            this.dpsoyad.Size = new System.Drawing.Size(121, 31);
            this.dpsoyad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "TC No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Branş:";
            // 
            // dpbrans
            // 
            this.dpbrans.FormattingEnabled = true;
            this.dpbrans.Location = new System.Drawing.Point(83, 89);
            this.dpbrans.Name = "dpbrans";
            this.dpbrans.Size = new System.Drawing.Size(121, 31);
            this.dpbrans.TabIndex = 3;
            // 
            // dptc
            // 
            this.dptc.Location = new System.Drawing.Point(83, 128);
            this.dptc.Mask = "00000000000";
            this.dptc.Name = "dptc";
            this.dptc.Size = new System.Drawing.Size(121, 31);
            this.dptc.TabIndex = 4;
            this.dptc.ValidatingType = typeof(int);
            // 
            // dpsifre
            // 
            this.dpsifre.Location = new System.Drawing.Point(83, 165);
            this.dpsifre.Name = "dpsifre";
            this.dpsifre.Size = new System.Drawing.Size(121, 31);
            this.dpsifre.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(222, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(820, 260);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dpekle
            // 
            this.dpekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dpekle.Location = new System.Drawing.Point(53, 202);
            this.dpekle.Name = "dpekle";
            this.dpekle.Size = new System.Drawing.Size(75, 32);
            this.dpekle.TabIndex = 11;
            this.dpekle.Text = "Ekle";
            this.dpekle.UseVisualStyleBackColor = false;
            this.dpekle.Click += new System.EventHandler(this.dpekle_Click);
            // 
            // dpsil
            // 
            this.dpsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dpsil.Location = new System.Drawing.Point(134, 202);
            this.dpsil.Name = "dpsil";
            this.dpsil.Size = new System.Drawing.Size(75, 32);
            this.dpsil.TabIndex = 12;
            this.dpsil.Text = "Sil";
            this.dpsil.UseVisualStyleBackColor = false;
            this.dpsil.Click += new System.EventHandler(this.dpsil_Click);
            // 
            // dpguncelle
            // 
            this.dpguncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dpguncelle.Location = new System.Drawing.Point(53, 240);
            this.dpguncelle.Name = "dpguncelle";
            this.dpguncelle.Size = new System.Drawing.Size(156, 32);
            this.dpguncelle.TabIndex = 13;
            this.dpguncelle.Text = "Güncelle";
            this.dpguncelle.UseVisualStyleBackColor = false;
            this.dpguncelle.Click += new System.EventHandler(this.dpguncelle_Click);
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1054, 286);
            this.Controls.Add(this.dpguncelle);
            this.Controls.Add(this.dpsil);
            this.Controls.Add(this.dpekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dpsifre);
            this.Controls.Add(this.dptc);
            this.Controls.Add(this.dpbrans);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dpsoyad);
            this.Controls.Add(this.dpad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorPaneli";
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dpad;
        private System.Windows.Forms.TextBox dpsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox dpbrans;
        private System.Windows.Forms.MaskedTextBox dptc;
        private System.Windows.Forms.TextBox dpsifre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dpekle;
        private System.Windows.Forms.Button dpsil;
        private System.Windows.Forms.Button dpguncelle;
    }
}