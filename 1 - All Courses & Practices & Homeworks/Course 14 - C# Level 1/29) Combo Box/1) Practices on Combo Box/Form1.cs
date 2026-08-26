using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            cb_Name.SelectedIndex = 0;
            cb_Age.SelectedIndex = 0;
            cb_Phone.SelectedIndex = 0;
            cb_School.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string[] names = { "Housam", "Yasmine", "Souaade" };

            cb_Name.Items.Add(names[rand.Next(names.Length)]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string[] Ages = { "16", "1", "27", "36", "44", };

            cb_Age.Items.Add(Ages[rand.Next(Ages.Length)]);
        }
    }
}
