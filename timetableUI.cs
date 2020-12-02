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
    public partial class timetableUI : DevApp.BaseUI
    {
        public timetableUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(0);
            reservationInformationsUI Check = new reservationInformationsUI();
            Check.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(1);
            reservationInformationsUI Check = new reservationInformationsUI();
            Check.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(2);
            reservationInformationsUI Check = new reservationInformationsUI();
            Check.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(3);
            reservationInformationsUI Check = new reservationInformationsUI();
            Check.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(4);
            reservationInformationsUI Check = new reservationInformationsUI();
            Check.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(5);
            reservationInformationsUI Check = new reservationInformationsUI();
            Check.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(6);
            reservationInformationsUI Check = new reservationInformationsUI();
            Check.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTime(7);
            reservationInformationsUI Check = new reservationInformationsUI();
            Check.Show();
            this.Hide();
        }

        private void timetableUI_Load(object sender, EventArgs e)
        {

            switch (globalData.getSelectedTable())
            {
                case 1:
                    checkAllButtonsStatus(1);
                    break;
                case 2:
                    checkAllButtonsStatus(2);
                    break;
                case 3:
                    checkAllButtonsStatus(3);
                    break;
                case 4:
                    checkAllButtonsStatus(4);
                    break;
            }

            
        }


        private void setButtonStatus(Button x, bool buttonStatus)
        {
            if(buttonStatus == true)
            {
                x.BackColor = Color.LightGreen;
                x.Enabled = true;
            }

            else
            {
                x.BackColor = Color.Red;
                x.Enabled = false;
            }


        }

        private void checkAllButtonsStatus(int tableID)
        {

            setButtonStatus(button1, globalData.getTimetableCheck(tableID, 0));
            setButtonStatus(button2, globalData.getTimetableCheck(tableID, 1));
            setButtonStatus(button3, globalData.getTimetableCheck(tableID, 2));
            setButtonStatus(button4, globalData.getTimetableCheck(tableID, 3));
            setButtonStatus(button5, globalData.getTimetableCheck(tableID, 4));
            setButtonStatus(button6, globalData.getTimetableCheck(tableID, 5));
            setButtonStatus(button7, globalData.getTimetableCheck(tableID, 6));
            setButtonStatus(button8, globalData.getTimetableCheck(tableID, 7));

        }
        public override void back_Click(object sender, EventArgs e)
        {
            tableSelection Check = new tableSelection();
            Check.Show();
            this.Hide();

        }

    }
}
