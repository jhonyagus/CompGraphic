using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppGeometricFiguresV2
{
    class CHexagon
    {
        // Datos miembro - Atributos.
        private float mSide, mApothem, mSegmentB, mAngle;
        private float mPerimeter, mArea;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mN, mS, mM, mP, mR, mQ;
        private PointF mA, mB, mC, mD, mE, mF;

        // Funciones miembro - Métodos.

        // Constructor por defecto.
        public CHexagon()
        {
            mSide = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Función que permite leer los tres lados del triángulo.
        public void ReadData(TextBox txtSideSide)
        {
            mSide = float.Parse(txtSideSide.Text);
        }

        // Función que permite calcular el perímetro del triángulo.
        public void PerimeterHexagon()
        {

        }

        // Función que permite calcular el área del triángulo.
        public void AreaHexagon()
        {

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

        // Función que permite calcular los valores de los tres vértices del triángulo,
        // utilizando fórmulas de Geometría Analítica.
        private void CalculateVertex()
        {
            mAngle = 60.0f * (float)Math.PI / 180.0f;
            mSegmentB = mSide * (float)Math.Cos(mAngle);
            mApothem = mSide * (float)Math.Sin(mAngle);            

            mA.X = mSegmentB; mA.Y = 0;
            mB.X = mSide + mSegmentB; mB.Y = 0;
            mC.X = 0; mC.Y = mApothem;
            mD.X = mSide + 2.0f * mSegmentB; mD.Y = mApothem;
            mE.X = mSegmentB; mE.Y = 2.0f * mApothem;
            mF.X = mSide + mSegmentB; mF.Y = 2.0f * mApothem;
        }

        // Función que permite graficar un triángulo en base a los valores de los tres 
        // vértices representados por tres puntos en un plano.
        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();

            CalculateVertex();

            mPen = new Pen(Color.Blue, 3);
            mGraph.DrawLine(mPen, mA.X * SF, mA.Y * SF, mB.X * SF, mB.Y * SF);
            mGraph.DrawLine(mPen, mA.X * SF, mA.Y * SF, mC.X * SF, mC.Y * SF);
            mGraph.DrawLine(mPen, mB.X * SF, mB.Y * SF, mD.X * SF, mD.Y * SF);
            mGraph.DrawLine(mPen, mE.X * SF, mE.Y * SF, mF.X * SF, mF.Y * SF);
            mGraph.DrawLine(mPen, mC.X * SF, mC.Y * SF, mE.X * SF, mE.Y * SF);
            mGraph.DrawLine(mPen, mD.X * SF, mD.Y * SF, mF.X * SF, mF.Y * SF);            
        }

    }
}
