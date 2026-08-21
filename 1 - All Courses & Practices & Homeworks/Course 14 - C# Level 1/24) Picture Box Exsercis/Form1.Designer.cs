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
            this.rb_Boy = new System.Windows.Forms.RadioButton();
            this.rb_Pen = new System.Windows.Forms.RadioButton();
            this.rb_Girl = new System.Windows.Forms.RadioButton();
            this.rb_Book = new System.Windows.Forms.RadioButton();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.lb_Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_Boy
            // 
            this.rb_Boy.AutoSize = true;
            this.rb_Boy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rb_Boy.ForeColor = System.Drawing.Color.Red;
            this.rb_Boy.Location = new System.Drawing.Point(185, 489);
            this.rb_Boy.Name = "rb_Boy";
            this.rb_Boy.Size = new System.Drawing.Size(92, 40);
            this.rb_Boy.TabIndex = 0;
            this.rb_Boy.Tag = "Boy";
            this.rb_Boy.Text = "Boy";
            this.rb_Boy.UseVisualStyleBackColor = true;
            this.rb_Boy.CheckedChanged += new System.EventHandler(this.rb_Boy_CheckedChanged);
            // 
            // rb_Pen
            // 
            this.rb_Pen.AutoSize = true;
            this.rb_Pen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rb_Pen.ForeColor = System.Drawing.Color.Red;
            this.rb_Pen.Location = new System.Drawing.Point(635, 489);
            this.rb_Pen.Name = "rb_Pen";
            this.rb_Pen.Size = new System.Drawing.Size(93, 40);
            this.rb_Pen.TabIndex = 3;
            this.rb_Pen.Tag = "Pen";
            this.rb_Pen.Text = "Pen";
            this.rb_Pen.UseVisualStyleBackColor = true;
            this.rb_Pen.CheckedChanged += new System.EventHandler(this.rb_Pen_CheckedChanged);
            // 
            // rb_Girl
            // 
            this.rb_Girl.AutoSize = true;
            this.rb_Girl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rb_Girl.ForeColor = System.Drawing.Color.Red;
            this.rb_Girl.Location = new System.Drawing.Point(331, 489);
            this.rb_Girl.Name = "rb_Girl";
            this.rb_Girl.Size = new System.Drawing.Size(87, 40);
            this.rb_Girl.TabIndex = 1;
            this.rb_Girl.Tag = "Girl";
            this.rb_Girl.Text = "Girl";
            this.rb_Girl.UseVisualStyleBackColor = true;
            this.rb_Girl.CheckedChanged += new System.EventHandler(this.rb_Girl_CheckedChanged);
            // 
            // rb_Book
            // 
            this.rb_Book.AutoSize = true;
            this.rb_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rb_Book.ForeColor = System.Drawing.Color.Red;
            this.rb_Book.Location = new System.Drawing.Point(472, 489);
            this.rb_Book.Name = "rb_Book";
            this.rb_Book.Size = new System.Drawing.Size(109, 40);
            this.rb_Book.TabIndex = 2;
            this.rb_Book.Tag = "Book";
            this.rb_Book.Text = "Book";
            this.rb_Book.UseVisualStyleBackColor = true;
            this.rb_Book.CheckedChanged += new System.EventHandler(this.rb_Book_CheckedChanged);
            // 
            // pb_Image
            // 
            this.pb_Image.Image = global::Prectices.Properties.Resources.Boy;
            this.pb_Image.Location = new System.Drawing.Point(254, 93);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(391, 367);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 4;
            this.pb_Image.TabStop = false;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lb_Title.ForeColor = System.Drawing.Color.Red;
            this.lb_Title.Location = new System.Drawing.Point(371, 10);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(155, 79);
            this.lb_Title.TabIndex = 5;
            this.lb_Title.Text = "Boy";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 581);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.rb_Book);
            this.Controls.Add(this.rb_Girl);
            this.Controls.Add(this.rb_Pen);
            this.Controls.Add(this.rb_Boy);
            this.Name = "frm_Main";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Boy;
        private System.Windows.Forms.RadioButton rb_Pen;
        private System.Windows.Forms.RadioButton rb_Girl;
        private System.Windows.Forms.RadioButton rb_Book;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Label lb_Title;
    }
}

