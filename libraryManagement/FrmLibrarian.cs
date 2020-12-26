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
    public partial class FrmLibrarian : Form
    {
        public FrmLibrarian()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        Frm_Login frL = new Frm_Login();
       // public string lTC;
       public string libTC;
        private void FrmLibrarian_Load(object sender, EventArgs e)
        {


            string lTC = frL.getLibrarian();
            //Gets information to the panel
            SqlCommand GetLibrarian = new SqlCommand("Select * From Tbl_Librarian where LibrarianTC=@p1", bgl.baglanti());
            GetLibrarian.Parameters.AddWithValue("@p1", lTC);
            SqlDataReader GetLibrarianDr = GetLibrarian.ExecuteReader();
            while (GetLibrarianDr.Read())
            {
                lblLibrarian2.Text = GetLibrarianDr[1] + " " + GetLibrarianDr[2];
                lblMail2.Text = GetLibrarianDr[3].ToString();
                lblGender2.Text = GetLibrarianDr[4].ToString();
                lblPhone2.Text = GetLibrarianDr[5].ToString();
                lblTC2.Text = lTC;
                pictureBoxPic.ImageLocation = GetLibrarianDr[8].ToString();

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmLibrarianEdit frle = new FrmLibrarianEdit();
            frle.TCno = lblTC2.Text;
            frle.Show();
        }

       
    }
}
