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
            this.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;

            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;

            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += dataGridView1_CellMouseLeave;
            dataGridView1.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;            
        }
        private void button1_MouseEnter(object sender, EventArgs e) { button1.BackColor = ColorTranslator.FromHtml("#8B0000"); button1.ForeColor = Color.White; }
        private void button1_MouseLeave(object sender, EventArgs e) { button1.BackColor = ColorTranslator.FromHtml("#FFF5E1"); button1.ForeColor = Color.Black; }
        private void button2_MouseEnter(object sender, EventArgs e) { button2.BackColor = ColorTranslator.FromHtml("#8B0000"); button2.ForeColor = Color.White; }
        private void button2_MouseLeave(object sender, EventArgs e) { button2.BackColor = ColorTranslator.FromHtml("#FFF5E1"); button2.ForeColor = Color.Black; }
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = ColorTranslator.FromHtml("#8B0000");
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
            }
        }
        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        { if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
           { 
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
           }
        }
        private void dataGridView1_CellMouseLeave(object sender, EventArgs e) { }
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

        private void button2_Click(object sender, EventArgs e)
        {
          this.Hide();
          DialogsDrop dialogsDrop = new DialogsDrop();
          dialogsDrop.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegSales regSales = new RegSales();
            regSales.Show();
        }
    }
}
