using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using System.IO;

namespace MazeProject
{
    public partial class Form2 : Form
    {
        Timer timer;
        public string url = "http://bilgisayar.kocaeli.edu.tr/prolab2/url1.txt";
        public Grid grid;
        public int cellSize = 20;// her hücrenin boyutu
        public Point start;
        public Point finish;
        public string content;
        public Form2()
        {
            InitializeComponent();
            this.Invalidate();
            reload();
            
        }
        public void reload()
        {
            WebClient client = new WebClient();
            content = client.DownloadString(url);
            string[] rows = content.Split('\n');
           
            char[,] matrix = new char[rows.Length, rows[0].Length];
            for (int i = 0; i < rows.Length; i++)
            {
                int j = 0;
                foreach (var c in rows[i])
                {
                    matrix[i, j] = c;
                    j++;
                }
            }
            

            grid = new Grid(rows.Length, rows[0].Length);

            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < rows[0].Length; j++)
                {
                    var cell = matrix[i, j];
                    var cellInt = int.Parse(cell.ToString());
                    grid.cells[i, j].value = cellInt;


                    if (grid.cells[i, j].value != 0)
                    {
                        grid.cells[i, j].obstacle = true;
                    }
                }
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (url == "http://bilgisayar.kocaeli.edu.tr/prolab2/url2.txt")
            {
                url = "http://bilgisayar.kocaeli.edu.tr/prolab2/url1.txt";
                
            }
            else
            {
                url = "http://bilgisayar.kocaeli.edu.tr/prolab2/url2.txt";
            }

            reload();
            panel1.Refresh();

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1_Paint(e.Graphics);
        }

        private void panel1_Paint(Graphics graphics)
        {
            Pen gridPen = new Pen(Color.Black);


            for (int i = 0; i <= grid.row; i++)
            {
                int y = i * cellSize;
                graphics.DrawLine(gridPen, y, 0, y, cellSize * grid.row);


            }
            for (int j = 0; j <= grid.column; j++)
            {
                int x = j * cellSize;
                graphics.DrawLine(gridPen, 0, x, cellSize * grid.column, x);
            }

            Cell start = new Cell(0, 0);
            Cell finish = new Cell(grid.row - 1, grid.column - 1);


            for (int x = 0; x < grid.column; x++)
            {
                for (int y = 0; y < grid.row; y++)
                {
                    if (grid.cells[x, y].IsVisited)
                    {

                    }
                }
            }
            for (int i = 0; i < grid.row; i++)
            {
                for (int j = 0; j < grid.column; j++)
                {
                    if (grid.cells[i, j].obstacle == true)
                    {

                        graphics.FillRectangle(Brushes.Black, j * cellSize, i * cellSize, cellSize, cellSize);
                    }

                }
            }

            graphics.FillRectangle(Brushes.MediumBlue, (grid.row - 1) * cellSize, (grid.column - 1) * cellSize, cellSize, cellSize);

            for (int x = 0; x < grid.column; x++)
            {
                for (int y = 0; y < grid.row; y++)
                {

                    if (grid.cells[x, y].obstacle == false)
                    {
                        //point artır
                        graphics.FillRectangle(Brushes.DarkRed, x, y * cellSize, cellSize, cellSize);
                        start.X = x;
                        start.Y = y;

                        break;
                    }
                }

                if (start.X != -1)
                {
                    break;
                }

            }

            Stopwatch sw = Stopwatch.StartNew();
            var cell = FindPath(grid.cells[start.Y, start.X], grid.cells[grid.row - 1, grid.column - 1]);
            for (int i = 0; i < grid.row; i++)
            {
                for (int j = 0; j < grid.column; j++)
                {

                    if (grid.cells[i, j].IsVisited)
                    {
                        Thread.Sleep(100);
                        graphics.FillRectangle(Brushes.Green, j * cellSize, i * cellSize, cellSize, cellSize);
                    }
                }
            }
            sw.Stop();
            graphics.FillRectangle(Brushes.MediumBlue, (grid.row - 1) * cellSize, (grid.column - 1) * cellSize, cellSize, cellSize);
            label1.Text = sw.ElapsedMilliseconds + " ms";
            label2.Text = stepCount.ToString();

            StreamWriter Yaz2 = new StreamWriter("C:\\Users\\YagmurAktas\\Desktop\\MazeProject\\MP.txt"); 
            Yaz2.WriteLine(content);
            Yaz2.WriteLine("////////////////////////////////");
            Yaz2.WriteLine("Step:"+stepCount);
            Yaz2.WriteLine("Time:"+sw.ElapsedMilliseconds);
            Yaz2.Close();
            stepCount =0;
            sw.Reset();
        }

        int stepCount = 0;

        Cell FindPath(Cell cell, Cell end)
        {
            Debug.WriteLine(cell.X + " - " + cell.Y);
            if (cell.X == end.X && cell.Y == end.Y)
                return cell;
            if (cell.Right?.obstacle == false && !cell.Right.IsVisited)
            {
                cell.Right.IsVisited = true;
                stepCount++;
                return FindPath(cell.Right, end);
            }
            if (cell.Bottom?.obstacle == false && !cell.Bottom.IsVisited)
            {
                cell.Bottom.IsVisited = true;
                stepCount++;
                return FindPath(cell.Bottom, end);
            }
            if (cell.Left?.obstacle == false && !cell.Left.IsVisited)
            {
                cell.Left.IsVisited = true;
                stepCount++;
                return FindPath(cell.Left, end);
            }
            if (cell.Top?.obstacle == false && !cell.Top.IsVisited)
            {
                cell.Top.IsVisited = true;
                stepCount++;
                return FindPath(cell.Top, end);
            }

           
            return cell;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //zaman 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //step 
        }
    }
}
