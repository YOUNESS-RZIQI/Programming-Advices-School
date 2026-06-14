namespace My_First_Win_Forms_Project
{
    partial class frmCheckBox
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
            this.chbColorToRed = new System.Windows.Forms.CheckBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnRed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chbColorToRed
            // 
            this.chbColorToRed.AutoSize = true;
            this.chbColorToRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbColorToRed.Location = new System.Drawing.Point(275, 194);
            this.chbColorToRed.Name = "chbColorToRed";
            this.chbColorToRed.Size = new System.Drawing.Size(290, 29);
            this.chbColorToRed.TabIndex = 0;
            this.chbColorToRed.Text = "Change Lable Color to Red ?";
            this.chbColorToRed.UseVisualStyleBackColor = true;
            this.chbColorToRed.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("MV Boli", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Cyan;
            this.lbTitle.Location = new System.Drawing.Point(23, 50);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(844, 58);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "YOUNESS RZIQI : Software Engineer";
            // 
            // btnRed
            // 
            this.btnRed.Enabled = false;
            this.btnRed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnRed.ForeColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(377, 260);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 57);
            this.btnRed.TabIndex = 2;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // frmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.chbColorToRed);
            this.Name = "frmCheckBox";
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbColorToRed;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnRed;
    }
}