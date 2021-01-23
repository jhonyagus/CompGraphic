using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace WinAppGeometricFiguresHomework
{
    class CDashedLines
    {
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen, mPen1;
        private PointF A, B, C, D, E, F, G, H;
        private float a, b;

        public CDashedLines()
        {
            b = 14.0f;
            a = 7.0f;
        }

        public PointF VectorToPointF(PointF V)
        {
            return new PointF((float)V.X * SF + 300, (-1) * (float)V.Y * SF + 200);
        }

        public void PlotShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 2);
            float[] dashValues = { 2, 1, 2, 1 };
            mPen1 = new Pen(Color.Blue, 2);
            mPen1.DashPattern = dashValues;

            A.X = (-b); A.Y = a;
            B.X = (-b); B.Y = -a;
            D.X = (b); D.Y = a;
            C.X = b; C.Y = -a;
            mGraph.DrawLine(mPen, VectorToPointF(A), VectorToPointF(B));
            mGraph.DrawLine(mPen, VectorToPointF(B), VectorToPointF(C));
            mGraph.DrawLine(mPen, VectorToPointF(C), VectorToPointF(D));
            mGraph.DrawLine(mPen, VectorToPointF(D), VectorToPointF(A));
            E.X = 0.5f * A.X; E.Y = 0.5f * A.Y;
            F.X = 0.5f * B.X; F.Y = 0.5f * B.Y;
            H.X = 0.5f * D.X; H.Y = 0.5f * D.Y;
            G.X = 0.5f * C.X; G.Y = 0.5f * C.Y;
            mGraph.DrawLine(mPen1, VectorToPointF(E), VectorToPointF(F));
            mGraph.DrawLine(mPen1, VectorToPointF(F), VectorToPointF(G));
            mGraph.DrawLine(mPen1, VectorToPointF(G), VectorToPointF(H));
            mGraph.DrawLine(mPen1, VectorToPointF(H), VectorToPointF(E));

            mGraph.DrawLine(mPen1, VectorToPointF(A), VectorToPointF(E));
            mGraph.DrawLine(mPen1, VectorToPointF(D), VectorToPointF(H));
            mGraph.DrawLine(mPen1, VectorToPointF(B), VectorToPointF(F));
            mGraph.DrawLine(mPen1, VectorToPointF(C), VectorToPointF(G));



        }

    }
}
