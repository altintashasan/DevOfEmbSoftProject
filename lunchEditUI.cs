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
    public partial class lunchEditUI : lunchUI
    {
        public lunchEditUI()
        {
            InitializeComponent();
        }

        private void lunchEditUI_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
        }

        public override void lunchUI_Load(object sender, EventArgs e)
        {
            


        }

    }
}
