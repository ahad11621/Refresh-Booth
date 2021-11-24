using Refresh_Booth.Repositories;
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
    public partial class Aquafina : Form
    {
        int quantity = 1;
        string company = "Aquafina";
        string size;
        int price;
        public Aquafina()
        {
            InitializeComponent();
        }

        private void Aquafina_Load(object sender, EventArgs e)
        {

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(radioButton3.Checked == true)
            {
                size = "500ml";
                price = 20;
                this.Hide();
                Payment p = new Payment(size,quantity,company,price);
                p.Show();
            }
            else
            {
                MessageBox.Show("Please select one.");
            }
        }
    }
}
