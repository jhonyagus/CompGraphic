using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinAppGeometricFiguresHomework
{
    class CHeptagon
    {
        // Datos miembro - Atributos.
        private float mSide, mSegmentA, mSegmentB, mSegmentC, mSegmentD, mSegmentE,mSegmentF, mAngleA, mAngleB, mAngleC;
        private float mPerimeter, mArea;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mA, mB, mC, mD, mE, mF, mG;

        // Funciones miembro - Métodos.

        // Constructor por defecto.
        public CHeptagon()
        {
            mSide = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Función que permite leer el lado del heptágono.
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

        // Función que permite calcular el perímetro del heptágono.
        public void PerimeterHeptagon()
        {
            mPerimeter = 7 * mSide;
        }

        // Función que permite calcular el área del heptágono.
        public void AreaHeptagon()
        {
            float angle = (2 * (float)Math.PI) / (2 * 7);
            float a = mSide / (2 * (float)Math.Tan((double)angle));
            mArea = (mPerimeter * a) / 2;
        }

        // Función que permite imprimir el perímetro y el área del heptágono.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        // Función que permite inicializar los datos y controles que operan en 
        // la GUI del heptágono.
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

        // Función que permite calcular los valores de los siete vértices del heptágono,
        // utilizando fórmulas de Geometría Analítica.
        private void CalculateVertex()
        {
            mAngleA = 25.7f * (float)Math.PI / 180.0f; //convertir a radianes
            mAngleB = 12.8f * (float)Math.PI / 180.0f; //convertir a radianes
            mAngleC = 51.4f * (float)Math.PI / 180.0f; //convertir a radianes
            mSegmentB = mSide * (float)Math.Cos(mAngleA);
            mSegmentA = mSide * (float)Math.Sin(mAngleA);
            mSegmentC = mSide * (float)Math.Sin(mAngleB);
            mSegmentE = mSide * (float)Math.Cos(mAngleB);
            mSegmentD = mSide * (float)Math.Sin(mAngleC);
            mSegmentF = mSide * (float)Math.Cos(mAngleC);

            mA.X = mSegmentB + mSegmentC; mA.Y = 0;
            mB.X = mSegmentC; mB.Y = mSegmentA;
            mC.X = 0; mC.Y = mSegmentA + mSegmentE;
            mD.X = mSegmentF; mD.Y = mSegmentA + mSegmentE + mSegmentD;
            mE.X = mSide + mSegmentF; mE.Y = mSegmentA + mSegmentE + mSegmentD;
            mF.X = 2.0f * mSegmentF + mSegmentE; mF.Y = mSegmentA + mSegmentE;
            mG.X = 2.0f * mSegmentB + mSegmentC; mG.Y = mSegmentA;
        }
        // Función que permite graficar un heptágono en base a los valores de los siete 
        // vértices representados por siete puntos en un plano.
        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();

            CalculateVertex();

            mPen = new Pen(Color.Blue, 3);
            mGraph.DrawLine(mPen, mA.X * SF, mA.Y * SF, mB.X * SF, mB.Y * SF);
            mGraph.DrawLine(mPen, mB.X * SF, mB.Y * SF, mC.X * SF, mC.Y * SF);
            mGraph.DrawLine(mPen, mC.X * SF, mC.Y * SF, mD.X * SF, mD.Y * SF);
            mGraph.DrawLine(mPen, mD.X * SF, mD.Y * SF, mE.X * SF, mE.Y * SF);
            mGraph.DrawLine(mPen, mE.X * SF, mE.Y * SF, mF.X * SF, mF.Y * SF);
            mGraph.DrawLine(mPen, mF.X * SF, mF.Y * SF, mG.X * SF, mG.Y * SF);
            mGraph.DrawLine(mPen, mG.X * SF, mG.Y * SF, mA.X * SF, mA.Y * SF);
        }
    }
}
