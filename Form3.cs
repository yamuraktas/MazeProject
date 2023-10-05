using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeProject
{
    public partial class Form3 : Form
    {
        private int x, y;
        public int CellSize=20;
        private Cell[,] nodes;
        private Brush resultColor = Brushes.MediumSlateBlue;
        private LineCap lineCap = LineCap.Flat;
        private int lineGen = 5;
        public Timer timer;
        private Color backgroundColor = Color.Black;
        public Form3()
        {
            InitializeComponent();
            Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void picMaze_Click(object sender, EventArgs e)
        {

        }
        private void Timer_Tick(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int uzunluk = int.Parse(Uzunluk.Text);
            int genislik = int.Parse(Genislik.Text);
           

            x = (picMaze.ClientSize.Width - genislik * CellSize) / 2;
            y = (picMaze.ClientSize.Height - uzunluk * CellSize) / 2;

            nodes = Grid.MazeNodes(genislik, uzunluk, y, x, CellSize);

            Maze.MinSpanTree(ref nodes[0, 0]);

            picMaze.Image = Maze.DisplayMaze(nodes, picMaze.ClientSize.Width, picMaze.ClientSize.Height, CellSize, backgroundColor, lineCap, lineGen);

          
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Form1_ResizeEnd(object sender, EventArgs e) => Refresh();



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
