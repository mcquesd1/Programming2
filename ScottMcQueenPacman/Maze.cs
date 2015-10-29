﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScottMcQueenPacman
{
    public class Maze : DataGridView
    {
        private const int NROWSCOLUMNS = 20;                          // Number of cells in each row and column
        private const int CELLSIZE = 27;
        private const int SPACESIZE = 4;
        private const int NKIBBLES = 12;

        private const string INITMAP =  "wwwwwwwwwwwwwwwwwwww" +
                                        "wkkkkkkkkkkkkkkkkkkw" +
                                        "wkwwwwkwwwkwwwkwwwkw" +
                                        "wkkkkwkwwwkwwwkkkkkw" +
                                        "wkwwkkkkkkkkkkkwwwkw" +
                                        "wkkkkwkwwwkwwwkwwwkw" +
                                        "wkwwwwkwwwkwwwkkkkkw" +
                                        "wkkkkkkkkkkkkkkwkwkw" +
                                        "wkwkwwwwwwkwwwwwkkkw" +
                                        "wkkkkkkkwkkkwkkkkwkw" +
                                        "wkwwwwwkwkkkwkwwwwkw" +
                                        "wkkkkwwkwwwwwkwwwwkw" +
                                        "wkwwkkkkkkkkkkkkkkkw" +
                                        "wkwwwwwwwkwwwkwkwwkw" +
                                        "wkkkwwkkkkkkkkwkwwkw" +
                                        "wkwkwwkwwwwkwkkkkkkw" +
                                        "wkkkkkkwwkkkwwwkwwkw" +
                                        "wkwwwwkwwkwkwwwkwwkw" +
                                        "wkkkkkkkkkkkkkkkkkkw" +
                                        "wwwwwwwwwwwwwwwwwwww";
     
	
		 
	
       
        //fields
        private string map;
        private int nKibbles;
        private Bitmap wall;
        private Bitmap kibble;
        private Bitmap blank;

        //constructor
        public Maze(Bitmap k, Bitmap w, Bitmap b)
            : base()
        {
            //initialise fields
            map = INITMAP;
            wall = w;
            kibble = k;
            blank = b;
            nKibbles = NKIBBLES;

            // set position of maze on the Form
            Top = 0;
            Left = 0;

            // setup the columns to display images. We want to display images, so we set 5 columns worth of Image columns
            for (int x = 0; x < NROWSCOLUMNS; x++)
            {
                Columns.Add(new DataGridViewImageColumn());
            }
            // then we can tell the grid the number of rows we want to display
            RowCount = NROWSCOLUMNS;

            // set the properties of the Maze(which is a DataGridView object)
            Height = NROWSCOLUMNS * CELLSIZE + SPACESIZE;
            Width = NROWSCOLUMNS * CELLSIZE + SPACESIZE;
            ScrollBars = ScrollBars.None;
            ColumnHeadersVisible = false;
            RowHeadersVisible = false;

            // set size of cells:
            foreach (DataGridViewRow r in this.Rows)
                r.Height = CELLSIZE;

            foreach (DataGridViewColumn c in this.Columns)
                c.Width = CELLSIZE;

            // rows and columns should never resize themselves to fit cell contents
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // prevent user from resizing rows or columns
            AllowUserToResizeColumns = false;
            AllowUserToResizeRows = false;
        }

        //to draw the maze, the string character is used to load the corresponding image into the DataGridView cell
        public void Draw()
        {
            int totalCells = NROWSCOLUMNS * NROWSCOLUMNS;

            for (int i = 0; i < totalCells; i++)
            {
                int nRow = i / NROWSCOLUMNS;
                int nColumn = i % NROWSCOLUMNS;

                switch (map.Substring(i, 1))
                {
                    case "w":
                        Rows[nRow].Cells[nColumn].Value = wall;
                        break;
                    case "k":
                        Rows[nRow].Cells[nColumn].Value = kibble;
                        break;
                    case "b":
                        Rows[nRow].Cells[nColumn].Value = blank;
                        break;
                    default:
                        MessageBox.Show("Unidentified value in string");
                        break;
                }
            }
        }
    }
}
