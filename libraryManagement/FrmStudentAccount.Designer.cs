
namespace libraryManagement
{
    partial class FrmStudentAccount
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.pictureBoxPic = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDepartment2 = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblTC2 = new System.Windows.Forms.Label();
            this.lblPhone2 = new System.Windows.Forms.Label();
            this.lblGender2 = new System.Windows.Forms.Label();
            this.lblMail2 = new System.Windows.Forms.Label();
            this.lblLibrarian2 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblLibrarian = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 159);
            this.panel1.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(614, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(281, 85);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(604, 360);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(259, 47);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit Account";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pictureBoxPic
            // 
            this.pictureBoxPic.Location = new System.Drawing.Point(604, 44);
            this.pictureBoxPic.Name = "pictureBoxPic";
            this.pictureBoxPic.Size = new System.Drawing.Size(259, 271);
            this.pictureBoxPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPic.TabIndex = 9;
            this.pictureBoxPic.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.pictureBoxPic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDepartment2);
            this.groupBox1.Controls.Add(this.lblDepartment);
            this.groupBox1.Controls.Add(this.lblTC2);
            this.groupBox1.Controls.Add(this.lblPhone2);
            this.groupBox1.Controls.Add(this.lblGender2);
            this.groupBox1.Controls.Add(this.lblMail2);
            this.groupBox1.Controls.Add(this.lblLibrarian2);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.lblLibrarian);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(316, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 451);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Informations";
            // 
            // lblDepartment2
            // 
            this.lblDepartment2.AutoSize = true;
            this.lblDepartment2.Location = new System.Drawing.Point(211, 386);
            this.lblDepartment2.Name = "lblDepartment2";
            this.lblDepartment2.Size = new System.Drawing.Size(0, 23);
            this.lblDepartment2.TabIndex = 23;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(23, 386);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(127, 23);
            this.lblDepartment.TabIndex = 22;
            this.lblDepartment.Text = "Department :";
            // 
            // lblTC2
            // 
            this.lblTC2.AutoSize = true;
            this.lblTC2.Location = new System.Drawing.Point(211, 329);
            this.lblTC2.Name = "lblTC2";
            this.lblTC2.Size = new System.Drawing.Size(0, 23);
            this.lblTC2.TabIndex = 21;
            // 
            // lblPhone2
            // 
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.Location = new System.Drawing.Point(211, 272);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.Size = new System.Drawing.Size(0, 23);
            this.lblPhone2.TabIndex = 20;
            // 
            // lblGender2
            // 
            this.lblGender2.AutoSize = true;
            this.lblGender2.Location = new System.Drawing.Point(211, 215);
            this.lblGender2.Name = "lblGender2";
            this.lblGender2.Size = new System.Drawing.Size(0, 23);
            this.lblGender2.TabIndex = 19;
            // 
            // lblMail2
            // 
            this.lblMail2.AutoSize = true;
            this.lblMail2.Location = new System.Drawing.Point(211, 158);
            this.lblMail2.Name = "lblMail2";
            this.lblMail2.Size = new System.Drawing.Size(0, 23);
            this.lblMail2.TabIndex = 18;
            // 
            // lblLibrarian2
            // 
            this.lblLibrarian2.AutoSize = true;
            this.lblLibrarian2.Location = new System.Drawing.Point(211, 101);
            this.lblLibrarian2.Name = "lblLibrarian2";
            this.lblLibrarian2.Size = new System.Drawing.Size(0, 23);
            this.lblLibrarian2.TabIndex = 17;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(104, 329);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(46, 23);
            this.lblTC.TabIndex = 10;
            this.lblTC.Text = "TC :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(75, 272);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(75, 23);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(65, 215);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(85, 23);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Gender :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(70, 158);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(80, 23);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "E-mail :";
            // 
            // lblLibrarian
            // 
            this.lblLibrarian.AutoSize = true;
            this.lblLibrarian.Location = new System.Drawing.Point(61, 101);
            this.lblLibrarian.Name = "lblLibrarian";
            this.lblLibrarian.Size = new System.Drawing.Size(89, 23);
            this.lblLibrarian.TabIndex = 2;
            this.lblLibrarian.Text = "Student :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(211, 44);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 23);
            this.lblID.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID :";
            // 
            // FrmStudentAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1325, 896);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmStudentAccount";
            this.Text = "My Account";
            this.Load += new System.EventHandler(this.FrmStudentAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.PictureBox pictureBoxPic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDepartment2;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblTC2;
        private System.Windows.Forms.Label lblPhone2;
        private System.Windows.Forms.Label lblGender2;
        private System.Windows.Forms.Label lblMail2;
        private System.Windows.Forms.Label lblLibrarian2;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblLibrarian;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
    }
}