using Butchershop.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butchershop.Windows
{
    public partial class ChanfInfo : Form
    {
        SqlConnector sql = new SqlConnector();
        public ChanfInfo(string id ,string Name , string Category, string PricePerKg , string StockWeight , string ArrivalDate)
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            ID.Text = id;
            NameBox.Text = Name;
            CategoryBox.Text = Category;
            PriceBox.Text = PricePerKg;
            TovarBox.Text = StockWeight;
            Date_bro.Text = ArrivalDate;
            ID.Hide();
            ID.ReadOnly = true;
        }
        private void POP()
        {
            string cs = sql.GetConnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                var stm = "UPDATE products SET " +
                    $"Name = '{NameBox.Text}' , " +
                    $"Category = '{CategoryBox.Text}' , " +
                    $"PricePerKg = '{PriceBox.Text}' , " +
                    $"StockWeight = '{TovarBox.Text}' , " +
                    $"ArrivalDate = '{Date_bro.Text}' " +
                    $"WHERE ID = {ID.Text}";
                var cmd = new MySqlCommand(stm, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Успешно добавлено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            POP();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TRON tRON = new TRON();
            tRON.Show();
        }
    }
}
