namespace proje_
{
    partial class frmKullanıcıGiris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanıcıGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtKullanıcıAdı = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnIptal = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblYeniKullanıcı = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre";
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(224, 241);
            this.txtParola.Multiline = true;
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(125, 22);
            this.txtParola.TabIndex = 2;
            // 
            // txtKullanıcıAdı
            // 
            this.txtKullanıcıAdı.Location = new System.Drawing.Point(224, 193);
            this.txtKullanıcıAdı.Name = "txtKullanıcıAdı";
            this.txtKullanıcıAdı.Size = new System.Drawing.Size(125, 22);
            this.txtKullanıcıAdı.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiris.ImageKey = "indir.jpg";
            this.btnGiris.ImageList = this.ımageList1;
            this.btnGiris.Location = new System.Drawing.Point(168, 304);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(94, 48);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giris";
            this.btnGiris.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "cancel.jpeg");
            this.ımageList1.Images.SetKeyName(1, "indir.jpg");
            // 
            // btnIptal
            // 
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIptal.ImageKey = "cancel.jpeg";
            this.btnIptal.ImageList = this.ımageList1;
            this.btnIptal.Location = new System.Drawing.Point(278, 304);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(94, 48);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İptal";
            this.btnIptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(388, 237);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblYeniKullanıcı
            // 
            this.lblYeniKullanıcı.AutoSize = true;
            this.lblYeniKullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYeniKullanıcı.ForeColor = System.Drawing.Color.Red;
            this.lblYeniKullanıcı.Location = new System.Drawing.Point(54, 405);
            this.lblYeniKullanıcı.Name = "lblYeniKullanıcı";
            this.lblYeniKullanıcı.Size = new System.Drawing.Size(143, 25);
            this.lblYeniKullanıcı.TabIndex = 4;
            this.lblYeniKullanıcı.Text = "Yeni Kullanıcı";
            this.lblYeniKullanıcı.Click += new System.EventHandler(this.lblYeniKullanıcı_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmKullanıcıGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblYeniKullanıcı);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtKullanıcıAdı);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKullanıcıGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş Sayfası";
            this.Load += new System.EventHandler(this.frmKullanıcıGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtKullanıcıAdı;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblYeniKullanıcı;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}