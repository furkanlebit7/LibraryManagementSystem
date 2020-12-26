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
    public partial class FrmReturnBook : Form
    {
        public FrmReturnBook()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void FrmReturnBook_Load(object sender, EventArgs e)
        {

            SqlCommand getBarrowStudent = new SqlCommand("Select DISTINCT StudentName From Tbl_Student INNER JOIN Tbl_BookOutOnLoan ON StudentID = BorrowStudentID", bgl.baglanti());
            SqlDataReader drGetBarrowStudent = getBarrowStudent.ExecuteReader();
            while (drGetBarrowStudent.Read())
            {
                cmbStudent.Items.Add(drGetBarrowStudent[0].ToString());
            }
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbBook.Items.Clear();
            //Get barrow student ID
            SqlCommand getBarrowStudent = new SqlCommand("Select DISTINCT StudentID From Tbl_Student INNER JOIN Tbl_BookOutOnLoan ON StudentID = BorrowStudentID where StudentName=@p1", bgl.baglanti());
            getBarrowStudent.Parameters.AddWithValue("@p1", cmbStudent.Text);
            SqlDataReader drGetBarrowStudent = getBarrowStudent.ExecuteReader();
            while (drGetBarrowStudent.Read())
            {
                lblStdID.Text = drGetBarrowStudent[0].ToString();
            }
            //Get barrow book
            SqlCommand getBarrowBook = new SqlCommand("Select BookName From Tbl_Book INNER JOIN Tbl_BookOutOnLoan ON BorrowBookID=BookID where BorrowStudentID=@p1", bgl.baglanti());
            getBarrowBook.Parameters.AddWithValue("@p1", lblStdID.Text);
            SqlDataReader drGetBarrowBook = getBarrowBook.ExecuteReader();
            while (drGetBarrowBook.Read())
            {
                cmbBook.Items.Add(drGetBarrowBook[0].ToString());
            }
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            SqlCommand getBookInformations = new SqlCommand("Select * From Tbl_Book where BookName=@p1", bgl.baglanti());
            getBookInformations.Parameters.AddWithValue("@p1", cmbBook.Text);
            SqlDataReader drGetBookInformations = getBookInformations.ExecuteReader();
            while (drGetBookInformations.Read())
            {
                lblBookID.Text = drGetBookInformations[0].ToString();
                lblName.Text = drGetBookInformations[1].ToString();
                lblDetail2.Text = drGetBookInformations[2].ToString();
                lblAuthor2.Text = drGetBookInformations[3].ToString();
                lblPub2.Text = drGetBookInformations[4].ToString();
                lblCat2.Text = drGetBookInformations[5].ToString();
                lblPrice2.Text = drGetBookInformations[6].ToString();
                pictureBoxPic.ImageLocation = drGetBookInformations[8].ToString();
                lblShelf2.Text = drGetBookInformations[9].ToString();
            }
            bgl.baglanti().Close();

            DateTime dayToday = DateTime.Today;

            SqlCommand getBarrowBookInformations = new SqlCommand("Select * From Tbl_BookOutOnLoan where BorrowStudentID=@p1 AND BorrowBookID=@p2", bgl.baglanti());
            getBarrowBookInformations.Parameters.AddWithValue("@p1", lblStdID.Text);
            getBarrowBookInformations.Parameters.AddWithValue("@p2", lblBookID.Text);
            SqlDataReader drGetBarrowBookInformations = getBarrowBookInformations.ExecuteReader();
            while (drGetBarrowBookInformations.Read())
            {
                lblDateIssued.Text = drGetBarrowBookInformations[1].ToString();
                lblDateDueForReturn.Text = drGetBarrowBookInformations[2].ToString();
                String date = drGetBarrowBookInformations[2].ToString();
                String[] values = date.Split('.');
                int day = Int16.Parse(values[0]);
                int month = Int16.Parse(values[1]);
                int year = Int16.Parse(values[2]);
                DateTime newDate = new DateTime(year, month, day);
                TimeSpan difference = newDate - dayToday;
                int amountOfFine = Int16.Parse(difference.Days.ToString());
                if (amountOfFine >= 0)
                {
                    lblPenalty.ForeColor = Color.Gainsboro;
                    lblPenalty.Text = "0 $";
                }
                else
                {
                    lblPenalty.ForeColor = Color.Red;
                    lblPenalty.Text = -1 * amountOfFine + "$";
                }
                
                

            }
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            int avaBook=0;
            int rentBook = 0;
            if (lblPenalty.Text!= "0 $")
            {
                DialogResult dialogResult = MessageBox.Show("'" + cmbStudent.Text + "' has '" + lblPenalty.Text + "' Penalty! Are You Sure ? ", "Return Book", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //delete book from out on loan
                    SqlCommand deleteBarrowBook = new SqlCommand("delete From Tbl_BookOutOnLoan where BorrowBookID=@p1 AND BorrowStudentID=@p2", bgl.baglanti());
                    deleteBarrowBook.Parameters.AddWithValue("@p1", lblBookID.Text);
                    deleteBarrowBook.Parameters.AddWithValue("@p2", lblStdID.Text);
                    deleteBarrowBook.ExecuteNonQuery();
                    MessageBox.Show("Book Returned Successfully");
                    groupBox1.Visible = false;
                    cmbStudent.Text = "";
                    cmbBook.Text = "";
                    //getBookquant
                    SqlCommand getBookQuant = new SqlCommand("Select BookAvailable,BookRent From Tbl_Book where BookID=@p1", bgl.baglanti());
                    getBookQuant.Parameters.AddWithValue("@p1", lblBookID.Text);
                    SqlDataReader drGetBookQuant = getBookQuant.ExecuteReader();
                    while (drGetBookQuant.Read())
                    {
                        avaBook = Int16.Parse(drGetBookQuant[0].ToString());
                        rentBook = Int16.Parse(drGetBookQuant[1].ToString());
                    }
                    avaBook += 1;
                    rentBook -= 1;
                    //update book quantities
                    SqlCommand updateBookQuant = new SqlCommand("update Tbl_Book set BookAvailable=@p1,BookRent=@p2 where BookID=@p3", bgl.baglanti());
                    updateBookQuant.Parameters.AddWithValue("@p1", avaBook);
                    updateBookQuant.Parameters.AddWithValue("@p2", rentBook);
                    updateBookQuant.Parameters.AddWithValue("@p3", lblBookID.Text);
                    updateBookQuant.ExecuteNonQuery();
                }
            }
            else
            {
                //delete book from out on loan
                DialogResult dialogResult = MessageBox.Show("Are You Sure", "Return Book", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand deleteBarrowBook2 = new SqlCommand("delete From Tbl_BookOutOnLoan where BorrowBookID=@p1 AND BorrowStudentID=@p2", bgl.baglanti());
                    deleteBarrowBook2.Parameters.AddWithValue("@p1", lblBookID.Text);
                    deleteBarrowBook2.Parameters.AddWithValue("@p2", lblStdID.Text);
                    deleteBarrowBook2.ExecuteNonQuery();
                    MessageBox.Show("Book Returned Successfully");
                    groupBox1.Visible = false;
                    cmbStudent.Text = "";
                    cmbBook.Text = "";
                    //getBookquant
                    SqlCommand getBookQuant = new SqlCommand("Select BookAvailable,BookRent From Tbl_Book where BookID=@p1", bgl.baglanti());
                    getBookQuant.Parameters.AddWithValue("@p1", lblBookID.Text);
                    SqlDataReader drGetBookQuant = getBookQuant.ExecuteReader();
                    while (drGetBookQuant.Read())
                    {
                        avaBook = Int16.Parse(drGetBookQuant[0].ToString());
                        rentBook = Int16.Parse(drGetBookQuant[1].ToString());
                    }
                    avaBook += 1;
                    rentBook -= 1;
                    //update book quantities
                    SqlCommand updateBookQuant = new SqlCommand("update Tbl_Book set BookAvailable=@p1,BookRent=@p2 where BookID=@p3", bgl.baglanti());
                    updateBookQuant.Parameters.AddWithValue("@p1", avaBook);
                    updateBookQuant.Parameters.AddWithValue("@p2", rentBook);
                    updateBookQuant.Parameters.AddWithValue("@p3", lblBookID.Text);
                    updateBookQuant.ExecuteNonQuery();
                }
            }


            
            

        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            cmbBook.Text = "";
            cmbStudent.Text = "";
        }
    }
}
