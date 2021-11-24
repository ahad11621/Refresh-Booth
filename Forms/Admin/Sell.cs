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

namespace Refresh_Booth.Forms.Admin
{
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            GetTable();
        }
        void GetTable()
        {
            SellRepo pr = new SellRepo();
            dataGridView1.DataSource = pr.GetAllSell();
            dataGridView1.Columns[0].Visible = false;
        }
    }
}
