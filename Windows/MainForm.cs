using Butchershop.Classes;
using Butchershop.Windows;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butchershop
{
    public partial class MainForm : Form
    {
        SqlConnector sql = new SqlConnector();
        public MainForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
           
        }
        public void AnalUsers()
        {
            string cs = sql.GetConnect();
            try
            {
                var con = new MySqlConnection(cs);
                con.Open();
                string stm = String.Format("SELECT Name, Login,  Password , Job_title , Job_PROF  FROM users WHERE Login = '{0}' AND password = '{1}'", Login1.Text, Password.Text);
                var cmd = new MySqlCommand(stm ,con);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string Name = reader.GetString(0);
                    string Login = reader.GetString(1);
                    int Password = reader.GetInt32(2);
                    string Job_title = reader.GetString(3);
                    string Job_PROF = reader.GetString(4);
                    Crack(Job_PROF,Job_title);
                }
                else
                {
                    MessageBox.Show("Не верный логин или пароль");
                }
                con.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Crack(string Job_PROF, string Job_title)
        {
            if (Job_PROF == "Администратор")
            {
                Checks(Job_title);
                Admin_GO admin_GO = new Admin_GO();
                admin_GO.Show();
            }
            else if (Job_PROF == "Сотрудник")
            {
                Checks(Job_title);
                DialogsDrop sialogsDrop = new DialogsDrop();
                sialogsDrop.Show();
            }
        }
        public void Checks(string Job_title)
        {
            
            if (Job_title == "Активен")
            {
                MessageBox.Show("Есть доступ");
            }
            else if (Job_title == "Забанен")
            {
                MessageBox.Show("Нету доступа");
            }
        }
        public void CheksT()
        {
            if (string.IsNullOrWhiteSpace(Login1.Text))
            {
                MessageBox.Show("Логин не может быть пустым");
                return;
            }
//_______________________________________________________________________
            if (string.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Пароль не может быть пустым");
                return;
            }

//________________________________________________________________________
        }
        private void Invate_Click(object sender, EventArgs e)
        {
          CheksT();
          AnalUsers();
        }
    }

}
