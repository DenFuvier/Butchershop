using Butchershop.Classes;
using MySql.Data.MySqlClient;
using System;
using Word = Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Butchershop.Windows
{
    public partial class Admin_GO : Form
    {
        public Admin_GO()
        {
            InitializeComponent();
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            button3.MouseEnter += button3_MouseEnter;
            button3.MouseLeave += button3_MouseLeave;
            button4.MouseEnter += button4_MouseEnter;
            button4.MouseLeave += button4_MouseLeave;
            button1.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            button2.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            button3.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            button4.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            this.BackColor = ColorTranslator.FromHtml("#FFF5E1");

        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#8B0000");
            button1.ForeColor = Color.White;
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
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = ColorTranslator.FromHtml("#8B0000");
            button3.ForeColor = Color.White;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            button3.ForeColor = Color.Black;
        }
        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = ColorTranslator.FromHtml("#8B0000");
            button4.ForeColor = Color.White;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            button4.ForeColor = Color.Black;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Now.AddDays(-7); // За последнюю неделю
            DateTime endDate = DateTime.Now;

            string cs = new SqlConnector().GetConnect();
            List<(DateTime Date, decimal Total)> salesData = new List<(DateTime, decimal)>();

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                string query = $"SELECT SaleDate, SUM(TotalPrice) FROM sales WHERE SaleDate BETWEEN '{startDate:yyyy-MM-dd}' AND '{endDate:yyyy-MM-dd}' GROUP BY SaleDate";
                var cmd = new MySqlCommand(query, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    salesData.Add((reader.GetDateTime(0), reader.GetDecimal(1)));
                }
            }

            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Add();
            doc.Content.Text = $"Отчёт о выручке за период: {startDate:dd.MM.yyyy} - {endDate:dd.MM.yyyy}\n\n";

            foreach (var item in salesData)
            {
                doc.Content.Text += $"{item.Date:dd.MM.yyyy}: {item.Total} руб.\n";
            }

            wordApp.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cs = new SqlConnector().GetConnect();
            List<(string ProductName, decimal TotalSold)> topProducts = new List<(string, decimal)>();

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                string query = "SELECT p.Name, SUM(s.WeightSold) as Sold FROM sales s JOIN products p ON s.ProductID = p.ID GROUP BY p.Name ORDER BY Sold DESC LIMIT 5";
                var cmd = new MySqlCommand(query, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    topProducts.Add((reader.GetString(0), reader.GetDecimal(1)));
                }
            }

            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Add();
            doc.Content.Text = "Топ 5 продаваемых товаров:\n\n";

            foreach (var item in topProducts)
            {
                doc.Content.Text += $"{item.ProductName} — {item.TotalSold} кг\n";
            }

            wordApp.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cs = new SqlConnector().GetConnect();
            List<(string Name, decimal Stock)> stockList = new List<(string, decimal)>();

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                string query = "SELECT Name, StockWeight FROM products ORDER BY StockWeight DESC";
                var cmd = new MySqlCommand(query, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    stockList.Add((reader.GetString(0), reader.GetDecimal(1)));
                }
            }

            Word.Application wordApp = new Word.Application();
            Word.Document doc = wordApp.Documents.Add();
            doc.Content.Text = "Остатки на складе:\n\n";

            foreach (var item in stockList)
            {
                doc.Content.Text += $"{item.Name}: {item.Stock} кг\n";
            }

            wordApp.Visible = true;
        }
    }
}
