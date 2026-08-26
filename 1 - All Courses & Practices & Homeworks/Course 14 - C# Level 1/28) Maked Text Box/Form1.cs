using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }


        private void check_is_valide(Label lb, MaskedTextBox mtb)
        {
            if (mtb.MaskFull)
            {
                lb.ForeColor = Color.Green;
                lb.Text = "Valide";
            }
            else
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Invalide";

            }
        }

        private void bt_text_only_Click(object sender, EventArgs e)
        {
            check_is_valide(lb_text_only, mtb_text_only);
        }

        private void bt_check_digits_only_Click(object sender, EventArgs e)
        {
            check_is_valide(lb_digits_only, mtb_only_digits);
        }

        private void bt_Digits_or_Space_Click(object sender, EventArgs e)
        {
            check_is_valide(lb_Digits_or_Space, mtb_Digits_or_Space);
        }
    }
}
