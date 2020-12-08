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
    public partial class adminMainUI : BaseUI
    {
        public adminMainUI()
        {
            InitializeComponent();
        }

        private void tableOne_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTable(1);
            adminTableSelectionUI Check = new adminTableSelectionUI();

            Check.Show();
            this.Hide();
        }

        private void tableTwo_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTable(2);
            adminTableSelectionUI Check = new adminTableSelectionUI();

            Check.Show();
            this.Hide();
        }

        private void tableThree_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTable(3);
            adminTableSelectionUI Check = new adminTableSelectionUI();

            Check.Show();
            this.Hide();
        }

        private void tableFour_Click(object sender, EventArgs e)
        {
            globalData.setSelectedTable(4);
            adminTableSelectionUI Check = new adminTableSelectionUI();

            Check.Show();
            this.Hide();
        }
        public override void back_Click(object sender, EventArgs e)
        {
            adminFirstUI Check = new adminFirstUI();
            Check.Show();
            this.Hide();

        }

        private void tableThree_Click_1(object sender, EventArgs e)
        {
            globalData.setSelectedTable(3);
            adminTableSelectionUI Check = new adminTableSelectionUI();

            Check.Show();
            this.Hide();
        }

        private void adminMainUI_Load(object sender, EventArgs e)
        {
            
                System.Drawing.Bitmap bitmap1 = DevApp.Properties.Resources.table;

                pictureBox1.Image = bitmap1;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;//filling the image box

                pictureBox2.Image = bitmap1;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;//filling the image box

                pictureBox5.Image = bitmap1;
                pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;//filling the image box

                pictureBox4.Image = bitmap1;
                pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;//filling the image box
        }

    }
}
