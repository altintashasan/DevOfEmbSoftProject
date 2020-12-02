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
    public partial class BaseUI : Form
    {
        

        public BaseUI()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            InitializeComponent();
            BackColor = Color.Transparent; //Control does not support transparent background colors.


        }



        private void exit_Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void main_Menu_Click(object sender, EventArgs e)
        {
            adminCustomerSelection Check = new adminCustomerSelection();
            Check.Show();
            Hide();
        }

        private void BaseUI_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
    
        }

        public virtual void back_Click(object sender, EventArgs e)
        {
            adminCustomerSelection Check = new adminCustomerSelection();
            Check.Show();
            this.Hide();

        }
    }
}
