namespace RandomCov2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtMD5 = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblMD5 = new System.Windows.Forms.Label();
            this.BtnYarat = new System.Windows.Forms.Button();
            this.BtnMD5 = new System.Windows.Forms.Button();
            this.BtnHafiza = new System.Windows.Forms.Button();
            this.BtnTut = new System.Windows.Forms.Button();
            this.lblHarf = new System.Windows.Forms.Label();
            this.txtKacHarf = new System.Windows.Forms.TextBox();
            this.chkSert = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblUyari = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSifre.Location = new System.Drawing.Point(123, 71);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(304, 25);
            this.txtSifre.TabIndex = 0;
            // 
            // txtMD5
            // 
            this.txtMD5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtMD5.Location = new System.Drawing.Point(123, 104);
            this.txtMD5.Name = "txtMD5";
            this.txtMD5.Size = new System.Drawing.Size(304, 25);
            this.txtMD5.TabIndex = 1;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(12, 71);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(58, 17);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Şifreniz :";
            // 
            // lblMD5
            // 
            this.lblMD5.AutoSize = true;
            this.lblMD5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMD5.Location = new System.Drawing.Point(12, 104);
            this.lblMD5.Name = "lblMD5";
            this.lblMD5.Size = new System.Drawing.Size(43, 17);
            this.lblMD5.TabIndex = 4;
            this.lblMD5.Text = "MD5 :";
            // 
            // BtnYarat
            // 
            this.BtnYarat.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.BtnYarat.FlatAppearance.BorderSize = 2;
            this.BtnYarat.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYarat.Location = new System.Drawing.Point(15, 135);
            this.BtnYarat.Name = "BtnYarat";
            this.BtnYarat.Size = new System.Drawing.Size(200, 27);
            this.BtnYarat.TabIndex = 6;
            this.BtnYarat.Text = "YENİ ŞİFRE YARAT";
            this.BtnYarat.UseVisualStyleBackColor = true;
            this.BtnYarat.Click += new System.EventHandler(this.BtnYarat_Click);
            // 
            // BtnMD5
            // 
            this.BtnMD5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BtnMD5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnMD5.Location = new System.Drawing.Point(227, 135);
            this.BtnMD5.Name = "BtnMD5";
            this.BtnMD5.Size = new System.Drawing.Size(200, 27);
            this.BtnMD5.TabIndex = 7;
            this.BtnMD5.Text = "ŞİFREYİ MD5\'LE";
            this.BtnMD5.UseVisualStyleBackColor = true;
            this.BtnMD5.Click += new System.EventHandler(this.BtnMD5_Click);
            // 
            // BtnHafiza
            // 
            this.BtnHafiza.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BtnHafiza.Location = new System.Drawing.Point(15, 170);
            this.BtnHafiza.Name = "BtnHafiza";
            this.BtnHafiza.Size = new System.Drawing.Size(200, 27);
            this.BtnHafiza.TabIndex = 8;
            this.BtnHafiza.Text = "ÜRETİLEN ŞİFREYİ KOPYALA";
            this.BtnHafiza.UseVisualStyleBackColor = true;
            this.BtnHafiza.Click += new System.EventHandler(this.BtnHafiza_Click);
            // 
            // BtnTut
            // 
            this.BtnTut.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.BtnTut.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BtnTut.Location = new System.Drawing.Point(227, 170);
            this.BtnTut.Name = "BtnTut";
            this.BtnTut.Size = new System.Drawing.Size(200, 27);
            this.BtnTut.TabIndex = 9;
            this.BtnTut.Text = "MD5\'Lİ ŞİFREYİ KOPYALA";
            this.BtnTut.UseVisualStyleBackColor = true;
            this.BtnTut.Click += new System.EventHandler(this.BtnTut_Click);
            // 
            // lblHarf
            // 
            this.lblHarf.AutoSize = true;
            this.lblHarf.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHarf.Location = new System.Drawing.Point(9, 38);
            this.lblHarf.Name = "lblHarf";
            this.lblHarf.Size = new System.Drawing.Size(91, 17);
            this.lblHarf.TabIndex = 10;
            this.lblHarf.Text = "HARF SAYISI :";
            // 
            // txtKacHarf
            // 
            this.txtKacHarf.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtKacHarf.Location = new System.Drawing.Point(123, 38);
            this.txtKacHarf.Name = "txtKacHarf";
            this.txtKacHarf.Size = new System.Drawing.Size(304, 25);
            this.txtKacHarf.TabIndex = 11;
            this.txtKacHarf.Text = "12";
            this.txtKacHarf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKacHarf_KeyPress);
            // 
            // chkSert
            // 
            this.chkSert.AutoSize = true;
            this.chkSert.Checked = true;
            this.chkSert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSert.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.chkSert.ForeColor = System.Drawing.Color.Brown;
            this.chkSert.Location = new System.Drawing.Point(278, 7);
            this.chkSert.Name = "chkSert";
            this.chkSert.Size = new System.Drawing.Size(149, 23);
            this.chkSert.TabIndex = 12;
            this.chkSert.Text = "Daha Zor Şifre Üret";
            this.chkSert.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 210);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(439, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "Bu Program Anıl SOYLU Tarafından Geliştirilmiştir.";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(269, 22);
            this.toolStripLabel1.Text = "Bu Program Anıl SOYLU Tarafından Geliştirilmiştir.";
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblUyari.Location = new System.Drawing.Point(9, 7);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(0, 15);
            this.lblUyari.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 235);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.chkSert);
            this.Controls.Add(this.txtKacHarf);
            this.Controls.Add(this.lblHarf);
            this.Controls.Add(this.BtnTut);
            this.Controls.Add(this.BtnHafiza);
            this.Controls.Add(this.BtnMD5);
            this.Controls.Add(this.BtnYarat);
            this.Controls.Add(this.lblMD5);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtMD5);
            this.Controls.Add(this.txtSifre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Şifre Üret Koplaya veya MD5 Çıkar";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtMD5;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblMD5;
        private System.Windows.Forms.Button BtnYarat;
        private System.Windows.Forms.Button BtnMD5;
        private System.Windows.Forms.Button BtnHafiza;
        private System.Windows.Forms.Button BtnTut;
        private System.Windows.Forms.Label lblHarf;
        private System.Windows.Forms.TextBox txtKacHarf;
        private System.Windows.Forms.CheckBox chkSert;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Label lblUyari;
    }
}

