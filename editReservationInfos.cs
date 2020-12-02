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
    public partial class editReservationInfos : BaseUI
    {
        public editReservationInfos()
        {
            InitializeComponent();
        }

        private void editReservationInfos_Load(object sender, EventArgs e)
        {
            reservationInformations Datas = new reservationInformations();
            Datas = globalData.getResData(globalData.getSelectedTable(), globalData.getSelectedTime());

            textBox1.Text = Datas.getPersonName();
            textBox2.Text = Datas.getTotalPeople();
            textBox3.Text = Datas.getNumber();
            textBox4.Text = Datas.getMail();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            globalData.setTimetableCheck(globalData.getSelectedTable(), globalData.getSelectedTime(), false);
            globalData.setResData(globalData.getSelectedTable(), globalData.getSelectedTime(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

            dialogBoxResSaved Check = new dialogBoxResSaved();
            Check.Show();
            this.Hide();
        }
        public override void back_Click(object sender, EventArgs e)
        {
            adminTableSelectionUI Check = new adminTableSelectionUI();
            Check.Show();
            this.Hide();

        }
    }
}
