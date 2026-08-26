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
            this.cb_Images = new System.Windows.Forms.ComboBox();
            this.lb_111 = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Images
            // 
            this.cb_Images.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_Images.BackColor = System.Drawing.Color.Black;
            this.cb_Images.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Images.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cb_Images.ForeColor = System.Drawing.Color.White;
            this.cb_Images.FormattingEnabled = true;
            this.cb_Images.Items.AddRange(new object[] {
            "Book",
            "Boy",
            "Girl",
            "Pen"});
            this.cb_Images.Location = new System.Drawing.Point(631, 632);
            this.cb_Images.Name = "cb_Images";
            this.cb_Images.Size = new System.Drawing.Size(296, 48);
            this.cb_Images.Sorted = true;
            this.cb_Images.TabIndex = 0;
            this.cb_Images.SelectedIndexChanged += new System.EventHandler(this.cb_Images_SelectedIndexChanged);
            // 
            // lb_111
            // 
            this.lb_111.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_111.AutoSize = true;
            this.lb_111.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lb_111.ForeColor = System.Drawing.Color.White;
            this.lb_111.Location = new System.Drawing.Point(328, 631);
            this.lb_111.Name = "lb_111";
            this.lb_111.Size = new System.Drawing.Size(290, 46);
            this.lb_111.TabIndex = 1;
            this.lb_111.Text = "Change Image:";
            // 
            // lb_Title
            // 
            this.lb_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("MV Boli", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.Blue;
            this.lb_Title.Location = new System.Drawing.Point(547, 9);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(164, 79);
            this.lb_Title.TabIndex = 8;
            this.lb_Title.Text = "Book";
            // 
            // pb_Image
            // 
            this.pb_Image.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_Image.Image = global::Practice.Properties.Resources.Book;
            this.pb_Image.Location = new System.Drawing.Point(322, 108);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(614, 493);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 9;
            this.pb_Image.TabStop = false;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1219, 702);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.lb_111);
            this.Controls.Add(this.cb_Images);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm_Main";
            this.Text = "Practice";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Images;
        private System.Windows.Forms.Label lb_111;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.PictureBox pb_Image;
    }
}

