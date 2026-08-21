using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Prectices.Properties;


namespace Prectices
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            rb_Boy.Checked = true;
        }

        private void rb_Boy_CheckedChanged(object sender, EventArgs e)
        {
            pb_Image.Image = Resources.Boy;
            lb_Title.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rb_Pen_CheckedChanged(object sender, EventArgs e)
        {
            pb_Image.Image = Resources.Pen;
            lb_Title.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rb_Girl_CheckedChanged(object sender, EventArgs e)
        {
            pb_Image.Image = Resources.Girl;
            lb_Title.Text = ((RadioButton)sender).Tag.ToString();
        }

        private void rb_Book_CheckedChanged(object sender, EventArgs e)
        {
            pb_Image.Image = Resources.Book;
            lb_Title.Text = ((RadioButton)sender).Tag.ToString();
        }
    }
}
