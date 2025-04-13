using Butchershop.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Butchershop.Windows
{
    public partial class TRON : Form
    {
        SqlConnector sql = new SqlConnector();
        List<Products> products_ = new List<Products>();
        public TRON()
        {
            InitializeComponent();
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            LoadUS();
            GG.ReadOnly = true;
            GG.DoubleClick += GG_DoubleClick;
            ////////////////////

           
        }
        private void GG_DoubleClick(object sender, EventArgs e)
        {
         int number = GG.CurrentRow.Index;
            Products X = products_[number];
            string id = X.ID.ToString();
            string Name = X.Name.ToString();
            string Category = X.Category.ToString();
            string PricePerKg = X.PricePerKg.ToString();
            string StockWeight = X.StockWeight.ToString();
            string ArrivalDate = X.ArrivalDate.ToString("yyyy-MM-dd");
            this.Hide();
            ChanfInfo css =new ChanfInfo(id, Name, Category, PricePerKg, StockWeight, ArrivalDate);
            css.Show();
        }
       
        private void LoadUS()
        {
            string cs = sql.GetConnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                string stm = "SELECT * FROM products";
                var cmd = new MySqlCommand(stm,con);
                MySqlDataReader READER = cmd.ExecuteReader();
                while (READER.Read())
                {
                 int ID  = READER.GetInt32(0);
                 string NAME = READER.GetString(1);
                 string Category = READER.GetString(2);
                 int Price = READER.GetInt32(3);
                 int StoclWeiht = READER.GetInt32(4);
                 DateTime ArruvalDate = READER.GetDateTime(5);

                 Products pro = new Products
                 {
                     ID = ID,
                     Name = NAME,
                     Category = Category,
                     PricePerKg = Price,
                     StockWeight = StoclWeiht,
                     ArrivalDate = ArruvalDate
                 };
                    products_.Add(pro);
                }
                GG.DataSource = null;
                GG.DataSource = products_;
                con.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMyaso addMyaso = new AddMyaso();
            addMyaso.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

    }
}
