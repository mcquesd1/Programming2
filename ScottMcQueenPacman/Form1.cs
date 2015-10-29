﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScottMcQueenPacman
{
    public partial class Form1 : Form
    {
        private const int FORMHEIGHT = 800;
        private const int FORMWIDTH = 600;

        private Maze maze;
    
        public Form1()
        {
            InitializeComponent();
                        // set the Properties of the form:
            Top = 0;
            Left = 0;
            Height = FORMHEIGHT;
            Width = FORMWIDTH;

            // create a Bitmap object for each image you want to display
            Bitmap k = new Bitmap("kibble.bmp");
            Bitmap w = new Bitmap("wall.bmp");
            Bitmap b = new Bitmap("blank.bmp");

            // create an instance of a Maze:
            maze = new Maze(k, w, b);

            // important, need to add the maze object to the list of controls on the form
            Controls.Add(maze);

            // remember the Timer Enabled Property is set to false as a default
            timer1.Enabled = true;

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            maze.Draw();
        }
    }
}
