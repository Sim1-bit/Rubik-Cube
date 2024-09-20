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
    public partial class Face : UserControl
    {
        private Button[,] face;
        public Face()
        {
            InitializeComponent();
        }

        public void CreateFace(Color color)
        {
            face = new Button[3, 3];

            for (int i = 0; i < face.GetLength(0); i++)
            {
                for (int j = 0; j < face.GetLength(1); j++)
                {
                    face[i, j] = new Button();
                    face[i, j].Size = new Size(Form1.proportion, Form1.proportion);
                    face[i, j].Location = new Point(j * Form1.proportion, i * Form1.proportion);
                    face[i, j].BackColor = color;

                    face[i, j].ForeColor = Color.Black;
                    this.Controls.Add(face[i, j]);
                }
            }
        }

        public void Rotate(bool direction)
        {
            for(int i = 0; i < 2; i++)
            {
                Color aux = face[0, 0].BackColor;
                if (direction)
                {
                    face[0, 0].BackColor = face[1, 0].BackColor;
                    face[1, 0].BackColor = face[2, 0].BackColor;
                    face[2, 0].BackColor = face[2, 1].BackColor;
                    face[2, 1].BackColor = face[2, 2].BackColor;
                    face[2, 2].BackColor = face[1, 2].BackColor;
                    face[1, 2].BackColor = face[0, 2].BackColor;
                    face[0, 2].BackColor = face[0, 1].BackColor;
                    face[0, 1].BackColor = aux;
                }
                else
                {
                    face[0, 0].BackColor = face[0, 1].BackColor;
                    face[0, 1].BackColor = face[0, 2].BackColor;
                    face[0, 2].BackColor = face[1, 2].BackColor;
                    face[1, 2].BackColor = face[2, 2].BackColor;
                    face[2, 2].BackColor = face[2, 1].BackColor;
                    face[2, 1].BackColor = face[2, 0].BackColor;
                    face[2, 0].BackColor = face[1, 0].BackColor;
                    face[1, 0].BackColor = aux;
                }
            }
        }

        public Color[] Moving(bool line, int index)
        {
            Color[] aux = new Color[3];

            if (line)
            {
                aux[0] = face[0, index].BackColor;
                aux[1] = face[1, index].BackColor;
                aux[2] = face[2, index].BackColor;

                face[0, index].BackColor = Color.Transparent;
                face[1, index].BackColor = Color.Transparent;
                face[2, index].BackColor = Color.Transparent;
            }
            else
            {
                aux[0] = face[index, 0].BackColor;
                aux[1] = face[index, 1].BackColor;
                aux[2] = face[index, 2].BackColor;

                face[index, 0].BackColor = Color.Transparent;
                face[index, 1].BackColor = Color.Transparent;
                face[index, 2].BackColor = Color.Transparent;
            }


            return aux;
        }

        public bool MissingSomething
        {
            get
            {
                foreach(Button aux in face)
                {
                    if (aux.BackColor == Color.Transparent)
                        return true;
                }
                return false;
            }
        }

        public Color[] Moving(Color[] value, bool line, int index)
        {
            Color[] aux = Moving(line, index);

            Receiving(value, line, index);

            return aux;
        }

        public void Receiving(Color[] aux, bool line, int index)
        {
            if (line)
            {
                face[0, index].BackColor = aux[0];
                face[1, index].BackColor = aux[1];
                face[2, index].BackColor = aux[2];
            }
            else
            {
                face[index, 0].BackColor = aux[0];
                face[index, 1].BackColor = aux[1];
                face[index, 2].BackColor = aux[2];
            }
        }
    }
}
