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
    }
}
