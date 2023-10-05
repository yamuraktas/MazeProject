using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProject
{
    public class Obstacle
    {
        public int x { get; set; }
        public int y { get; set; }
        public Cell[,] obstacles { get; set; }
        public Obstacle(int x, int y)
        {
            this.x = x;
            this.y = y;
            obstacles = new Cell[x, y];
        }

    }
}
