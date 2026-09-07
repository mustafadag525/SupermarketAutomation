namespace proje_.Formlar
{
    partial class frmKullanıcıListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanıcıListele));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adısoyadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tumTablolarDataset = new proje_.TumTablolarDataset();
            this.kullaniciTableAdapter = new proje_.TumTablolarDatasetTableAdapters.KullaniciTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGorev = new System.Windows.Forms.TextBox();
            this.kullaniciBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.txtKullanıcıadı = new System.Windows.Forms.TextBox();
            this.kullaniciBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.kullaniciBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.kullaniciBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.txtTelefonno = new System.Windows.Forms.TextBox();
            this.kullaniciBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txtAdsoyad = new System.Windows.Forms.TextBox();
            this.kullaniciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnYazdır = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.txtıd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumTablolarDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.adısoyadıDataGridViewTextBoxColumn,
            this.telnoDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.kullaniciadiDataGridViewTextBoxColumn,
            this.parolaDataGridViewTextBoxColumn,
            this.gorevDataGridViewTextBoxColumn,
            this.resimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kullaniciBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1205, 304);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adısoyadıDataGridViewTextBoxColumn
            // 
            this.adısoyadıDataGridViewTextBoxColumn.DataPropertyName = "Adısoyadı";
            this.adısoyadıDataGridViewTextBoxColumn.HeaderText = "Adısoyadı";
            this.adısoyadıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adısoyadıDataGridViewTextBoxColumn.Name = "adısoyadıDataGridViewTextBoxColumn";
            // 
            // telnoDataGridViewTextBoxColumn
            // 
            this.telnoDataGridViewTextBoxColumn.DataPropertyName = "Telno";
            this.telnoDataGridViewTextBoxColumn.HeaderText = "Telno";
            this.telnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telnoDataGridViewTextBoxColumn.Name = "telnoDataGridViewTextBoxColumn";
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // kullaniciadiDataGridViewTextBoxColumn
            // 
            this.kullaniciadiDataGridViewTextBoxColumn.DataPropertyName = "Kullaniciadi";
            this.kullaniciadiDataGridViewTextBoxColumn.HeaderText = "Kullaniciadi";
            this.kullaniciadiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kullaniciadiDataGridViewTextBoxColumn.Name = "kullaniciadiDataGridViewTextBoxColumn";
            // 
            // parolaDataGridViewTextBoxColumn
            // 
            this.parolaDataGridViewTextBoxColumn.DataPropertyName = "Parola";
            this.parolaDataGridViewTextBoxColumn.HeaderText = "Parola";
            this.parolaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parolaDataGridViewTextBoxColumn.Name = "parolaDataGridViewTextBoxColumn";
            // 
            // gorevDataGridViewTextBoxColumn
            // 
            this.gorevDataGridViewTextBoxColumn.DataPropertyName = "Gorev";
            this.gorevDataGridViewTextBoxColumn.HeaderText = "Gorev";
            this.gorevDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gorevDataGridViewTextBoxColumn.Name = "gorevDataGridViewTextBoxColumn";
            // 
            // resimDataGridViewTextBoxColumn
            // 
            this.resimDataGridViewTextBoxColumn.DataPropertyName = "Resim";
            this.resimDataGridViewTextBoxColumn.HeaderText = "Resim";
            this.resimDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.resimDataGridViewTextBoxColumn.Name = "resimDataGridViewTextBoxColumn";
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "Kullanici";
            this.kullaniciBindingSource.DataSource = this.tumTablolarDataset;
            // 
            // tumTablolarDataset
            // 
            this.tumTablolarDataset.DataSetName = "TumTablolarDataset";
            this.tumTablolarDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Görevi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Telefon No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Adı Soyadı";
            // 
            // txtGorev
            // 
            this.txtGorev.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource6, "Gorev", true));
            this.txtGorev.Location = new System.Drawing.Point(470, 445);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(169, 22);
            this.txtGorev.TabIndex = 6;
            // 
            // kullaniciBindingSource6
            // 
            this.kullaniciBindingSource6.DataMember = "Kullanici";
            this.kullaniciBindingSource6.DataSource = this.tumTablolarDataset;
            // 
            // txtKullanıcıadı
            // 
            this.txtKullanıcıadı.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource5, "Kullaniciadi", true));
            this.txtKullanıcıadı.Location = new System.Drawing.Point(470, 402);
            this.txtKullanıcıadı.Name = "txtKullanıcıadı";
            this.txtKullanıcıadı.Size = new System.Drawing.Size(169, 22);
            this.txtKullanıcıadı.TabIndex = 5;
            // 
            // kullaniciBindingSource5
            // 
            this.kullaniciBindingSource5.DataMember = "Kullanici";
            this.kullaniciBindingSource5.DataSource = this.tumTablolarDataset;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource4, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(470, 363);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // kullaniciBindingSource4
            // 
            this.kullaniciBindingSource4.DataMember = "Kullanici";
            this.kullaniciBindingSource4.DataSource = this.tumTablolarDataset;
            // 
            // txtAdres
            // 
            this.txtAdres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource3, "Adres", true));
            this.txtAdres.Location = new System.Drawing.Point(131, 445);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(169, 22);
            this.txtAdres.TabIndex = 3;
            // 
            // kullaniciBindingSource3
            // 
            this.kullaniciBindingSource3.DataMember = "Kullanici";
            this.kullaniciBindingSource3.DataSource = this.tumTablolarDataset;
            // 
            // txtTelefonno
            // 
            this.txtTelefonno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource2, "Telno", true));
            this.txtTelefonno.Location = new System.Drawing.Point(131, 405);
            this.txtTelefonno.Name = "txtTelefonno";
            this.txtTelefonno.Size = new System.Drawing.Size(169, 22);
            this.txtTelefonno.TabIndex = 2;
            // 
            // kullaniciBindingSource2
            // 
            this.kullaniciBindingSource2.DataMember = "Kullanici";
            this.kullaniciBindingSource2.DataSource = this.tumTablolarDataset;
            // 
            // txtAdsoyad
            // 
            this.txtAdsoyad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kullaniciBindingSource1, "Adısoyadı", true));
            this.txtAdsoyad.Location = new System.Drawing.Point(131, 358);
            this.txtAdsoyad.Name = "txtAdsoyad";
            this.txtAdsoyad.Size = new System.Drawing.Size(169, 22);
            this.txtAdsoyad.TabIndex = 1;
            this.txtAdsoyad.TextChanged += new System.EventHandler(this.txtAdsoyad_TextChanged);
            // 
            // kullaniciBindingSource1
            // 
            this.kullaniciBindingSource1.DataMember = "Kullanici";
            this.kullaniciBindingSource1.DataSource = this.tumTablolarDataset;
            // 
            // btnYazdır
            // 
            this.btnYazdır.ImageKey = "indir (1).jpg";
            this.btnYazdır.ImageList = this.ımageList1;
            this.btnYazdır.Location = new System.Drawing.Point(493, 488);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(131, 67);
            this.btnYazdır.TabIndex = 18;
            this.btnYazdır.UseVisualStyleBackColor = true;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "indir (1).jpg");
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "İD";
            // 
            // txtıd
            // 
            this.txtıd.Location = new System.Drawing.Point(131, 319);
            this.txtıd.Name = "txtıd";
            this.txtıd.Size = new System.Drawing.Size(169, 22);
            this.txtıd.TabIndex = 20;
            // 
            // frmKullanıcıListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1205, 652);
            this.Controls.Add(this.txtıd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnYazdır);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGorev);
            this.Controls.Add(this.txtKullanıcıadı);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefonno);
            this.Controls.Add(this.txtAdsoyad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmKullanıcıListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KULLANICI LİSTELE";
            this.Load += new System.EventHandler(this.frmKullanıcıListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tumTablolarDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TumTablolarDataset tumTablolarDataset;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private TumTablolarDatasetTableAdapters.KullaniciTableAdapter kullaniciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adısoyadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resimDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGorev;
        private System.Windows.Forms.BindingSource kullaniciBindingSource6;
        private System.Windows.Forms.TextBox txtKullanıcıadı;
        private System.Windows.Forms.BindingSource kullaniciBindingSource5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.BindingSource kullaniciBindingSource4;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.BindingSource kullaniciBindingSource3;
        private System.Windows.Forms.TextBox txtTelefonno;
        private System.Windows.Forms.BindingSource kullaniciBindingSource2;
        private System.Windows.Forms.TextBox txtAdsoyad;
        private System.Windows.Forms.BindingSource kullaniciBindingSource1;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtıd;
    }
}