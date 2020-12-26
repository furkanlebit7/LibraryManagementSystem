namespace libraryManagement
{
    partial class FrmReturnBook
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblSelectPub = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
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
            this.lblStdID = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblBookRent = new System.Windows.Forms.Label();
            this.lblBookAva = new System.Windows.Forms.Label();
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 159);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(519, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return Book";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ıconButton1);
            this.groupBox3.Controls.Add(this.cmbBook);
            this.groupBox3.Controls.Add(this.cmbStudent);
            this.groupBox3.Controls.Add(this.lblBook);
            this.groupBox3.Controls.Add(this.lblSelectPub);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic);
            this.groupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Location = new System.Drawing.Point(272, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(958, 100);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Book";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(893, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Search";
            // 
            // ıconButton1
            // 
            this.ıconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ıconButton1.IconColor = System.Drawing.Color.White;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.IconSize = 40;
            this.ıconButton1.Location = new System.Drawing.Point(871, 25);
            this.ıconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(84, 53);
            this.ıconButton1.TabIndex = 14;
            this.ıconButton1.UseVisualStyleBackColor = true;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // cmbBook
            // 
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(547, 36);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(267, 31);
            this.cmbBook.TabIndex = 13;
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(155, 36);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(267, 31);
            this.cmbStudent.TabIndex = 12;
            this.cmbStudent.SelectedIndexChanged += new System.EventHandler(this.cmbStudent_SelectedIndexChanged);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(480, 39);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(64, 23);
            this.lblBook.TabIndex = 11;
            this.lblBook.Text = "Book :";
            // 
            // lblSelectPub
            // 
            this.lblSelectPub.AutoSize = true;
            this.lblSelectPub.Location = new System.Drawing.Point(28, 39);
            this.lblSelectPub.Name = "lblSelectPub";
            this.lblSelectPub.Size = new System.Drawing.Size(89, 23);
            this.lblSelectPub.TabIndex = 9;
            this.lblSelectPub.Text = "Student :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ıconButton3);
            this.groupBox1.Controls.Add(this.ıconButton2);
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
            this.groupBox1.Location = new System.Drawing.Point(272, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 540);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Informations";
            this.groupBox1.Visible = false;
            // 
            // ıconButton2
            // 
            this.ıconButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ıconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton2.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ıconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ıconButton2.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry;
            this.ıconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton2.IconSize = 60;
            this.ıconButton2.Location = new System.Drawing.Point(616, 434);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Size = new System.Drawing.Size(271, 60);
            this.ıconButton2.TabIndex = 33;
            this.ıconButton2.Text = "Return Book";
            this.ıconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton2.UseVisualStyleBackColor = true;
            this.ıconButton2.Click += new System.EventHandler(this.ıconButton2_Click);
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
            this.pictureBoxPic.Location = new System.Drawing.Point(616, 99);
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
            this.lblName.Location = new System.Drawing.Point(663, 52);
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
            this.lblPenalty.Location = new System.Drawing.Point(255, 438);
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
            // lblStdID
            // 
            this.lblStdID.AutoSize = true;
            this.lblStdID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStdID.Location = new System.Drawing.Point(90, 209);
            this.lblStdID.Name = "lblStdID";
            this.lblStdID.Size = new System.Drawing.Size(122, 13);
            this.lblStdID.TabIndex = 29;
            this.lblStdID.Text = "toKeepBarrowStudentID";
            this.lblStdID.Visible = false;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBookID.Location = new System.Drawing.Point(90, 237);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(110, 13);
            this.lblBookID.TabIndex = 30;
            this.lblBookID.Text = "toKeepBarrowBookID";
            this.lblBookID.Visible = false;
            // 
            // lblBookRent
            // 
            this.lblBookRent.AutoSize = true;
            this.lblBookRent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBookRent.Location = new System.Drawing.Point(78, 302);
            this.lblBookRent.Name = "lblBookRent";
            this.lblBookRent.Size = new System.Drawing.Size(89, 13);
            this.lblBookRent.TabIndex = 32;
            this.lblBookRent.Text = "toKeepBookRent";
            this.lblBookRent.Visible = false;
            // 
            // lblBookAva
            // 
            this.lblBookAva.AutoSize = true;
            this.lblBookAva.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBookAva.Location = new System.Drawing.Point(78, 279);
            this.lblBookAva.Name = "lblBookAva";
            this.lblBookAva.Size = new System.Drawing.Size(109, 13);
            this.lblBookAva.TabIndex = 31;
            this.lblBookAva.Text = "toKeepBookAvailable";
            this.lblBookAva.Visible = false;
            // 
            // ıconButton3
            // 
            this.ıconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ıconButton3.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.ıconButton3.IconColor = System.Drawing.Color.DarkRed;
            this.ıconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton3.IconSize = 50;
            this.ıconButton3.Location = new System.Drawing.Point(893, 15);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Size = new System.Drawing.Size(62, 68);
            this.ıconButton3.TabIndex = 34;
            this.ıconButton3.UseVisualStyleBackColor = true;
            this.ıconButton3.Click += new System.EventHandler(this.ıconButton3_Click);
            // 
            // FrmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1325, 896);
            this.Controls.Add(this.lblBookRent);
            this.Controls.Add(this.lblBookAva);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.lblStdID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmReturnBook";
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.FrmReturnBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblSelectPub;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton ıconButton2;
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
        private System.Windows.Forms.Label lblStdID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblBookRent;
        private System.Windows.Forms.Label lblBookAva;
        private FontAwesome.Sharp.IconButton ıconButton3;
    }
}