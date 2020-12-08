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
    public partial class adminFirstUI : BaseUI
    {
        public adminFirstUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminDailyMenuUI check = new adminDailyMenuUI();
            check.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminMainUI check = new adminMainUI();
            check.Show();
            this.Hide();
        }
    }
}
