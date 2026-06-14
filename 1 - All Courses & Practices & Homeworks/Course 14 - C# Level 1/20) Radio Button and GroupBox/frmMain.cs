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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmPractice();
            frm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form frm1 = new frmPractice();
            frm1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frmMessageFrom = new frmMessageBox();

            frmMessageFrom.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frmCheckBox = new frmCheckBox();

            frmCheckBox.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm_Rd_and_Gb = new frm_Rd_and_Gb();

            frm_Rd_and_Gb.ShowDialog();
        }
    }
}
