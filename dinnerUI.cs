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
    public partial class dinnerUI : DevApp.BaseUI
    {
        public dinnerUI()
        {
            InitializeComponent();
        }

        private void dinnerUI_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = DevApp.Properties.Resources.dinner1; 

        }

        public override void back_Click(object sender, EventArgs e)
        {
            dailyMenuUI Check = new dailyMenuUI();
            Check.Show();
            this.Hide();

        }
    }
}
