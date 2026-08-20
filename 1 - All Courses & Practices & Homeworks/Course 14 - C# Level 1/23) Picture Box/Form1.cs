using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prectices.Properties;

namespace Prectices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Strong;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Weak;
        }

        private void bt_Local_Image_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\rziki\OneDrive\Pictures\Coding\656978248_938059501935246_9181455163809033416_n.jpg");
        }
    }
}
