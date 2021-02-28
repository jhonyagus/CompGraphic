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
        private PointF iA, iB, iC, iD, iE, iF, iG, iH, iI, iJ;
        private float mSide, mAngle, mAngleA, mA, mB, mC, mD;


        public CPentagon()
        {
            mSide = 12.0f;
        }

        private PointF HalfPoint(PointF A, PointF B)
        {
            return new PointF((A.X + B.X)/2,(A.Y+B.Y)/2); 
        }

        public PointF VectorToPointF(PointF V)
        {
            return new PointF((float)V.X * SF+75, (-1) * (float)V.Y * SF+400);
        }

        private void CalculateIntersections()
        {
            CRecta FC = new CRecta();
            CRecta BG = new CRecta();
            CRecta HA = new CRecta();
            CRecta AI = new CRecta();
            CRecta BI = new CRecta();
            CRecta HC = new CRecta();
            CRecta FD = new CRecta();
            CRecta CJ = new CRecta();
            CRecta BJ = new CRecta();
            CRecta HE = new CRecta();
            CRecta DI = new CRecta();
            FC.Pending(F, C);
            FC.Ecuation(F);
            BG.Pending(B, G);
            BG.Ecuation(B);
            HA.Pending(H, A);
            HA.Ecuation(H);
            AI.Pending(A, I);
            AI.Ecuation(A);
            BI.Pending(B, I);
            BI.Ecuation(B);
            HC.Pending(H, C);
            HC.Ecuation(H);
            FD.Pending(F, D);
            FD.Ecuation(F);
            CJ.Pending(C, J);
            CJ.Ecuation(C);
            BJ.Pending(B, J);
            BJ.Ecuation(B);
            HE.Pending(H, E);
            HE.Ecuation(H);
            DI.Pending(D, I);
            DI.Ecuation(D);

            iA = FC.Intersection(FC, BG);
            iA = VectorToPointF(iA);
            iB = HA.Intersection(HA, BG);
            iB = VectorToPointF(iB);
            iC = FC.Intersection(FC, AI);
            iC = VectorToPointF(iC);
            iD = HA.Intersection(HA, BI);
            iD = VectorToPointF(iD);
            iE = FC.Intersection(AI, HC);
            iE = VectorToPointF(iE);
            iF = HA.Intersection(FD, HC);
            iF = VectorToPointF(iF);
            iG = FC.Intersection(BI, CJ);
            iG = VectorToPointF(iG);
            iH = HA.Intersection(BJ, HE);
            iH = VectorToPointF(iH);
            iI = FC.Intersection(DI, CJ);
            iI = VectorToPointF(iI);
            iJ = HA.Intersection(HE, DI);
            iJ = VectorToPointF(iJ);
        }

        private void CalculatePoints()
        {
            mAngle = 36.0f * (float)Math.PI / 180.0f;
            mAngleA = 72.0f * (float)Math.PI / 180.0f;
            mC = mSide * (float)Math.Cos(mAngle);
            mD = mSide * (float)Math.Sin(mAngle);
            mA = mSide * (float)Math.Sin(mAngleA);
            mB = mSide * (float)Math.Cos(mAngleA);
            A.X = mSide/2.0f; A.Y = mA + mD;
            B.X = (-1.0f) *mB; B.Y = mA;
            C.X = mSide + mB; C.Y = mA;
            D.X = 0; D.Y = 0;
            E.X = mSide; E.Y = 0;
            F.X = 0.5F*mC - mB; F.Y = mA + 0.5f * mD;
            G.X = 0.5F*mC + 0.5f * mSide; G.Y = mA + 0.5f * mD;
            H.X = (-0.5f)*mB; H.Y = 0.5f * mA;
            I.X = mSide + 0.5f * mB; I.Y = 0.5f * mA;
            J.X = mSide  * 0.5f; J.Y = 0;
            K = HalfPoint(B, C);
            L = HalfPoint(A, D);
            M = HalfPoint(A, E);
            N = HalfPoint(B, E);
            O = HalfPoint(D, C);
        }

        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();

            CalculatePoints();

            mPen = new Pen(Color.Blue, 2.0f);
            mPen1 = new Pen(Color.Red, 2.0f);
            mGraph.DrawLine(mPen, VectorToPointF(A), VectorToPointF(B));
            mGraph.DrawLine(mPen, VectorToPointF(B), VectorToPointF(D));
            mGraph.DrawLine(mPen, VectorToPointF(C), VectorToPointF(A));
            mGraph.DrawLine(mPen, VectorToPointF(D), VectorToPointF(E));
            mGraph.DrawLine(mPen, VectorToPointF(E), VectorToPointF(C));

            mGraph.DrawLine(mPen, VectorToPointF(A), VectorToPointF(D));
            mGraph.DrawLine(mPen, VectorToPointF(A), VectorToPointF(H));
            mGraph.DrawLine(mPen, VectorToPointF(A), VectorToPointF(E));
            mGraph.DrawLine(mPen, VectorToPointF(A), VectorToPointF(I));

            mGraph.DrawLine(mPen, VectorToPointF(B), VectorToPointF(G));
            mGraph.DrawLine(mPen, VectorToPointF(B), VectorToPointF(C));
            mGraph.DrawLine(mPen, VectorToPointF(B), VectorToPointF(J));
            mGraph.DrawLine(mPen, VectorToPointF(B), VectorToPointF(E));

            mGraph.DrawLine(mPen, VectorToPointF(C), VectorToPointF(F));
            mGraph.DrawLine(mPen, VectorToPointF(C), VectorToPointF(D));
            mGraph.DrawLine(mPen, VectorToPointF(C), VectorToPointF(J));

            mGraph.DrawLine(mPen, VectorToPointF(D), VectorToPointF(F));
            mGraph.DrawLine(mPen, VectorToPointF(D), VectorToPointF(I));

            mGraph.DrawLine(mPen, VectorToPointF(E), VectorToPointF(G));
            mGraph.DrawLine(mPen, VectorToPointF(E), VectorToPointF(H));

            mGraph.DrawLine(mPen, VectorToPointF(F), VectorToPointF(J));
            mGraph.DrawLine(mPen, VectorToPointF(F), VectorToPointF(I));

            mGraph.DrawLine(mPen, VectorToPointF(G), VectorToPointF(H));
            mGraph.DrawLine(mPen, VectorToPointF(G), VectorToPointF(J));

            mGraph.DrawLine(mPen, VectorToPointF(H), VectorToPointF(I));

            mGraph.DrawLine(mPen, VectorToPointF(A), VectorToPointF(K));
            mGraph.DrawLine(mPen, VectorToPointF(B), VectorToPointF(L));
            mGraph.DrawLine(mPen, VectorToPointF(C), VectorToPointF(M));
            mGraph.DrawLine(mPen, VectorToPointF(D), VectorToPointF(N));
            mGraph.DrawLine(mPen, VectorToPointF(E), VectorToPointF(O));

            CalculateIntersections();
            mGraph.DrawLine(mPen1, iA, iB);
            mGraph.DrawLine(mPen1, iA, iC);
            mGraph.DrawLine(mPen1, iB, iD);
            mGraph.DrawLine(mPen1, iD, iF);
            mGraph.DrawLine(mPen1, iF, iH);
            mGraph.DrawLine(mPen1, iH, iJ);
            mGraph.DrawLine(mPen1, iJ, iI);
            mGraph.DrawLine(mPen1, iI, iG);
            mGraph.DrawLine(mPen1, iG, iE);
            mGraph.DrawLine(mPen1, iE, iC);

            mGraph.DrawLine(mPen1, VectorToPointF(K), VectorToPointF(L));
            mGraph.DrawLine(mPen1, VectorToPointF(K), VectorToPointF(M));
            mGraph.DrawLine(mPen1, VectorToPointF(L), VectorToPointF(N));
            mGraph.DrawLine(mPen1, VectorToPointF(N), VectorToPointF(O));
            mGraph.DrawLine(mPen1, VectorToPointF(O), VectorToPointF(M));

            mGraph.DrawLine(mPen1, iA, VectorToPointF(K));
            mGraph.DrawLine(mPen1, iD, VectorToPointF(L));
            mGraph.DrawLine(mPen1, iH, VectorToPointF(N));
            mGraph.DrawLine(mPen1, iI, VectorToPointF(O));
            mGraph.DrawLine(mPen1, iE, VectorToPointF(M));
        }
    }
}
