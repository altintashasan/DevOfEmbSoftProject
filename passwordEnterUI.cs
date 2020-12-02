using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevApp
{
    public partial class passwordEnterUI : Form
    {
        public passwordEnterUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminMainUI Check1 = new adminMainUI();
            if(textBox1.Text == "12345")
            {
                Check1.Show();
                this.Hide();
            }
            else
            {
                string message = "Authorization Denied!";
                string title = "Wrong Password";
                MessageBox.Show(message, title);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminCustomerSelection Check = new adminCustomerSelection();
            Check.Show();
            this.Hide();
        }
    }
}
