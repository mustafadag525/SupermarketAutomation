namespace proje_.Formlar
{
    partial class frmBizeUlasin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBizeUlasin));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.ImageKey = "indir (1).png";
            this.linkLabel1.ImageList = this.ımageList1;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(99, 40);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(160, 94);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Gmail";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel2.ImageKey = "linekdin.png";
            this.linkLabel2.ImageList = this.ımageList1;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Red;
            this.linkLabel2.Location = new System.Drawing.Point(99, 188);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(160, 94);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "LinkedIn";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "discord.png");
            this.ımageList1.Images.SetKeyName(1, "indir (1).png");
            this.ımageList1.Images.SetKeyName(2, "linekdin.png");
            // 
            // linkLabel3
            // 
            this.linkLabel3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel3.ImageKey = "discord.png";
            this.linkLabel3.ImageList = this.ımageList1;
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.Red;
            this.linkLabel3.Location = new System.Drawing.Point(99, 335);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(160, 94);
            this.linkLabel3.TabIndex = 1;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "linkLabel2";
            this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // frmBizeUlasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(529, 517);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Name = "frmBizeUlasin";
            this.Text = "frmBizeUlasin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
    }
}