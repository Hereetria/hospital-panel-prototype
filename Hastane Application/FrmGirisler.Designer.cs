namespace Hastane_Application
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.btndoktorgiris = new System.Windows.Forms.Button();
            this.btnsekretergiris = new System.Windows.Forms.Button();
            this.btnhastagiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btndoktorgiris
            // 
            this.btndoktorgiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndoktorgiris.BackgroundImage")));
            this.btndoktorgiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndoktorgiris.Location = new System.Drawing.Point(168, 125);
            this.btndoktorgiris.Name = "btndoktorgiris";
            this.btndoktorgiris.Size = new System.Drawing.Size(126, 99);
            this.btndoktorgiris.TabIndex = 0;
            this.btndoktorgiris.UseVisualStyleBackColor = true;
            this.btndoktorgiris.Click += new System.EventHandler(this.btndoktorgiris_Click);
            // 
            // btnsekretergiris
            // 
            this.btnsekretergiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsekretergiris.BackgroundImage")));
            this.btnsekretergiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsekretergiris.Location = new System.Drawing.Point(326, 125);
            this.btnsekretergiris.Name = "btnsekretergiris";
            this.btnsekretergiris.Size = new System.Drawing.Size(126, 99);
            this.btnsekretergiris.TabIndex = 1;
            this.btnsekretergiris.UseVisualStyleBackColor = true;
            this.btnsekretergiris.Click += new System.EventHandler(this.btnsekretergiris_Click);
            // 
            // btnhastagiris
            // 
            this.btnhastagiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhastagiris.BackgroundImage")));
            this.btnhastagiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhastagiris.Location = new System.Drawing.Point(12, 125);
            this.btnhastagiris.Name = "btnhastagiris";
            this.btnhastagiris.Size = new System.Drawing.Size(126, 99);
            this.btnhastagiris.TabIndex = 2;
            this.btnhastagiris.UseVisualStyleBackColor = true;
            this.btnhastagiris.Click += new System.EventHandler(this.btnhastagiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hastane Giriş Paneli";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(488, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhastagiris);
            this.Controls.Add(this.btnsekretergiris);
            this.Controls.Add(this.btndoktorgiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Hastane Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndoktorgiris;
        private System.Windows.Forms.Button btnsekretergiris;
        private System.Windows.Forms.Button btnhastagiris;
        private System.Windows.Forms.Label label1;
    }
}

