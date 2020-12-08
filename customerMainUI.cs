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
    public partial class customerMainUI : DevApp.BaseUI
    {
        public customerMainUI()
        {
            InitializeComponent();
        }

        private void showDailyMenu_Click(object sender, EventArgs e)
        {
            dailyMenuUI Check = new dailyMenuUI();
            Check.Show();
            this.Hide();
        }

        private void makeReservation_Click(object sender, EventArgs e)
        {

            tableSelection Check = new tableSelection();
            Check.Show();
            this.Hide();
        }

        public override void back_Click(object sender, EventArgs e)
        {
            adminCustomerSelection Check = new adminCustomerSelection();
            Check.Show();
            this.Hide();

        }

        private void customerMainUI_Load(object sender, EventArgs e)
        {

        }
    }
}
