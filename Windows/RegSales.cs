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
    public partial class RegSales : Form
    {   SqlConnector sql = new SqlConnector();
        public RegSales()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
        }
        private void button1_MouseEnter(object sender, EventArgs e) { button1.BackColor = ColorTranslator.FromHtml("#8B0000"); button1.ForeColor = Color.White; }
        private void button1_MouseLeave(object sender, EventArgs e) { button1.BackColor = ColorTranslator.FromHtml("#FFF5E1"); button1.ForeColor = Color.Black; }
        private void button2_MouseEnter(object sender, EventArgs e) { button2.BackColor = ColorTranslator.FromHtml("#8B0000"); button2.ForeColor = Color.White; }
        private void button2_MouseLeave(object sender, EventArgs e) { button2.BackColor = ColorTranslator.FromHtml("#FFF5E1"); button2.ForeColor = Color.Black; } 
        private void button2_Click(object sender, EventArgs e)
        {
           this.Hide();
           Salesss salesss = new Salesss();
            salesss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = sql.GetConnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                var stm = $"INSERT INTO sales (ProductID , WeightSold , TotalPrice , SaleDate ) VALUES ('{ProductID.Text}' , '{WeightSold.Text}' , '{TotalPrice.Text}' , '{SaleDate.Text}')";
                var cmd = new MySqlCommand(stm , con); 
                MySqlDataReader reader = cmd.ExecuteReader();
                MessageBox.Show("Всё добавлено");
                con.Close();
            } 
            catch(Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
        }
    }
}
