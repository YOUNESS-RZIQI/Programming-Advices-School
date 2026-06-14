using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_First_Win_Forms_Project
{
    public partial class frm_Rd_and_Gb : Form
    {
        public frm_Rd_and_Gb()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbPizzaSize.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbPizzaSize.Visible = true;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            gbCrust.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbCrust.Visible = true;
        }
    }
}
