using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScottMcQueenPacman
{
    public abstract class Creature
    {
        protected Maze maze;
        protected Bitmap image1;
        protected Bitmap image2;
        protected Point position;

        public Creature(String fileName1, String fileName2, Maze maze, Point position)
        {
            image1 = new Bitmap(fileName1);
            image2 = new Bitmap(fileName2);
            this.maze = maze;
            this.position = position;
        }
        public DataGridViewCell GetMazeCellForPosition(Point p)
         {
             return maze.Rows[p.Y].Cells[p.X];
         }
        public virtual void Draw()
        {
             GetMazeCellForPosition(position).Value = image1;
             Application.DoEvents();
            
            GetMazeCellForPosition(position).Value = image2;
              Application.DoEvents();
              
        }
        public Point Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}
