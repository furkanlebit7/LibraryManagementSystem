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
    public partial class FrmStudentBookReport : Form
    {
        public FrmStudentBookReport()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        FrmStudentAccount fsa = new FrmStudentAccount();
        
        private void FrmStudentBookReport_Load(object sender, EventArgs e)
        {
            string stdID = fsa.getData();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BookBarrowID,DateIssued,DateDueForReturn,BookName,BookDetail,BookAuthor,BookAvailable,BookRent From Tbl_BookOutOnLoan INNER JOIN Tbl_Book ON BookID = BorrowBookID where BorrowStudentID='"+stdID+"'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            groupBox1.Visible = true;
            dataGridView1.Visible = false;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string barrowID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            DateTime dayToday = DateTime.Today;

            SqlCommand getBookDetail = new SqlCommand("Select  BookName,BookAuthor,BookPublication,BookCategories,BookPrice,BookShelf,BookDetail,DateIssued,DateDueForReturn,BookPhoto From Tbl_BookOutOnLoan INNER JOIN Tbl_Book ON BookID = BorrowBookID where BookBarrowID=@p1", bgl.baglanti());
            getBookDetail.Parameters.AddWithValue("@p1", barrowID);
            SqlDataReader drGetBookDetail = getBookDetail.ExecuteReader();
            while (drGetBookDetail.Read())
            {
                lblName.Text = drGetBookDetail[0].ToString();
                lblAuthor2.Text = drGetBookDetail[1].ToString();
                lblPub2.Text = drGetBookDetail[2].ToString();
                lblCat2.Text = drGetBookDetail[3].ToString();
                lblPrice2.Text = drGetBookDetail[4].ToString();
                lblShelf2.Text = drGetBookDetail[5].ToString();
                lblDetail2.Text = drGetBookDetail[6].ToString();
                lblDateIssued.Text = drGetBookDetail[7].ToString();
                lblDateDueForReturn.Text = drGetBookDetail[8].ToString();
                pictureBoxPic.ImageLocation = drGetBookDetail[9].ToString();
                String date = drGetBookDetail[8].ToString();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            dataGridView1.Visible = true;
        }
    }
}
