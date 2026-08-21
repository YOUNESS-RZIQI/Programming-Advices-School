using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Prectices.Properties;


namespace Prectices
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Mouse_Move(object sender, MouseEventArgs e)
        {
            // Get the Current x,y of the mouse Pos.
            lb_X_Y.Text = $"X: {e.X}, Y: {e.Y}";
        }

        private void frm_Main_Panting_on(object sender, PaintEventArgs e)
        {
            Color black = Color.Black;
            //black = Color.FromArgb(255, 0, 0, 0);

            //Pen pen = new Pen(black, 10);
            Pen pen = new Pen(black);

            pen.Width = 10;

            //pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            //pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 31, 31, 400, 31);
            e.Graphics.DrawLine(pen, 31, 61, 400, 61);
            e.Graphics.DrawLine(pen, 31, 31, 31, 61);
            e.Graphics.DrawLine(pen, 400, 31, 400, 61);

            e.Graphics.DrawEllipse(pen, 185, 125, 183, 186);
        }
    }
}
