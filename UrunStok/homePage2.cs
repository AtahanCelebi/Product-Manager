using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public homePage2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int y = 0;
            int x=0;
            int xPos = 90;
            int temp = 0;
            for (int i = 0; i < productNameList.Count; i++)
            {
                if (i % 5 == 0)
                {
                    y += 150;
                    temp = 0;

                }
                RichTextBox newTextBox = new RichTextBox();
                newTextBox.Location = new Point((xPos) * (temp), 40+y);
                newTextBox.Size = new Size(75, 95);
                newTextBox.Text= productNameList[i].ToString();
                this.Controls.Add(newTextBox);

                


                Button button = new Button();
                button.Text = "Sepete Ekle";
                button.Size = new Size(50, 35);
                button.Location = new Point((xPos) * (temp), 135+y);
                this.Controls.Add(button);
                temp += 1;

            }


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
                productNameList.Add(readar1["productName"].ToString());
                productPriceList.Add(readar1["productPrice"].ToString());
                productStockList.Add(readar1["productStock"].ToString());
                
            }

            
        }
    }
}
