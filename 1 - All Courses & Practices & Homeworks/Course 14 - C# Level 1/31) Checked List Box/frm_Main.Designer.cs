namespace Practice
{
    partial class frm_Main
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
            this.lb_Contact_Me = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            this.chlb_Modifications = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Add_Item = new System.Windows.Forms.Button();
            this.bt_Show_Selected_Items = new System.Windows.Forms.Button();
            this.bt_Check_All_Items = new System.Windows.Forms.Button();
            this.bt_UnCheck_All_Items = new System.Windows.Forms.Button();
            this.bt_Remove_First_Item = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Contact_Me
            // 
            this.lb_Contact_Me.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Contact_Me.AutoSize = true;
            this.lb_Contact_Me.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lb_Contact_Me.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Contact_Me.Font = new System.Drawing.Font("Palatino Linotype", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Contact_Me.ForeColor = System.Drawing.Color.White;
            this.lb_Contact_Me.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lb_Contact_Me.Location = new System.Drawing.Point(302, 602);
            this.lb_Contact_Me.Name = "lb_Contact_Me";
            this.lb_Contact_Me.Size = new System.Drawing.Size(699, 80);
            this.lb_Contact_Me.TabIndex = 0;
            this.lb_Contact_Me.Text = "Click Her To Contact Me";
            this.lb_Contact_Me.Click += new System.EventHandler(this.lb_Contact_Me_Click);
            // 
            // lb_Title
            // 
            this.lb_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI Symbol", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.Red;
            this.lb_Title.Location = new System.Drawing.Point(275, 32);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(715, 81);
            this.lb_Title.TabIndex = 1;
            this.lb_Title.Text = "Checked List Box Control";
            // 
            // chlb_Modifications
            // 
            this.chlb_Modifications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chlb_Modifications.BackColor = System.Drawing.Color.Black;
            this.chlb_Modifications.CheckOnClick = true;
            this.chlb_Modifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chlb_Modifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chlb_Modifications.ForeColor = System.Drawing.Color.White;
            this.chlb_Modifications.FormattingEnabled = true;
            this.chlb_Modifications.Items.AddRange(new object[] {
            "1337",
            "ProgrammingAdvices"});
            this.chlb_Modifications.Location = new System.Drawing.Point(91, 245);
            this.chlb_Modifications.Name = "chlb_Modifications";
            this.chlb_Modifications.Size = new System.Drawing.Size(372, 260);
            this.chlb_Modifications.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(29, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "List:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(557, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Actions:";
            // 
            // bt_Add_Item
            // 
            this.bt_Add_Item.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Add_Item.BackColor = System.Drawing.Color.Black;
            this.bt_Add_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_Add_Item.ForeColor = System.Drawing.Color.White;
            this.bt_Add_Item.Location = new System.Drawing.Point(676, 245);
            this.bt_Add_Item.Name = "bt_Add_Item";
            this.bt_Add_Item.Size = new System.Drawing.Size(210, 55);
            this.bt_Add_Item.TabIndex = 6;
            this.bt_Add_Item.Text = "Add Item";
            this.bt_Add_Item.UseVisualStyleBackColor = false;
            this.bt_Add_Item.Click += new System.EventHandler(this.bt_Add_Item_Click);
            // 
            // bt_Show_Selected_Items
            // 
            this.bt_Show_Selected_Items.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Show_Selected_Items.BackColor = System.Drawing.Color.Black;
            this.bt_Show_Selected_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_Show_Selected_Items.ForeColor = System.Drawing.Color.White;
            this.bt_Show_Selected_Items.Location = new System.Drawing.Point(902, 245);
            this.bt_Show_Selected_Items.Name = "bt_Show_Selected_Items";
            this.bt_Show_Selected_Items.Size = new System.Drawing.Size(282, 55);
            this.bt_Show_Selected_Items.TabIndex = 7;
            this.bt_Show_Selected_Items.Text = "Show Checked Items";
            this.bt_Show_Selected_Items.UseVisualStyleBackColor = false;
            this.bt_Show_Selected_Items.Click += new System.EventHandler(this.bt_Show_Checked_Items_Click);
            // 
            // bt_Check_All_Items
            // 
            this.bt_Check_All_Items.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Check_All_Items.BackColor = System.Drawing.Color.Black;
            this.bt_Check_All_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_Check_All_Items.ForeColor = System.Drawing.Color.White;
            this.bt_Check_All_Items.Location = new System.Drawing.Point(676, 328);
            this.bt_Check_All_Items.Name = "bt_Check_All_Items";
            this.bt_Check_All_Items.Size = new System.Drawing.Size(254, 55);
            this.bt_Check_All_Items.TabIndex = 8;
            this.bt_Check_All_Items.Text = "Check All Items";
            this.bt_Check_All_Items.UseVisualStyleBackColor = false;
            this.bt_Check_All_Items.Click += new System.EventHandler(this.bt_Check_All_Items_Click);
            // 
            // bt_UnCheck_All_Items
            // 
            this.bt_UnCheck_All_Items.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_UnCheck_All_Items.BackColor = System.Drawing.Color.Black;
            this.bt_UnCheck_All_Items.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_UnCheck_All_Items.ForeColor = System.Drawing.Color.White;
            this.bt_UnCheck_All_Items.Location = new System.Drawing.Point(936, 328);
            this.bt_UnCheck_All_Items.Name = "bt_UnCheck_All_Items";
            this.bt_UnCheck_All_Items.Size = new System.Drawing.Size(248, 55);
            this.bt_UnCheck_All_Items.TabIndex = 9;
            this.bt_UnCheck_All_Items.Text = "UnCheck All Items";
            this.bt_UnCheck_All_Items.UseVisualStyleBackColor = false;
            this.bt_UnCheck_All_Items.Click += new System.EventHandler(this.bt_UnCheck_All_Items_Click);
            // 
            // bt_Remove_First_Item
            // 
            this.bt_Remove_First_Item.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Remove_First_Item.BackColor = System.Drawing.Color.Black;
            this.bt_Remove_First_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bt_Remove_First_Item.ForeColor = System.Drawing.Color.White;
            this.bt_Remove_First_Item.Location = new System.Drawing.Point(676, 418);
            this.bt_Remove_First_Item.Name = "bt_Remove_First_Item";
            this.bt_Remove_First_Item.Size = new System.Drawing.Size(508, 55);
            this.bt_Remove_First_Item.TabIndex = 10;
            this.bt_Remove_First_Item.Text = "Remove First Item";
            this.bt_Remove_First_Item.UseVisualStyleBackColor = false;
            this.bt_Remove_First_Item.Click += new System.EventHandler(this.bt_Remove_First_Item_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1219, 702);
            this.Controls.Add(this.bt_Remove_First_Item);
            this.Controls.Add(this.bt_UnCheck_All_Items);
            this.Controls.Add(this.bt_Check_All_Items);
            this.Controls.Add(this.bt_Show_Selected_Items);
            this.Controls.Add(this.bt_Add_Item);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chlb_Modifications);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.lb_Contact_Me);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm_Main";
            this.Text = "Practice";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_Main_When_Mouse_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Contact_Me;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.CheckedListBox chlb_Modifications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Add_Item;
        private System.Windows.Forms.Button bt_Show_Selected_Items;
        private System.Windows.Forms.Button bt_Check_All_Items;
        private System.Windows.Forms.Button bt_UnCheck_All_Items;
        private System.Windows.Forms.Button bt_Remove_First_Item;
    }
}

