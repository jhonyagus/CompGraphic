using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NaranjoPicado_Examen
{
    class CPentagon
    {
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen, mPen1;
        private PointF A, B, C, D, E, F, G, H, I, J, K, L, M, N, O;
        private float mSide, mAngle, mAngleA, mA, mB, mC, mD;

        public CPentagon()
        {
            mSide = 12.0f;
        }

        private PointF HalfPoint(PointF A, PointF B)
        {
            return new PointF((A.X + B.X)/2,(A.Y+B.Y)/2); 
        }

        private void CalculateVertex()
        {
            mAngle = 36.0f * (float)Math.PI / 180.0f;
            mAngleA = 72.0f * (float)Math.PI / 180.0f;
            mB = mSide * (float)Math.Cos(mAngle);
            mA = mSide * (float)Math.Sin(mAngle);
            mC = mSide * (float)Math.Sin(mAngleA);
            mD = mSide * (float)Math.Cos(mAngleA);

            A.X = mB; A.Y = 0;
            B.X = 0; B.Y = mA;
            C.X = 2.0f * mB; C.Y = mA;
            D.X = mD; D.Y = mA + mC;
            E.X = mD + mSide; E.Y = mA + mC;
            F.X = A.X / 2; F.Y = B.Y / 2;
            G.X = 1.5f * mB; G.Y = 0.5f * mA;
            H.X = D.X / 2; H.Y = mA + 0.5f * mC;
            I.X = C.X - 0.5f * mD; I.Y = H.Y;
            J.X = mD + 0.5f * mSide; J.Y = mA + mC;
            K = HalfPoint(B, C);
            L = HalfPoint(A, D);
            M = HalfPoint(A, E);
            N = HalfPoint(B, E);
            O = HalfPoint(D, C);
        }

        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();

            CalculateVertex();

            mPen = new Pen(Color.Blue, 2.0f);
            mGraph.DrawLine(mPen, A.X * SF, A.Y * SF, B.X * SF, B.Y * SF);
            mGraph.DrawLine(mPen, B.X * SF, B.Y * SF, D.X * SF, D.Y * SF);
            mGraph.DrawLine(mPen, C.X * SF, C.Y * SF, A.X * SF, A.Y * SF);
            mGraph.DrawLine(mPen, D.X * SF, D.Y * SF, E.X * SF, E.Y * SF);
            mGraph.DrawLine(mPen, E.X * SF, E.Y * SF, C.X * SF, C.Y * SF);

            mGraph.DrawLine(mPen, A.X * SF, A.Y * SF, D.X * SF, D.Y * SF);
            mGraph.DrawLine(mPen, A.X * SF, A.Y * SF, H.X * SF, H.Y * SF);
            mGraph.DrawLine(mPen, A.X * SF, A.Y * SF, E.X * SF, E.Y * SF);
            mGraph.DrawLine(mPen, A.X * SF, A.Y * SF, I.X * SF, I.Y * SF);

            mGraph.DrawLine(mPen, B.X * SF, B.Y * SF, G.X * SF, G.Y * SF);
            mGraph.DrawLine(mPen, B.X * SF, B.Y * SF, C.X * SF, C.Y * SF);
            mGraph.DrawLine(mPen, B.X * SF, B.Y * SF, J.X * SF, J.Y * SF);
            mGraph.DrawLine(mPen, B.X * SF, B.Y * SF, E.X * SF, E.Y * SF);
            
            mGraph.DrawLine(mPen, C.X * SF, C.Y * SF, F.X * SF, F.Y * SF);
            mGraph.DrawLine(mPen, C.X * SF, C.Y * SF, B.X * SF, B.Y * SF);
            mGraph.DrawLine(mPen, C.X * SF, C.Y * SF, D.X * SF, D.Y * SF);
            mGraph.DrawLine(mPen, C.X * SF, C.Y * SF, J.X * SF, J.Y * SF);

            mGraph.DrawLine(mPen, D.X * SF, D.Y * SF, F.X * SF, F.Y * SF);
            mGraph.DrawLine(mPen, D.X * SF, D.Y * SF, I.X * SF, I.Y * SF);

            mGraph.DrawLine(mPen, E.X * SF, E.Y * SF, G.X * SF, G.Y * SF);
            mGraph.DrawLine(mPen, E.X * SF, E.Y * SF, H.X * SF, H.Y * SF);

            mGraph.DrawLine(mPen, F.X * SF, F.Y * SF, J.X * SF, J.Y * SF);
            mGraph.DrawLine(mPen, F.X * SF, F.Y * SF, I.X * SF, I.Y * SF);

            mGraph.DrawLine(mPen, G.X * SF, G.Y * SF, H.X * SF, H.Y * SF);
            mGraph.DrawLine(mPen, G.X * SF, G.Y * SF, J.X * SF, J.Y * SF);

            mGraph.DrawLine(mPen, H.X * SF, H.Y * SF, I.X * SF, I.Y * SF);

            mGraph.DrawLine(mPen, A.X * SF, A.Y * SF, K.X * SF, K.Y * SF);
            mGraph.DrawLine(mPen, B.X * SF, B.Y * SF, L.X * SF, L.Y * SF);
            mGraph.DrawLine(mPen, C.X * SF, C.Y * SF, M.X * SF, M.Y * SF);
            mGraph.DrawLine(mPen, D.X * SF, D.Y * SF, N.X * SF, N.Y * SF);
            mGraph.DrawLine(mPen, E.X * SF, E.Y * SF, O.X * SF, O.Y * SF);
        }
    }
}
