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
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Youness Rziqi, Software Engineer ;)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Youness Rziqi, Software Engineer ;)", "It is Me ;-)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you In Good Mode ?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Good For You :-)");
            }
            else
            {
                MessageBox.Show("Sory For You :_(");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you In Good Mode ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Good For You :-)");
            }
            else
            {
                MessageBox.Show("Sory For You :_(");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you In Good Mode ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MessageBox.Show("Good For You :-)");
            }
            else
            {
                MessageBox.Show("Sory For You :_(");
            }
        }
    }
}
