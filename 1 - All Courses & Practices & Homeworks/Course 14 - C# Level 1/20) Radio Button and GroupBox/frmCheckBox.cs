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
    public partial class frmCheckBox : Form
    {
        public frmCheckBox()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnRed.Enabled = chbColorToRed.Checked;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            lbTitle.ForeColor = Color.Red;
        }
    }
}
