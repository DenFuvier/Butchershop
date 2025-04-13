using Butchershop.Classes;
using MySql.Data.MySqlClient;
using System;

using System.Windows.Forms;

namespace Butchershop.Windows
{
    public partial class AddMyaso : Form
    {
        SqlConnector sql = new SqlConnector();
        public AddMyaso()
        {
            InitializeComponent();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = sql.GetConnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                var stm = $"INSERT INTO products (Name , Category , PricePerKg , StockWeight , ArrivalDate) VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}')";
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TRON tRON = new TRON();
            tRON.Show();

        }
    }
}
