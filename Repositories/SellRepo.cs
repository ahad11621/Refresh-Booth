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
    class SellRepo
    {
        DataAccess dataAccess;
        public SellRepo()
        {
            dataAccess = new DataAccess();
        }
        //Get all Sell (Admin-Sell)
        public List<Product> GetAllSell()
        {
            try
            {
                string sql = "SELECT * FROM sell";
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
    }
}
