using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPuzzle
{
    public class Game
    {

        public enum Direction
        {
            Up,
            Down,
            Left,
            Right,
            None

        };

        private static Game instance;

        private int[,] Board = new int[4, 4];

        private Game()
        {

        }

        public static Game getInstance()
        {
            if (Game.instance == null)
                Game.instance = new Game();
            return Game.instance;
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            int[] numbers = new int[16];
            for (int i = 0; i < 16; i++)
            {
                numbers[i] = i + 1;
            }
            for (int i = 0; i < 16; i++)
            {
                int r = rnd.Next(0, 16);
                int temp = numbers[i];
                numbers[i] = numbers[r];
                numbers[r] = temp;
            }
            for (int i = 0; i < 16; i++)
            {
                int x = i % 4;
                int y = i / 4;
                Game.getInstance().Board[x, y] = numbers[i] - 1;
            }
        }
        public int[,] getBoard()
        {
            return Game.getInstance().Board;
        }

        public int CheckMove(int x, int y)
        {

            if (x != 3)
                if (Game.getInstance().Board[x + 1, y] == 0)
                    return (int)Game.Direction.Right;

            if (x != 0)
                if (Game.getInstance().Board[x - 1, y] == 0)
                    return (int)Game.Direction.Left;

            if (y != 3)
                if (Game.getInstance().Board[x, y + 1] == 0)
                    return (int)Game.Direction.Up;

            if (y != 0)
                if (Game.getInstance().Board[x, y - 1] == 0)
                    return (int)Game.Direction.Down;

            return (int)Game.Direction.None;

        }

        public void Move(int x, int y, int direction)
        {

            switch (direction)
            {
                case (int)Game.Direction.Down:
                    Game.getInstance().Board[x, y - 1] = Game.getInstance().Board[x, y];
                    break;

                case (int)Game.Direction.Up:
                    Game.getInstance().Board[x, y + 1] = Game.getInstance().Board[x, y];
                    break;

                case (int)Game.Direction.Right:
                    Game.getInstance().Board[x + 1, y] = Game.getInstance().Board[x, y];
                    break;

                case (int)Game.Direction.Left:
                    Game.getInstance().Board[x - 1, y] = Game.getInstance().Board[x, y];
                    break;

            }

            Game.getInstance().Board[x, y] = 0;

        }
    }
}
