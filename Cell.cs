using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProject

{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }

        public const int North = 0;
        public const int South = 1;
        public const int East = 2;
        public const int West = 3;
        public bool IsVisited { get; set; }

        public bool obstacle = false;

        public Color color; // hücrenin rengi

        // Hücrenin sol, sağ, üst ve alt komşuları
        public Cell Left { get; set; }
        public Cell Right { get; set; }
        public Cell Top { get; set; }
        public Cell Bottom { get; set; }
        public int value { get; set; }
       
        public Cell[] Neighbors = new Cell[4];

        public Cell Current = null;

        public Rectangle Edge;
        public Cell(int x, int y)
        {
            this.X = x;
            this.Y = y;
            IsVisited = false;
            this.color = Color.Blue; 

        }
        public Cell(int x, int y, int gen, int boy)
        {
       
            Edge = new Rectangle(x, y, gen, boy);
        }

        public void DrawEdge(Graphics gr, Pen pen)
        {
            for (int way = 0; way < 4; way++)
            {
                if ((Neighbors[way] == null) || ((Neighbors[way].Current != this) && (Neighbors[way] != this.Current)))
                {
                    DrawEdge(gr, pen, way, 0);
                }
            }
        }

        public void DrawCenter(Graphics gr, Brush brush, int cellSize)
        {
            float size = cellSize ;
            int cx = Edge.Left + Edge.Width ;
            int cy = Edge.Top + Edge.Height ;

            gr.FillRectangle(brush, cx - size, cy - size, size, size);
        }

        private void DrawEdge(Graphics gr, Pen pen, int way, int offset)
        {

            switch (way)
            {
                case North:

                    gr.DrawLine(pen,
                        Edge.Left + offset, Edge.Top + offset,
                        Edge.Right - offset, Edge.Top + offset);
                    break;
                case South:
                    gr.DrawLine(pen,
                        Edge.Left + offset, Edge.Bottom - offset,
                        Edge.Right - offset, Edge.Bottom - offset);
                    break;
                case East:
                    gr.DrawLine(pen,
                        Edge.Right - offset, Edge.Top + offset,
                        Edge.Right - offset, Edge.Bottom - offset);
                    break;
                case West:
                    gr.DrawLine(pen,
                        Edge.Left + offset, Edge.Top + offset,
                        Edge.Left + offset, Edge.Bottom - offset);
                    break;
            }
        }

    }
}
