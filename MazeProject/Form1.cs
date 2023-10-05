using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Problem 1
            Form2 form = new Form2();
            form.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Problem 2
            Form3 form = new Form3();
            form.Show(this);
            this.Hide();
        }


    }
}
