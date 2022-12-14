using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunStok
{
    public partial class Form1 : Form
    {
        string get_user_name;
        string get_password;
        string get_urunSayisi;
        string get_sepetTutari;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            signUp f = new signUp();
            f.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            homePage homepage = new homePage();
            homepage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkAdmins(txtUserName.Text, txtPassword.Text))
            {
                adminPage adminpage = new adminPage();  
                adminpage.Show();
            }
            else if (checkIfExsist(txtUserName.Text, txtPassword.Text))
            {
                
                homePage2 frm = new homePage2();
                frm.get_userName(get_user_name,get_password,get_sepetTutari,get_urunSayisi);
                frm.Show();

            }
            else
            {
                
                MessageBox.Show("Bilgileriniz Yanlış", "Girmiş olduğunuz bilgiler yanlış\nya da mevcut değil",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        public bool checkIfExsist(string userName, string password)
        {

            SqlConnection conn1 = new SqlConnection("Server=DESKTOP-LKOHK1C;Database=stok;Trusted_Connection=True;");

            conn1.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT userName,user_password,kisiSepetTutari,kisiSepetUrunSayisi FROM userInfo WHERE userName=@nName OR user_password=@password", conn1);
            cmd1.Parameters.AddWithValue("@nName", userName);
            cmd1.Parameters.AddWithValue("@password", password);
            SqlDataReader readar1;
            readar1 = cmd1.ExecuteReader();
            if (readar1.Read())
            {
                if (userName == readar1["userName"].ToString() && password == readar1["user_password"].ToString())
                {
                    get_user_name = userName;
                    get_password = password;
                    get_sepetTutari = readar1["kisiSepetTutari"].ToString();
                    get_urunSayisi = readar1["kisiSepetUrunSayisi"].ToString();

                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public bool checkAdmins(string userName, string password)
        {
            SqlConnection conn1 = new SqlConnection("Server=DESKTOP-LKOHK1C;Database=stok;Trusted_Connection=True;");

            conn1.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT adminUserName,adminPassword FROM admins WHERE adminUserName=@nName OR adminPassword=@password", conn1);
            cmd1.Parameters.AddWithValue("@nName", userName);
            cmd1.Parameters.AddWithValue("@password", password);
            SqlDataReader readar1;
            readar1 = cmd1.ExecuteReader();
            if (readar1.Read())
            {
                if (userName == readar1["adminUserName"].ToString() && password == readar1["adminPassword"].ToString())
                {
                    get_user_name = userName;
                    get_password = password;

                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
