using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeProject
{
    class Maze  
    {
        public static void MinSpanTree(ref Cell root)
        {
            Random rand = new Random();

            List<Links> links = new List<Links>();
            root.Current = root;
            foreach (Cell neighbor in root.Neighbors)
            {
                if (neighbor != null)
                    links.Add(new Links(root, neighbor));
            }

            do
            {

                int link_num = rand.Next(0, links.Count);
                Links link = links[link_num];
                links.RemoveAt(link_num);

                Cell to_node = link.NextNode;
                link.NextNode.Current = link.PreNode;

                for (int i = links.Count - 1; i >= 0; i--)
                {
                    if (links[i].NextNode.Current != null)
                        links.RemoveAt(i);
                }

                foreach (Cell neighbor in to_node.Neighbors)
                {
                    if ((neighbor != null) && (neighbor.Current == null))
                        links.Add(new Links(to_node, neighbor));
                }
            } while (links.Count > 0);

        }
        public static Bitmap DisplayMaze(Cell[,] nodes, int picWid, int picHgt, int cellSize, Color color, LineCap lineCap, int lineWid)
        {
            Pen pen = new Pen(color, lineWid)
            {
                StartCap = lineCap,
                EndCap = lineCap,
            };
            int boy = nodes.GetUpperBound(0) + 1;
            int gen = nodes.GetUpperBound(1) + 1;
            Bitmap bitmap = new Bitmap(picWid, picHgt);
            using (Graphics gr = Graphics.FromImage(bitmap))
            {
                for (int r = 0; r < boy; r++)
                {
                    for (int c = 0; c < gen; c++)
                    {
                        if ((r == 0 && c == 0) || (r == boy - 1 && c == gen - 1))
                        {
                            if (pen.Color != Color.Red) pen.Color = Color.OrangeRed;
                            else pen.Color = Color.BlueViolet;
                        }
                        else pen.Color = color;
                        nodes[r, c].DrawEdge(gr, pen);

                    }
                }
            }

            return bitmap;
        }

    }
}
