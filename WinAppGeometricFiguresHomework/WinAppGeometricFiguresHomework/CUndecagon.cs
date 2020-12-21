using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinAppGeometricFiguresHomework
{
    class CUndecagon
    {
        // Datos miembro - Atributos.
        private float mSide, mSegmentA, mSegmentB, mSegmentC,mSegmentD, mSegmentE,
                      mSegmentF, mSegmentG, mSegmentH, mSegmentI, mSegmentJ,
                      mAngleA, mAngleB, mAngleC, mAngleD, mAngleE;
        private float mPerimeter, mArea, mApothem;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mA, mB, mC, mD, mE, mF, mG, mH, mI, mJ, mK;

        // Funciones miembro - Métodos.

        // Constructor por defecto.
        public CUndecagon()
        {
            mSide = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Función que permite leer los tres lados del triángulo.
        public void ReadData(TextBox txtSideSide)
        {
            mSide = float.Parse(txtSideSide.Text);
        }

        // Función que permite calcular el perímetro del triángulo.
        public void PerimeterUndecagon()
        {
            mPerimeter = 11 * mSide;
        }

        // Función que permite calcular el área del triángulo.
        public void AreaUndecagon()
        {
            //float mAngle3 = 22.5f * (float)Math.PI / 180.0f;
            //  mApothem = (mSide / 2.0f) / (float)Math.Tan(mAngle3);

            //mAngle1 = 45.0f * (float)math.PI / 180.0f;
            //mSegmentB = mSide * (float)Math.cos(mAngle1);
            //

            // mArea = mPerimeter * mApothem / 2.0f;
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

        // Función que permite calcular los valores de los ocho vértices del octagono,
        // utilizando fórmulas de Geometría Analítica.
        private void CalculateVertex()
        {
            mAngleA = 32.73f * (float)Math.PI / 180.0f; //convertir a radianes
            mAngleB = 65.46f * (float)Math.PI / 180.0f; //convertir a radianes
            mAngleC = 8.19f * (float)Math.PI / 180.0f; //convertir a radianes
            mAngleD = 40.905f * (float)Math.PI / 180.0f; //convertir a radianes
            mAngleE = 73.635f * (float)Math.PI / 180.0f; //convertir a radianes
            mSegmentB = mSide * (float)Math.Cos(mAngleA);
            mSegmentA = mSide * (float)Math.Sin(mAngleA);
            mSegmentC = mSide * (float)Math.Sin(mAngleB);
            mSegmentD = mSide * (float)Math.Cos(mAngleB);
            mSegmentE = mSide * (float)Math.Sin(mAngleC);
            mSegmentF = mSide * (float)Math.Cos(mAngleC);
            mSegmentG = mSide * (float)Math.Sin(mAngleD);
            mSegmentH = mSide * (float)Math.Cos(mAngleD);
            mSegmentI = mSide * (float)Math.Sin(mAngleE);
            mSegmentJ = mSide * (float)Math.Cos(mAngleE);

            mA.X = mSegmentB + mSegmentD; mA.Y = 0;
            mB.X = mSegmentD; mB.Y = mSegmentA;
            mC.X = 0; mC.Y = mSegmentA + mSegmentC;
            mD.X = mSegmentE; mD.Y = mC.Y + mSegmentF;
            mE.X = mD.X + mSegmentG; mE.Y = mD.Y + mSegmentH;
            mF.X = mE.X + mSegmentI; mF.Y = mE.Y + mSegmentJ;
            mG.X = mF.X + mSegmentI; mG.Y = mE.Y;
            mH.X = mG.X + mSegmentG; mH.Y = mD.Y;
            mI.X = mH.X + mSegmentE; mI.Y = mC.Y;
            mJ.X = mA.X + mSide + mSegmentB; mJ.Y = mSegmentA;
            mK.X = mA.X + mSide; mK.Y = 0;
        }
        // Función que permite graficar un triángulo en base a los valores de los tres 
        // vértices representados por tres puntos en un plano.
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
            mGraph.DrawLine(mPen, mG.X * SF, mG.Y * SF, mH.X * SF, mH.Y * SF);
            mGraph.DrawLine(mPen, mH.X * SF, mH.Y * SF, mI.X * SF, mI.Y * SF);
            mGraph.DrawLine(mPen, mI.X * SF, mI.Y * SF, mJ.X * SF, mJ.Y * SF);
            mGraph.DrawLine(mPen, mJ.X * SF, mJ.Y * SF, mK.X * SF, mK.Y * SF);
            mGraph.DrawLine(mPen, mK.X * SF, mK.Y * SF, mA.X * SF, mA.Y * SF);
        }
    }
}
