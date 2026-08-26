using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void Panit_Scheduel_of_the_Game(object sender, PaintEventArgs e)
        {
            Color white = Color.White;

            Pen pen = new Pen(white, 10);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 397, 94, 397, 340);
            e.Graphics.DrawLine(pen, 527, 94, 527, 340);

            e.Graphics.DrawLine(pen, 275, 168, 626, 168);
            e.Graphics.DrawLine(pen, 275, 258, 626, 258);
        }

        // Bach End.

        string[,] table;
        PictureBox[] pbs;
        string winner_cords;
        string Turn;
        string Winner;

        enum en_Message_Box_Type { Error, Game_Over}
        enum en_Game_State { In_Progress, Winner, Draw}

        private void Init_Game()
        {
            this.pbs = new PictureBox[]{
                    pb_Box_0_0, pb_Box_0_1, pb_Box_0_2,
                    pb_Box_1_0, pb_Box_1_1, pb_Box_1_2,
                    pb_Box_2_0, pb_Box_2_1, pb_Box_2_2
            };

            foreach (PictureBox pb in this.pbs)
            {
                pb.Enabled = true;
                pb.BackColor = Color.Black;
                pb.Image = Resources.question_mark_961;
                pb.MouseEnter -= Winner_PictureBox_MouseEnter;
                pb.MouseLeave -= Winner_PictureBox_MouseLeave;
            }


            this.table = new string[3, 3] { { "", "", "" }, { "", "", "" }, { "", "", "" } };
            this.Turn = "Player 1";
            lb_Player_turn.Text = this.Turn;
            this.Winner = "In Progress";
            lb_The_Winner_Name.Text = this.Winner;

        }

        private string Get_Player_Symbol()
        {
            if (this.Turn == "Player 1")
                return "X";
            return "O";
        }
        
        private bool is_alredy_Changed(PictureBox pb)
        {
            // because it can not change twice.
            string[] row_col = pb.Tag.ToString().Split('_');

            int row = int.Parse(row_col[0]);
            int col = int.Parse(row_col[1]);

            if (this.table[row, col] == "")
            {
                this.table[row, col] = Get_Player_Symbol();
                return false;
            }
            return true;
        }
        
        private void Show_Message_box(en_Message_Box_Type type)
        {
            if (type == en_Message_Box_Type.Error)
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Place_symbole_and_Change_Turn(PictureBox pb)
        {
            if (this.Turn == "Player 1")
            {
                pb.Image = Resources.X1;
                this.Turn = "Player 2";
                lb_Player_turn.Text = this.Turn;
            }
            else
            {
                pb.Image = Resources.O1;
                this.Turn = "Player 1";
                lb_Player_turn.Text = this.Turn;
            }
        }

        private en_Game_State Get_Game_State()
        {
            string[] players = { "X", "O" };

            foreach (string symbol in players)
            {
                string winnerName = (symbol == "X") ? "Player 1" : "Player 2";

                // Check Rows
                for (int r = 0; r < 3; r++)
                {
                    if (this.table[r, 0] == symbol && this.table[r, 1] == symbol && this.table[r, 2] == symbol)
                    {
                        this.Winner = winnerName;
                        this.winner_cords = $"{r}_0/{r}_1/{r}_2";
                        return en_Game_State.Winner;
                    }
                }

                // Check Columns
                for (int c = 0; c < 3; c++)
                {
                    if (this.table[0, c] == symbol && this.table[1, c] == symbol && this.table[2, c] == symbol)
                    {
                        this.Winner = winnerName;
                        this.winner_cords = $"0_{c}/1_{c}/2_{c}";
                        return en_Game_State.Winner;
                    }
                }

                // Check Main Diagonal (top-left to bottom-right)
                if (this.table[0, 0] == symbol && this.table[1, 1] == symbol && this.table[2, 2] == symbol)
                {
                    this.Winner = winnerName;
                    this.winner_cords = "0_0/1_1/2_2";
                    return en_Game_State.Winner;
                }

                // Check Anti-Diagonal (top-right to bottom-left)
                if (this.table[0, 2] == symbol && this.table[1, 1] == symbol && this.table[2, 0] == symbol)
                {
                    this.Winner = winnerName;
                    this.winner_cords = "0_2/1_1/2_0";
                    return en_Game_State.Winner;
                }
            }

            // Check for Draw
            foreach (string cell in this.table)
            {
                if (string.IsNullOrEmpty(cell))
                    return en_Game_State.In_Progress;
            }

            this.Winner = "Draw";
            this.winner_cords = "";
            return en_Game_State.Draw;
        }

        private void Winner_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.Black;
            }
        }

        private void Winner_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pb)
            {
                pb.BackColor = Color.Green;
            }
        }

        private void Green_Winner_Cords()
        {
            if (string.IsNullOrEmpty(this.winner_cords)) return;

            // Use a HashSet or Contains check for clean lookups
            string[] winning_Cords = this.winner_cords.Split('/');

            foreach (PictureBox pb in this.pbs)
            {
                if (pb?.Tag != null && winning_Cords.Contains(pb.Tag.ToString()))
                {
                    pb.BackColor = Color.Green;
                    pb.MouseEnter += Winner_PictureBox_MouseEnter;
                    pb.MouseLeave += Winner_PictureBox_MouseLeave;
                }
            }
        }

        private void Game_Box_Changed(PictureBox pb)
        {
            // edg (try to change twice ! ! !)
            if (is_alredy_Changed(pb) || this.Winner != "In Progress")
            {
                Show_Message_box(en_Message_Box_Type.Error);
                return;
            }

            // Aplay Changes
            Place_symbole_and_Change_Turn(pb);

            // check game State
   
            if (Get_Game_State() == en_Game_State.Winner)
            {
                lb_The_Winner_Name.Text = this.Winner;
                lb_Player_turn.Text = "Game Over";
                Green_Winner_Cords();
                Show_Message_box(en_Message_Box_Type.Game_Over);
            }
            else if (Get_Game_State() == en_Game_State.Draw)
            {
                lb_The_Winner_Name.Text = this.Winner;
                lb_Player_turn.Text = "Game Over";
                Show_Message_box(en_Message_Box_Type.Game_Over);
            }

        }


        // Clicks
        private void pb_Box_Click(object sender, EventArgs e)
        {
            Game_Box_Changed((PictureBox)sender);
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            Init_Game();
        }

        private void bt_Restart_Game_Click(object sender, EventArgs e)
        {
            Init_Game();
        }

    }

}
