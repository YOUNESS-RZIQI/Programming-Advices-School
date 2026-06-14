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
    public partial class frmPractice : Form
    {

        public frmPractice()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            label1.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.White;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

    }

}
