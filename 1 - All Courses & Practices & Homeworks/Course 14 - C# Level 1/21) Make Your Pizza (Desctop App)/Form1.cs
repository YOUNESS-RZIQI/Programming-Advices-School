using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_Your_Pizza
{
    public partial class frm_Main_Form : Form
    {
        public frm_Main_Form()
        {
            InitializeComponent();
        }

        private string Recalculate_Total_Price()
        {
            int total_price = 0;

            if (lb_order_summery_Size_text.Text == "Small")
                total_price += 10;
            else if (lb_order_summery_Size_text.Text == "Meduim")
                total_price += 20;
            else if (lb_order_summery_Size_text.Text == "Larg")
                total_price += 30;

            if (lb_order_summery_crust_type_Text.Text == "Thin Crust")
                total_price += 10;
            else if (lb_order_summery_crust_type_Text.Text == "Think Crust")
                total_price += 20;


            if (lb_order_summery_where_to_eat_Text.Text == "Take Out")
                total_price += 5;



            return (total_price.ToString());
        }

        private void rb_Small_size_CheckedChanged(object sender, EventArgs e)
        {
            lb_order_summery_Size_text.Text = "Small";
            lb_order_summery_total_price_Text.Text = Recalculate_Total_Price();
        }

        private void rb_Meduim_size_CheckedChanged(object sender, EventArgs e)
        {
            lb_order_summery_Size_text.Text = "Meduim";
            lb_order_summery_total_price_Text.Text = Recalculate_Total_Price();

        }

        private void rb_Larg_size_CheckedChanged(object sender, EventArgs e)
        {
            lb_order_summery_Size_text.Text = "Larg";
            lb_order_summery_total_price_Text.Text = Recalculate_Total_Price();

        }

        private void rb_Thin_crust_CheckedChanged(object sender, EventArgs e)
        {
            lb_order_summery_crust_type_Text.Text = "Thin Crust";
            lb_order_summery_total_price_Text.Text = Recalculate_Total_Price();

        }

        private void rb_Think_crust_CheckedChanged(object sender, EventArgs e)
        {
            lb_order_summery_crust_type_Text.Text = "Think Crust";
            lb_order_summery_total_price_Text.Text = Recalculate_Total_Price();

        }

        private void rb_where_to_eat_Eat_in_CheckedChanged(object sender, EventArgs e)
        {
            lb_order_summery_where_to_eat_Text.Text = "Eat In";
            lb_order_summery_total_price_Text.Text = Recalculate_Total_Price();

        }

        private void rb_where_to_eat_Take_out_CheckedChanged(object sender, EventArgs e)
        {
            lb_order_summery_where_to_eat_Text.Text = "Take Out";
            lb_order_summery_total_price_Text.Text = Recalculate_Total_Price();

        }

    }
}
