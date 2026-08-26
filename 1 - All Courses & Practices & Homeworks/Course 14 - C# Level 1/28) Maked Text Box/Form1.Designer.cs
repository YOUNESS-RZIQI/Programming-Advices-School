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
            this.mtb_text_only = new System.Windows.Forms.MaskedTextBox();
            this.bt_text_only = new System.Windows.Forms.Button();
            this.lb_text_only = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_only_digits = new System.Windows.Forms.Label();
            this.lb_digits_only = new System.Windows.Forms.Label();
            this.bt_check_digits_only = new System.Windows.Forms.Button();
            this.mtb_only_digits = new System.Windows.Forms.MaskedTextBox();
            this.lb_digit_or_space = new System.Windows.Forms.Label();
            this.lb_Digits_or_Space = new System.Windows.Forms.Label();
            this.bt_Digits_or_Space = new System.Windows.Forms.Button();
            this.mtb_Digits_or_Space = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // mtb_text_only
            // 
            this.mtb_text_only.BackColor = System.Drawing.Color.Black;
            this.mtb_text_only.BeepOnError = true;
            this.mtb_text_only.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.mtb_text_only.ForeColor = System.Drawing.Color.White;
            this.mtb_text_only.HideSelection = false;
            this.mtb_text_only.Location = new System.Drawing.Point(376, 81);
            this.mtb_text_only.Mask = "LLLLL";
            this.mtb_text_only.Name = "mtb_text_only";
            this.mtb_text_only.Size = new System.Drawing.Size(411, 41);
            this.mtb_text_only.TabIndex = 0;
            // 
            // bt_text_only
            // 
            this.bt_text_only.BackColor = System.Drawing.Color.Black;
            this.bt_text_only.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bt_text_only.ForeColor = System.Drawing.Color.White;
            this.bt_text_only.Location = new System.Drawing.Point(376, 144);
            this.bt_text_only.Name = "bt_text_only";
            this.bt_text_only.Size = new System.Drawing.Size(248, 50);
            this.bt_text_only.TabIndex = 3;
            this.bt_text_only.Text = "Check is Full";
            this.bt_text_only.UseVisualStyleBackColor = false;
            this.bt_text_only.Click += new System.EventHandler(this.bt_text_only_Click);
            // 
            // lb_text_only
            // 
            this.lb_text_only.AutoSize = true;
            this.lb_text_only.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_text_only.ForeColor = System.Drawing.Color.Red;
            this.lb_text_only.Location = new System.Drawing.Point(673, 151);
            this.lb_text_only.Name = "lb_text_only";
            this.lb_text_only.Size = new System.Drawing.Size(55, 36);
            this.lb_text_only.TabIndex = 4;
            this.lb_text_only.Text = "     ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(433, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Only a-z A-Z , len = 5";
            // 
            // lb_only_digits
            // 
            this.lb_only_digits.AutoSize = true;
            this.lb_only_digits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_only_digits.ForeColor = System.Drawing.Color.BlueViolet;
            this.lb_only_digits.Location = new System.Drawing.Point(451, 275);
            this.lb_only_digits.Name = "lb_only_digits";
            this.lb_only_digits.Size = new System.Drawing.Size(261, 36);
            this.lb_only_digits.TabIndex = 9;
            this.lb_only_digits.Text = "Only digits, len = 5";
            // 
            // lb_digits_only
            // 
            this.lb_digits_only.AutoSize = true;
            this.lb_digits_only.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_digits_only.ForeColor = System.Drawing.Color.Red;
            this.lb_digits_only.Location = new System.Drawing.Point(673, 404);
            this.lb_digits_only.Name = "lb_digits_only";
            this.lb_digits_only.Size = new System.Drawing.Size(55, 36);
            this.lb_digits_only.TabIndex = 8;
            this.lb_digits_only.Text = "     ";
            // 
            // bt_check_digits_only
            // 
            this.bt_check_digits_only.BackColor = System.Drawing.Color.Black;
            this.bt_check_digits_only.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bt_check_digits_only.ForeColor = System.Drawing.Color.White;
            this.bt_check_digits_only.Location = new System.Drawing.Point(376, 397);
            this.bt_check_digits_only.Name = "bt_check_digits_only";
            this.bt_check_digits_only.Size = new System.Drawing.Size(248, 50);
            this.bt_check_digits_only.TabIndex = 7;
            this.bt_check_digits_only.Text = "Check is Full";
            this.bt_check_digits_only.UseVisualStyleBackColor = false;
            this.bt_check_digits_only.Click += new System.EventHandler(this.bt_check_digits_only_Click);
            // 
            // mtb_only_digits
            // 
            this.mtb_only_digits.BackColor = System.Drawing.Color.Black;
            this.mtb_only_digits.BeepOnError = true;
            this.mtb_only_digits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.mtb_only_digits.ForeColor = System.Drawing.Color.White;
            this.mtb_only_digits.Location = new System.Drawing.Point(377, 334);
            this.mtb_only_digits.Mask = "00000";
            this.mtb_only_digits.Name = "mtb_only_digits";
            this.mtb_only_digits.Size = new System.Drawing.Size(411, 41);
            this.mtb_only_digits.TabIndex = 6;
            // 
            // lb_digit_or_space
            // 
            this.lb_digit_or_space.AutoSize = true;
            this.lb_digit_or_space.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_digit_or_space.ForeColor = System.Drawing.Color.Chartreuse;
            this.lb_digit_or_space.Location = new System.Drawing.Point(415, 505);
            this.lb_digit_or_space.Name = "lb_digit_or_space";
            this.lb_digit_or_space.Size = new System.Drawing.Size(331, 36);
            this.lb_digit_or_space.TabIndex = 13;
            this.lb_digit_or_space.Text = "Digits or Space , len = 5";
            // 
            // lb_Digits_or_Space
            // 
            this.lb_Digits_or_Space.AutoSize = true;
            this.lb_Digits_or_Space.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lb_Digits_or_Space.ForeColor = System.Drawing.Color.Red;
            this.lb_Digits_or_Space.Location = new System.Drawing.Point(672, 634);
            this.lb_Digits_or_Space.Name = "lb_Digits_or_Space";
            this.lb_Digits_or_Space.Size = new System.Drawing.Size(55, 36);
            this.lb_Digits_or_Space.TabIndex = 12;
            this.lb_Digits_or_Space.Text = "     ";
            // 
            // bt_Digits_or_Space
            // 
            this.bt_Digits_or_Space.BackColor = System.Drawing.Color.Black;
            this.bt_Digits_or_Space.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.bt_Digits_or_Space.ForeColor = System.Drawing.Color.White;
            this.bt_Digits_or_Space.Location = new System.Drawing.Point(375, 627);
            this.bt_Digits_or_Space.Name = "bt_Digits_or_Space";
            this.bt_Digits_or_Space.Size = new System.Drawing.Size(248, 50);
            this.bt_Digits_or_Space.TabIndex = 11;
            this.bt_Digits_or_Space.Text = "Check is Full";
            this.bt_Digits_or_Space.UseVisualStyleBackColor = false;
            this.bt_Digits_or_Space.Click += new System.EventHandler(this.bt_Digits_or_Space_Click);
            // 
            // mtb_Digits_or_Space
            // 
            this.mtb_Digits_or_Space.BackColor = System.Drawing.Color.Black;
            this.mtb_Digits_or_Space.BeepOnError = true;
            this.mtb_Digits_or_Space.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.mtb_Digits_or_Space.ForeColor = System.Drawing.Color.White;
            this.mtb_Digits_or_Space.Location = new System.Drawing.Point(375, 564);
            this.mtb_Digits_or_Space.Mask = "99999";
            this.mtb_Digits_or_Space.Name = "mtb_Digits_or_Space";
            this.mtb_Digits_or_Space.Size = new System.Drawing.Size(411, 41);
            this.mtb_Digits_or_Space.TabIndex = 10;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1219, 702);
            this.Controls.Add(this.lb_digit_or_space);
            this.Controls.Add(this.lb_Digits_or_Space);
            this.Controls.Add(this.bt_Digits_or_Space);
            this.Controls.Add(this.mtb_Digits_or_Space);
            this.Controls.Add(this.lb_only_digits);
            this.Controls.Add(this.lb_digits_only);
            this.Controls.Add(this.bt_check_digits_only);
            this.Controls.Add(this.mtb_only_digits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_text_only);
            this.Controls.Add(this.bt_text_only);
            this.Controls.Add(this.mtb_text_only);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm_Main";
            this.Text = "Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_text_only;
        private System.Windows.Forms.Button bt_text_only;
        private System.Windows.Forms.Label lb_text_only;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_only_digits;
        private System.Windows.Forms.Label lb_digits_only;
        private System.Windows.Forms.Button bt_check_digits_only;
        private System.Windows.Forms.MaskedTextBox mtb_only_digits;
        private System.Windows.Forms.Label lb_digit_or_space;
        private System.Windows.Forms.Label lb_Digits_or_Space;
        private System.Windows.Forms.Button bt_Digits_or_Space;
        private System.Windows.Forms.MaskedTextBox mtb_Digits_or_Space;
    }
}

