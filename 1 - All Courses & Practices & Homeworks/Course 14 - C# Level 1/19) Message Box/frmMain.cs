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
    }
}
