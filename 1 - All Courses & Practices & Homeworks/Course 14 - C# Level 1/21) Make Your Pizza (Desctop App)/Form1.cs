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

        private void Remove_From_Toppings_List(string To_Remove)
        {
            // " " word, word, word

            string Toppings = lb_order_summery_toppings_Text.Text;
            string Tag = lb_order_summery_toppings_Text.Tag.ToString();

            if (Toppings.Contains(To_Remove + ", "))
                lb_order_summery_toppings_Text.Text = Toppings.Replace(" " + To_Remove, "");
            else if (Toppings.Contains(To_Remove) && Tag == "1")
                lb_order_summery_toppings_Text.Text = Toppings.Replace(To_Remove, "");
            else
                lb_order_summery_toppings_Text.Text = Toppings.Replace(", " + To_Remove, "");

            lb_order_summery_toppings_Text.Tag = (int.Parse(lb_order_summery_toppings_Text.Tag.ToString()) - 1).ToString();

        }

        private void Append_To_Toppings_List(string To_Append)
        {
            // word1, word2 
            // word, 
            // 
            string Toppings = lb_order_summery_toppings_Text.Text;
            string Tag = lb_order_summery_toppings_Text.Tag.ToString();

            //if (Toppings.Contains(To_Append))
            //    return;

            if (Tag == "0")
                lb_order_summery_toppings_Text.Text = To_Append;
            else
                lb_order_summery_toppings_Text.Text = Toppings + ", " + To_Append;

            lb_order_summery_toppings_Text.Tag = (int.Parse(lb_order_summery_toppings_Text.Tag.ToString()) + 1).ToString();
        }

        private void Recalculate_Total_Price()
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


            // Toppings
            if (lb_order_summery_toppings_Text.Text.Contains("Extra Chees"))
                total_price += 5;

            if (lb_order_summery_toppings_Text.Text.Contains("Onion"))
                total_price += 5;

            if (lb_order_summery_toppings_Text.Text.Contains("Mushrooms"))
                total_price += 5;

            if (lb_order_summery_toppings_Text.Text.Contains("Olives"))
                total_price += 5;

            if (lb_order_summery_toppings_Text.Text.Contains("Tomatoes"))
                total_price += 5;

            if (lb_order_summery_toppings_Text.Text.Contains("Green Peppers"))
                total_price += 5;

            lb_order_summery_total_price_Text.Text = total_price.ToString();
        }

        private void rb_Small_size_CheckedChanged(object sender, EventArgs e)
        {
            lb_order_summery_Size_text.Text = "Small";
            Recalculate_Total_Price();
        }

        private void rb_Meduim_size_CheckedChanged(object sender, EventArgs e)
        {
            lb_order_summery_Size_text.Text = "Meduim";
            Recalculate_Total_Price();

        }

        private void rb_Larg_size_CheckedChanged(object sender, EventArgs e)
        {
            lb_order_summery_Size_text.Text = "Larg";
            Recalculate_Total_Price();

        }

        private void rb_Thin_crust_CheckedChanged(object sender, EventArgs e)
        {
            lb_order_summery_crust_type_Text.Text = "Thin Crust";
            Recalculate_Total_Price();

        }

        private void rb_Think_crust_CheckedChanged(object sender, EventArgs e)
        {
            lb_order_summery_crust_type_Text.Text = "Think Crust";
            Recalculate_Total_Price();

        }

        private void rb_where_to_eat_Eat_in_CheckedChanged(object sender, EventArgs e)
        {
            lb_order_summery_where_to_eat_Text.Text = "Eat In";
            Recalculate_Total_Price();

        }

        private void rb_where_to_eat_Take_out_CheckedChanged(object sender, EventArgs e)
        {
            lb_order_summery_where_to_eat_Text.Text = "Take Out";
            Recalculate_Total_Price();

        }

        private void chb_toppings_Extra_Chees_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_toppings_Extra_Chees.Checked == true)
                Append_To_Toppings_List("Extra Chees");
            else
                Remove_From_Toppings_List("Extra Chees");
            Recalculate_Total_Price();
        }

        private void chb_toppings_Onion_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_toppings_Onion.Checked == true)
                Append_To_Toppings_List("Onion");
            else
                Remove_From_Toppings_List("Onion");
            Recalculate_Total_Price();

        }

        private void chb_toppings_Mushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_toppings_Mushrooms.Checked == true)
                Append_To_Toppings_List("Mushrooms");
            else
                Remove_From_Toppings_List("Mushrooms");
            Recalculate_Total_Price();
        }

        private void chb_toppings_Olives_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_toppings_Olives.Checked == true)
                Append_To_Toppings_List("Olives");
            else
                Remove_From_Toppings_List("Olives");
            Recalculate_Total_Price();
        }

        private void chb_toppings_Tomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_toppings_Tomatoes.Checked == true)
                Append_To_Toppings_List("Tomatoes");
            else
                Remove_From_Toppings_List("Tomatoes");
            Recalculate_Total_Price();
        }

        private void chb_toppings_Green_Peppers_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_toppings_Green_Peppers.Checked == true)
                Append_To_Toppings_List("Green Peppers");
            else
                Remove_From_Toppings_List("Green Peppers");
            Recalculate_Total_Price();
        }
    }
}
