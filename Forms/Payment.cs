using Refresh_Booth.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refresh_Booth.Forms
{
    public partial class Payment : Form
    {
        string size, company;
        int quantity, price;
        public Payment()
        {
            InitializeComponent();
        }
        public Payment(string size, int quantity, string company, int price)
        {
            InitializeComponent();
            this.size = size;
            this.quantity = quantity;
            this.company = company;
            this.price = price;
        }
        static Regex Valid_Number = NumbersOnly();
        //Method for numbers only validation
        private static Regex NumbersOnly()
        {
            string StringAndNumber_Pattern = "^[0-9]*$";

            return new Regex(StringAndNumber_Pattern, RegexOptions.IgnoreCase);
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

        private void Payment_Load(object sender, EventArgs e)
        {
            lblPrice.Text = price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtAmount.Text == "")
            {
                MessageBox.Show("Please, Pay your amount");
            }
            else
            {
                if (Valid_Number.IsMatch(txtAmount.Text) != true)
                {
                    MessageBox.Show("Amount acccept numbers only.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAmount.Focus();
                    return;
                }
                else
                {
                    if (price == Convert.ToInt32(txtAmount.Text))
                    {
                        ProductRepo pr = new ProductRepo();
                        int result = pr.SellProduct(size, quantity, company);
                        SellRepo sr = new SellRepo();
                        int result1 = sr.SellProduct(size, quantity, company);
                        if (result == result1)
                        {
                            MessageBox.Show("Thank you for shopping here.\n Enjoy your drink.");
                            this.Hide();
                            Home h = new Home();
                            h.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pay the right price");
                    }
                }
            }
        }
    }
}
