namespace proje_.Formlar
{
    partial class frmUrunListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltoplammaliyet = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResimsec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblToplamkayit = new System.Windows.Forms.Label();
            this.txtTelefonara = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnMarkamodelGuncelle = new System.Windows.Forms.Button();
            this.lblYenimarka = new System.Windows.Forms.Label();
            this.lblYeniurun = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtkdv = new System.Windows.Forms.TextBox();
            this.txtsatisfiyati = new System.Windows.Forms.TextBox();
            this.txtAlisfiyati = new System.Windows.Forms.TextBox();
            this.dateUretim = new System.Windows.Forms.DateTimePicker();
            this.dateGelis = new System.Windows.Forms.DateTimePicker();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.tBLMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gıdaDataSet = new proje_.gıdaDataSet();
            this.comboUrunadi = new System.Windows.Forms.ComboBox();
            this.fKTBLModelTBLMarkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLMarkaTableAdapter = new proje_.gıdaDataSetTableAdapters.TBLMarkaTableAdapter();
            this.tBLModelTableAdapter = new proje_.gıdaDataSetTableAdapters.TBLModelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gıdaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTBLModelTBLMarkaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1302, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbltoplammaliyet);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnResimsec);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblToplamkayit);
            this.panel1.Controls.Add(this.txtTelefonara);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnIptal);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnMarkamodelGuncelle);
            this.panel1.Controls.Add(this.lblYenimarka);
            this.panel1.Controls.Add(this.lblYeniurun);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMiktar);
            this.panel1.Controls.Add(this.txtkdv);
            this.panel1.Controls.Add(this.txtsatisfiyati);
            this.panel1.Controls.Add(this.txtAlisfiyati);
            this.panel1.Controls.Add(this.dateUretim);
            this.panel1.Controls.Add(this.dateGelis);
            this.panel1.Controls.Add(this.comboMarka);
            this.panel1.Controls.Add(this.comboUrunadi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 408);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbltoplammaliyet
            // 
            this.lbltoplammaliyet.AutoSize = true;
            this.lbltoplammaliyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoplammaliyet.Location = new System.Drawing.Point(698, 78);
            this.lbltoplammaliyet.Name = "lbltoplammaliyet";
            this.lbltoplammaliyet.Size = new System.Drawing.Size(114, 16);
            this.lbltoplammaliyet.TabIndex = 34;
            this.lbltoplammaliyet.Text = "Toplam Maliyet";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Yellow;
            this.txtID.Location = new System.Drawing.Point(197, -1);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(135, 22);
            this.txtID.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "İD";
            // 
            // btnResimsec
            // 
            this.btnResimsec.Location = new System.Drawing.Point(372, 197);
            this.btnResimsec.Name = "btnResimsec";
            this.btnResimsec.Size = new System.Drawing.Size(98, 38);
            this.btnResimsec.TabIndex = 31;
            this.btnResimsec.Text = "Resim Seç";
            this.btnResimsec.UseVisualStyleBackColor = true;
            this.btnResimsec.Click += new System.EventHandler(this.btnResimsec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(349, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 108);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // lblToplamkayit
            // 
            this.lblToplamkayit.AutoSize = true;
            this.lblToplamkayit.BackColor = System.Drawing.Color.Red;
            this.lblToplamkayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamkayit.Location = new System.Drawing.Point(708, 147);
            this.lblToplamkayit.Name = "lblToplamkayit";
            this.lblToplamkayit.Size = new System.Drawing.Size(243, 29);
            this.lblToplamkayit.TabIndex = 29;
            this.lblToplamkayit.Text = "Toplam Kayıt Sayısı";
            // 
            // txtTelefonara
            // 
            this.txtTelefonara.Location = new System.Drawing.Point(860, 12);
            this.txtTelefonara.Name = "txtTelefonara";
            this.txtTelefonara.Size = new System.Drawing.Size(122, 22);
            this.txtTelefonara.TabIndex = 28;
            this.txtTelefonara.TextChanged += new System.EventHandler(this.txtTelefonara_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(703, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Ürün Ara";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIptal.Location = new System.Drawing.Point(492, 171);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(91, 40);
            this.btnIptal.TabIndex = 26;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(492, 124);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(91, 40);
            this.btnSil.TabIndex = 26;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Yellow;
            this.btnGuncelle.Location = new System.Drawing.Point(492, 78);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(91, 40);
            this.btnGuncelle.TabIndex = 26;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnMarkamodelGuncelle
            // 
            this.btnMarkamodelGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMarkamodelGuncelle.Location = new System.Drawing.Point(492, 12);
            this.btnMarkamodelGuncelle.Name = "btnMarkamodelGuncelle";
            this.btnMarkamodelGuncelle.Size = new System.Drawing.Size(111, 47);
            this.btnMarkamodelGuncelle.TabIndex = 25;
            this.btnMarkamodelGuncelle.Text = "Marka Model Güncelle";
            this.btnMarkamodelGuncelle.UseVisualStyleBackColor = false;
            this.btnMarkamodelGuncelle.Click += new System.EventHandler(this.btnMarkamodelGuncelle_Click);
            // 
            // lblYenimarka
            // 
            this.lblYenimarka.AutoSize = true;
            this.lblYenimarka.Location = new System.Drawing.Point(382, 8);
            this.lblYenimarka.Name = "lblYenimarka";
            this.lblYenimarka.Size = new System.Drawing.Size(75, 16);
            this.lblYenimarka.TabIndex = 24;
            this.lblYenimarka.Text = "Yeni marka";
            // 
            // lblYeniurun
            // 
            this.lblYeniurun.AutoSize = true;
            this.lblYeniurun.Location = new System.Drawing.Point(382, 35);
            this.lblYeniurun.Name = "lblYeniurun";
            this.lblYeniurun.Size = new System.Drawing.Size(79, 16);
            this.lblYeniurun.TabIndex = 24;
            this.lblYeniurun.Text = "yeni ürün ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Miktar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Kdv";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Satış Fiyatı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Alış fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Alış Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Üretim Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Marka";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(253, 355);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(135, 22);
            this.txtMiktar.TabIndex = 12;
            // 
            // txtkdv
            // 
            this.txtkdv.Location = new System.Drawing.Point(197, 200);
            this.txtkdv.Name = "txtkdv";
            this.txtkdv.Size = new System.Drawing.Size(135, 22);
            this.txtkdv.TabIndex = 13;
            // 
            // txtsatisfiyati
            // 
            this.txtsatisfiyati.Location = new System.Drawing.Point(197, 172);
            this.txtsatisfiyati.Name = "txtsatisfiyati";
            this.txtsatisfiyati.Size = new System.Drawing.Size(135, 22);
            this.txtsatisfiyati.TabIndex = 14;
            // 
            // txtAlisfiyati
            // 
            this.txtAlisfiyati.Location = new System.Drawing.Point(197, 144);
            this.txtAlisfiyati.Name = "txtAlisfiyati";
            this.txtAlisfiyati.Size = new System.Drawing.Size(135, 22);
            this.txtAlisfiyati.TabIndex = 15;
            // 
            // dateUretim
            // 
            this.dateUretim.Location = new System.Drawing.Point(197, 85);
            this.dateUretim.Name = "dateUretim";
            this.dateUretim.Size = new System.Drawing.Size(135, 22);
            this.dateUretim.TabIndex = 10;
            // 
            // dateGelis
            // 
            this.dateGelis.Location = new System.Drawing.Point(197, 116);
            this.dateGelis.Name = "dateGelis";
            this.dateGelis.Size = new System.Drawing.Size(135, 22);
            this.dateGelis.TabIndex = 11;
            // 
            // comboMarka
            // 
            this.comboMarka.DataSource = this.tBLMarkaBindingSource;
            this.comboMarka.DisplayMember = "marka";
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(197, 25);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(135, 24);
            this.comboMarka.TabIndex = 8;
            // 
            // tBLMarkaBindingSource
            // 
            this.tBLMarkaBindingSource.DataMember = "TBLMarka";
            this.tBLMarkaBindingSource.DataSource = this.gıdaDataSet;
            // 
            // gıdaDataSet
            // 
            this.gıdaDataSet.DataSetName = "gıdaDataSet";
            this.gıdaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboUrunadi
            // 
            this.comboUrunadi.DataSource = this.fKTBLModelTBLMarkaBindingSource;
            this.comboUrunadi.DisplayMember = "urun";
            this.comboUrunadi.FormattingEnabled = true;
            this.comboUrunadi.Location = new System.Drawing.Point(197, 55);
            this.comboUrunadi.Name = "comboUrunadi";
            this.comboUrunadi.Size = new System.Drawing.Size(135, 24);
            this.comboUrunadi.TabIndex = 9;
            // 
            // fKTBLModelTBLMarkaBindingSource
            // 
            this.fKTBLModelTBLMarkaBindingSource.DataMember = "FK_TBLModel_TBLMarka";
            this.fKTBLModelTBLMarkaBindingSource.DataSource = this.tBLMarkaBindingSource;
            // 
            // tBLMarkaTableAdapter
            // 
            this.tBLMarkaTableAdapter.ClearBeforeFill = true;
            // 
            // tBLModelTableAdapter
            // 
            this.tBLModelTableAdapter.ClearBeforeFill = true;
            // 
            // frmUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1302, 790);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUrunListele";
            this.Text = "ÜRÜN LİSTELEME EKRANI";
            this.Load += new System.EventHandler(this.frmUrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMarkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gıdaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTBLModelTBLMarkaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblToplamkayit;
        private System.Windows.Forms.TextBox txtTelefonara;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnMarkamodelGuncelle;
        private System.Windows.Forms.Label lblYenimarka;
        private System.Windows.Forms.Label lblYeniurun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtkdv;
        private System.Windows.Forms.TextBox txtsatisfiyati;
        private System.Windows.Forms.TextBox txtAlisfiyati;
        private System.Windows.Forms.DateTimePicker dateUretim;
        private System.Windows.Forms.DateTimePicker dateGelis;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.ComboBox comboUrunadi;
        private System.Windows.Forms.Button btnResimsec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private gıdaDataSet gıdaDataSet;
        private System.Windows.Forms.BindingSource tBLMarkaBindingSource;
        private gıdaDataSetTableAdapters.TBLMarkaTableAdapter tBLMarkaTableAdapter;
        private System.Windows.Forms.BindingSource fKTBLModelTBLMarkaBindingSource;
        private gıdaDataSetTableAdapters.TBLModelTableAdapter tBLModelTableAdapter;
        private System.Windows.Forms.Label lbltoplammaliyet;
    }
}