using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace WinAppGeometricFiguresHomework
{
    class CConcentricSquare
    {
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen, mPen1;
        private PointF A, B, C, D, O;
        private float b;
        public CConcentricSquare()
        {

        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 2);
            mPen1 = new Pen(Color.Red, 2);
            mGraph.DrawEllipse(mPen, 0, 0, 4*2 * SF, 4*2 * SF);

            b = 8.0f;
            for (int i = 0; i<=10; i++)
            {
                A.X = (-b) * SF + 300; A.Y = (-1) * b * SF + 200;
                B.X = b * SF + 300; B.Y = (-1) * b * SF + 200;
                D.X = (-b) * SF + 300; D.Y = b * SF + 200;
                C.X = b * SF + 300; C.Y = b * SF + 200;
                mGraph.DrawLine(mPen, A, B);
                mGraph.DrawLine(mPen, B, C);
                mGraph.DrawLine(mPen, C, D);
                mGraph.DrawLine(mPen, D, A);

                A.X = 300; A.Y = (-1) * b * SF + 200;
                B.X = (-b) * SF + 300; B.Y = 200;
                D.X = b * SF + 300; D.Y = 200;
                C.X = 300; C.Y = b * SF + 200;
                mGraph.DrawLine(mPen1, A, B);
                mGraph.DrawLine(mPen1, B, C);
                mGraph.DrawLine(mPen1, C, D);
                mGraph.DrawLine(mPen1, D, A);
                b = b /2.0f;
            }
        }
    }
}
