using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practice.Properties;

namespace Practice
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ll_Github.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/YOUNESS-RZIQI");
        }

        private void ll_Linkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ll_Linkedin.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/youness-rziqi/");
        }

    }
}
