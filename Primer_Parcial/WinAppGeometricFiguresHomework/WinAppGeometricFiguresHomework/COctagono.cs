using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppGeometricFiguresHomework
{
    class COctagono
    {
        // Datos miembro - Atributos.
        private float mSide, mApothem, mSegmentB, mAngle1;
        private float mPerimeter, mArea;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mA, mB, mC, mD, mE, mF, mG, mH;

        // Funciones miembro - Métodos.

        // Constructor por defecto.
        public COctagono()
        {
            mSide = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Función que permite leer el lado del octógono.
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

        // Función que permite calcular el perímetro del octógono.
        public void PerimeterOctagon()
        {
            mPerimeter = 8 * mSide;
        }

        // Función que permite calcular el área del octógono.
        public void AreaOctagon()
        {
            float mAngle3 = 22.5f * (float)Math.PI / 180.0f;
            mApothem = (mSide / 2.0f) / (float)Math.Tan(mAngle3);
            mArea = mPerimeter * mApothem / 2.0f;
        }

        // Función que permite imprimir el perímetro y el área del octógono.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        // Función que permite inicializar los datos y controles que operan en 
        // la GUI del octógono.
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

        // Función que permite calcular los valores de los ocho vértices del octagono,
        // utilizando fórmulas de Geometría Analítica.
        private void CalculateVertex()
        {
            mAngle1 = 45.0f * (float)Math.PI / 180.0f; //convertir a radianes
            mSegmentB = mSide * (float)Math.Cos(mAngle1);

            mA.X = mSegmentB; mA.Y = 0;
            mB.X = mSide + mSegmentB; mB.Y = 0;
            mC.X = mSide + 2.0f * mSegmentB; mC.Y = mSegmentB;
            mD.X = mSide + 2.0f * mSegmentB; mD.Y = mSide + mSegmentB;
            mE.X = mSide + mSegmentB; mE.Y = mSide + 2.0f * mSegmentB;
            mF.X = mSegmentB; mF.Y = mSide + 2.0f * mSegmentB;
            mG.X = 0; mG.Y = mSide + mSegmentB;
            mH.X = 0; mH.Y = mSegmentB;

        }
        // Función que permite graficar un octógono en base a los valores de los ocho 
        // vértices representados por ocho puntos en un plano.
        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();

            CalculateVertex();

            mPen = new Pen(Color.Blue, 3);
            mGraph.DrawLine(mPen, mA.X * SF, mA.Y * SF, mB.X * SF, mB.Y * SF);
            mGraph.DrawLine(mPen, mA.X * SF, mA.Y * SF, mH.X * SF, mH.Y * SF);
            mGraph.DrawLine(mPen, mB.X * SF, mB.Y * SF, mC.X * SF, mC.Y * SF);
            mGraph.DrawLine(mPen, mG.X * SF, mG.Y * SF, mH.X * SF, mH.Y * SF);
            mGraph.DrawLine(mPen, mC.X * SF, mC.Y * SF, mD.X * SF, mD.Y * SF);
            mGraph.DrawLine(mPen, mF.X * SF, mF.Y * SF, mG.X * SF, mG.Y * SF);
            mGraph.DrawLine(mPen, mE.X * SF, mE.Y * SF, mF.X * SF, mF.Y * SF);
            mGraph.DrawLine(mPen, mD.X * SF, mD.Y * SF, mE.X * SF, mE.Y * SF);
        }

    }
}