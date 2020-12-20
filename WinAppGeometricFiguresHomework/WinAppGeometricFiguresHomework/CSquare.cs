using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppGeometricFiguresV2
{
    class CSquare
    {
        // Data Member (Atributes).        
        private float mSide;
        private float mPerimeter;
        private float mArea;

        // Objeto que activa el modo gráfico.
        private Graphics mGraph;
        // Constante scale factor (Zoom In/Zoom Out)
        private const float SF = 20;
        // Objeto pluma que dibuja o escribe en un lienzo.
        private Pen mPen;

        // Funciones miembro - Métodos.

        // Constructor sin parámetros.
        public CSquare()
        {            
            mSide = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        public void ReadData(TextBox txtSide)
        {
            mSide = float.Parse(txtSide.Text);
        }

        public void PerimeterSquare()
        {
            mPerimeter = 4 * mSide;
        }

        public void AreaSquare()
        {
            mArea = (float)Math.Pow(mSide, 2);
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtSide, TextBox txtPerimeter,
                                    TextBox txtArea, PictureBox picCanvas)
        {
            mSide = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            txtSide.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";
            txtSide.Focus();
            picCanvas.Refresh();
        }

        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            // Graficar un cuadrado en función de un rectángulo.
            mGraph.DrawRectangle(mPen, 0, 0, mSide * SF, mSide * SF);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }

    }
}
