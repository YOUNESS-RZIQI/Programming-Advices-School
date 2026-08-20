namespace Prectices
{
    partial class Form1
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
            this.bt_Strong = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_Weak = new System.Windows.Forms.Button();
            this.bt_Local_Image = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Strong
            // 
            this.bt_Strong.Location = new System.Drawing.Point(216, 339);
            this.bt_Strong.Name = "bt_Strong";
            this.bt_Strong.Size = new System.Drawing.Size(132, 35);
            this.bt_Strong.TabIndex = 0;
            this.bt_Strong.Text = "Strong";
            this.bt_Strong.UseVisualStyleBackColor = true;
            this.bt_Strong.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prectices.Properties.Resources.Strong;
            this.pictureBox1.Location = new System.Drawing.Point(216, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bt_Weak
            // 
            this.bt_Weak.Location = new System.Drawing.Point(354, 339);
            this.bt_Weak.Name = "bt_Weak";
            this.bt_Weak.Size = new System.Drawing.Size(132, 35);
            this.bt_Weak.TabIndex = 2;
            this.bt_Weak.Text = "Weak";
            this.bt_Weak.UseVisualStyleBackColor = true;
            this.bt_Weak.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_Local_Image
            // 
            this.bt_Local_Image.Location = new System.Drawing.Point(284, 403);
            this.bt_Local_Image.Name = "bt_Local_Image";
            this.bt_Local_Image.Size = new System.Drawing.Size(132, 35);
            this.bt_Local_Image.TabIndex = 3;
            this.bt_Local_Image.Text = "Local Image";
            this.bt_Local_Image.UseVisualStyleBackColor = true;
            this.bt_Local_Image.Click += new System.EventHandler(this.bt_Local_Image_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Local_Image);
            this.Controls.Add(this.bt_Weak);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_Strong);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Strong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_Weak;
        private System.Windows.Forms.Button bt_Local_Image;
    }
}

