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

        private void frm_Main_Load(object sender, EventArgs e)
        {
            cb_Images.SelectedIndex = 0;
        }

        private void cb_Images_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Images.Text == "Book")
            {
                pb_Image.Image = Resources.Book;
                lb_Title.Text = "Book";
            }
            else if (cb_Images.Text == "Boy")
            {
                lb_Title.Text = "Boy";
                pb_Image.Image = Resources.Boy;
            }
            else if (cb_Images.Text == "Girl")
            {    
                pb_Image.Image = Resources.Girl;
                lb_Title.Text = "Girl";
            }
            else
            {
                pb_Image.Image = Resources.Pen;
                lb_Title.Text = "Pen";
            }
        }
    }
}
