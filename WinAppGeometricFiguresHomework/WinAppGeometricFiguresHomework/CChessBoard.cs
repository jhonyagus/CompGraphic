using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinAppGeometricFiguresHomework
{
    class CChessBoard
    {
        // Datos miembro - Atributos.
        private int maxX, maxY, minMaxXY, xCenter, yCenter;
        private Rectangle d;

        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;
        private PointF mP1, mP2, mP3;

        // Funciones miembro - Métodos.

        // Constructor sin parámetros.
        public CChessBoard()
        {

        }

        public void InitializeData(PictureBox picCanvas)
        {
            picCanvas.Refresh();

            d = new Rectangle();
            d.X = picCanvas.Width;
            d.Y = picCanvas.Height;

            //Resolucion 600x600
            //Eje x: 0,1,2,..,599
            //Eje y: 0,1,2,...,599
            maxX = d.X - 1; maxY = d.Y - 1;
            //maxX = 800 - 1; maxY = 600 - 1;
            minMaxXY = Math.Min(maxX, maxY);
            //xCenter = 400, yCenter = 300
            xCenter = maxX / 2; yCenter = maxY / 2;
        }

        private int iX(float x)
        {
            return ((int)Math.Round(x));
        }

        private int iY(float y)
        {
            return (maxY - (int)Math.Round(y));
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 1);

            InitializeData(picCanvas);

            float side = 0.95f * minMaxXY;
            float sideHalf = 0.5f * side;
            float h = sideHalf * (float)Math.Sqrt(3);
            float xA, yA, xB, yB, xC, yC, xD, yD;
            float xA1, yA1, xB1, yB1, xC1, yC1, xD1, yD1;
            float p, q;

            q = 0.05f; //5%
            p = 1 - q;  //95%
            xA = sideHalf;
            yA = 0;
            xB = xCenter*2.0f;
            yB = sideHalf;
            xC = sideHalf;
            yC = yCenter*2.0f ;
            xD = 0;
            yD = sideHalf;

            for (int i = 0; i < 1; i++)
            {
                mGraph.DrawLine(mPen, iX(xA), iY(yA), iX(xB), iY(yB));
                mGraph.DrawLine(mPen, iX(xB), iY(yB), iX(xC), iY(yC));
                mGraph.DrawLine(mPen, iX(xC), iY(yC), iX(xD), iY(yD));
                mGraph.DrawLine(mPen, iX(xD), iY(yD), iX(xA), iY(yA));

                xA1 = xA*2.5f;
                yA1 = yA*2.5f;
                xB1 = p * xB + q * xC;
                yB1 = p * yB + q * yC;
                xC1 = p * xC + q * xA;
                yC1 = p * yC + q * yA;
                xD1 = p * xD + q * xD; 
                yD1 = p * yD + q * yD;
                xA = xA1; xB = xB1; xC = xC1; xD = xD1;
                yA = yA1; yB = yB1; yC = yC1; yD = yD1;
            }

        }
    }
}
