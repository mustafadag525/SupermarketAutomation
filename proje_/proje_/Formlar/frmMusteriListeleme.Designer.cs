namespace proje_.Formlar
{
    partial class frmMusteriListeleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriListeleme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdsoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSil = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToplamkayıt = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnExcelaktar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(158, 476);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(144, 81);
            this.txtAdres.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(158, 443);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(144, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(158, 404);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(144, 22);
            this.txtTelefon.TabIndex = 1;
            // 
            // txtAdsoyad
            // 
            this.txtAdsoyad.Location = new System.Drawing.Point(158, 363);
            this.txtAdsoyad.Name = "txtAdsoyad";
            this.txtAdsoyad.Size = new System.Drawing.Size(144, 22);
            this.txtAdsoyad.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(31, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(31, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(31, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(31, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ad Soyad";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.ImageKey = "5278658.png";
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(434, 326);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(142, 42);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir.png");
            this.ımageList1.Images.SetKeyName(1, "png-transparent-computer-icons-delete-icon-white-text-logo.png");
            this.ımageList1.Images.SetKeyName(2, "5278658.png");
            this.ımageList1.Images.SetKeyName(3, "indir (1).jpg");
            this.ımageList1.Images.SetKeyName(4, "17705097992139781671.png");
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.ImageKey = "png-transparent-computer-icons-delete-icon-white-text-logo.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(434, 384);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(142, 42);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIptal.ImageKey = "indir.png";
            this.btnIptal.ImageList = this.ımageList1;
            this.btnIptal.Location = new System.Drawing.Point(434, 440);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(142, 42);
            this.btnIptal.TabIndex = 9;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(31, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Yellow;
            this.txtId.Location = new System.Drawing.Point(158, 326);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(144, 22);
            this.txtId.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(642, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Müşteri Ara";
            // 
            // lblToplamkayıt
            // 
            this.lblToplamkayıt.AutoSize = true;
            this.lblToplamkayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamkayıt.Location = new System.Drawing.Point(633, 466);
            this.lblToplamkayıt.Name = "lblToplamkayıt";
            this.lblToplamkayıt.Size = new System.Drawing.Size(166, 29);
            this.lblToplamkayıt.TabIndex = 10;
            this.lblToplamkayıt.Text = "Toplam Kayıt";
            // 
            // txtAra
            // 
            this.txtAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAra.Location = new System.Drawing.Point(741, 318);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(134, 22);
            this.txtAra.TabIndex = 11;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnYazdır
            // 
            this.btnYazdır.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnYazdır.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYazdır.ImageKey = "indir (1).jpg";
            this.btnYazdır.ImageList = this.ımageList1;
            this.btnYazdır.Location = new System.Drawing.Point(434, 488);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(142, 42);
            this.btnYazdır.TabIndex = 12;
            this.btnYazdır.Text = "Yazdır";
            this.btnYazdır.UseVisualStyleBackColor = false;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnExcelaktar
            // 
            this.btnExcelaktar.BackColor = System.Drawing.Color.Aqua;
            this.btnExcelaktar.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnExcelaktar.ImageKey = "17705097992139781671.png";
            this.btnExcelaktar.ImageList = this.ımageList1;
            this.btnExcelaktar.Location = new System.Drawing.Point(434, 546);
            this.btnExcelaktar.Name = "btnExcelaktar";
            this.btnExcelaktar.Size = new System.Drawing.Size(152, 46);
            this.btnExcelaktar.TabIndex = 13;
            this.btnExcelaktar.UseVisualStyleBackColor = false;
            this.btnExcelaktar.Click += new System.EventHandler(this.btnExcelaktar_Click);
            // 
            // frmMusteriListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1002, 620);
            this.Controls.Add(this.btnExcelaktar);
            this.Controls.Add(this.btnYazdır);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblToplamkayıt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtAdsoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMusteriListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ LİSTELEME EKRANI";
            this.Load += new System.EventHandler(this.frmMusteriListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdsoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblToplamkayıt;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnExcelaktar;
    }
}