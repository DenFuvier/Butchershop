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
    public partial class DialogsDrop : Form
    {
        public DialogsDrop()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseEnter += button1_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            button2.MouseEnter += button2_MouseEnter;
            button3.MouseLeave += button3_MouseLeave;
            button3.MouseEnter += button3_MouseEnter;
            button4.MouseLeave += button4_MouseLeave;
            button4.MouseEnter += button4_MouseEnter;
            button1.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            button2.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            button3.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            button4.BackColor = ColorTranslator.FromHtml("#FFF5E1");
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
        private void button2_Click(object sender, EventArgs e)
        {
          this.Hide();
            Salesss salesss = new Salesss();
            salesss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TRON tRON = new TRON();
            tRON.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void DialogsDrop_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
