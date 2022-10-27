using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunStok
{
    public partial class Form1 : Form
    {
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
    }
}
