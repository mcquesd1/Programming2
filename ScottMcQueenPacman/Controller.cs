using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottMcQueenPacman
{
   
    public class Controller
    {
        private const int PACSTARTX = 10;
        private const int PACSTARTY = 12;
        private const int GHOULSTARTX = 10;
        private const int GHOULSTARTY = 9;
        
        private Maze maze;
        private Random random;
        private Pacman pacman;
        private Ghoul [] ghouls;

        public Controller(Maze maze, Random random)
        {
            this.maze = maze;
            this.random = random;
            pacman = new Pacman("pacman1.bmp", "pacman2.bmp", maze, new Point(PACSTARTX,PACSTARTY));
            ghouls = new Ghoul[3];
            ghouls[0] = new Ghoul("green1.bmp", "green2.bmp", maze, new Point((GHOULSTARTX - 1), GHOULSTARTY));
            ghouls[1] = new Ghoul("orange1.bmp", "orange2.bmp", maze, new Point(GHOULSTARTX, GHOULSTARTY));
            ghouls[2] = new Ghoul("red1.bmp", "red2.bmp", maze, new Point((GHOULSTARTX + 1), GHOULSTARTY));

        }
        public void Play()
        {
            maze.Draw();
            pacman.Draw();
            GhoulDraw();
            pacman.Move();
        }
        public void GhoulDraw()
        {
            for (int i = 0; i < ghouls.Length; i++)
            {
                ghouls[i].Draw();
            }
        }
        public void SetPacmanDirection(Direction direction)
        {
            pacman.Direction = direction;
        }
        public void PacmanHitsGhoul()
        { 
        
        }
        public void PacmanEatsKibble()
        { 
        
        }
        public void CheckAllKibbleEaten()
        { 
        
        }
    
    }
}
