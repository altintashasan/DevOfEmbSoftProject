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
    public partial class reservationInformationsUI : DevApp.BaseUI
    {
        public reservationInformationsUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            globalData.setTimetableCheck(globalData.getSelectedTable(), globalData.getSelectedTime(), false);
            globalData.setResData(globalData.getSelectedTable(), globalData.getSelectedTime(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

            dialogBoxResSaved Check = new dialogBoxResSaved();
            Check.Show();
            this.Hide();
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public override void back_Click(object sender, EventArgs e)
        {
            timetableUI Check = new timetableUI();
            Check.Show();
            this.Hide();

        }
    }
}
