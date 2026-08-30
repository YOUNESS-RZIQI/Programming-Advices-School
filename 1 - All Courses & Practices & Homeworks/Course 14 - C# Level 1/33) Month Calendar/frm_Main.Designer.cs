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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_End_Date = new System.Windows.Forms.Button();
            this.bt_Start_Date = new System.Windows.Forms.Button();
            this.mcl_m1 = new System.Windows.Forms.MonthCalendar();
            this.tb_End_Time = new System.Windows.Forms.TextBox();
            this.tb_Start_Time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_End_Time = new System.Windows.Forms.DateTimePicker();
            this.dtp_Start_Time = new System.Windows.Forms.DateTimePicker();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Contact_Me
            // 
            this.lb_Contact_Me.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Contact_Me.AutoSize = true;
            this.lb_Contact_Me.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lb_Contact_Me.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Contact_Me.Font = new System.Drawing.Font("Palatino Linotype", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Contact_Me.ForeColor = System.Drawing.Color.Violet;
            this.lb_Contact_Me.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lb_Contact_Me.Location = new System.Drawing.Point(291, 654);
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
            this.lb_Title.BackColor = System.Drawing.Color.CadetBlue;
            this.lb_Title.Font = new System.Drawing.Font("Times New Roman", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.SlateBlue;
            this.lb_Title.Location = new System.Drawing.Point(426, 19);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(440, 67);
            this.lb_Title.TabIndex = 1;
            this.lb_Title.Text = "Month Calendar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(139, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 47);
            this.button1.TabIndex = 2;
            this.button1.TabStop = false;
            this.button1.Text = "Meeting";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aquamarine;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(352, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 47);
            this.button2.TabIndex = 3;
            this.button2.TabStop = false;
            this.button2.Text = "Reminder";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aquamarine;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(565, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 47);
            this.button3.TabIndex = 4;
            this.button3.TabStop = false;
            this.button3.Text = "Activity";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Aquamarine;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(778, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 47);
            this.button4.TabIndex = 5;
            this.button4.TabStop = false;
            this.button4.Text = "Task";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.bt_End_Date);
            this.groupBox1.Controls.Add(this.bt_Start_Date);
            this.groupBox1.Controls.Add(this.mcl_m1);
            this.groupBox1.Controls.Add(this.tb_End_Time);
            this.groupBox1.Controls.Add(this.tb_Start_Time);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_Date);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_End_Time);
            this.groupBox1.Controls.Add(this.dtp_Start_Time);
            this.groupBox1.Controls.Add(this.dtp_Date);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.ForeColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.Location = new System.Drawing.Point(142, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 503);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task X:";
            this.groupBox1.MouseHover += new System.EventHandler(this.Group_Box_Mouse_Hover);
            // 
            // bt_End_Date
            // 
            this.bt_End_Date.BackColor = System.Drawing.Color.Aquamarine;
            this.bt_End_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_End_Date.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_End_Date.Location = new System.Drawing.Point(811, 440);
            this.bt_End_Date.Name = "bt_End_Date";
            this.bt_End_Date.Size = new System.Drawing.Size(134, 47);
            this.bt_End_Date.TabIndex = 18;
            this.bt_End_Date.TabStop = false;
            this.bt_End_Date.Text = "End Date";
            this.bt_End_Date.UseVisualStyleBackColor = false;
            this.bt_End_Date.Click += new System.EventHandler(this.bt_End_Date_Click);
            // 
            // bt_Start_Date
            // 
            this.bt_Start_Date.BackColor = System.Drawing.Color.Aquamarine;
            this.bt_Start_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bt_Start_Date.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_Start_Date.Location = new System.Drawing.Point(631, 440);
            this.bt_Start_Date.Name = "bt_Start_Date";
            this.bt_Start_Date.Size = new System.Drawing.Size(134, 47);
            this.bt_Start_Date.TabIndex = 17;
            this.bt_Start_Date.TabStop = false;
            this.bt_Start_Date.Text = "Start Date";
            this.bt_Start_Date.UseVisualStyleBackColor = false;
            this.bt_Start_Date.Click += new System.EventHandler(this.bt_Start_Date_Click);
            // 
            // mcl_m1
            // 
            this.mcl_m1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.mcl_m1.Location = new System.Drawing.Point(631, 162);
            this.mcl_m1.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.mcl_m1.MaxSelectionCount = 2;
            this.mcl_m1.MinDate = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.mcl_m1.Name = "mcl_m1";
            this.mcl_m1.ShowTodayCircle = false;
            this.mcl_m1.TabIndex = 3;
            // 
            // tb_End_Time
            // 
            this.tb_End_Time.BackColor = System.Drawing.Color.Turquoise;
            this.tb_End_Time.Location = new System.Drawing.Point(339, 348);
            this.tb_End_Time.Multiline = true;
            this.tb_End_Time.Name = "tb_End_Time";
            this.tb_End_Time.Size = new System.Drawing.Size(247, 51);
            this.tb_End_Time.TabIndex = 16;
            this.tb_End_Time.TabStop = false;
            // 
            // tb_Start_Time
            // 
            this.tb_Start_Time.BackColor = System.Drawing.Color.Turquoise;
            this.tb_Start_Time.Location = new System.Drawing.Point(30, 348);
            this.tb_Start_Time.Multiline = true;
            this.tb_Start_Time.Name = "tb_Start_Time";
            this.tb_Start_Time.Size = new System.Drawing.Size(247, 51);
            this.tb_Start_Time.TabIndex = 14;
            this.tb_Start_Time.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.CadetBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(421, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "End Time";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(24, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date";
            // 
            // tb_Date
            // 
            this.tb_Date.BackColor = System.Drawing.Color.Turquoise;
            this.tb_Date.Location = new System.Drawing.Point(30, 271);
            this.tb_Date.Multiline = true;
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(556, 51);
            this.tb_Date.TabIndex = 13;
            this.tb_Date.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(244, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Start Time";
            // 
            // dtp_End_Time
            // 
            this.dtp_End_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtp_End_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_End_Time.Location = new System.Drawing.Point(427, 215);
            this.dtp_End_Time.Name = "dtp_End_Time";
            this.dtp_End_Time.Size = new System.Drawing.Size(159, 32);
            this.dtp_End_Time.TabIndex = 2;
            this.dtp_End_Time.ValueChanged += new System.EventHandler(this.dtp_End_Time_ValueChanged);
            // 
            // dtp_Start_Time
            // 
            this.dtp_Start_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtp_Start_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Start_Time.Location = new System.Drawing.Point(250, 215);
            this.dtp_Start_Time.Name = "dtp_Start_Time";
            this.dtp_Start_Time.Size = new System.Drawing.Size(159, 32);
            this.dtp_Start_Time.TabIndex = 1;
            this.dtp_Start_Time.ValueChanged += new System.EventHandler(this.dtp_Start_Time_ValueChanged);
            // 
            // dtp_Date
            // 
            this.dtp_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Date.Location = new System.Drawing.Point(30, 212);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.ShowUpDown = true;
            this.dtp_Date.Size = new System.Drawing.Size(200, 35);
            this.dtp_Date.TabIndex = 0;
            this.dtp_Date.ValueChanged += new System.EventHandler(this.dtp_Date_ValueChanged);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1256, 789);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.lb_Contact_Me);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm_Main";
            this.Text = "Practice";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_Main_When_Mouse_Move);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Contact_Me;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.DateTimePicker dtp_Start_Time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_End_Time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.TextBox tb_Start_Time;
        private System.Windows.Forms.TextBox tb_End_Time;
        private System.Windows.Forms.MonthCalendar mcl_m1;
        private System.Windows.Forms.Button bt_End_Date;
        private System.Windows.Forms.Button bt_Start_Date;
    }
}

