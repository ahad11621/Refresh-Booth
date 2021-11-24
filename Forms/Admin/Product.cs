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
    public partial class Product : Form
    {
        public Product()
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

        private void Product_Load(object sender, EventArgs e)
        {
            CmbSize();
            CmbCompany();
            txtQuantity.Text = string.Empty;

            GetTable();
        }
        void GetTable()
        {
            ProductRepo pr = new ProductRepo();
            dataGridView1.DataSource = pr.GetAllProduct();
            dataGridView1.Columns[0].Visible = false;
        }
        void CmbSize()
        {  
            cmbSize.Items.Clear();
            cmbSize.Items.Add("200ml");
            cmbSize.Items.Add("250ml");
            cmbSize.Items.Add("400ml");
            cmbSize.Items.Add("500ml");
            cmbSize.Items.Add("600ml");
        }
        void CmbCompany()
        {
            cmbCom.Items.Clear();
            cmbCom.Items.Add("Cocacola");
            cmbCom.Items.Add("Pepsi");
            cmbCom.Items.Add("MountainDew");
            cmbCom.Items.Add("Sprite");
            cmbCom.Items.Add("7up");
            cmbCom.Items.Add("Fanta");
            cmbCom.Items.Add("Mirinda");
            cmbCom.Items.Add("RedBull");
            cmbCom.Items.Add("Aquafina");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if(cmbSize.SelectedItem.ToString() == "" || cmbCom.SelectedItem.ToString() == "" || txtQuantity.Text == "")
            {
                MessageBox.Show("Add your product information.");
                CmbSize();
                CmbCompany();
                txtQuantity.Text = string.Empty;
            }
            else
            {
                string size = cmbSize.SelectedItem.ToString();
                int quantity = Convert.ToInt32(txtQuantity.Text);
                string company = cmbCom.SelectedItem.ToString();

                ProductRepo p = new ProductRepo();
                int q = p.GetProductQuantity(size, company);

                if ((q + quantity) > 20)
                {
                    MessageBox.Show("Quantity cann't be up to 20");
                    CmbSize();
                    CmbCompany();
                    txtQuantity.Text = string.Empty;
                }
                else
                {
                    ProductRepo pr = new ProductRepo();
                    int result = pr.AddProduct(size, quantity, company);
                    if (result > 0)
                    {
                        MessageBox.Show("Update");
                        CmbSize();
                        CmbCompany();
                        txtQuantity.Text = string.Empty;
                        GetTable();
                    }
                    else
                    {
                        MessageBox.Show("Won't work");
                        CmbSize();
                        CmbCompany();
                        txtQuantity.Text = string.Empty;
                    }
                }
            }
        }
    }
}
