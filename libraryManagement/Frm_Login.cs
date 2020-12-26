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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        public static string studentTC = "";
        public static string librarianTC = "";
        private void ıconButton2_Click(object sender, EventArgs e)
        {
            greenButton1.Visible = true;
            greenButton2.Visible = false;
            gbLibrarian.Visible = false;
            gbStudent.Visible = true;
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void ıconButton7_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select * From Tbl_Student Where StudentTC=@p1 and StudentPassword=@p2", bgl.baglanti());

            komut2.Parameters.AddWithValue("@p1", mskTC.Text);
            komut2.Parameters.AddWithValue("@p2", txtPas.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                studentTC = mskTC.Text;
                Form2 fr2 = new Form2();
                fr2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid TC or Password");
            }
            bgl.baglanti().Close();

        }
        public string getStudent()
        {
            return studentTC;
        }
        

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            gbLibrarian.Visible = true;
            gbStudent.Visible = false;
            greenButton1.Visible = false;
            greenButton2.Visible = true;
            
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            greenButton1.Visible = false;
            greenButton2.Visible = false;
            gbLibrarian.Visible = false;
        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            greenButton1.Visible = false;
            greenButton2.Visible = false;
            gbStudent.Visible = false;
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select * From Tbl_Librarian Where LibrarianTC=@p1 and LibrarianPassword=@p2", bgl.baglanti());

            komut1.Parameters.AddWithValue("@p1", mskTC2.Text);
            komut1.Parameters.AddWithValue("@p2", txtPas2.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            if (dr1.Read())
            {
                librarianTC = mskTC2.Text;
                Form1 fr1 = new Form1();
                fr1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid TC or Password");
            }
            bgl.baglanti().Close();
        }

        public string getLibrarian()
        {
            return librarianTC;
        }
    }
}
