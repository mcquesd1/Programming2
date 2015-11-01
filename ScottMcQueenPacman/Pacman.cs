using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottMcQueenPacman
{
    public class Pacman : Creature
    {
        private Direction direction;

        public Pacman(String fileName1, String fileName2, Maze maze)
        :base(fileName1,fileName2,maze)
        {
            direction = Direction.Right;
        }
        public void Move()
        {
            switch (direction)
            {
                case Direction.Up:
                    position.Y--;
                    break;
                case Direction.Down:
                    position.Y++;
                    break;
                case Direction.Left:
                    position.X--;
                    break;
                case Direction.Right:
                    position.X++;
                    break;
                default:
                    break;
            }
        }
    }
}
