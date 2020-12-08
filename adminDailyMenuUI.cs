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
    public partial class adminDailyMenuUI : dailyMenuUI
    {
        public adminDailyMenuUI()
        {
            InitializeComponent();
        }

        private void lunchEdit_Click(object sender, EventArgs e)
        {
            lunchEditUI check = new lunchEditUI();
            check.Show();
            this.Hide();
        }
        public override void back_Click(object sender, EventArgs e)
        {
            adminFirstUI Check = new adminFirstUI();
            Check.Show();
            this.Hide();

        }

        private void adminDailyMenuUI_Load(object sender, EventArgs e)
        {

        }
    }
}
