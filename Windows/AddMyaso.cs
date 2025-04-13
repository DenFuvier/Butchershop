using Butchershop.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Butchershop.Windows
{
    public partial class AddMyaso : Form
    {
        SqlConnector sql = new SqlConnector();
        public AddMyaso()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            button1.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            button2.BackColor = ColorTranslator.FromHtml("#FFF5E1");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#8B0000");
            button1.ForeColor =  Color.White;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            button1.ForeColor = Color.Black;
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml("#8B0000");
            button2.ForeColor = Color.White;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            button2.ForeColor = Color.Black;
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
