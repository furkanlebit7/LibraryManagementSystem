namespace libraryManagement
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.ıconButtonAddPublication = new FontAwesome.Sharp.IconButton();
            this.ıconButtonAddBook = new FontAwesome.Sharp.IconButton();
            this.ıconButtonBookReport = new FontAwesome.Sharp.IconButton();
            this.ıconButtonAddBranch = new FontAwesome.Sharp.IconButton();
            this.ıconButtonAddStudent = new FontAwesome.Sharp.IconButton();
            this.ıconButtonStudentReport = new FontAwesome.Sharp.IconButton();
            this.ıconButtonIssueBook = new FontAwesome.Sharp.IconButton();
            this.ıconButtonReturnBook = new FontAwesome.Sharp.IconButton();
            this.ıconButtonLogOut = new FontAwesome.Sharp.IconButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.LblHome = new System.Windows.Forms.Label();
            this.ıconPictureBoxCurrent = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktopForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxCurrent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.ıconButtonAddPublication);
            this.panelMenu.Controls.Add(this.ıconButtonAddBook);
            this.panelMenu.Controls.Add(this.ıconButtonBookReport);
            this.panelMenu.Controls.Add(this.ıconButtonAddBranch);
            this.panelMenu.Controls.Add(this.ıconButtonAddStudent);
            this.panelMenu.Controls.Add(this.ıconButtonStudentReport);
            this.panelMenu.Controls.Add(this.ıconButtonIssueBook);
            this.panelMenu.Controls.Add(this.ıconButtonReturnBook);
            this.panelMenu.Controls.Add(this.ıconButtonLogOut);
            this.panelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(350, 1024);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 126);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(137, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(108, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kelco";
            // 
            // btnHome
            // 
            this.btnHome.Image = global::libraryManagement.Properties.Resources.open_book_png_vectors_and_clipart_for_free_download_162538;
            this.btnHome.Location = new System.Drawing.Point(9, 25);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(115, 90);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ıconButtonAddPublication
            // 
            this.ıconButtonAddPublication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButtonAddPublication.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButtonAddPublication.FlatAppearance.BorderSize = 0;
            this.ıconButtonAddPublication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonAddPublication.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ıconButtonAddPublication.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonAddPublication.IconChar = FontAwesome.Sharp.IconChar.Accusoft;
            this.ıconButtonAddPublication.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonAddPublication.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonAddPublication.IconSize = 32;
            this.ıconButtonAddPublication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonAddPublication.Location = new System.Drawing.Point(3, 135);
            this.ıconButtonAddPublication.Name = "ıconButtonAddPublication";
            this.ıconButtonAddPublication.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ıconButtonAddPublication.Size = new System.Drawing.Size(350, 70);
            this.ıconButtonAddPublication.TabIndex = 1;
            this.ıconButtonAddPublication.Text = "Manage Publication";
            this.ıconButtonAddPublication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonAddPublication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonAddPublication.UseVisualStyleBackColor = true;
            this.ıconButtonAddPublication.Click += new System.EventHandler(this.ıconButtonAddPublication_Click);
            // 
            // ıconButtonAddBook
            // 
            this.ıconButtonAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButtonAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButtonAddBook.FlatAppearance.BorderSize = 0;
            this.ıconButtonAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonAddBook.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ıconButtonAddBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonAddBook.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.ıconButtonAddBook.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonAddBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonAddBook.IconSize = 32;
            this.ıconButtonAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonAddBook.Location = new System.Drawing.Point(3, 211);
            this.ıconButtonAddBook.Name = "ıconButtonAddBook";
            this.ıconButtonAddBook.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ıconButtonAddBook.Size = new System.Drawing.Size(350, 70);
            this.ıconButtonAddBook.TabIndex = 2;
            this.ıconButtonAddBook.Text = "Add Book";
            this.ıconButtonAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonAddBook.UseVisualStyleBackColor = true;
            this.ıconButtonAddBook.Click += new System.EventHandler(this.ıconButtonAddBook_Click);
            // 
            // ıconButtonBookReport
            // 
            this.ıconButtonBookReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButtonBookReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButtonBookReport.FlatAppearance.BorderSize = 0;
            this.ıconButtonBookReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonBookReport.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ıconButtonBookReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonBookReport.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.ıconButtonBookReport.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonBookReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonBookReport.IconSize = 32;
            this.ıconButtonBookReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonBookReport.Location = new System.Drawing.Point(3, 287);
            this.ıconButtonBookReport.Name = "ıconButtonBookReport";
            this.ıconButtonBookReport.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ıconButtonBookReport.Size = new System.Drawing.Size(350, 70);
            this.ıconButtonBookReport.TabIndex = 3;
            this.ıconButtonBookReport.Text = "Book Report";
            this.ıconButtonBookReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonBookReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonBookReport.UseVisualStyleBackColor = true;
            this.ıconButtonBookReport.Click += new System.EventHandler(this.ıconButtonBookReport_Click);
            // 
            // ıconButtonAddBranch
            // 
            this.ıconButtonAddBranch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButtonAddBranch.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButtonAddBranch.FlatAppearance.BorderSize = 0;
            this.ıconButtonAddBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonAddBranch.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ıconButtonAddBranch.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonAddBranch.IconChar = FontAwesome.Sharp.IconChar.AcquisitionsIncorporated;
            this.ıconButtonAddBranch.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonAddBranch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonAddBranch.IconSize = 32;
            this.ıconButtonAddBranch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonAddBranch.Location = new System.Drawing.Point(3, 363);
            this.ıconButtonAddBranch.Name = "ıconButtonAddBranch";
            this.ıconButtonAddBranch.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ıconButtonAddBranch.Size = new System.Drawing.Size(350, 70);
            this.ıconButtonAddBranch.TabIndex = 4;
            this.ıconButtonAddBranch.Text = "Manage Categorie";
            this.ıconButtonAddBranch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonAddBranch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonAddBranch.UseVisualStyleBackColor = true;
            this.ıconButtonAddBranch.Click += new System.EventHandler(this.ıconButtonAddBranch_Click);
            // 
            // ıconButtonAddStudent
            // 
            this.ıconButtonAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButtonAddStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButtonAddStudent.FlatAppearance.BorderSize = 0;
            this.ıconButtonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonAddStudent.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ıconButtonAddStudent.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonAddStudent.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.ıconButtonAddStudent.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonAddStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonAddStudent.IconSize = 32;
            this.ıconButtonAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonAddStudent.Location = new System.Drawing.Point(3, 439);
            this.ıconButtonAddStudent.Name = "ıconButtonAddStudent";
            this.ıconButtonAddStudent.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ıconButtonAddStudent.Size = new System.Drawing.Size(350, 70);
            this.ıconButtonAddStudent.TabIndex = 5;
            this.ıconButtonAddStudent.Text = "Add Student";
            this.ıconButtonAddStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonAddStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonAddStudent.UseVisualStyleBackColor = true;
            this.ıconButtonAddStudent.Click += new System.EventHandler(this.ıconButtonAddStudent_Click);
            // 
            // ıconButtonStudentReport
            // 
            this.ıconButtonStudentReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButtonStudentReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButtonStudentReport.FlatAppearance.BorderSize = 0;
            this.ıconButtonStudentReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonStudentReport.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ıconButtonStudentReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonStudentReport.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ıconButtonStudentReport.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonStudentReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonStudentReport.IconSize = 32;
            this.ıconButtonStudentReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonStudentReport.Location = new System.Drawing.Point(3, 515);
            this.ıconButtonStudentReport.Name = "ıconButtonStudentReport";
            this.ıconButtonStudentReport.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ıconButtonStudentReport.Size = new System.Drawing.Size(350, 70);
            this.ıconButtonStudentReport.TabIndex = 6;
            this.ıconButtonStudentReport.Text = "Student Report";
            this.ıconButtonStudentReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonStudentReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonStudentReport.UseVisualStyleBackColor = true;
            this.ıconButtonStudentReport.Click += new System.EventHandler(this.ıconButtonStudentReport_Click);
            // 
            // ıconButtonIssueBook
            // 
            this.ıconButtonIssueBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButtonIssueBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButtonIssueBook.FlatAppearance.BorderSize = 0;
            this.ıconButtonIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonIssueBook.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ıconButtonIssueBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonIssueBook.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.ıconButtonIssueBook.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonIssueBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonIssueBook.IconSize = 32;
            this.ıconButtonIssueBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonIssueBook.Location = new System.Drawing.Point(3, 591);
            this.ıconButtonIssueBook.Name = "ıconButtonIssueBook";
            this.ıconButtonIssueBook.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ıconButtonIssueBook.Size = new System.Drawing.Size(350, 70);
            this.ıconButtonIssueBook.TabIndex = 7;
            this.ıconButtonIssueBook.Text = "Issue Book";
            this.ıconButtonIssueBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonIssueBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonIssueBook.UseVisualStyleBackColor = true;
            this.ıconButtonIssueBook.Click += new System.EventHandler(this.ıconButtonIssueBook_Click);
            // 
            // ıconButtonReturnBook
            // 
            this.ıconButtonReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButtonReturnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButtonReturnBook.FlatAppearance.BorderSize = 0;
            this.ıconButtonReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonReturnBook.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ıconButtonReturnBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonReturnBook.IconChar = FontAwesome.Sharp.IconChar.History;
            this.ıconButtonReturnBook.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonReturnBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonReturnBook.IconSize = 32;
            this.ıconButtonReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonReturnBook.Location = new System.Drawing.Point(3, 667);
            this.ıconButtonReturnBook.Name = "ıconButtonReturnBook";
            this.ıconButtonReturnBook.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ıconButtonReturnBook.Size = new System.Drawing.Size(350, 70);
            this.ıconButtonReturnBook.TabIndex = 9;
            this.ıconButtonReturnBook.Text = "Return Book";
            this.ıconButtonReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonReturnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonReturnBook.UseVisualStyleBackColor = true;
            this.ıconButtonReturnBook.Click += new System.EventHandler(this.ıconButtonReturnBook_Click);
            // 
            // ıconButtonLogOut
            // 
            this.ıconButtonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıconButtonLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButtonLogOut.FlatAppearance.BorderSize = 0;
            this.ıconButtonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButtonLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonLogOut.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.ıconButtonLogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconButtonLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButtonLogOut.IconSize = 32;
            this.ıconButtonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonLogOut.Location = new System.Drawing.Point(3, 743);
            this.ıconButtonLogOut.Name = "ıconButtonLogOut";
            this.ıconButtonLogOut.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.ıconButtonLogOut.Size = new System.Drawing.Size(350, 70);
            this.ıconButtonLogOut.TabIndex = 11;
            this.ıconButtonLogOut.Text = "LogOut";
            this.ıconButtonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButtonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButtonLogOut.UseVisualStyleBackColor = true;
            this.ıconButtonLogOut.Click += new System.EventHandler(this.ıconButtonLogOut_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelTop.Controls.Add(this.LblHome);
            this.panelTop.Controls.Add(this.ıconPictureBoxCurrent);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(350, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1221, 75);
            this.panelTop.TabIndex = 1;
            // 
            // LblHome
            // 
            this.LblHome.AutoSize = true;
            this.LblHome.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblHome.Location = new System.Drawing.Point(70, 24);
            this.LblHome.Name = "LblHome";
            this.LblHome.Size = new System.Drawing.Size(74, 33);
            this.LblHome.TabIndex = 1;
            this.LblHome.Text = "Home";
            // 
            // ıconPictureBoxCurrent
            // 
            this.ıconPictureBoxCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ıconPictureBoxCurrent.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconPictureBoxCurrent.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ıconPictureBoxCurrent.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconPictureBoxCurrent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBoxCurrent.IconSize = 63;
            this.ıconPictureBoxCurrent.Location = new System.Drawing.Point(8, 11);
            this.ıconPictureBoxCurrent.Name = "ıconPictureBoxCurrent";
            this.ıconPictureBoxCurrent.Size = new System.Drawing.Size(65, 63);
            this.ıconPictureBoxCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ıconPictureBoxCurrent.TabIndex = 0;
            this.ıconPictureBoxCurrent.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(350, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1221, 14);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktopForm
            // 
            this.panelDesktopForm.AutoScroll = true;
            this.panelDesktopForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktopForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopForm.Location = new System.Drawing.Point(350, 89);
            this.panelDesktopForm.Name = "panelDesktopForm";
            this.panelDesktopForm.Size = new System.Drawing.Size(1221, 935);
            this.panelDesktopForm.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 1024);
            this.Controls.Add(this.panelDesktopForm);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelco Library";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBoxCurrent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton ıconButtonAddPublication;
        private FontAwesome.Sharp.IconButton ıconButtonAddBook;
        private FontAwesome.Sharp.IconButton ıconButtonBookReport;
        private FontAwesome.Sharp.IconButton ıconButtonAddBranch;
        private FontAwesome.Sharp.IconButton ıconButtonAddStudent;
        private FontAwesome.Sharp.IconButton ıconButtonStudentReport;
        private FontAwesome.Sharp.IconButton ıconButtonIssueBook;
        private FontAwesome.Sharp.IconButton ıconButtonReturnBook;
        private FontAwesome.Sharp.IconButton ıconButtonLogOut;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label LblHome;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBoxCurrent;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktopForm;
    }
}

