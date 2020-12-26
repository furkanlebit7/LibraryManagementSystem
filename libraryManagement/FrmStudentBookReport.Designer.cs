
namespace libraryManagement
{
    partial class FrmStudentBookReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblDetail2 = new System.Windows.Forms.Label();
            this.lblDateDueForReturn = new System.Windows.Forms.Label();
            this.pictureBoxPic = new System.Windows.Forms.PictureBox();
            this.lblShelf2 = new System.Windows.Forms.Label();
            this.lblDateIssued = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lblCat2 = new System.Windows.Forms.Label();
            this.lblPub2 = new System.Windows.Forms.Label();
            this.lblAuthor2 = new System.Windows.Forms.Label();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblAva = new System.Windows.Forms.Label();
            this.lblShelf = new System.Windows.Forms.Label();
            this.lblQnt = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblPub = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1421, 159);
            this.panel1.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(625, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(414, 85);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Book Report";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(320, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1015, 162);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.lblDetail2);
            this.groupBox1.Controls.Add(this.lblDateDueForReturn);
            this.groupBox1.Controls.Add(this.pictureBoxPic);
            this.groupBox1.Controls.Add(this.lblShelf2);
            this.groupBox1.Controls.Add(this.lblDateIssued);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblPrice2);
            this.groupBox1.Controls.Add(this.lblCat2);
            this.groupBox1.Controls.Add(this.lblPub2);
            this.groupBox1.Controls.Add(this.lblAuthor2);
            this.groupBox1.Controls.Add(this.lblPenalty);
            this.groupBox1.Controls.Add(this.lblDetail);
            this.groupBox1.Controls.Add(this.lblAva);
            this.groupBox1.Controls.Add(this.lblShelf);
            this.groupBox1.Controls.Add(this.lblQnt);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblCat);
            this.groupBox1.Controls.Add(this.lblPub);
            this.groupBox1.Controls.Add(this.lblAuthor);
            this.groupBox1.Controls.Add(this.lblRent);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(320, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 540);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Informations";
            this.groupBox1.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.DarkRed;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 50;
            this.btnClose.Location = new System.Drawing.Point(947, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(62, 68);
            this.btnClose.TabIndex = 34;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDetail2
            // 
            this.lblDetail2.AutoSize = true;
            this.lblDetail2.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDetail2.Location = new System.Drawing.Point(257, 252);
            this.lblDetail2.MaximumSize = new System.Drawing.Size(270, 100);
            this.lblDetail2.Name = "lblDetail2";
            this.lblDetail2.Size = new System.Drawing.Size(0, 23);
            this.lblDetail2.TabIndex = 32;
            // 
            // lblDateDueForReturn
            // 
            this.lblDateDueForReturn.AutoSize = true;
            this.lblDateDueForReturn.Location = new System.Drawing.Point(257, 398);
            this.lblDateDueForReturn.Name = "lblDateDueForReturn";
            this.lblDateDueForReturn.Size = new System.Drawing.Size(0, 23);
            this.lblDateDueForReturn.TabIndex = 31;
            // 
            // pictureBoxPic
            // 
            this.pictureBoxPic.Location = new System.Drawing.Point(622, 132);
            this.pictureBoxPic.Name = "pictureBoxPic";
            this.pictureBoxPic.Size = new System.Drawing.Size(271, 313);
            this.pictureBoxPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPic.TabIndex = 24;
            this.pictureBoxPic.TabStop = false;
            // 
            // lblShelf2
            // 
            this.lblShelf2.AutoSize = true;
            this.lblShelf2.Location = new System.Drawing.Point(257, 212);
            this.lblShelf2.Name = "lblShelf2";
            this.lblShelf2.Size = new System.Drawing.Size(0, 23);
            this.lblShelf2.TabIndex = 30;
            // 
            // lblDateIssued
            // 
            this.lblDateIssued.AutoSize = true;
            this.lblDateIssued.Location = new System.Drawing.Point(257, 351);
            this.lblDateIssued.Name = "lblDateIssued";
            this.lblDateIssued.Size = new System.Drawing.Size(0, 23);
            this.lblDateIssued.TabIndex = 29;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Location = new System.Drawing.Point(669, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(180, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Book Name ";
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Location = new System.Drawing.Point(257, 172);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(0, 23);
            this.lblPrice2.TabIndex = 28;
            // 
            // lblCat2
            // 
            this.lblCat2.AutoSize = true;
            this.lblCat2.Location = new System.Drawing.Point(257, 132);
            this.lblCat2.Name = "lblCat2";
            this.lblCat2.Size = new System.Drawing.Size(0, 23);
            this.lblCat2.TabIndex = 27;
            // 
            // lblPub2
            // 
            this.lblPub2.AutoSize = true;
            this.lblPub2.Location = new System.Drawing.Point(257, 92);
            this.lblPub2.Name = "lblPub2";
            this.lblPub2.Size = new System.Drawing.Size(0, 23);
            this.lblPub2.TabIndex = 26;
            // 
            // lblAuthor2
            // 
            this.lblAuthor2.AutoSize = true;
            this.lblAuthor2.Location = new System.Drawing.Point(257, 52);
            this.lblAuthor2.Name = "lblAuthor2";
            this.lblAuthor2.Size = new System.Drawing.Size(0, 23);
            this.lblAuthor2.TabIndex = 25;
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPenalty.Location = new System.Drawing.Point(257, 438);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(0, 31);
            this.lblPenalty.TabIndex = 24;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDetail.Location = new System.Drawing.Point(136, 251);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(74, 23);
            this.lblDetail.TabIndex = 23;
            this.lblDetail.Text = "Detail :";
            // 
            // lblAva
            // 
            this.lblAva.AutoSize = true;
            this.lblAva.Location = new System.Drawing.Point(8, 397);
            this.lblAva.Name = "lblAva";
            this.lblAva.Size = new System.Drawing.Size(202, 23);
            this.lblAva.TabIndex = 22;
            this.lblAva.Text = "Date Due For Return :";
            // 
            // lblShelf
            // 
            this.lblShelf.AutoSize = true;
            this.lblShelf.Location = new System.Drawing.Point(146, 216);
            this.lblShelf.Name = "lblShelf";
            this.lblShelf.Size = new System.Drawing.Size(64, 23);
            this.lblShelf.TabIndex = 21;
            this.lblShelf.Text = "Shelf :";
            // 
            // lblQnt
            // 
            this.lblQnt.AutoSize = true;
            this.lblQnt.Location = new System.Drawing.Point(88, 350);
            this.lblQnt.Name = "lblQnt";
            this.lblQnt.Size = new System.Drawing.Size(122, 23);
            this.lblQnt.TabIndex = 19;
            this.lblQnt.Text = "Date Issued :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(143, 174);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 23);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price :";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(96, 132);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(114, 23);
            this.lblCat.TabIndex = 10;
            this.lblCat.Text = "Categories :";
            // 
            // lblPub
            // 
            this.lblPub.AutoSize = true;
            this.lblPub.Location = new System.Drawing.Point(89, 90);
            this.lblPub.Name = "lblPub";
            this.lblPub.Size = new System.Drawing.Size(121, 23);
            this.lblPub.TabIndex = 8;
            this.lblPub.Text = "Publication :";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(127, 48);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(83, 23);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author :";
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Location = new System.Drawing.Point(122, 444);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(88, 23);
            this.lblRent.TabIndex = 2;
            this.lblRent.Text = "Penalty :";
            // 
            // FrmStudentBookReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1421, 910);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmStudentBookReport";
            this.Text = "Book Report";
            this.Load += new System.EventHandler(this.FrmStudentBookReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDetail2;
        private System.Windows.Forms.Label lblDateDueForReturn;
        private System.Windows.Forms.PictureBox pictureBoxPic;
        private System.Windows.Forms.Label lblShelf2;
        private System.Windows.Forms.Label lblDateIssued;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Label lblCat2;
        private System.Windows.Forms.Label lblPub2;
        private System.Windows.Forms.Label lblAuthor2;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblAva;
        private System.Windows.Forms.Label lblShelf;
        private System.Windows.Forms.Label lblQnt;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblPub;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblRent;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}