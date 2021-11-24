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
    public partial class RedBull : Form
    {
        string company = "RedBull";
        int quantity = 1;
        string size;
        int price;
        public RedBull()
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
            if (radioButton3.Checked == true)
            {
                size = "200ml";
                price = 200;
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
