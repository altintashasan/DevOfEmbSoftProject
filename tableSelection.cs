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
    public partial class tableSelection : DevApp.BaseUI
    {

        public tableSelection()
        {
            InitializeComponent();
        }

        private void tableSelection_Load(object sender, EventArgs e)
        {
            System.Drawing.Bitmap bitmap1 = DevApp.Properties.Resources.dinner_table;
            
            pictureBox1.Image = bitmap1;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;//filling the image box
            
            pictureBox2.Image = bitmap1;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;//filling the image box

            pictureBox5.Image = bitmap1;
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;//filling the image box

            pictureBox4.Image = bitmap1;
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;//filling the image box

            setTableAvailability(tableOne, 1);
            setTableAvailability(tableTwo, 2);
            setTableAvailability(tableThree, 3);
            setTableAvailability(tableFour, 4);
        }


        private void tableOne_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTable(1);
            timetableUI Check = new timetableUI();

            Check.Show();
            this.Hide();
        }

        private void tableTwo_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTable(2);
            timetableUI Check = new timetableUI();

            Check.Show();
            this.Hide();
        }

        private void tableThree_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTable(3);
            timetableUI Check = new timetableUI();

            Check.Show();
            this.Hide();
        }

        private void tableFour_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTable(4);
            timetableUI Check = new timetableUI();

            Check.Show();
            this.Hide();
        }

        public override void back_Click(object sender, EventArgs e)
        {
            customerMainUI Check = new customerMainUI();
            Check.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTable(1);
            timetableUI Check = new timetableUI();

            Check.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private int checkTableStatus(int tableID)
        {
            bool check;
            int reservedTable = 0;
            for (int i = 0; i < 8; i++)
            {
                check = globalData.getTimetableCheck(tableID, i);
                if(check == false) {
                    reservedTable++;
                }
            }

            return reservedTable;
        }
        private void setTableAvailability(Button x, int tableID)
        {
            int reservedTable = checkTableStatus(tableID);
            if(reservedTable == 8)
            {
                x.BackColor = Color.Red;
                x.Enabled = false;

            }
            else
            {
                x.BackColor = Color.LightGreen;
                x.Enabled = true;
            }
        }
    }
}
