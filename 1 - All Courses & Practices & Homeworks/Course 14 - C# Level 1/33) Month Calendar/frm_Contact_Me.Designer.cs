namespace Practice
{
    partial class frm_Contact_Me
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
            this.lb_Github = new System.Windows.Forms.Label();
            this.ll_Github = new System.Windows.Forms.LinkLabel();
            this.ll_Linkedin = new System.Windows.Forms.LinkLabel();
            this.lb_Linkedin = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Github
            // 
            this.lb_Github.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Github.AutoSize = true;
            this.lb_Github.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lb_Github.ForeColor = System.Drawing.Color.White;
            this.lb_Github.Location = new System.Drawing.Point(104, 180);
            this.lb_Github.Name = "lb_Github";
            this.lb_Github.Size = new System.Drawing.Size(212, 46);
            this.lb_Github.TabIndex = 0;
            this.lb_Github.Text = "My Github:";
            // 
            // ll_Github
            // 
            this.ll_Github.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.ll_Github.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ll_Github.AutoSize = true;
            this.ll_Github.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ll_Github.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ll_Github.Location = new System.Drawing.Point(322, 188);
            this.ll_Github.Name = "ll_Github";
            this.ll_Github.Size = new System.Drawing.Size(492, 36);
            this.ll_Github.TabIndex = 1;
            this.ll_Github.TabStop = true;
            this.ll_Github.Text = "https://github.com/YOUNESS-RZIQI";
            this.ll_Github.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ll_Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Github_LinkClicked);
            // 
            // ll_Linkedin
            // 
            this.ll_Linkedin.ActiveLinkColor = System.Drawing.Color.Yellow;
            this.ll_Linkedin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ll_Linkedin.AutoSize = true;
            this.ll_Linkedin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ll_Linkedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ll_Linkedin.Location = new System.Drawing.Point(291, 321);
            this.ll_Linkedin.Name = "ll_Linkedin";
            this.ll_Linkedin.Size = new System.Drawing.Size(570, 36);
            this.ll_Linkedin.TabIndex = 3;
            this.ll_Linkedin.TabStop = true;
            this.ll_Linkedin.Text = "https://www.linkedin.com/in/youness-rziqi/";
            this.ll_Linkedin.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ll_Linkedin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lb_Linkedin
            // 
            this.lb_Linkedin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Linkedin.AutoSize = true;
            this.lb_Linkedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lb_Linkedin.ForeColor = System.Drawing.Color.White;
            this.lb_Linkedin.Location = new System.Drawing.Point(42, 313);
            this.lb_Linkedin.Name = "lb_Linkedin";
            this.lb_Linkedin.Size = new System.Drawing.Size(243, 46);
            this.lb_Linkedin.TabIndex = 2;
            this.lb_Linkedin.Text = "My Linkedin:";
            // 
            // lb_Title
            // 
            this.lb_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.Red;
            this.lb_Title.Location = new System.Drawing.Point(296, 22);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(320, 63);
            this.lb_Title.TabIndex = 4;
            this.lb_Title.Text = "Contact Me:";
            // 
            // frm_Contact_Me
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(899, 451);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.ll_Linkedin);
            this.Controls.Add(this.lb_Linkedin);
            this.Controls.Add(this.ll_Github);
            this.Controls.Add(this.lb_Github);
            this.Name = "frm_Contact_Me";
            this.Text = "Contact Me";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Github;
        private System.Windows.Forms.LinkLabel ll_Github;
        private System.Windows.Forms.LinkLabel ll_Linkedin;
        private System.Windows.Forms.Label lb_Linkedin;
        private System.Windows.Forms.Label lb_Title;
    }
}