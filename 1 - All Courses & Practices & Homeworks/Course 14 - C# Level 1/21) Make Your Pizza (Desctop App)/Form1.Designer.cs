namespace Make_Your_Pizza
{
    partial class frm_Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Main_Title = new System.Windows.Forms.Label();
            this.gb_Size = new System.Windows.Forms.GroupBox();
            this.rb_Larg_size = new System.Windows.Forms.RadioButton();
            this.rb_Meduim_size = new System.Windows.Forms.RadioButton();
            this.rb_Small_size = new System.Windows.Forms.RadioButton();
            this.gb_Crust_Type = new System.Windows.Forms.GroupBox();
            this.rb_Think_crust = new System.Windows.Forms.RadioButton();
            this.rb_Thin_crust = new System.Windows.Forms.RadioButton();
            this.gb_Where_to_eat = new System.Windows.Forms.GroupBox();
            this.rb_where_to_eat_Take_out = new System.Windows.Forms.RadioButton();
            this.rb_where_to_eat_Eat_in = new System.Windows.Forms.RadioButton();
            this.gb_Toppings = new System.Windows.Forms.GroupBox();
            this.chb_toppings_Green_Peppers = new System.Windows.Forms.CheckBox();
            this.chb_toppings_Tomatoes = new System.Windows.Forms.CheckBox();
            this.chb_toppings_Olives = new System.Windows.Forms.CheckBox();
            this.chb_toppings_Mushrooms = new System.Windows.Forms.CheckBox();
            this.chb_toppings_Onion = new System.Windows.Forms.CheckBox();
            this.chb_toppings_Extra_Chees = new System.Windows.Forms.CheckBox();
            this.bt_OrderPizza = new System.Windows.Forms.Button();
            this.bt_Reset_Form = new System.Windows.Forms.Button();
            this.gb_Order_Summery = new System.Windows.Forms.GroupBox();
            this.lb_order_summery_total_price_Text = new System.Windows.Forms.Label();
            this.lb_order_summery_total_price_Dolar_Sign = new System.Windows.Forms.Label();
            this.lb_order_summery_Total_Price = new System.Windows.Forms.Label();
            this.lb_order_summery_where_to_eat_Text = new System.Windows.Forms.Label();
            this.lb_order_summery_Where_To_Eat = new System.Windows.Forms.Label();
            this.lb_order_summery_crust_type_Text = new System.Windows.Forms.Label();
            this.lb_order_summery_Crust_Type = new System.Windows.Forms.Label();
            this.lb_order_summery_toppings_Text = new System.Windows.Forms.Label();
            this.lb_order_summery_Toppings = new System.Windows.Forms.Label();
            this.lb_order_summery_Size = new System.Windows.Forms.Label();
            this.lb_order_summery_Size_text = new System.Windows.Forms.Label();
            this.gb_Size.SuspendLayout();
            this.gb_Crust_Type.SuspendLayout();
            this.gb_Where_to_eat.SuspendLayout();
            this.gb_Toppings.SuspendLayout();
            this.gb_Order_Summery.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Main_Title
            // 
            this.lb_Main_Title.AutoSize = true;
            this.lb_Main_Title.Font = new System.Drawing.Font("Impact", 45F, System.Drawing.FontStyle.Bold);
            this.lb_Main_Title.ForeColor = System.Drawing.Color.Red;
            this.lb_Main_Title.Location = new System.Drawing.Point(288, 20);
            this.lb_Main_Title.Name = "lb_Main_Title";
            this.lb_Main_Title.Size = new System.Drawing.Size(637, 111);
            this.lb_Main_Title.TabIndex = 10;
            this.lb_Main_Title.Text = "Make Your Pizza";
            // 
            // gb_Size
            // 
            this.gb_Size.Controls.Add(this.rb_Larg_size);
            this.gb_Size.Controls.Add(this.rb_Meduim_size);
            this.gb_Size.Controls.Add(this.rb_Small_size);
            this.gb_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gb_Size.Location = new System.Drawing.Point(106, 165);
            this.gb_Size.Name = "gb_Size";
            this.gb_Size.Size = new System.Drawing.Size(200, 234);
            this.gb_Size.TabIndex = 1;
            this.gb_Size.TabStop = false;
            this.gb_Size.Text = "Size";
            // 
            // rb_Larg_size
            // 
            this.rb_Larg_size.AutoSize = true;
            this.rb_Larg_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rb_Larg_size.Location = new System.Drawing.Point(36, 177);
            this.rb_Larg_size.Name = "rb_Larg_size";
            this.rb_Larg_size.Size = new System.Drawing.Size(66, 24);
            this.rb_Larg_size.TabIndex = 2;
            this.rb_Larg_size.TabStop = true;
            this.rb_Larg_size.Text = "Larg";
            this.rb_Larg_size.UseVisualStyleBackColor = true;
            this.rb_Larg_size.CheckedChanged += new System.EventHandler(this.rb_Larg_size_CheckedChanged);
            // 
            // rb_Meduim_size
            // 
            this.rb_Meduim_size.AutoSize = true;
            this.rb_Meduim_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rb_Meduim_size.Location = new System.Drawing.Point(36, 105);
            this.rb_Meduim_size.Name = "rb_Meduim_size";
            this.rb_Meduim_size.Size = new System.Drawing.Size(90, 24);
            this.rb_Meduim_size.TabIndex = 1;
            this.rb_Meduim_size.TabStop = true;
            this.rb_Meduim_size.Text = "Meduim";
            this.rb_Meduim_size.UseVisualStyleBackColor = true;
            this.rb_Meduim_size.CheckedChanged += new System.EventHandler(this.rb_Meduim_size_CheckedChanged);
            // 
            // rb_Small_size
            // 
            this.rb_Small_size.AutoSize = true;
            this.rb_Small_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rb_Small_size.Location = new System.Drawing.Point(36, 40);
            this.rb_Small_size.Name = "rb_Small_size";
            this.rb_Small_size.Size = new System.Drawing.Size(73, 24);
            this.rb_Small_size.TabIndex = 0;
            this.rb_Small_size.TabStop = true;
            this.rb_Small_size.Text = "Small";
            this.rb_Small_size.UseVisualStyleBackColor = true;
            this.rb_Small_size.CheckedChanged += new System.EventHandler(this.rb_Small_size_CheckedChanged);
            // 
            // gb_Crust_Type
            // 
            this.gb_Crust_Type.Controls.Add(this.rb_Think_crust);
            this.gb_Crust_Type.Controls.Add(this.rb_Thin_crust);
            this.gb_Crust_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gb_Crust_Type.Location = new System.Drawing.Point(106, 447);
            this.gb_Crust_Type.Name = "gb_Crust_Type";
            this.gb_Crust_Type.Size = new System.Drawing.Size(200, 168);
            this.gb_Crust_Type.TabIndex = 2;
            this.gb_Crust_Type.TabStop = false;
            this.gb_Crust_Type.Text = "Crust Type";
            // 
            // rb_Think_crust
            // 
            this.rb_Think_crust.AutoSize = true;
            this.rb_Think_crust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rb_Think_crust.Location = new System.Drawing.Point(36, 105);
            this.rb_Think_crust.Name = "rb_Think_crust";
            this.rb_Think_crust.Size = new System.Drawing.Size(114, 24);
            this.rb_Think_crust.TabIndex = 1;
            this.rb_Think_crust.TabStop = true;
            this.rb_Think_crust.Text = "Think Crust";
            this.rb_Think_crust.UseVisualStyleBackColor = true;
            this.rb_Think_crust.CheckedChanged += new System.EventHandler(this.rb_Think_crust_CheckedChanged);
            // 
            // rb_Thin_crust
            // 
            this.rb_Thin_crust.AutoSize = true;
            this.rb_Thin_crust.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rb_Thin_crust.Location = new System.Drawing.Point(36, 40);
            this.rb_Thin_crust.Name = "rb_Thin_crust";
            this.rb_Thin_crust.Size = new System.Drawing.Size(106, 24);
            this.rb_Thin_crust.TabIndex = 0;
            this.rb_Thin_crust.TabStop = true;
            this.rb_Thin_crust.Text = "Thin Crust";
            this.rb_Thin_crust.UseVisualStyleBackColor = true;
            this.rb_Thin_crust.CheckedChanged += new System.EventHandler(this.rb_Thin_crust_CheckedChanged);
            // 
            // gb_Where_to_eat
            // 
            this.gb_Where_to_eat.Controls.Add(this.rb_where_to_eat_Take_out);
            this.gb_Where_to_eat.Controls.Add(this.rb_where_to_eat_Eat_in);
            this.gb_Where_to_eat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gb_Where_to_eat.Location = new System.Drawing.Point(413, 447);
            this.gb_Where_to_eat.Name = "gb_Where_to_eat";
            this.gb_Where_to_eat.Size = new System.Drawing.Size(354, 97);
            this.gb_Where_to_eat.TabIndex = 4;
            this.gb_Where_to_eat.TabStop = false;
            this.gb_Where_to_eat.Text = "Where To Eat";
            // 
            // rb_where_to_eat_Take_out
            // 
            this.rb_where_to_eat_Take_out.AutoSize = true;
            this.rb_where_to_eat_Take_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rb_where_to_eat_Take_out.Location = new System.Drawing.Point(196, 40);
            this.rb_where_to_eat_Take_out.Name = "rb_where_to_eat_Take_out";
            this.rb_where_to_eat_Take_out.Size = new System.Drawing.Size(99, 24);
            this.rb_where_to_eat_Take_out.TabIndex = 1;
            this.rb_where_to_eat_Take_out.TabStop = true;
            this.rb_where_to_eat_Take_out.Text = "Take Out";
            this.rb_where_to_eat_Take_out.UseVisualStyleBackColor = true;
            this.rb_where_to_eat_Take_out.CheckedChanged += new System.EventHandler(this.rb_where_to_eat_Take_out_CheckedChanged);
            // 
            // rb_where_to_eat_Eat_in
            // 
            this.rb_where_to_eat_Eat_in.AutoSize = true;
            this.rb_where_to_eat_Eat_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rb_where_to_eat_Eat_in.Location = new System.Drawing.Point(36, 40);
            this.rb_where_to_eat_Eat_in.Name = "rb_where_to_eat_Eat_in";
            this.rb_where_to_eat_Eat_in.Size = new System.Drawing.Size(75, 24);
            this.rb_where_to_eat_Eat_in.TabIndex = 0;
            this.rb_where_to_eat_Eat_in.TabStop = true;
            this.rb_where_to_eat_Eat_in.Text = "Eat in";
            this.rb_where_to_eat_Eat_in.UseVisualStyleBackColor = true;
            this.rb_where_to_eat_Eat_in.CheckedChanged += new System.EventHandler(this.rb_where_to_eat_Eat_in_CheckedChanged);
            // 
            // gb_Toppings
            // 
            this.gb_Toppings.Controls.Add(this.chb_toppings_Green_Peppers);
            this.gb_Toppings.Controls.Add(this.chb_toppings_Tomatoes);
            this.gb_Toppings.Controls.Add(this.chb_toppings_Olives);
            this.gb_Toppings.Controls.Add(this.chb_toppings_Mushrooms);
            this.gb_Toppings.Controls.Add(this.chb_toppings_Onion);
            this.gb_Toppings.Controls.Add(this.chb_toppings_Extra_Chees);
            this.gb_Toppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gb_Toppings.Location = new System.Drawing.Point(413, 174);
            this.gb_Toppings.Name = "gb_Toppings";
            this.gb_Toppings.Size = new System.Drawing.Size(387, 225);
            this.gb_Toppings.TabIndex = 3;
            this.gb_Toppings.TabStop = false;
            this.gb_Toppings.Text = "Toppings";
            // 
            // chb_toppings_Green_Peppers
            // 
            this.chb_toppings_Green_Peppers.AutoSize = true;
            this.chb_toppings_Green_Peppers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chb_toppings_Green_Peppers.Location = new System.Drawing.Point(214, 167);
            this.chb_toppings_Green_Peppers.Name = "chb_toppings_Green_Peppers";
            this.chb_toppings_Green_Peppers.Size = new System.Drawing.Size(106, 24);
            this.chb_toppings_Green_Peppers.TabIndex = 5;
            this.chb_toppings_Green_Peppers.Text = "Tomatoes";
            this.chb_toppings_Green_Peppers.UseVisualStyleBackColor = true;
            // 
            // chb_toppings_Tomatoes
            // 
            this.chb_toppings_Tomatoes.AutoSize = true;
            this.chb_toppings_Tomatoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chb_toppings_Tomatoes.Location = new System.Drawing.Point(35, 167);
            this.chb_toppings_Tomatoes.Name = "chb_toppings_Tomatoes";
            this.chb_toppings_Tomatoes.Size = new System.Drawing.Size(106, 24);
            this.chb_toppings_Tomatoes.TabIndex = 4;
            this.chb_toppings_Tomatoes.Text = "Tomatoes";
            this.chb_toppings_Tomatoes.UseVisualStyleBackColor = true;
            // 
            // chb_toppings_Olives
            // 
            this.chb_toppings_Olives.AutoSize = true;
            this.chb_toppings_Olives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chb_toppings_Olives.Location = new System.Drawing.Point(214, 106);
            this.chb_toppings_Olives.Name = "chb_toppings_Olives";
            this.chb_toppings_Olives.Size = new System.Drawing.Size(77, 24);
            this.chb_toppings_Olives.TabIndex = 3;
            this.chb_toppings_Olives.Text = "Olives";
            this.chb_toppings_Olives.UseVisualStyleBackColor = true;
            // 
            // chb_toppings_Mushrooms
            // 
            this.chb_toppings_Mushrooms.AutoSize = true;
            this.chb_toppings_Mushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chb_toppings_Mushrooms.Location = new System.Drawing.Point(35, 106);
            this.chb_toppings_Mushrooms.Name = "chb_toppings_Mushrooms";
            this.chb_toppings_Mushrooms.Size = new System.Drawing.Size(118, 24);
            this.chb_toppings_Mushrooms.TabIndex = 2;
            this.chb_toppings_Mushrooms.Text = "Mushrooms";
            this.chb_toppings_Mushrooms.UseVisualStyleBackColor = true;
            // 
            // chb_toppings_Onion
            // 
            this.chb_toppings_Onion.AutoSize = true;
            this.chb_toppings_Onion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chb_toppings_Onion.Location = new System.Drawing.Point(214, 45);
            this.chb_toppings_Onion.Name = "chb_toppings_Onion";
            this.chb_toppings_Onion.Size = new System.Drawing.Size(77, 24);
            this.chb_toppings_Onion.TabIndex = 1;
            this.chb_toppings_Onion.Text = "Onion";
            this.chb_toppings_Onion.UseVisualStyleBackColor = true;
            // 
            // chb_toppings_Extra_Chees
            // 
            this.chb_toppings_Extra_Chees.AutoSize = true;
            this.chb_toppings_Extra_Chees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.chb_toppings_Extra_Chees.Location = new System.Drawing.Point(35, 45);
            this.chb_toppings_Extra_Chees.Name = "chb_toppings_Extra_Chees";
            this.chb_toppings_Extra_Chees.Size = new System.Drawing.Size(122, 24);
            this.chb_toppings_Extra_Chees.TabIndex = 0;
            this.chb_toppings_Extra_Chees.Text = "Extra Chees";
            this.chb_toppings_Extra_Chees.UseVisualStyleBackColor = true;
            // 
            // bt_OrderPizza
            // 
            this.bt_OrderPizza.Location = new System.Drawing.Point(371, 615);
            this.bt_OrderPizza.Name = "bt_OrderPizza";
            this.bt_OrderPizza.Size = new System.Drawing.Size(153, 49);
            this.bt_OrderPizza.TabIndex = 0;
            this.bt_OrderPizza.Text = "Order Pizza";
            this.bt_OrderPizza.UseVisualStyleBackColor = true;
            // 
            // bt_Reset_Form
            // 
            this.bt_Reset_Form.Location = new System.Drawing.Point(627, 615);
            this.bt_Reset_Form.Name = "bt_Reset_Form";
            this.bt_Reset_Form.Size = new System.Drawing.Size(153, 49);
            this.bt_Reset_Form.TabIndex = 5;
            this.bt_Reset_Form.Text = "Reset Form";
            this.bt_Reset_Form.UseVisualStyleBackColor = true;
            // 
            // gb_Order_Summery
            // 
            this.gb_Order_Summery.Controls.Add(this.lb_order_summery_total_price_Text);
            this.gb_Order_Summery.Controls.Add(this.lb_order_summery_total_price_Dolar_Sign);
            this.gb_Order_Summery.Controls.Add(this.lb_order_summery_Total_Price);
            this.gb_Order_Summery.Controls.Add(this.lb_order_summery_where_to_eat_Text);
            this.gb_Order_Summery.Controls.Add(this.lb_order_summery_Where_To_Eat);
            this.gb_Order_Summery.Controls.Add(this.lb_order_summery_crust_type_Text);
            this.gb_Order_Summery.Controls.Add(this.lb_order_summery_Crust_Type);
            this.gb_Order_Summery.Controls.Add(this.lb_order_summery_toppings_Text);
            this.gb_Order_Summery.Controls.Add(this.lb_order_summery_Toppings);
            this.gb_Order_Summery.Controls.Add(this.lb_order_summery_Size);
            this.gb_Order_Summery.Controls.Add(this.lb_order_summery_Size_text);
            this.gb_Order_Summery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Order_Summery.Location = new System.Drawing.Point(865, 174);
            this.gb_Order_Summery.Name = "gb_Order_Summery";
            this.gb_Order_Summery.Size = new System.Drawing.Size(312, 490);
            this.gb_Order_Summery.TabIndex = 6;
            this.gb_Order_Summery.TabStop = false;
            this.gb_Order_Summery.Text = "Order Summery";
            // 
            // lb_order_summery_total_price_Text
            // 
            this.lb_order_summery_total_price_Text.AutoSize = true;
            this.lb_order_summery_total_price_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lb_order_summery_total_price_Text.ForeColor = System.Drawing.Color.Green;
            this.lb_order_summery_total_price_Text.Location = new System.Drawing.Point(181, 397);
            this.lb_order_summery_total_price_Text.Name = "lb_order_summery_total_price_Text";
            this.lb_order_summery_total_price_Text.Size = new System.Drawing.Size(63, 69);
            this.lb_order_summery_total_price_Text.TabIndex = 9;
            this.lb_order_summery_total_price_Text.Text = "0";
            // 
            // lb_order_summery_total_price_Dolar_Sign
            // 
            this.lb_order_summery_total_price_Dolar_Sign.AutoSize = true;
            this.lb_order_summery_total_price_Dolar_Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lb_order_summery_total_price_Dolar_Sign.ForeColor = System.Drawing.Color.Green;
            this.lb_order_summery_total_price_Dolar_Sign.Location = new System.Drawing.Point(136, 397);
            this.lb_order_summery_total_price_Dolar_Sign.Name = "lb_order_summery_total_price_Dolar_Sign";
            this.lb_order_summery_total_price_Dolar_Sign.Size = new System.Drawing.Size(63, 69);
            this.lb_order_summery_total_price_Dolar_Sign.TabIndex = 10;
            this.lb_order_summery_total_price_Dolar_Sign.Text = "$";
            // 
            // lb_order_summery_Total_Price
            // 
            this.lb_order_summery_Total_Price.AutoSize = true;
            this.lb_order_summery_Total_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_order_summery_Total_Price.Location = new System.Drawing.Point(21, 376);
            this.lb_order_summery_Total_Price.Name = "lb_order_summery_Total_Price";
            this.lb_order_summery_Total_Price.Size = new System.Drawing.Size(123, 25);
            this.lb_order_summery_Total_Price.TabIndex = 8;
            this.lb_order_summery_Total_Price.Text = "Total Price:";
            // 
            // lb_order_summery_where_to_eat_Text
            // 
            this.lb_order_summery_where_to_eat_Text.AutoSize = true;
            this.lb_order_summery_where_to_eat_Text.Location = new System.Drawing.Point(153, 333);
            this.lb_order_summery_where_to_eat_Text.Name = "lb_order_summery_where_to_eat_Text";
            this.lb_order_summery_where_to_eat_Text.Size = new System.Drawing.Size(107, 25);
            this.lb_order_summery_where_to_eat_Text.TabIndex = 7;
            this.lb_order_summery_where_to_eat_Text.Text = "                   ";
            // 
            // lb_order_summery_Where_To_Eat
            // 
            this.lb_order_summery_Where_To_Eat.AutoSize = true;
            this.lb_order_summery_Where_To_Eat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_order_summery_Where_To_Eat.Location = new System.Drawing.Point(21, 289);
            this.lb_order_summery_Where_To_Eat.Name = "lb_order_summery_Where_To_Eat";
            this.lb_order_summery_Where_To_Eat.Size = new System.Drawing.Size(153, 25);
            this.lb_order_summery_Where_To_Eat.TabIndex = 6;
            this.lb_order_summery_Where_To_Eat.Text = "Where To Eat:";
            // 
            // lb_order_summery_crust_type_Text
            // 
            this.lb_order_summery_crust_type_Text.AutoSize = true;
            this.lb_order_summery_crust_type_Text.Location = new System.Drawing.Point(153, 246);
            this.lb_order_summery_crust_type_Text.Name = "lb_order_summery_crust_type_Text";
            this.lb_order_summery_crust_type_Text.Size = new System.Drawing.Size(107, 25);
            this.lb_order_summery_crust_type_Text.TabIndex = 5;
            this.lb_order_summery_crust_type_Text.Text = "                   ";
            // 
            // lb_order_summery_Crust_Type
            // 
            this.lb_order_summery_Crust_Type.AutoSize = true;
            this.lb_order_summery_Crust_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_order_summery_Crust_Type.Location = new System.Drawing.Point(21, 246);
            this.lb_order_summery_Crust_Type.Name = "lb_order_summery_Crust_Type";
            this.lb_order_summery_Crust_Type.Size = new System.Drawing.Size(126, 25);
            this.lb_order_summery_Crust_Type.TabIndex = 4;
            this.lb_order_summery_Crust_Type.Text = "Crust Type:";
            // 
            // lb_order_summery_toppings_Text
            // 
            this.lb_order_summery_toppings_Text.AutoSize = true;
            this.lb_order_summery_toppings_Text.Location = new System.Drawing.Point(37, 144);
            this.lb_order_summery_toppings_Text.Name = "lb_order_summery_toppings_Text";
            this.lb_order_summery_toppings_Text.Size = new System.Drawing.Size(182, 25);
            this.lb_order_summery_toppings_Text.TabIndex = 3;
            this.lb_order_summery_toppings_Text.Text = "                                  ";
            // 
            // lb_order_summery_Toppings
            // 
            this.lb_order_summery_Toppings.AutoSize = true;
            this.lb_order_summery_Toppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_order_summery_Toppings.Location = new System.Drawing.Point(21, 106);
            this.lb_order_summery_Toppings.Name = "lb_order_summery_Toppings";
            this.lb_order_summery_Toppings.Size = new System.Drawing.Size(109, 25);
            this.lb_order_summery_Toppings.TabIndex = 2;
            this.lb_order_summery_Toppings.Text = "Toppings:";
            // 
            // lb_order_summery_Size
            // 
            this.lb_order_summery_Size.AutoSize = true;
            this.lb_order_summery_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_order_summery_Size.Location = new System.Drawing.Point(21, 58);
            this.lb_order_summery_Size.Name = "lb_order_summery_Size";
            this.lb_order_summery_Size.Size = new System.Drawing.Size(62, 25);
            this.lb_order_summery_Size.TabIndex = 1;
            this.lb_order_summery_Size.Text = "Size:";
            // 
            // lb_order_summery_Size_text
            // 
            this.lb_order_summery_Size_text.AutoSize = true;
            this.lb_order_summery_Size_text.Location = new System.Drawing.Point(89, 58);
            this.lb_order_summery_Size_text.Name = "lb_order_summery_Size_text";
            this.lb_order_summery_Size_text.Size = new System.Drawing.Size(182, 25);
            this.lb_order_summery_Size_text.TabIndex = 0;
            this.lb_order_summery_Size_text.Text = "                                  ";
            // 
            // frm_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 717);
            this.Controls.Add(this.gb_Order_Summery);
            this.Controls.Add(this.bt_Reset_Form);
            this.Controls.Add(this.bt_OrderPizza);
            this.Controls.Add(this.gb_Toppings);
            this.Controls.Add(this.gb_Where_to_eat);
            this.Controls.Add(this.gb_Crust_Type);
            this.Controls.Add(this.gb_Size);
            this.Controls.Add(this.lb_Main_Title);
            this.Name = "frm_Main_Form";
            this.Text = "Pizza Order";
            this.gb_Size.ResumeLayout(false);
            this.gb_Size.PerformLayout();
            this.gb_Crust_Type.ResumeLayout(false);
            this.gb_Crust_Type.PerformLayout();
            this.gb_Where_to_eat.ResumeLayout(false);
            this.gb_Where_to_eat.PerformLayout();
            this.gb_Toppings.ResumeLayout(false);
            this.gb_Toppings.PerformLayout();
            this.gb_Order_Summery.ResumeLayout(false);
            this.gb_Order_Summery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Main_Title;
        private System.Windows.Forms.GroupBox gb_Size;
        private System.Windows.Forms.RadioButton rb_Small_size;
        private System.Windows.Forms.RadioButton rb_Meduim_size;
        private System.Windows.Forms.RadioButton rb_Larg_size;
        private System.Windows.Forms.GroupBox gb_Crust_Type;
        private System.Windows.Forms.RadioButton rb_Think_crust;
        private System.Windows.Forms.RadioButton rb_Thin_crust;
        private System.Windows.Forms.GroupBox gb_Where_to_eat;
        private System.Windows.Forms.RadioButton rb_where_to_eat_Eat_in;
        private System.Windows.Forms.RadioButton rb_where_to_eat_Take_out;
        private System.Windows.Forms.GroupBox gb_Toppings;
        private System.Windows.Forms.CheckBox chb_toppings_Extra_Chees;
        private System.Windows.Forms.CheckBox chb_toppings_Onion;
        private System.Windows.Forms.CheckBox chb_toppings_Mushrooms;
        private System.Windows.Forms.CheckBox chb_toppings_Olives;
        private System.Windows.Forms.CheckBox chb_toppings_Tomatoes;
        private System.Windows.Forms.CheckBox chb_toppings_Green_Peppers;
        private System.Windows.Forms.Button bt_OrderPizza;
        private System.Windows.Forms.Button bt_Reset_Form;
        private System.Windows.Forms.GroupBox gb_Order_Summery;
        private System.Windows.Forms.Label lb_order_summery_Size_text;
        private System.Windows.Forms.Label lb_order_summery_Size;
        private System.Windows.Forms.Label lb_order_summery_Toppings;
        private System.Windows.Forms.Label lb_order_summery_toppings_Text;
        private System.Windows.Forms.Label lb_order_summery_Crust_Type;
        private System.Windows.Forms.Label lb_order_summery_crust_type_Text;
        private System.Windows.Forms.Label lb_order_summery_Where_To_Eat;
        private System.Windows.Forms.Label lb_order_summery_where_to_eat_Text;
        private System.Windows.Forms.Label lb_order_summery_Total_Price;
        private System.Windows.Forms.Label lb_order_summery_total_price_Text;
        private System.Windows.Forms.Label lb_order_summery_total_price_Dolar_Sign;
    }
}

