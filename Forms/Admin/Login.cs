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

namespace Refresh_Booth.Forms.Admin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Id or Password can not be empty.");
            }
            else
            {
                if (Regex.Match(txtId.Text, @"^[0-9]{6}$").Success && Regex.Match(txtPassword.Text, @"^[0-9]{4}$").Success)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    int pass = Convert.ToInt32(txtPassword.Text);
                    if(id == 123456 && pass == 1234)
                    {
                        this.Hide();
                        Home h = new Home();
                        h.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Id and password.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID and Password");
                }
            }
        }
    }
}
