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
using System.Threading;

namespace Practice
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void lb_Contact_Me_Click(object sender, EventArgs e)
        {
            Form frm_Contact_Me = new frm_Contact_Me();

            frm_Contact_Me.Show();
        }

        private Random _random = new Random();
        private void frm_Main_When_Mouse_Move(object sender, MouseEventArgs e)
        {
            int r = _random.Next(256);
            int g = _random.Next(256);
            int b = _random.Next(256);

            // Apply the random color to the label's ForeColor
            lb_Contact_Me.ForeColor = Color.FromArgb(r, g, b);
            Thread.Sleep(10);
        }

        private void Group_Box_Mouse_Hover(object sender, EventArgs e)
        {
            int r = _random.Next(256);
            int g = _random.Next(256);
            int b = _random.Next(256);

            // Apply the random color to the label's ForeColor
            lb_Contact_Me.ForeColor = Color.FromArgb(r, g, b);
            Thread.Sleep(10);
        }

        // Start From Her


        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            tb_Date.Text = "\t" + dtp_Date.Value.ToString("dddd - MMMM - yyyy");
        }

        private void dtp_Start_Time_ValueChanged(object sender, EventArgs e)
        {
            tb_Start_Time.Text = "From: " + dtp_Start_Time.Value.ToString("HH:mm");
        }

        private void dtp_End_Time_ValueChanged(object sender, EventArgs e)
        {
            tb_End_Time.Text = "To: " + dtp_End_Time.Value.ToString("HH:mm");
        }
    }
}
