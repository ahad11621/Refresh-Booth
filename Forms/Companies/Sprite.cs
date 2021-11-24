using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refresh_Booth.Forms.Companies
{
    public partial class Sprite : Form
    {
        string company = "Sprite";
        int quantity = 1;
        string size;
        int price;
        public Sprite()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                if (radioButton1.Checked == true)
                {
                    size = "200ml";
                    price = 20;
                }
                else if (radioButton2.Checked == true)
                {
                    size = "400ml";
                    price = 30;
                }
                else
                {
                    size = "600ml";
                    price = 40;
                }
                this.Hide();
                Payment p = new Payment(size, quantity, company, price);
                p.Show();
            }
            else
            {
                MessageBox.Show("Please select one.");
            }
        }
    }
}
