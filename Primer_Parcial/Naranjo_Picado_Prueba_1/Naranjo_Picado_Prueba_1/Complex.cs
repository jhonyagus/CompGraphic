using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Naranjo_Picado_Prueba_1
{
    class Complex
    {
        private float mX, mY, mModule, mAngle;
        
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public Complex()
        {
            mX = 0.0f; mY = 0.0f;
        }
        public Complex(float x, float y)
        {
            mX = x; mY = y;
        }
        public float MX { get => mX; set => mX = value; }
        public float MY { get => mY; set => mY = value; }
        public float MModule { get => mModule; set => mModule = value; }
        public float MAngle { get => mAngle; set => mAngle = value; }

        public void ReadData(NumericUpDown nudXComplexV, NumericUpDown nudYComplexV)
        {
            try
            {
                mX = (float)(nudXComplexV.Value);
                mY = (float)(nudYComplexV.Value);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...");
            }
        }
        public void PrintData(TextBox txtXComplexV, TextBox txtYComplexV)
        {
            txtXComplexV.Text = mX.ToString();
            txtYComplexV.Text = mY.ToString();
        }
        public Complex Addition(Complex V)
        {
            return (new Complex(mX + V.mX, mY + V.mY));
        }
        public Complex Substraction(Complex V)
        {
            return (new Complex(mX - V.mX, mY - V.mY));
        }
        public Complex Multiplication(Complex V)
        {
            return (new Complex(mX * V.mX - mY * V.mY, mX * V.mY + mY * V.mX));
        }
        public Complex Division(Complex V)
        {
            return (new Complex((float)((mX * V.mX + mY * V.mY) / (Math.Pow(V.mX, 2) + Math.Pow(V.mY, 2))),
                (float)((mY * V.mX - mX * V.mY) / (Math.Pow(V.mX, 2) + Math.Pow(V.mY, 2)))));
        }
        public float ConvertirRadianesAGrados(float angulo)
        {
            return (float)(angulo * (180 / Math.PI));
        }
        public Complex VectorEscalarProduct(float escalar)
        {
            return (new Complex(mX * escalar, mY * escalar));
        }
        public float Module()
        {
            return (float)Math.Sqrt(mX * mX + mY * mY);
        }
        public float Argument()
        {
            float argument = 0.0f;

            if (mX > 0)
            {
                argument = ConvertirRadianesAGrados((float)Math.Atan(mY / mX));
            }
            else
            {
                if (mY >= 0)
                {
                    argument = ConvertirRadianesAGrados((float)(Math.Atan(mY / mX) + Math.PI));
                }
                else
                {
                    argument = ConvertirRadianesAGrados((float)(Math.Atan(mY / mX) - Math.PI));
                }
            }

            if (mX == 0)
            {
                if (mY > 0)
                {
                    argument = ConvertirRadianesAGrados((float)(Math.PI / 2));
                }
                else
                {
                    if (mY < 0)
                    {
                        argument = ConvertirRadianesAGrados((float)(-1 * Math.PI / 2));
                    }
                    else
                    {
                        argument = 0.0f;
                    }
                }
            }
            return argument;
        }
        public void GraphAxis(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Black);

            mGraph.DrawLine(mPen, 0, 150, 400, 150);
            mGraph.DrawLine(mPen, 200, 0, 200, 300);
        }
        public PointF VectorToPointF(Complex V)
        {
            return new PointF((float)V.mX * SF + 200, (-1) * (float)V.mY * SF + 150);
        }
        public void DrawVector(Complex V, Color color, PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(color, 3.0f);
            mPen.StartCap = LineCap.RoundAnchor; 
            mPen.EndCap = LineCap.ArrowAnchor; 

            PointF origin = VectorToPointF(new Complex(0, 0));
            PointF end = VectorToPointF(V);
            mGraph.DrawLine(mPen, origin, end);
        }
        public void DrawVector(Complex U, Complex V, Color color, PictureBox picCanvas)
        {
            float[] dashValues = { 2, 1, 2, 1 };
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(color, 1.5f);
            mPen.DashPattern = dashValues;
            V.mX = U.mX; V.mY = 0;
            PointF origin = VectorToPointF(U);
            PointF end = VectorToPointF(V);
            mGraph.DrawLine(mPen, origin, end);
            V.mX = 0; V.mY = U.mY;
            origin = VectorToPointF(U);
            end = VectorToPointF(V);
            mGraph.DrawLine(mPen, origin, end);
        }

    }
}
