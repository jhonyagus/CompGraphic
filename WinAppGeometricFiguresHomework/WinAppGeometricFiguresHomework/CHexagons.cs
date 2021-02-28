using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WinAppGeometricFiguresHomework
{
    class CHexagons
    {
        private float mSide, mApothem, mSegmentB, mAngle, mSegmentX;


        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 1;
        private PointF mG, mH, mI, mJ, mK, mL;
        private PointF mA, mB, mC, mD, mE, mF;

        public float MSide { get => mSide; set => mSide = value; }

        // Constructor por defecto.
        public CHexagons()
        {
            //mSide = 1f;
        }

        public void GraphShape(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            mAngle = 60.0f * (float)Math.PI / 180.0f;
            mSegmentB = MSide * (float)Math.Cos(mAngle);
            mApothem = MSide * (float)Math.Sin(mAngle);
            mSegmentX = 2.0f * MSide + 2.0f * mSegmentB;


            for (int i = 0; i<50; i++)
            {
                mA.X = mSegmentB + i * mSegmentX ; mA.Y = 0;
                mB.X = MSide + mSegmentB + i * mSegmentX; mB.Y = 0;
                mC.X = 0 + i * mSegmentX; mC.Y = mApothem;
                mD.X = MSide + 2.0f * mSegmentB + i * mSegmentX; mD.Y = mApothem;
                mE.X = mSegmentB + i * mSegmentX; mE.Y = 2.0f * mApothem;
                mF.X = MSide + mSegmentB + i * mSegmentX; mF.Y = 2.0f * mApothem;

                GraphicHexagons();

                mG.X = MSide + 2.0f * mSegmentB + i * mSegmentX; mG.Y = mApothem;
                mH.X = 2.0f * MSide + 2.0f * mSegmentB + i * mSegmentX; mH.Y = mG.Y;
                mI.X = MSide + mSegmentB + i * mSegmentX; mI.Y = 2.0f * mG.Y;
                mJ.X = 2.0f * MSide + 3.0f * mSegmentB + i * mSegmentX; mJ.Y = mI.Y;
                mK.X = MSide + 2.0f * mSegmentB + i * mSegmentX; mK.Y = 3.0f * mG.Y;
                mL.X = 2.0f * MSide + 2.0f * mSegmentB + i * mSegmentX; mL.Y = mK.Y;

                GraphicHexagons1();
            }         
        }

        private void GraphicHexagons() {
            for (int i = 1; i <= 50; i++)
            {
                mGraph.DrawLine(mPen, mA.X * SF, mA.Y * SF, mB.X * SF, mB.Y * SF);
                mGraph.DrawLine(mPen, mA.X * SF, mA.Y * SF, mC.X * SF, mC.Y * SF);
                mGraph.DrawLine(mPen, mB.X * SF, mB.Y * SF, mD.X * SF, mD.Y * SF);
                mGraph.DrawLine(mPen, mE.X * SF, mE.Y * SF, mF.X * SF, mF.Y * SF);
                mGraph.DrawLine(mPen, mC.X * SF, mC.Y * SF, mE.X * SF, mE.Y * SF);
                mGraph.DrawLine(mPen, mD.X * SF, mD.Y * SF, mF.X * SF, mF.Y * SF);

                mA.Y += 2.0f * mApothem;
                mB.Y += 2.0f * mApothem;
                mC.Y += 2.0f * mApothem;
                mD.Y += 2.0f * mApothem;
                mE.Y += 2.0f * mApothem;
                mF.Y += 2.0f * mApothem;
            }
        }

        private void GraphicHexagons1()
        {
            for (int i = 1; i <= 50; i++)
            {
                mGraph.DrawLine(mPen, mG.X * SF, mG.Y * SF, mH.X * SF, mH.Y * SF);
                mGraph.DrawLine(mPen, mG.X * SF, mG.Y * SF, mI.X * SF, mI.Y * SF);
                mGraph.DrawLine(mPen, mH.X * SF, mH.Y * SF, mJ.X * SF, mJ.Y * SF);
                mGraph.DrawLine(mPen, mK.X * SF, mK.Y * SF, mL.X * SF, mL.Y * SF);
                mGraph.DrawLine(mPen, mI.X * SF, mI.Y * SF, mK.X * SF, mK.Y * SF);
                mGraph.DrawLine(mPen, mJ.X * SF, mJ.Y * SF, mL.X * SF, mL.Y * SF);

                mG.Y += 2.0f * mApothem;
                mH.Y += 2.0f * mApothem;
                mI.Y += 2.0f * mApothem;
                mJ.Y += 2.0f * mApothem;
                mK.Y += 2.0f * mApothem;
                mL.Y += 2.0f * mApothem;
            }
        }
    }

}
