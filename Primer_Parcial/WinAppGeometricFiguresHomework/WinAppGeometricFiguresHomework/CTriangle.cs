using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppGeometricFiguresHomework
{
    class CTriangle
    {
        // Datos miembro - Atributos.
        private float mSide;
        private float mPerimeter, mArea;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mP1, mP2, mP3;
        private float mAngle = 1.0472f;

        // Funciones miembro - Métodos.

        // Constructor sin parámetros.
        public CTriangle()
        {
            mSide = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Función que permite leer los tres lados del triángulo.
        public void ReadData(TextBox txtSide)
        {
            try
            {
                mSide = float.Parse(txtSide.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...");
            }
        }

        // Función que permite calcular el semi-perímetro del triángulo.
        private float SemiperimeterTriangle()
        {
            return ((mSide*3) / 2);
        }

        // Función que permite calcular el perímetro del triángulo.
        public void PerimeterTriangle()
        {
            float s = SemiperimeterTriangle();
            mPerimeter = 2 * s;
        }

        // Función que permite calcular el área del triángulo.
        public void AreaTriangle()
        {
            float s = SemiperimeterTriangle();
            mArea = (float)Math.Sqrt(s * (s - mSide) * (s - mSide) * (s - mSide));
        }

        // Función que permite imprimir el perímetro y el área del triángulo.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        // Función que permite inicializar los datos y controles que operan en 
        // la GUI del triángulo.
        public void InitializeData(TextBox txtSide,
                                   TextBox txtPerimeter,
                                   TextBox txtArea,
                                   PictureBox picCanvas)
        {
            txtSide.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            // Mantiene el cursor titilando en una caja de texto.
            txtSide.Focus();
            mSide = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
            picCanvas.Refresh();
        }

        // Función que permite validar la existencia de un triángulo.
        //public bool CheckTriangle()
        //{
        //    if ((mSide + mSide > m) && (mA + mC > mB) && (mB + mC > mA))
        //    {
        //        return (true);
        //    }
        //    else // !((mA + mB > mC) && (mA + mC > mB) && (mB + mC > mA))
        //        return (false);
        //}

        // Función que permite calcular el ángulo A del triángulo, utilizando 
        // la Ley de Cosenos.
        // Función que permite calcular los valores de los tres vértices del triángulo,
        // utilizando fórmulas de Geometría Analítica.
        private void CalculateVertexC()
        {
            mP1.X = 0.0f; mP1.Y = 0.0f;
            mP2.X = mSide; mP2.Y = 0.0f;
            mP3.X = mSide * (float)Math.Cos(mAngle);
            mP3.Y = mSide * (float)Math.Sin(mAngle);


        }

        // Función que permite graficar un triángulo en base a los valores de los tres 
        // vértices representados por tres puntos en un plano.
        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);

            CalculateVertexC();

            mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP2.X * SF, mP2.Y * SF);
            mGraph.DrawLine(mPen, mP1.X * SF, mP1.Y * SF, mP3.X * SF, mP3.Y * SF);
            mGraph.DrawLine(mPen, mP2.X * SF, mP2.Y * SF, mP3.X * SF, mP3.Y * SF);
        }

        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
