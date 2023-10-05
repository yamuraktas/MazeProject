using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProject
{
    class Links
    {
        public Cell PreNode, NextNode;
        public Links(Cell prenode, Cell nextnode)
        {
            PreNode = prenode;
            NextNode = nextnode;
        }
    }
}
