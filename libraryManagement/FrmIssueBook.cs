using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace libraryManagement
{
    public partial class FrmIssueBook : Form
    {
        public FrmIssueBook()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        string borrowStudentID;
        string borrowBookID;
        static int howManyDay;
        int bookAvailable;
        int bookRent;
        private void FrmIssueBook_Load(object sender, EventArgs e)
        {
            //Gets Publications from DataBase
            SqlCommand getPub = new SqlCommand("Select PublicationName From Tbl_Publication", bgl.baglanti());
            SqlDataReader drgetPub = getPub.ExecuteReader();
            while (drgetPub.Read())
            {
                cmbPub.Items.Add(drgetPub[0]);
            }
            bgl.baglanti().Close();
            //Gets Departments from DataBase
            SqlCommand getDep = new SqlCommand("Select DepartmentName From Tbl_Department", bgl.baglanti());
            SqlDataReader drGetDep = getDep.ExecuteReader();
            while (drGetDep.Read())
            {
                cmbDepartment.Items.Add(drGetDep[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmbPub_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBook.Items.Clear();
            //Gets Books from data base as it's categorie
            SqlCommand getCat = new SqlCommand("Select BookName From Tbl_Book where BookPublication=@p1", bgl.baglanti());
            getCat.Parameters.AddWithValue("@p1", cmbPub.Text);
            SqlDataReader drgetCat = getCat.ExecuteReader();
            while (drgetCat.Read())
            {
                cmbBook.Items.Add(drgetCat[0]);
            }
            bgl.baglanti().Close();
        }

        

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            SqlCommand getBook = new SqlCommand("Select * From Tbl_Book where BookName=@p1", bgl.baglanti());
            getBook.Parameters.AddWithValue("@p1", cmbBook.Text);
            SqlDataReader drGetBook = getBook.ExecuteReader();
            while (drGetBook.Read())
            {
                lblAuthor2.Text = drGetBook[3].ToString();
                lblPub2.Text = drGetBook[4].ToString();
                lblCat2.Text = drGetBook[5].ToString();
                lblPrice2.Text = drGetBook[6].ToString();
                lblShelf2.Text = drGetBook[9].ToString();
                lblQnt2.Text = drGetBook[7].ToString();
                lblAva2.Text = drGetBook[10].ToString();
                lblRent2.Text = drGetBook[11].ToString();
                lblDetail2.Text = drGetBook[2].ToString();
                pictureBoxPic.ImageLocation = drGetBook[8].ToString();
                lblName.Text = drGetBook[1].ToString();


                borrowBookID = drGetBook[0].ToString();
                bookAvailable = Int16.Parse(drGetBook[10].ToString());
                bookRent = Int16.Parse(drGetBook[11].ToString());
            }
            bgl.baglanti().Close();
        }
        
        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStudent.Items.Clear();
            SqlCommand getStudent = new SqlCommand("Select StudentName From Tbl_Student where StudentDepartment=@p1", bgl.baglanti());
            getStudent.Parameters.AddWithValue("@p1", cmbDepartment.Text);
            SqlDataReader drGetStudent = getStudent.ExecuteReader();
            while (drGetStudent.Read())
            {
                cmbStudent.Items.Add(drGetStudent[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand getStudentID = new SqlCommand("Select StudentID From Tbl_Student where StudentDepartment=@p1", bgl.baglanti());
            getStudentID.Parameters.AddWithValue("@p1", cmbDepartment.Text);
            SqlDataReader drgetStudentID = getStudentID.ExecuteReader();
            while (drgetStudentID.Read())
            {
                borrowStudentID = drgetStudentID[0].ToString();
            }
            bgl.baglanti().Close();
        }

        


        
        private void ıconButton2_Click(object sender, EventArgs e)
        {

            howManyDay = Int32.Parse(txtDays.Text);
            DateTime dateIssue = DateTime.Today;
            DateTime dateReturn = DateTime.Today.AddDays(howManyDay);
            //Book Issue to student
            SqlCommand bookBarrow = new SqlCommand("insert into Tbl_BookOutOnLoan (DateIssued,DateDueForReturn,BorrowBookID,BorrowStudentID) " +
                "values (@p1,@p2,@p3,@p4) ", bgl.baglanti());
            bookBarrow.Parameters.AddWithValue("@p1", dateIssue.ToString("d"));
            bookBarrow.Parameters.AddWithValue("@p2", dateReturn.ToString("d"));
            bookBarrow.Parameters.AddWithValue("@p3", borrowBookID);
            bookBarrow.Parameters.AddWithValue("@p4", borrowStudentID);

            bookBarrow.ExecuteNonQuery();
            bgl.baglanti().Close();

            cmbDepartment.Text = "";
            cmbStudent.Text = "";
            txtDays.Clear();
            
            bookAvailable -= 1;
            bookRent += 1;

            //Update Book Quantities,available,rent
            SqlCommand updateBook = new SqlCommand("update Tbl_Book set BookAvailable=@p1,BookRent=@p2 where BookID=@p3", bgl.baglanti());
            updateBook.Parameters.AddWithValue("@p1", bookAvailable);
            updateBook.Parameters.AddWithValue("@p2", bookRent);
            updateBook.Parameters.AddWithValue("@p3", borrowBookID);
            updateBook.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Successful");
        }

        
    }
}
