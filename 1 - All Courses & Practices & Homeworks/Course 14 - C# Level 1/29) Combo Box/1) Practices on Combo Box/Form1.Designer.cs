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
            this.cb_Name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Phone = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Age = new System.Windows.Forms.ComboBox();
            this.cb_School = new System.Windows.Forms.ComboBox();
            this.lb_Title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Name
            // 
            this.cb_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Name.BackColor = System.Drawing.Color.Black;
            this.cb_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cb_Name.ForeColor = System.Drawing.Color.White;
            this.cb_Name.FormattingEnabled = true;
            this.cb_Name.Items.AddRange(new object[] {
            "Amine",
            "Salma",
            "Walide",
            "Youness"});
            this.cb_Name.Location = new System.Drawing.Point(266, 134);
            this.cb_Name.Name = "cb_Name";
            this.cb_Name.Size = new System.Drawing.Size(296, 48);
            this.cb_Name.Sorted = true;
            this.cb_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone:";
            // 
            // cb_Phone
            // 
            this.cb_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Phone.BackColor = System.Drawing.Color.Black;
            this.cb_Phone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cb_Phone.ForeColor = System.Drawing.Color.White;
            this.cb_Phone.FormattingEnabled = true;
            this.cb_Phone.Items.AddRange(new object[] {
            "0987654321",
            "1234567890"});
            this.cb_Phone.Location = new System.Drawing.Point(266, 458);
            this.cb_Phone.Name = "cb_Phone";
            this.cb_Phone.Size = new System.Drawing.Size(296, 48);
            this.cb_Phone.Sorted = true;
            this.cb_Phone.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(91, 619);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "School:";
            // 
            // cb_Age
            // 
            this.cb_Age.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Age.BackColor = System.Drawing.Color.Black;
            this.cb_Age.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cb_Age.ForeColor = System.Drawing.Color.White;
            this.cb_Age.FormattingEnabled = true;
            this.cb_Age.Items.AddRange(new object[] {
            "18",
            "19",
            "21",
            "22"});
            this.cb_Age.Location = new System.Drawing.Point(266, 296);
            this.cb_Age.Name = "cb_Age";
            this.cb_Age.Size = new System.Drawing.Size(296, 48);
            this.cb_Age.Sorted = true;
            this.cb_Age.TabIndex = 1;
            // 
            // cb_School
            // 
            this.cb_School.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_School.BackColor = System.Drawing.Color.Black;
            this.cb_School.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_School.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cb_School.ForeColor = System.Drawing.Color.White;
            this.cb_School.FormattingEnabled = true;
            this.cb_School.Items.AddRange(new object[] {
            "1337",
            "Programming Advices"});
            this.cb_School.Location = new System.Drawing.Point(266, 617);
            this.cb_School.Name = "cb_School";
            this.cb_School.Size = new System.Drawing.Size(296, 48);
            this.cb_School.Sorted = true;
            this.cb_School.TabIndex = 3;
            // 
            // lb_Title
            // 
            this.lb_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.Blue;
            this.lb_Title.Location = new System.Drawing.Point(338, 9);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(574, 79);
            this.lb_Title.TabIndex = 8;
            this.lb_Title.Text = "ComboBox Practice";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(629, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(561, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add a Name To Names List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(629, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(561, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add a Age To Ages List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1219, 702);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.cb_School);
            this.Controls.Add(this.cb_Age);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Name);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm_Main";
            this.Text = "Practice";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Age;
        private System.Windows.Forms.ComboBox cb_School;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

