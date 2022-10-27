using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            for (int i = 1; i <= 10; i++)
            {
                if (i % 6 == 0)
                {
                    y += 150;
                    temp = 0;

                }
                RichTextBox newTextBox = new RichTextBox();
                newTextBox.Location = new Point((xPos) * (temp), 40+y);
                newTextBox.Size = new Size(75, 95);
                this.Controls.Add(newTextBox);

                


                Button button = new Button();
                button.Text = i.ToString();
                button.Size = new Size(50, 35);
                button.Location = new Point((xPos) * (temp), 135+y);
                this.Controls.Add(button);
                temp += 1;

            }


        }
    }
}
