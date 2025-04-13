using Butchershop.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butchershop.Windows
{
    public partial class Salesss : Form
    {
        SqlConnector sql = new SqlConnector();
        List<Sales> sales_ = new List<Sales>();
        public Salesss()
        {
            InitializeComponent();
            loadSales();
        }
        private void loadSales()
        {
            string cs = sql.GetConnect();
            try
            { 

                var con = new MySqlConnection(cs);
                con.Open();
                string stm = "SELECT * FROM sales";
                var cmd = new MySqlCommand(stm,con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                  int ID = reader.GetInt32(0);
                  int ProductID = reader.GetInt32(1);
                  int WeightSold = reader.GetInt32(2);
                  int TotalPrice = reader.GetInt32(3);
                  DateTime SaleDate = reader.GetDateTime(4);
                  Sales SS = new Sales
                  {
                      ID = ID,
                      ProductID = ProductID,
                      WeightSold = WeightSold,
                      TotalPrice = TotalPrice,
                      SaleDate = SaleDate
                  };
                    sales_.Add(SS);
                }
                con.Close();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = sales_;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
