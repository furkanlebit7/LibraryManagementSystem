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
    public partial class FrmStudentAccount : Form
    {
        public FrmStudentAccount()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        Frm_Login frl = new Frm_Login();
        public string sTC;
        public static string data="";
        private void FrmStudentAccount_Load(object sender, EventArgs e)
        {

            sTC = frl.getStudent();
            //Gets information to the panel
            SqlCommand GetLibrarian = new SqlCommand("Select StudentID,StudentName,StudentSurname,StudentEmail,StudentGender,StudentPhone,StudentDepartment,StudentPicture From Tbl_Student where StudentTC=@p1", bgl.baglanti());
            GetLibrarian.Parameters.AddWithValue("@p1", sTC);
            SqlDataReader GetLibrarianDr = GetLibrarian.ExecuteReader();
            while (GetLibrarianDr.Read())
            {
                lblID.Text = GetLibrarianDr[0].ToString();
                lblLibrarian2.Text = GetLibrarianDr[1] + " " + GetLibrarianDr[2];
                lblMail2.Text = GetLibrarianDr[3].ToString();
                lblGender2.Text = GetLibrarianDr[4].ToString();
                lblPhone2.Text = GetLibrarianDr[5].ToString();
                lblDepartment2.Text = GetLibrarianDr[6].ToString();
                lblTC2.Text = sTC;
                pictureBoxPic.ImageLocation = GetLibrarianDr[7].ToString();

            }
             data = lblID.Text;

        }
        public string getData()
        {
            return data;
        }




        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmStudentEditAccount fsea = new FrmStudentEditAccount();
            fsea.TCno = lblTC2.Text;
            fsea.ShowDialog();
        }
    }
}
