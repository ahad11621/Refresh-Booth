﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refresh_Booth.Forms.Admin
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product p = new Product();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sell p = new Sell();
            p.Show();
        }
    }
}
