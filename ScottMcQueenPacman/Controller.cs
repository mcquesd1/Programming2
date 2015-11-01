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
        
        private const int GHOULSTARTX = 10;
        private const int GHOULSTARTY = 10;
        
        private Maze maze;
        private Random random;
        private Pacman pacman;
        private Ghoul [] ghouls;

        public Controller(Maze maze, Random random)
        {
            this.maze = maze;
            this.random = random;
            pacman = new Pacman("pacman1.bmp", "pacman2.bmp", maze);
            ghouls = new Ghoul[3];
            ghouls[0] = new Ghoul("green1.bmp","green2.bmp",maze);
            ghouls[1] = new Ghoul("orange1.bmp", "orange2.bmp", maze);
            ghouls[2] = new Ghoul("red1.bmp", "red2.bmp", maze);

        }
        public void Play()
        {
            
            pacman.draw();
        }
    
    }
}
