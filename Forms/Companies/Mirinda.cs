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
    public partial class Mirinda : Form
    {
        string company = "Mirinda";
        int quantity = 1;
        string size;
        int price;
        public Mirinda()
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

        private void Mirinda_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true || radioButton3.Checked == true)
            {
                if (radioButton2.Checked == true)
                {
                    size = "250ml";
                    price = 20;
                }
                else
                {
                    size = "500ml";
                    price = 35;
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
