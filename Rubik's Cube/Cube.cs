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
    public partial class Cube : UserControl
    {
        private List<Face> cube;

        public Cube()
        {
            InitializeComponent();
        }

        public Face MakeFace(Color color)
        {
            Face face = new Face();
            face.Size = new Size(Form1.proportion * 3, Form1.proportion * 3);
            int x = 0, y = 0;
            if(color == Color.White)
            {
                x = 1;
                y = 1;
            }
            else if(color == Color.Blue)
            {
                x = 1; 
                y = 0;
            }
            else if( color == Color.Red)
            {
                x = 2;
                y = 1;
            }
            else if (color == Color.Green)
            {
                x = 1;
                y = 2;
            }
            else if (color == Color.Orange)
            {
                x = 0;
                y = 1;
            }
            else if (color == Color.Yellow)
            {
                x = 3;
                y = 1;
            }
            face.Location = new Point(Form1.proportion * 3 * x, Form1.proportion * 3 * y);

            face.CreateFace(color);

            this.Controls.Add(face);

            return face;
        }

        public void CreateCube()
        {
            cube = new List<Face>();
            cube.Add(MakeFace(Color.White));
            cube.Add(MakeFace(Color.Blue));
            cube.Add(MakeFace(Color.Red));
            cube.Add(MakeFace(Color.Green));
            cube.Add(MakeFace(Color.Orange));
            cube.Add(MakeFace(Color.Yellow));
        }

        public void Moving(bool line, bool direction, int index)
        {
            int auxIndex;
            if(index == 0 && line)
                auxIndex = 2;
            else if(index == 2 && line)
                auxIndex = 0;
            else
                auxIndex = 1;

            if (line)
            {
                if (direction)
                    cube[0].Receiving(cube[3].Moving(cube[5].Moving(cube[1].Moving(cube[0].Moving(line, index), line, index), line, auxIndex), line, index), line, index);
                else
                    cube[0].Receiving(cube[1].Moving(cube[5].Moving(cube[3].Moving(cube[0].Moving(line, index), line, index), line, auxIndex), line, index), line, index);

                if (index == 0)
                    cube[4].Rotate(!direction);
                else if (index == 2)
                    cube[2].Rotate(direction);
            }
            else
            {
                if (direction)
                    cube[0].Receiving(cube[4].Moving(cube[5].Moving(cube[2].Moving(cube[0].Moving(line, index), line, index), line, index), line, index), line, index);
                else
                    cube[0].Receiving(cube[2].Moving(cube[5].Moving(cube[4].Moving(cube[0].Moving(line, index), line, index), line, index), line, index), line, index);

                if (index == 0)
                    cube[1].Rotate(!direction);
                else if (index == 2)
                    cube[3].Rotate(direction);
            }
        }
    }
}
