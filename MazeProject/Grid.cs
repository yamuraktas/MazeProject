using MazeProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProject
{
    public class Grid
    {
        public int row { get; set; }
        public int column { get; set; }
        public Cell[,] cells { get; set; }
        public Grid(int rowCount, int columnCount)
        {
            row = rowCount;
            column = columnCount;
            cells = new Cell[rowCount, columnCount];

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    cells[i, j] = new Cell(i, j);
                }
            }

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {

                    if (j > 0)
                    {
                        cells[i, j].Left = cells[i, j - 1];
                    }

                    if (j < columnCount - 1)
                    {
                        cells[i, j].Right = cells[i, j + 1];
                    }

                    if (i > 0)
                    {
                        cells[i, j].Top = cells[i - 1, j];
                    }

                    if (i < rowCount - 1)
                    {
                        cells[i, j].Bottom = cells[i + 1, j];
                    }

                }
            }
        }
        private static Cell[,] MazeNodes(int gen, int boy, int Ymin, int Xmin, int CellSize)
        {
            Cell[,] cells2 = new Cell[boy, gen];

            for (int i = 0; i < boy; ++i)
            {
                int y = Ymin + CellSize * i;
                for (int j = 0; j < gen; ++j)
                {
                    int x = Xmin + CellSize * j;
                    cells2[i, j] = new Cell(x, y, CellSize, CellSize);
                }
            }

            for (int i = 0; i < boy; ++i)
            {
                for (int j = 0; j < gen; ++j)
                {
                    if (i > 0) cells2[i, j].Neighbors[Cell.North] = cells2[i - 1, j];
                    if (i < boy - 1) cells2[i, j].Neighbors[Cell.South] = cells2[i + 1, j];
                    if (j > 0) cells2[i, j].Neighbors[Cell.West] = cells2[i, j - 1];
                    if (j < gen - 1) cells2[i, j].Neighbors[Cell.East] = cells2[i, j + 1];
                }
            }
            return cells2;
        }
       

    }

}
