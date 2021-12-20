using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberPuzzle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateBoard(Game game)
        {

            int[,] Board = Game.getInstance().getBoard();

            //primeira linha
            button1.Text = Board[0, 3].ToString() == "0" ? "" : Board[0, 3].ToString();
            button2.Text = Board[0, 2].ToString() == "0" ? "" : Board[0, 2].ToString();
            button3.Text = Board[0, 1].ToString() == "0" ? "" : Board[0, 1].ToString();
            button4.Text = Board[0, 0].ToString() == "0" ? "" : Board[0, 0].ToString();

            //segunda linha
            button5.Text = Board[1, 3].ToString() == "0" ? "" : Board[1, 3].ToString();
            button6.Text = Board[1, 2].ToString() == "0" ? "" : Board[1, 2].ToString();
            button7.Text = Board[1, 1].ToString() == "0" ? "" : Board[1, 1].ToString();
            button8.Text = Board[1, 0].ToString() == "0" ? "" : Board[1, 0].ToString();

            //terceira linha
            button9.Text = Board[2, 3].ToString() == "0" ? "" : Board[2, 3].ToString();
            button10.Text = Board[2, 2].ToString() == "0" ? "" : Board[2, 2].ToString();
            button11.Text = Board[2, 1].ToString() == "0" ? "" : Board[2, 1].ToString();
            button12.Text = Board[2, 0].ToString() == "0" ? "" : Board[2, 0].ToString();

            //quarta linha
            button13.Text = Board[3, 3].ToString() == "0" ? "" : Board[3, 3].ToString();
            button14.Text = Board[3, 2].ToString() == "0" ? "" : Board[3, 2].ToString();
            button15.Text = Board[3, 1].ToString() == "0" ? "" : Board[3, 1].ToString();
            button16.Text = Board[3, 0].ToString() == "0" ? "" : Board[3, 0].ToString();

            if (Game.getInstance().CheckWin())
                MessageBox.Show("PARABÉNS!!! VOCÊ CONSEGUIU!!!");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game.getInstance().Shuffle();
            this.UpdateBoard(Game.getInstance());
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if(Game.getInstance().CheckMove(0,3) != (int)Game.Direction.None)
            {
                Game.getInstance().Move(0,3, Game.getInstance().CheckMove(0, 3));
            }

            this.UpdateBoard(Game.getInstance());
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (Game.getInstance().CheckMove(0, 2) != (int)Game.Direction.None)
            {
                Game.getInstance().Move(0, 2, Game.getInstance().CheckMove(0, 2));
            }

            this.UpdateBoard(Game.getInstance());
        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (Game.getInstance().CheckMove(0, 1) != (int)Game.Direction.None)
            {
                Game.getInstance().Move(0, 1, Game.getInstance().CheckMove(0, 1));
            }

            this.UpdateBoard(Game.getInstance());
        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (Game.getInstance().CheckMove(0, 0) != (int)Game.Direction.None)
            {
                Game.getInstance().Move(0, 0, Game.getInstance().CheckMove(0, 0));
            }

            this.UpdateBoard(Game.getInstance());
        }

        public void button5_Click(object sender, EventArgs e)
        {
            if (Game.getInstance().CheckMove(1, 3) != (int)Game.Direction.None)
            {
                Game.getInstance().Move(1, 3, Game.getInstance().CheckMove(1, 3));
            }

            this.UpdateBoard(Game.getInstance());
        }

        public void button6_Click(object sender, EventArgs e)
        {
            if (Game.getInstance().CheckMove(1, 2) != (int)Game.Direction.None)
            {
                Game.getInstance().Move(1, 2, Game.getInstance().CheckMove(1, 2));
            }

            this.UpdateBoard(Game.getInstance());
        }

        public void button7_Click(object sender, EventArgs e)
        {
            if (Game.getInstance().CheckMove(1, 1) != (int)Game.Direction.None)
            {
                Game.getInstance().Move(1, 1, Game.getInstance().CheckMove(1, 1));
            }

            this.UpdateBoard(Game.getInstance());
        }

        public void button8_Click(object sender, EventArgs e)
        {
            if (Game.getInstance().CheckMove(1, 0) != (int)Game.Direction.None)
            {
                Game.getInstance().Move(1, 0, Game.getInstance().CheckMove(1, 0));
            }

            this.UpdateBoard(Game.getInstance());
        }

        public void button9_Click(object sender, EventArgs e)
        {
            if (Game.getInstance().CheckMove(2, 3) != (int)Game.Direction.None)
            {
                Game.getInstance().Move(2, 3, Game.getInstance().CheckMove(2, 3));
            }

            this.UpdateBoard(Game.getInstance());
        }

        public void button10_Click(object sender, EventArgs e)
        {
            if (Game.getInstance().CheckMove(2, 2) != (int)Game.Direction.None)
            {
                Game.getInstance().Move(2, 2, Game.getInstance().CheckMove(2, 2));
            }

            this.UpdateBoard(Game.getInstance());
        }

        public void button11_Click(object sender, EventArgs e)
        {
            if (Game.getInstance().CheckMove(2, 1) != (int)Game.Direction.None)
            {
                Game.getInstance().Move(2, 1, Game.getInstance().CheckMove(2, 1));
            }

            this.UpdateBoard(Game.getInstance());
        }

        public void button12_Click(object sender, EventArgs e)
        {
            if (Game.getInstance().CheckMove(2, 0) != (int)Game.Direction.None)
            {
                Game.getInstance().Move(2, 0, Game.getInstance().CheckMove(2, 0));
            }

            this.UpdateBoard(Game.getInstance());
        }

        public void button13_Click(object sender, EventArgs e)
        {
            if (Game.getInstance().CheckMove(3, 3) != (int)Game.Direction.None)
            {
                Game.getInstance().Move(3, 3, Game.getInstance().CheckMove(3, 3));
            }

            this.UpdateBoard(Game.getInstance());
        }

        public void button14_Click(object sender, EventArgs e)
        {
            if (Game.getInstance().CheckMove(3, 2) != (int)Game.Direction.None)
            {
                Game.getInstance().Move(3, 2, Game.getInstance().CheckMove(3, 2));
            }

            this.UpdateBoard(Game.getInstance());
        }

        public void button15_Click(object sender, EventArgs e)
        {
            if (Game.getInstance().CheckMove(3, 1) != (int)Game.Direction.None)
            {
                Game.getInstance().Move(3, 1, Game.getInstance().CheckMove(3, 1));
            }

            this.UpdateBoard(Game.getInstance());
        }

        public void button16_Click(object sender, EventArgs e)
        {
            if (Game.getInstance().CheckMove(3, 0) != (int)Game.Direction.None)
            {
                Game.getInstance().Move(3, 0, Game.getInstance().CheckMove(3, 0));
            }

            this.UpdateBoard(Game.getInstance());
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Game.getInstance().Shuffle();
            this.UpdateBoard(Game.getInstance());
        }
    }
}
