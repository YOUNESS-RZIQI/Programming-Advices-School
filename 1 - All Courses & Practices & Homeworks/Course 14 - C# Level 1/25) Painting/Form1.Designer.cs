namespace Prectices
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
            this.lb_X_Y = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_X_Y
            // 
            this.lb_X_Y.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_X_Y.AutoSize = true;
            this.lb_X_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lb_X_Y.Location = new System.Drawing.Point(365, 273);
            this.lb_X_Y.Name = "lb_X_Y";
            this.lb_X_Y.Size = new System.Drawing.Size(95, 46);
            this.lb_X_Y.TabIndex = 0;
            this.lb_X_Y.Text = "X_Y";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(883, 582);
            this.Controls.Add(this.lb_X_Y);
            this.Name = "frm_Main";
            this.Text = "Main Form";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frm_Main_Panting_on);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_Main_Mouse_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_X_Y;
    }
}

