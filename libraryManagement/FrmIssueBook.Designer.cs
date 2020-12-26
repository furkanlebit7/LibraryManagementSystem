namespace libraryManagement
{
    partial class FrmIssueBook
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
            this.pictureBoxPic = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDetail2 = new System.Windows.Forms.Label();
            this.lblAva2 = new System.Windows.Forms.Label();
            this.lblShelf2 = new System.Windows.Forms.Label();
            this.lblQnt2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lblCat2 = new System.Windows.Forms.Label();
            this.lblPub2 = new System.Windows.Forms.Label();
            this.lblAuthor2 = new System.Windows.Forms.Label();
            this.lblRent2 = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblAva = new System.Windows.Forms.Label();
            this.lblShelf = new System.Windows.Forms.Label();
            this.lblQnt = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblPub = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.cmbPub = new System.Windows.Forms.ComboBox();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblSelectPub = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
            this.lblDays = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(570, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Issue";
            // 
            // pictureBoxPic
            // 
            this.pictureBoxPic.Location = new System.Drawing.Point(609, 104);
            this.pictureBoxPic.Name = "pictureBoxPic";
            this.pictureBoxPic.Size = new System.Drawing.Size(295, 282);
            this.pictureBoxPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPic.TabIndex = 24;
            this.pictureBoxPic.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDetail2);
            this.groupBox1.Controls.Add(this.lblAva2);
            this.groupBox1.Controls.Add(this.pictureBoxPic);
            this.groupBox1.Controls.Add(this.lblShelf2);
            this.groupBox1.Controls.Add(this.lblQnt2);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblPrice2);
            this.groupBox1.Controls.Add(this.lblCat2);
            this.groupBox1.Controls.Add(this.lblPub2);
            this.groupBox1.Controls.Add(this.lblAuthor2);
            this.groupBox1.Controls.Add(this.lblRent2);
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
            this.groupBox1.Location = new System.Drawing.Point(252, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 471);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Informations";
            this.groupBox1.Visible = false;
            // 
            // lblDetail2
            // 
            this.lblDetail2.AutoSize = true;
            this.lblDetail2.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDetail2.Location = new System.Drawing.Point(181, 363);
            this.lblDetail2.MaximumSize = new System.Drawing.Size(270, 100);
            this.lblDetail2.Name = "lblDetail2";
            this.lblDetail2.Size = new System.Drawing.Size(0, 23);
            this.lblDetail2.TabIndex = 32;
            // 
            // lblAva2
            // 
            this.lblAva2.AutoSize = true;
            this.lblAva2.Location = new System.Drawing.Point(181, 292);
            this.lblAva2.Name = "lblAva2";
            this.lblAva2.Size = new System.Drawing.Size(0, 23);
            this.lblAva2.TabIndex = 31;
            // 
            // lblShelf2
            // 
            this.lblShelf2.AutoSize = true;
            this.lblShelf2.Location = new System.Drawing.Point(181, 185);
            this.lblShelf2.Name = "lblShelf2";
            this.lblShelf2.Size = new System.Drawing.Size(0, 23);
            this.lblShelf2.TabIndex = 30;
            // 
            // lblQnt2
            // 
            this.lblQnt2.AutoSize = true;
            this.lblQnt2.Location = new System.Drawing.Point(181, 256);
            this.lblQnt2.Name = "lblQnt2";
            this.lblQnt2.Size = new System.Drawing.Size(0, 23);
            this.lblQnt2.TabIndex = 29;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Location = new System.Drawing.Point(603, 48);
            this.lblName.MaximumSize = new System.Drawing.Size(0, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(180, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Book Name ";
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Location = new System.Drawing.Point(181, 153);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(0, 23);
            this.lblPrice2.TabIndex = 28;
            // 
            // lblCat2
            // 
            this.lblCat2.AutoSize = true;
            this.lblCat2.Location = new System.Drawing.Point(181, 118);
            this.lblCat2.Name = "lblCat2";
            this.lblCat2.Size = new System.Drawing.Size(0, 23);
            this.lblCat2.TabIndex = 27;
            // 
            // lblPub2
            // 
            this.lblPub2.AutoSize = true;
            this.lblPub2.Location = new System.Drawing.Point(181, 84);
            this.lblPub2.Name = "lblPub2";
            this.lblPub2.Size = new System.Drawing.Size(0, 23);
            this.lblPub2.TabIndex = 26;
            // 
            // lblAuthor2
            // 
            this.lblAuthor2.AutoSize = true;
            this.lblAuthor2.Location = new System.Drawing.Point(181, 48);
            this.lblAuthor2.Name = "lblAuthor2";
            this.lblAuthor2.Size = new System.Drawing.Size(0, 23);
            this.lblAuthor2.TabIndex = 25;
            // 
            // lblRent2
            // 
            this.lblRent2.AutoSize = true;
            this.lblRent2.Location = new System.Drawing.Point(181, 329);
            this.lblRent2.Name = "lblRent2";
            this.lblRent2.Size = new System.Drawing.Size(0, 23);
            this.lblRent2.TabIndex = 24;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDetail.Location = new System.Drawing.Point(57, 363);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(74, 23);
            this.lblDetail.TabIndex = 23;
            this.lblDetail.Text = "Detail :";
            // 
            // lblAva
            // 
            this.lblAva.AutoSize = true;
            this.lblAva.Location = new System.Drawing.Point(28, 292);
            this.lblAva.Name = "lblAva";
            this.lblAva.Size = new System.Drawing.Size(103, 23);
            this.lblAva.TabIndex = 22;
            this.lblAva.Text = "Available :";
            // 
            // lblShelf
            // 
            this.lblShelf.AutoSize = true;
            this.lblShelf.Location = new System.Drawing.Point(67, 185);
            this.lblShelf.Name = "lblShelf";
            this.lblShelf.Size = new System.Drawing.Size(64, 23);
            this.lblShelf.TabIndex = 21;
            this.lblShelf.Text = "Shelf :";
            // 
            // lblQnt
            // 
            this.lblQnt.AutoSize = true;
            this.lblQnt.Location = new System.Drawing.Point(31, 256);
            this.lblQnt.Name = "lblQnt";
            this.lblQnt.Size = new System.Drawing.Size(100, 23);
            this.lblQnt.TabIndex = 19;
            this.lblQnt.Text = "Quantity :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(64, 153);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 23);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price :";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(17, 118);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(114, 23);
            this.lblCat.TabIndex = 10;
            this.lblCat.Text = "Categories :";
            // 
            // lblPub
            // 
            this.lblPub.AutoSize = true;
            this.lblPub.Location = new System.Drawing.Point(10, 84);
            this.lblPub.Name = "lblPub";
            this.lblPub.Size = new System.Drawing.Size(121, 23);
            this.lblPub.TabIndex = 8;
            this.lblPub.Text = "Publication :";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(48, 48);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(83, 23);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author :";
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Location = new System.Drawing.Point(69, 329);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(62, 23);
            this.lblRent.TabIndex = 2;
            this.lblRent.Text = "Rent :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.ıconButton1);
            this.groupBox3.Controls.Add(this.cmbBook);
            this.groupBox3.Controls.Add(this.cmbPub);
            this.groupBox3.Controls.Add(this.lblBook);
            this.groupBox3.Controls.Add(this.lblSelectPub);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic);
            this.groupBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Location = new System.Drawing.Point(252, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(958, 100);
            this.groupBox3.TabIndex = 26;
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
            // cmbPub
            // 
            this.cmbPub.FormattingEnabled = true;
            this.cmbPub.Location = new System.Drawing.Point(155, 36);
            this.cmbPub.Name = "cmbPub";
            this.cmbPub.Size = new System.Drawing.Size(267, 31);
            this.cmbPub.TabIndex = 12;
            this.cmbPub.SelectedIndexChanged += new System.EventHandler(this.cmbPub_SelectedIndexChanged);
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
            this.lblSelectPub.Size = new System.Drawing.Size(121, 23);
            this.lblSelectPub.TabIndex = 9;
            this.lblSelectPub.Text = "Publication :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbStudent);
            this.groupBox2.Controls.Add(this.txtDays);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.ıconButton2);
            this.groupBox2.Controls.Add(this.lblDays);
            this.groupBox2.Controls.Add(this.cmbDepartment);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic);
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(252, 758);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(958, 100);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Student";
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(466, 40);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(214, 31);
            this.cmbStudent.TabIndex = 22;
            this.cmbStudent.SelectedIndexChanged += new System.EventHandler(this.cmbStudent_SelectedIndexChanged);
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(784, 42);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(81, 29);
            this.txtDays.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(897, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Issue";
            // 
            // ıconButton2
            // 
            this.ıconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ıconButton2.IconChar = FontAwesome.Sharp.IconChar.YinYang;
            this.ıconButton2.IconColor = System.Drawing.Color.White;
            this.ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton2.IconSize = 40;
            this.ıconButton2.Location = new System.Drawing.Point(871, 28);
            this.ıconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Size = new System.Drawing.Size(84, 53);
            this.ıconButton2.TabIndex = 16;
            this.ıconButton2.UseVisualStyleBackColor = true;
            this.ıconButton2.Click += new System.EventHandler(this.ıconButton2_Click);
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(721, 43);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(66, 23);
            this.lblDays.TabIndex = 20;
            this.lblDays.Text = "Days :";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(128, 40);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(214, 31);
            this.cmbDepartment.TabIndex = 18;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Department :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Student :";
            // 
            // FrmIssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1325, 896);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmIssueBook";
            this.Text = "Issue Book";
            this.Load += new System.EventHandler(this.FrmIssueBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxPic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblShelf;
        private System.Windows.Forms.Label lblQnt;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblPub;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAva;
        private System.Windows.Forms.Label lblDetail2;
        private System.Windows.Forms.Label lblAva2;
        private System.Windows.Forms.Label lblShelf2;
        private System.Windows.Forms.Label lblQnt2;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Label lblCat2;
        private System.Windows.Forms.Label lblPub2;
        private System.Windows.Forms.Label lblAuthor2;
        private System.Windows.Forms.Label lblRent2;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.ComboBox cmbPub;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblSelectPub;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}