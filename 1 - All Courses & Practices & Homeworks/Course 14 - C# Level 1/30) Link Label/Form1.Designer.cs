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
            this.label1 = new System.Windows.Forms.Label();
            this.ll_Github = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ll_Linkedin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(466, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "About Me :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ll_Github
            // 
            this.ll_Github.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ll_Github.AutoSize = true;
            this.ll_Github.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F);
            this.ll_Github.Location = new System.Drawing.Point(453, 264);
            this.ll_Github.Name = "ll_Github";
            this.ll_Github.Size = new System.Drawing.Size(733, 63);
            this.ll_Github.TabIndex = 1;
            this.ll_Github.TabStop = true;
            this.ll_Github.Text = "github.com/YOUNESS-RZIQI";
            this.ll_Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(101, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 69);
            this.label2.TabIndex = 2;
            this.label2.Text = "My Git Hub:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 69);
            this.label3.TabIndex = 4;
            this.label3.Text = "My Linkedin:";
            // 
            // ll_Linkedin
            // 
            this.ll_Linkedin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ll_Linkedin.AutoSize = true;
            this.ll_Linkedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F);
            this.ll_Linkedin.Location = new System.Drawing.Point(453, 451);
            this.ll_Linkedin.Name = "ll_Linkedin";
            this.ll_Linkedin.Size = new System.Drawing.Size(738, 63);
            this.ll_Linkedin.TabIndex = 3;
            this.ll_Linkedin.TabStop = true;
            this.ll_Linkedin.Text = "linkedin.com/in/youness-rziqi/";
            this.ll_Linkedin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_Linkedin_LinkClicked);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1219, 702);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ll_Linkedin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ll_Github);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm_Main";
            this.Text = "Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ll_Github;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel ll_Linkedin;
    }
}

