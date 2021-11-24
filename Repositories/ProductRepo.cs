using ATM_System.Data;
using MySql.Data.MySqlClient;
using Refresh_Booth.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh_Booth.Repositories
{
    class ProductRepo
    {
        DataAccess dataAccess;
        public ProductRepo()
        {
            dataAccess = new DataAccess();
        }
        //Get all Product (Admin-Product)
        public List<Product> GetAllProduct()
        {
            try
            {
                string sql = "SELECT * FROM product";
                MySqlDataReader reader = dataAccess.GetData(sql);
                List<Product> pra = new List<Product>();
                while (reader.Read())
                {
                    Product pr = new Product();
                    pr.Company = reader["Company"].ToString();
                    pr.S200ml = (int)reader["S200ml"];
                    pr.S250ml = (int)reader["S250ml"];
                    pr.S400ml = (int)reader["S400ml"];
                    pr.S500ml = (int)reader["S500ml"];
                    pr.S600ml = (int)reader["S600ml"];

                    pra.Add(pr);
                }
                return pra;
            }
            catch (Exception)
            {
                return null;
            }
        }
        //Add Product (Admin-Product)
        public int AddProduct(string size, int quantity, string company)
        {
            try
            {
                string sql = "UPDATE product SET S" + size + " = S" + size + " + '" + quantity + "' WHERE Company='" + company + "'";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        // Get Product Quantity (Admin-Product)
        public int GetProductQuantity(string size, string company)
        {
            string sql = "SELECT S" + size + " FROM product WHERE Company='" + company + "'";
            MySqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            int quantity = (int)reader["S" + size + ""];
            return quantity;
        }
        //Sell Product (Companies)
        public int SellProduct(string size, int quantity, string company)
        {
            try
            {
                string sql = "UPDATE product SET S" + size + " = S" + size + " - '" + quantity + "' WHERE Company='" + company + "'";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
