using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunStok
{
    public partial class homePage2 : Form
    {
        List<string> productNameList = new List<string>();
        List<string> productPriceList = new List<string>();
        List<string> productStockList = new List<string>();
        int sepettekiUrunSayisi = 0;
        string currentUserName;
        string currentPassword;
        string currentSepetTutari;
        string currentUrunSayisi;
        public homePage2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        
        private void homePage2_Load(object sender, EventArgs e)
        {
            SqlConnection conn1 = new SqlConnection("Server=DESKTOP-LKOHK1C;Database=stok;Trusted_Connection=True;");

            conn1.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT productName,productPrice,productStock FROM product", conn1);
            SqlDataReader readar1;
            readar1 = cmd1.ExecuteReader();
            while (readar1.Read())
            {
                //Adding all datas to list from product table
                productNameList.Add(readar1["productName"].ToString());
                productPriceList.Add(readar1["productPrice"].ToString());
                productStockList.Add(readar1["productStock"].ToString());
                
            }
            load_products();
            
        }

        void load_products()
        {
            int y = 0;
            int x = 0;
            int xPos = 90;
            int temp = 0;
            for (int i = 0; i < productNameList.Count; i++)
            {
                if (i % 5 == 0)
                {
                    y += 190;
                    temp = 0;

                }
                RichTextBox newTextBox = new RichTextBox();
                newTextBox.Location = new Point((xPos) * (temp), -90 + y);
                newTextBox.Size = new Size(75, 95);
                newTextBox.Text = productNameList[i].ToString();
                this.Controls.Add(newTextBox);

                Label newLabel = new Label();
                newLabel.Location = new Point((xPos+10) * (temp), 10 + y);
                newLabel.Text= productPriceList[i].ToString();
                newLabel.Name = "label" + i.ToString();
                this.Controls.Add(newLabel);


                Button button = new Button();
                button.Text = "Sepete Ekle";
                button.Name = "btnProduct" + i.ToString();
                button.Size = new Size(50, 35);
                button.Location = new Point((xPos) * (temp), 40 + y);
                button.Click += new EventHandler(button_Click);
                void button_Click(object sender, EventArgs e)
                {
                    Button btn = sender as Button;
                    // identify which button was clicked and perform necessary actions
                    //number of items in the user's bucket
                    int sepettekiUrunsayisi = Int32.Parse(txtSepettekiUrunSayisi.Text)+1;
                    txtSepettekiUrunSayisi.Text = sepettekiUrunsayisi.ToString();

                    //exmp: label0 means first product of the product-view page
                    string thePrice = btn.Name.Substring(btn.Name.Length-1);
                    string theLabel = "label" + thePrice;

                    //assign attribute to tags with name dynamically
                    Label lbl_text = this.Controls.Find(theLabel, true).FirstOrDefault() as Label;
                    //You can access 'lbl_text' here...
                    int sepetTutari = Int32.Parse(txtSepetTutari.Text);
                    txtSepetTutari.Text = "";
                    txtSepetTutari.Text += (Int32.Parse(lbl_text.Text)+sepetTutari).ToString();

                }
                //button.Click += (s, e) => { 
                //    sepettekiUrunSayisi++;
                //    txtSepettekiUrunSayisi.Text = sepettekiUrunSayisi.ToString();
                //    txtSepetTutari.Text = productPriceList[i].ToString();
                //};

                this.Controls.Add(button);
                temp += 1;

            }
        }

        private void btnSepet_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlDataAdapter adapter;
            DataTable dt;
            SqlCommand cmd;
                conn = new SqlConnection();
                conn.ConnectionString = "Server=DESKTOP-LKOHK1C;Database=stok;Trusted_Connection=True;";

                cmd = new SqlCommand();
            cmd.CommandText = "UPDATE userInfo SET kisiSepetTutari=@sepetTutari, kisiSepetUrunSayisi=@urunSayisi WHERE userName=@uName AND user_password=@uPassword";
                cmd.Parameters.AddWithValue("@sepetTutari", Int32.Parse(txtSepetTutari.Text));
                cmd.Parameters.AddWithValue("@urunSayisi", Int32.Parse(txtSepettekiUrunSayisi.Text));
                cmd.Parameters.AddWithValue("@uName", currentUserName);
                cmd.Parameters.AddWithValue("@uPassword", currentPassword);

            cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            MessageBox.Show("Başarıyla Kayıt Oldunuz", "üyelik oluşturuldu", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public void get_userName(string userName, string password, string urunTutari,string urunSayisi)
        {
            currentUserName = userName;
            currentPassword = password;
            currentSepetTutari = urunTutari;
            currentUrunSayisi = urunSayisi;

            txtSepettekiUrunSayisi.Text = currentUrunSayisi;
            txtSepetTutari.Text = currentSepetTutari;
        }
    }
}
