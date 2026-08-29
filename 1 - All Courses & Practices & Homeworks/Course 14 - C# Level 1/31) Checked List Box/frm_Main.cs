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

        private void bt_Add_Item_Click(object sender, EventArgs e)
        {
            chlb_Modifications.Items.Add(_random.Next(256));
        }

        private void bt_Show_Checked_Items_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <  chlb_Modifications.CheckedItems.Count; i++)
            {
                MessageBox.Show(chlb_Modifications.Items[i].ToString(), "Checked Items", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Check_All_Items_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chlb_Modifications.Items.Count; i++)
            {
                chlb_Modifications.SetItemChecked(i, true);
            }
        }

        private void bt_UnCheck_All_Items_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chlb_Modifications.Items.Count; i++)
            {
                chlb_Modifications.SetItemChecked(i, false);
            }
        }

        private void bt_Remove_First_Item_Click(object sender, EventArgs e)
        {
            if (chlb_Modifications.Items.Count != 0)
                chlb_Modifications.Items.RemoveAt(0);
        }
    }
}
