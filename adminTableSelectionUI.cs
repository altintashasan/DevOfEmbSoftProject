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
    public partial class adminTableSelectionUI : timetableUI
    {
        public adminTableSelectionUI()
        {
            InitializeComponent();
        }

        private void edit1_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(0);
            editReservationInfos Check = new editReservationInfos();
            Check.Show();
            this.Hide();
        }
        private void edit2_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(1);
            editReservationInfos Check = new editReservationInfos();
            Check.Show();
            this.Hide();
        }
        private void edit3_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(2);
            editReservationInfos Check = new editReservationInfos();
            Check.Show();
            this.Hide();
        }


        private void edit4_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(3);
            editReservationInfos Check = new editReservationInfos();
            Check.Show();
            this.Hide();
        }

        private void edit5_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(4);
            editReservationInfos Check = new editReservationInfos();
            Check.Show();
            this.Hide();
        }

        private void edit6_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(5);
            editReservationInfos Check = new editReservationInfos();
            Check.Show();
            this.Hide();
        }

        private void edit7_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(6);
            editReservationInfos Check = new editReservationInfos();
            Check.Show();
            this.Hide();
        }

        private void edit8_Click(object sender, EventArgs e)
        {

        }

        private void delete1_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(0);
            deleteDecision Check = new deleteDecision();
            Check.Show();
            this.Hide();
        }
        private void delete2_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(1);
            deleteDecision Check = new deleteDecision();
            Check.Show();
            this.Hide();
        }

        private void delete3_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(2);
            deleteDecision Check = new deleteDecision();
            Check.Show();
            this.Hide();
        }


        private void delete4_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(1);
            deleteDecision Check = new deleteDecision();
            Check.Show();
            this.Hide();
        }

        private void delete5_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(4);
            deleteDecision Check = new deleteDecision();
            Check.Show();
            this.Hide();
        }
        private void delete6_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(5);
            deleteDecision Check = new deleteDecision();
            Check.Show();
            this.Hide();
        }
        private void delete7_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(6);
            deleteDecision Check = new deleteDecision();
            Check.Show();
            this.Hide();
        }

        private void delete8_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(7);
            deleteDecision Check = new deleteDecision();
            Check.Show();
            this.Hide();
        }

        public override void back_Click(object sender, EventArgs e)
        {
            adminMainUI Check = new adminMainUI();
            Check.Show();
            this.Hide();

        }

    }
}
