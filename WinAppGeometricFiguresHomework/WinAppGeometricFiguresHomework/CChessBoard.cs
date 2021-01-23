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
        private const float SF = 1;
        private Pen mPen;
        private PointF mP1, mP2, mP3;
        PointF A, B, C, D;
        PointF A1, B1, C1, D1;

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
            maxX = d.X-1; maxY = d.Y-1;
            //maxX = 600 - 1; maxY = 600 - 1;
            minMaxXY = Math.Min(maxX, maxY);
            //xCenter = 300, yCenter = 300
            xCenter = maxX / 2; yCenter = maxY / 2;
        }

        public PointF iX(PointF V)
        {
            return new PointF((float)V.X * SF, (-1) * (float)V.Y * SF + 600);
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);

            InitializeData(picCanvas);

            float side = 0.95f * minMaxXY;
            float sideHalf = 0.5f * side;
            float h = sideHalf * (float)Math.Sqrt(3);
            float p, q;

            q = 0.05f; //5%
            p = 1 - q;  //95%
            A.X = sideHalf; A.Y = 0;
            B.X = xCenter * 2; B.Y = sideHalf;
            C.X = sideHalf; C.Y = yCenter * 2;
            D.X = 0; D.Y = sideHalf;
            for (int i = 0; i < 50; i++)
            {
                mGraph.DrawLine(mPen, iX(A), iX(B));
                mGraph.DrawLine(mPen, iX(B), iX(C));
                mGraph.DrawLine(mPen, iX(C), iX(D));
                mGraph.DrawLine(mPen, iX(D), iX(A));

                A1.X = p * A.X + q * B.X;
                A1.Y = p * A.Y + q * B.Y;
                B1.X = p * B.X + q * C.X;
                B1.Y = p * B.Y + q * C.Y;
                C1.X = p * C.X + q * D.X;
                C1.Y = p * C.Y + q * D.Y;
                D1.X = p * D.X + q * A.X;
                D1.Y = p * D.Y + q * A.Y;
                A.X = A1.X; B.X = B1.X; C.X = C1.X; D.X = D1.X;
                A.Y = A1.Y; B.Y = B1.Y; C.Y = C1.Y; D.Y = D1.Y;
            }

        }
    }
}
