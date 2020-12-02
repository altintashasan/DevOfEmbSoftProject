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
    public partial class dailyMenuUI : DevApp.BaseUI
    {
        public dailyMenuUI()
        {
            InitializeComponent();
        }

        private void lunch_Click(object sender, EventArgs e)
        {
            lunchUI Check = new lunchUI();
           
            Check.Show();

            this.Hide();
            
        }

        private void dinner_Click(object sender, EventArgs e)
        {
            dinnerUI Check = new dinnerUI();

            Check.Show();

            this.Hide();
        }

        public override void back_Click(object sender, EventArgs e)
        {
            customerMainUI Check = new customerMainUI();
            Check.Show();
            this.Hide();

        }

        private void dailyMenuUI_Load(object sender, EventArgs e)
        {

            
        }
    }
}
