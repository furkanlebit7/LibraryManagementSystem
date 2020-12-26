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
    public partial class FrmBookReport : Form
    {
        public FrmBookReport()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBookReport_Load(object sender, EventArgs e)
        {
            //Get Publications from database to cmbBox
            SqlCommand getPub = new SqlCommand("Select PublicationName From Tbl_Publication", bgl.baglanti());
            SqlDataReader drGetPub = getPub.ExecuteReader();
            while (drGetPub.Read())
            {
                cmbPublication.Items.Add(drGetPub[0].ToString());
                cmbPublication2.Items.Add(drGetPub[0].ToString());
            }
            //Get Categorie from database to cmbBox
            SqlCommand getCat = new SqlCommand("Select CategorieName From Tbl_Categorie", bgl.baglanti());
            SqlDataReader drGetCat = getCat.ExecuteReader();
            while (drGetCat.Read())
            {
                cmbCategories.Items.Add(drGetCat[0].ToString());
                cmbCategories2.Items.Add(drGetCat[0].ToString());
            }
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            dataGridView1.Visible = true;
            //Add books on data dable
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BookID, BookName, BookAuthor, BookPublication,BookCategories From Tbl_Book where BookPublication='"+cmbPublication.Text+"' and BookCategories='"+cmbCategories.Text+"' ",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Visible = false;
            groupBox1.Visible = true;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string bookID = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            //Get student informations from database
            SqlCommand getBookInformations = new SqlCommand("Select * From Tbl_Book where BookID=@p1", bgl.baglanti());
            getBookInformations.Parameters.AddWithValue("@p1", bookID);
            SqlDataReader drGetBookInformations = getBookInformations.ExecuteReader();
            while (drGetBookInformations.Read())
            {
                lblBookID.Text = drGetBookInformations[0].ToString();
                txtName.Text = drGetBookInformations[1].ToString();
                txtAuthor.Text = drGetBookInformations[3].ToString();
                cmbPublication2.Text = drGetBookInformations[4].ToString();
                cmbCategories2.Text = drGetBookInformations[5].ToString();
                txtPrice.Text = drGetBookInformations[6].ToString();
                txtShelf.Text= drGetBookInformations[9].ToString();
                txtQuant.Text= drGetBookInformations[7].ToString();
                txtAva.Text= drGetBookInformations[10].ToString();
                txtRent.Text= drGetBookInformations[11].ToString();
                rchDetail.Text = drGetBookInformations[2].ToString();
                pictureBoxPic.ImageLocation= drGetBookInformations[8].ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            dataGridView1.Visible = true;
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            lblDosyaName.Text = openFileDialog1.FileName;
            pictureBoxPic.ImageLocation = openFileDialog1.FileName;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            //edit Book informations
            SqlCommand updateBook = new SqlCommand("update Tbl_Book set BookName=@p1,BookDetail=@p2,BookAuthor=@p3,BookPublication=@p4," +
                "BookCategories=@p5, BookPrice=@p6, BookQuantity=@p7, BookPhoto=@p8, BookShelf=@p9, BookAvailable=@p10, BookRent=@p11 where BookID=@p12", bgl.baglanti());
            updateBook.Parameters.AddWithValue("@p12", lblBookID.Text);
            updateBook.Parameters.AddWithValue("@p1", txtName.Text);
            updateBook.Parameters.AddWithValue("@p2", rchDetail.Text);
            updateBook.Parameters.AddWithValue("@p3", txtAuthor.Text);
            updateBook.Parameters.AddWithValue("@p4", cmbPublication2.Text);
            updateBook.Parameters.AddWithValue("@p5", cmbCategories2.Text);
            updateBook.Parameters.AddWithValue("@p6", txtPrice.Text);
            updateBook.Parameters.AddWithValue("@p7", txtQuant.Text);
            updateBook.Parameters.AddWithValue("@p8", lblDosyaName.Text);
            updateBook.Parameters.AddWithValue("@p9", txtShelf.Text);
            updateBook.Parameters.AddWithValue("@p10", txtAva.Text);
            updateBook.Parameters.AddWithValue("@p11", txtRent.Text);
            updateBook.ExecuteNonQuery();
            bgl.baglanti().Close();
            cmbPublication.Text = "";
            cmbCategories.Text = "";
            groupBox1.Visible = false;
            MessageBox.Show("Successful");
        }

        
    }
}
