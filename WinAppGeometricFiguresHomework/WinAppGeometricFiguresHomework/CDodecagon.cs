﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinAppGeometricFiguresHomework
{
    class CDodecagon
    {
        // Datos miembro - Atributos.
        private float mSide, mSegmentA, mSegmentB, mSegmentC, mAngleA, mAngleB;
        private float mPerimeter, mArea, mApothem;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mA, mB, mC, mD, mE, mF, mG, mH, mI, mJ, mK, mL;

        // Funciones miembro - Métodos.

        // Constructor por defecto.
        public CDodecagon()
        {
            mSide = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Función que permite leer los tres lados del triángulo.
        public void ReadData(TextBox txtSideSide)
        {
            mSide = float.Parse(txtSideSide.Text);
        }

        // Función que permite calcular el perímetro del triángulo.
        public void PerimeterDodecagon()
        {
            mPerimeter = 12 * mSide;
        }

        // Función que permite calcular el área del triángulo.
        public void AreaDodecagon()
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
            mAngleA = 15.0f * (float)Math.PI / 180.0f; //convertir a radianes
            mAngleB = 45.0f * (float)Math.PI / 180.0f; //convertir a radianes
            mSegmentA = mSide * (float)Math.Sin(mAngleA);
            mSegmentB = mSide * (float)Math.Cos(mAngleA);
            mSegmentC = mSide * (float)Math.Sin(mAngleB);
           
            mA.X = mSegmentA + mSegmentB + mSegmentC; mA.Y = 0;
            mB.X = mSegmentA + mSegmentC; mB.Y = mSegmentA;
            mC.X = mSegmentA; mC.Y = mSegmentA + mSegmentC;
            mD.X = 0; mD.Y = mC.Y + mSegmentB;
            mE.X = mC.X; mE.Y = mD.Y + mSegmentB;
            mF.X = mB.X; mF.Y = mE.Y + mSegmentC;
            mG.X = mA.X; mG.Y = mF.Y+mSegmentA;
            mH.X = mG.X + mSegmentB; mH.Y = mF.Y;
            mI.X = mH.X + mSegmentC; mI.Y = mE.Y;
            mJ.X = mI.X + mSegmentA; mJ.Y = mD.Y;
            mK.X = mI.X; mK.Y = mC.Y;
            mL.X = mH.X; mL.Y = mB.Y;
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
            mGraph.DrawLine(mPen, mK.X * SF, mK.Y * SF, mL.X * SF, mL.Y * SF);
            mGraph.DrawLine(mPen, mL.X * SF, mL.Y * SF, mA.X * SF, mA.Y * SF);
        }
    
    }
}
