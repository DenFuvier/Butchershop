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
            button1.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            button2.BackColor = ColorTranslator.FromHtml("#FFF5E1");
            button3.BackColor = ColorTranslator.FromHtml("#FFF5E1");
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
    }
}
