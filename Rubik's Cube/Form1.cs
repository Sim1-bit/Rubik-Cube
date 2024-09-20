using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubik_s_Cube
{
    public partial class Form1 : Form
    {
        public const int proportion = 100;
        public Form1()
        {
            InitializeComponent();
            Size = new Size(proportion * 3 * 4 + proportion / 2, proportion * 3 * 3 + proportion / 2);
        }

        private Cube cube;

        private void Form1_Load(object sender, EventArgs e)
        {
            cube = new Cube();
            cube.Size = new Size(proportion * 3 * 4, proportion * 3 * 3);
            cube.Location = new Point(0, 0);

            cube.CreateCube();

            this.Controls.Add(cube);
        }

        private void buttonUP_left_Click(object sender, EventArgs e)
        {
            cube.Moving(true, true, 0);
        }

        private void buttonUP_midle_Click(object sender, EventArgs e)
        {
            cube.Moving(true, true, 1);
        }

        private void buttonUP_right_Click(object sender, EventArgs e)
        {
            cube.Moving(true, true, 2);
        }

        private void buttonDOWN_left_Click(object sender, EventArgs e)
        {
            cube.Moving(true, false, 0);
        }

        private void buttonDOWN_midle_Click(object sender, EventArgs e)
        {
            cube.Moving(true, false, 1);
        }

        private void buttonDOWN_right_Click(object sender, EventArgs e)
        {
            cube.Moving(true, false, 2);
        }



        private void buttonRIGHT_left_Click(object sender, EventArgs e)
        {
            cube.Moving(false, true, 0);
        }

        private void buttonRIGHT_midle_Click(object sender, EventArgs e)
        {
            cube.Moving(false, true, 1);
        }

        private void buttonRIGHT_right_Click(object sender, EventArgs e)
        {
            cube.Moving(false, true, 2);
        }

        private void buttonLEFT_left_Click(object sender, EventArgs e)
        {
            cube.Moving(false, false, 0);
        }

        private void buttonLEFT_midle_Click(object sender, EventArgs e)
        {
            cube.Moving(false, false, 1);
        }

        private void buttonLEFT_right_Click(object sender, EventArgs e)
        {
            cube.Moving(false, false, 2);
        }
    }
}
