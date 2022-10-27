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
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        userManager userMngr = new userManager();
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (checkIfExsist(txtMail.Text, txtNickName.Text))
            {
                if (txtPasswordCheck.Text == txtPassword.Text)
                {
                    UserClass user = new UserClass();
                    user.userName = txtNickName.Text;
                    user.email = txtMail.Text;
                    user.password = txtPassword.Text;
                    user.nickName = txtNickName.Text;

                    userMngr.CreateUser(user);
                    Clear();
                    btnSignIn.Enabled = true;
                    btnSignIn.BackColor = Color.Green;
                    MessageBox.Show("Başarıyla Kayıt Oldunuz", "üyelik oluşturuldu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Şifreleriniz Uyuşmuyor", "Şifre uyuşmuyor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Üyelik Mevcut", "Bu üyelik daha önce alınmış ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        public bool checkIfExsist(string mail,string nickName)
        {

            SqlConnection conn1 = new SqlConnection("Server=DESKTOP-LKOHK1C;Database=stok;Trusted_Connection=True;");

            conn1.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT nickName,email FROM userInfo WHERE nickName=@nName OR email=@mail",conn1);
            cmd1.Parameters.AddWithValue("@nName",nickName);
            cmd1.Parameters.AddWithValue("@mail", mail);
            SqlDataReader readar1;
            readar1 = cmd1.ExecuteReader();
            if (readar1.Read())
            {
                if(mail == readar1["email"].ToString() || nickName == readar1["nickName"].ToString())
                {
                    return false;
                }
                return true;
            }
            else
            {
                return true;
            }
        }

        void Clear()
        {
            txtMail.Clear();
            txtNameSurname.Clear();
            txtNickName.Clear();
            txtPassword.Clear();
            txtPasswordCheck.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            homePage homepage = new homePage();
            homepage.Show();
        }
    }
}
