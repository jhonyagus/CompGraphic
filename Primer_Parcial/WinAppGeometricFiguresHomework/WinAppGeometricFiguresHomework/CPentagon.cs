using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinAppGeometricFiguresHomework
{
    class CPentagon
    {
        // Datos miembro - Atributos.
        private float mSide, mSegmentB, mAngle, mSegmentA, mAngleA, mSegmentC, mSegmentD;
        private float mPerimeter, mArea;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mA, mB, mC, mD, mE;

        // Funciones miembro - Métodos.

        // Constructor por defecto.
        public CPentagon()
        {
            mSide = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Función que permite leer los cinco lados del pentágono.
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

        // Función que permite calcular el perímetro del pentágono.
        public void PerimeterPentagon()
        {
            mPerimeter = 5.0f * mSide; 
        }

        // Función que permite calcular el área del pentágono.
        public void AreaPentagon()
        {
            float angle = (2 * (float)Math.PI) / (2 * 5);
            float a = mSide / (2 * (float)Math.Tan((double)angle));
            mArea = (mPerimeter * a) / 2;
        }

        // Función que permite imprimir el perímetro y el área del pentágono.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        // Función que permite inicializar los datos y controles que operan en 
        // la GUI del pentágono.
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

        // Función que permite calcular los valores de los cinco vértices del pentágono,
        // utilizando fórmulas de Geometría Analítica.
        private void CalculateVertex()
        {
            mAngle = 36.0f * (float)Math.PI / 180.0f;
            mAngleA = 72.0f * (float)Math.PI / 180.0f;
            mSegmentB = mSide * (float)Math.Cos(mAngle);
            mSegmentA = mSide * (float)Math.Sin(mAngle);
            mSegmentC = mSide * (float)Math.Cos(mAngleA);
            mSegmentD = mSide * (float)Math.Sin(mAngleA);

            mA.X = mSegmentB; mA.Y = 0;
            mB.X = 0; mB.Y = mSegmentA;
            mC.X = mSegmentC; mC.Y = mSegmentD + mSegmentA;
            mD.X = mSide + mSegmentC; mD.Y = mSegmentD + mSegmentA;
            mE.X = 2.0f * mSegmentC + mSide; mE.Y = mSegmentA;
            
        }

        // Función que permite graficar un pentágono en base a los valores de los cinco 
        // vértices representados por cinco puntos en un plano.
        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();

            CalculateVertex();

            mPen = new Pen(Color.Blue, 3);
            mGraph.DrawLine(mPen, mA.X * SF, mA.Y * SF, mB.X * SF, mB.Y * SF);
            mGraph.DrawLine(mPen, mB.X * SF, mB.Y * SF, mC.X * SF, mC.Y * SF);
            mGraph.DrawLine(mPen, mC.X * SF, mC.Y * SF, mD.X * SF, mD.Y * SF);
            mGraph.DrawLine(mPen, mD.X * SF, mD.Y * SF, mE.X * SF, mE.Y * SF);
            mGraph.DrawLine(mPen, mE.X * SF, mE.Y * SF, mA.X * SF, mA.Y * SF);
        }
    }
}
