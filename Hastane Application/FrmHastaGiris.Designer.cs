namespace Hastane_Application
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.MaskedTextBox();
            this.txsifre = new System.Windows.Forms.TextBox();
            this.girisyap = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 61);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasta Giris Paneli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(60, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sifre:";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(144, 88);
            this.txtc.Mask = "00000000000";
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(121, 20);
            this.txtc.TabIndex = 3;
            this.txtc.Text = "22222222222";
            this.txtc.ValidatingType = typeof(int);
            this.txtc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txsifre
            // 
            this.txsifre.Location = new System.Drawing.Point(144, 130);
            this.txsifre.Name = "txsifre";
            this.txsifre.Size = new System.Drawing.Size(121, 20);
            this.txsifre.TabIndex = 4;
            this.txsifre.Text = "234";
            this.txsifre.UseSystemPasswordChar = true;
            // 
            // girisyap
            // 
            this.girisyap.Location = new System.Drawing.Point(171, 156);
            this.girisyap.Name = "girisyap";
            this.girisyap.Size = new System.Drawing.Size(94, 27);
            this.girisyap.TabIndex = 5;
            this.girisyap.Text = "Giris Yap";
            this.girisyap.UseVisualStyleBackColor = true;
            this.girisyap.Click += new System.EventHandler(this.girisyap_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(289, 131);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 19);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Üye Ol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.girisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(477, 245);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.girisyap);
            this.Controls.Add(this.txsifre);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.Text = "Hasta Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtc;
        private System.Windows.Forms.TextBox txsifre;
        private System.Windows.Forms.Button girisyap;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}