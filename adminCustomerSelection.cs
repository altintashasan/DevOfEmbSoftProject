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
    public partial class adminCustomerSelection : DevApp.BaseUI
    
    {


        public adminCustomerSelection()
        {
            InitializeComponent();
         
        }

        private void customer_Click(object sender, EventArgs e)
        {
            customerMainUI Check = new customerMainUI();
            Check.Show();
            this.Hide();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            passwordEnterUI Check = new passwordEnterUI();

            Check.Show();
            this.Hide();
        }

        private void adminCustomerSelection_Load(object sender, EventArgs e)
        
        {

            System.Drawing.Bitmap bitmap1 = DevApp.Properties.Resources.admin;
            System.Drawing.Bitmap bitmap2 = DevApp.Properties.Resources.customer;

            pictureBox1.Image = bitmap1;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;//filling the image box

            pictureBox2.Image = bitmap2;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;//filling the image box


        }
    }
}
