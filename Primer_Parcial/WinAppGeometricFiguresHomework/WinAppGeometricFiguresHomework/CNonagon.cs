﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinAppGeometricFiguresHomework
{
    class CNonagon
    {
        // Datos miembro - Atributos.
        private float mSide, mSegmentA, mSegmentB, mSegmentC, 
                      mSegmentD, mSegmentE, mSegmentF, mSegmentG, mSegmentH,
                      mAngleA, mAngleB, mAngleC, mAngleD;
        private float mPerimeter, mArea, mApothem;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 20;
        private PointF mA, mB, mC, mD, mE, mF, mG, mH, mI;

        // Funciones miembro - Métodos.

        // Constructor por defecto.
        public CNonagon()
        {
            mSide = 0.0f; mPerimeter = 0.0f; mArea = 0.0f;
        }

        // Función que permite leer el lado del nonágono.
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

        // Función que permite calcular el perímetro del nonágono.
        public void PerimeterNonagon()
        {
            mPerimeter = 9 * mSide;
        }

        // Función que permite calcular el área del nonágono.
        public void AreaNonagon()
        {
            float angle = (2 * (float)Math.PI) / (2 * 9);
            float a = mSide / (2 * (float)Math.Tan((double)angle));
            mArea = (mPerimeter * a) / 2;
        }

        // Función que permite imprimir el perímetro y el área del nonágono.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        // Función que permite inicializar los datos y controles que operan en 
        // la GUI del nonágono.
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

        // Función que permite calcular los valores de los nueve vértices del nonágono,
        // utilizando fórmulas de Geometría Analítica.
        private void CalculateVertex()
        {
            mAngleA = 40.0f * (float)Math.PI / 180.0f; //convertir a radianes
            mAngleB = 80.0f * (float)Math.PI / 180.0f; //convertir a radianes
            mAngleC = 60.0f * (float)Math.PI / 180.0f; //convertir a radianes
            mAngleD = 20.0f * (float)Math.PI / 180.0f; //convertir a radianes
            mSegmentB = mSide * (float)Math.Cos(mAngleA);
            mSegmentA = mSide * (float)Math.Sin(mAngleA);
            mSegmentC = mSide * (float)Math.Sin(mAngleB);
            mSegmentD = mSide * (float)Math.Cos(mAngleB);
            mSegmentE = mSide * (float)Math.Cos(mAngleC);
            mSegmentF = mSide * (float)Math.Sin(mAngleC);
            mSegmentG = mSide * (float)Math.Cos(mAngleD);
            mSegmentH = mSide * (float)Math.Sin(mAngleD);

            mA.X = mSegmentB + mSegmentD; mA.Y = 0;
            mB.X = mSegmentD; mB.Y = mSegmentA;
            mC.X = 0; mC.Y = mSegmentA + mSegmentC;
            mD.X = mSegmentE; mD.Y = mSegmentA + mSegmentC + mSegmentF;
            mE.X = mSegmentG + mSegmentE; mE.Y = mSegmentA + mSegmentC + mSegmentF + mSegmentH;
            mF.X = 2.0f * mSegmentG + mSegmentE; mF.Y = mSegmentA + mSegmentC + mSegmentF;
            mG.X = 2.0f * mSegmentG + 2.0f * mSegmentE; mG.Y = mSegmentA + mSegmentC;
            mH.X = (2.0f * mSegmentG + 2.0f * mSegmentE) - mSegmentD; mH.Y = mSegmentA;
            mI.X = mSegmentD + mSegmentB + mSide; mI.Y = 0;
        }
        // Función que permite graficar un nonágono en base a los valores de los nueve 
        // vértices representados por nueve puntos en un plano.
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
            mGraph.DrawLine(mPen, mI.X * SF, mI.Y * SF, mA.X * SF, mA.Y * SF);
        }
    }
}
