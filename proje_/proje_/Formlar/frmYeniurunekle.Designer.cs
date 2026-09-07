namespace proje_.Formlar
{
    partial class frmYeniurunekle
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
            this.txturun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txturun
            // 
            this.txturun.Location = new System.Drawing.Point(145, 82);
            this.txturun.Name = "txturun";
            this.txturun.Size = new System.Drawing.Size(196, 22);
            this.txturun.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(188, 138);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(82, 29);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // comboMarka
            // 
            this.comboMarka.DisplayMember = "marka";
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(145, 45);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(196, 24);
            this.comboMarka.TabIndex = 4;
            // 
            // frmYeniurunekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(454, 331);
            this.Controls.Add(this.comboMarka);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txturun);
            this.Name = "frmYeniurunekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Ürün Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txturun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox comboMarka;
    }
}