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
    public partial class deleteDecision : Form
    {
        public deleteDecision()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminTableSelectionUI Check = new adminTableSelectionUI();
            Check.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            globalData.setTimetableCheck(globalData.getSelectedTable(), globalData.getSelectedTime(), true);
            globalData.setResData(globalData.getSelectedTable(), globalData.getSelectedTime(), "no name", "no name", "no name", "no name");
            
            adminTableSelectionUI Check = new adminTableSelectionUI();
            Check.Show();
            this.Hide();
        }
    }
}
