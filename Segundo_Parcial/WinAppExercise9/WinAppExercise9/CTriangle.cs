using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppExercise9
{
    class CTriangle
    {
        // Datos miembro - Atributos.
        private float mA, mB, mC;
        private float mPerimeter, mArea, mSemiperimeter;

        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;
        private const float SF = 10;
        private PointF mP1, mP2, mP3, Center, G, P, H, I;
        private float mAngleA, mAngleB, mAngleC;

        // Funciones miembro - Métodos.

        // Constructor sin parámetros.
        public CTriangle()
        {
            mA = 0.0f; mB = 0.0f; mC = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f;
        }
        //Funcion que permite inicializar el centro de nuestro grafico en este caso
        //las coordenadas (mitad ancho picturebox, mitad alto picturebox)
        public void Initialize(PictureBox picCanvas)
        {
            Center.X = picCanvas.Width / 2;
            Center.Y = picCanvas.Height / 2;
        }

        // Función que permite leer los Vertices del triangulo.
        public void ReadData(TextBox txtAX,
                             TextBox txtAY,
                             TextBox txtBX,
                             TextBox txtBY,
                             TextBox txtCX,
                             TextBox txtCY)
        {
            try
            {
                mP1.X = float.Parse(txtAX.Text);
                mP1.Y = float.Parse(txtAY.Text);
                mP2.X = float.Parse(txtBX.Text);
                mP2.Y = float.Parse(txtBY.Text);
                mP3.X = float.Parse(txtCX.Text);
                mP3.Y = float.Parse(txtCY.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...");
            }
        }

        // Función que permite calcular el semi-perímetro del triángulo.
        private float SemiperimeterTriangle()
        {
            mSemiperimeter = ((mA + mB + mC) / 2);
            return mSemiperimeter;
        }

        // Función que permite calcular el perímetro del triángulo.
        public void PerimeterTriangle()
        {
            float s = SemiperimeterTriangle();
            mPerimeter = 2 * s;
        }

        // Función que permite calcular el área del triángulo.
        public void AreaTriangle()
        {
            float s = SemiperimeterTriangle();
            mArea = (float)Math.Sqrt(s * (s - mA) * (s - mB) * (s - mC));
        }

        // Función que permite imprimir el perímetro y el área del triángulo.
        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        // Función que permite inicializar los datos y controles que operan en 
        // la GUI del triángulo.
        public void InitializeData(TextBox txtAX,
                                   TextBox txtAY,
                                   TextBox txtBX,
                                   TextBox txtBY,
                                   TextBox txtCX,
                                   TextBox txtCY,
                                   TextBox txtPerimeter,
                                   TextBox txtArea,
                                   PictureBox picCanvas)
        {
            txtAX.Text = ""; txtAY.Text = ""; txtBX.Text = ""; txtBY.Text = ""; txtCX.Text = ""; txtCY.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            // Mantiene el cursor titilando en una caja de texto.
            txtAX.Focus();
            mA = 0.0f; mB = 0.0f; mC = 0.0f;
            mP1 = new PointF(); mP2 = new PointF(); mP3 = new PointF();
            mPerimeter = 0.0f; mArea = 0.0f; mAngleA = 0.0f; mAngleB = 0.0f; mAngleC = 0.0f;
            picCanvas.Refresh();
        }

        // Función que permite validar la existencia de un triángulo.
        public bool CheckTriangle()
        {
            mA = DistancePoints(mP2, mP3);
            mB = DistancePoints(mP1, mP3);
            mC = DistancePoints(mP1, mP2);
            Console.WriteLine("A:" + mA + "B:" + mB + "C:" + mC);
            if ((mA + mB > mC) && (mA + mC > mB) && (mB + mC > mA))
            {
                return (true);
            }
            else // !((mA + mB > mC) && (mA + mC > mB) && (mB + mC > mA))
                return (false);
        }

        // Función que permite calcular los ángulos del triángulo, utilizando 
        // la Ley de Cosenos.
        private void CalculateAngleA()
        {
            mAngleA = (float)Math.Acos((mB * mB + mC * mC - mA * mA) / (2 * mB * mC));
            mAngleB = (float)Math.Acos((mA * mA + mC * mC - mB * mB) / (2 * mA * mC));
            mAngleC = (float)Math.Acos((mA * mA + mB * mB - mC * mC) / (2 * mA * mB));
        }
        //Funcion que nos permite transformar del mundo real a la computacion
        //gráfica
        public PointF ToPointF(PointF V)
        {
            return new PointF((float)V.X * SF + Center.X, (-1) * (float)V.Y * SF + Center.Y);
        }

        //Funcion que nos permite calcular los puntos del traingulo como: incentro
        //ortocentro, baricentro.
        public void CalculatePoints()
        {
            float cotA = (float)(Math.Cos(mAngleA) / Math.Sin(mAngleA));
            G.X = (mP1.X + mP2.X + mP3.X) / 3; G.Y = (mP1.Y + mP2.Y + mP3.Y) / 3;
            P.X = mC / 2; P.Y = (mB - mC * (float)Math.Cos(mAngleA)) / (2 * (float)Math.Sin(mAngleA));
            H.X = mB * (float)Math.Cos(mAngleA); H.Y = mC * cotA - mB * (float)Math.Cos(mAngleA) * cotA;
            I.X = (mA * mP1.X + mB * mP2.X + mC * mP3.X) / (mPerimeter); I.Y = (mA * mP1.Y + mB * mP2.Y + mC * mP3.Y) / (mPerimeter);
        }

        // Función que permite graficar un triángulo en base a los valores de los tres 
        // vértices representados por tres puntos en un plano.
        public void GraphShape(PictureBox picCanvas)
        {

            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 3);
            mGraph.DrawLine(mPen, ToPointF(mP1), ToPointF(mP2));
            mGraph.DrawLine(mPen, ToPointF(mP1), ToPointF(mP3));
            mGraph.DrawLine(mPen, ToPointF(mP2), ToPointF(mP3));
            CalculatePoints();
            CalculateAngleA();

        }

        //Funcion que nos permite graficar los ejes x,y de nuestro plano.
        public void GraphAxis(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Black, 2);
            mGraph.DrawLine(mPen, Center.X, 0, Center.X, Center.Y * 2);
            mGraph.DrawLine(mPen, 0, Center.Y, Center.X * 2, Center.Y);

        }

        //Funcion que nos permite obtener la distancia entre dos puntos.
        public float DistancePoints(PointF A, PointF B)
        {
            return (float)Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        }

        //Funcion que nos permite Graficar los circulos exinscritos al triangulo.
        public void GraphCircle(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            CRecta BC1 = new CRecta();
            CRecta IP = new CRecta();
            BC1.Pending(mP2, mP3);
            BC1.Ecuation(mP2);
            IP.Pending1 = -1 / BC1.Pending1;
            IP.Ecuation(I);

            float r = DistancePoints(I, IP.Intersection(IP,BC1));

            CCircle Circle = new CCircle(I, r);
            Circle.DrawCurve(picCanvas, Center, Color.Green);

            mPen = new Pen(Color.Black, 3);
            mGraph.DrawLine(mPen, ToPointF(I), ToPointF(BC1.Intersection(BC1, IP)));

            float rA = (float)Math.Sqrt((mSemiperimeter * (mSemiperimeter - mB) * (mSemiperimeter - mC)) / (mSemiperimeter - mA));
            float rB = (float)Math.Sqrt((mSemiperimeter * (mSemiperimeter - mA) * (mSemiperimeter - mC)) / (mSemiperimeter - mB));
            float rC = (float)Math.Sqrt((mSemiperimeter * (mSemiperimeter - mB) * (mSemiperimeter - mA)) / (mSemiperimeter - mC));
           
            CRecta AI = new CRecta();
            CRecta BI = new CRecta();
            CRecta CI = new CRecta();
            CRecta EF = new CRecta();
            CRecta DF = new CRecta();
            CRecta ED = new CRecta();

            AI.Pending(mP1, I);
            AI.Ecuation(mP1);
            BI.Pending(mP2, I);
            BI.Ecuation(mP2);
            CI.Pending(mP3, I);
            CI.Ecuation(mP3);
            EF.Pending1 = -1 / AI.Pending1;
            EF.Ecuation(mP1);
            DF.Pending1 = -1 / BI.Pending1;
            DF.Ecuation(mP2);
            ED.Pending1 = -1 / CI.Pending1;
            ED.Ecuation(mP3);

            PointF E = EF.Intersection(EF,BI);
            PointF D = ED.Intersection(DF, AI);
            PointF F = EF.Intersection(EF, DF);

            Circle = new CCircle(E, rB);
            Circle.DrawCurve(picCanvas, Center, Color.DarkOrange);
            Circle = new CCircle(D, rA);
            Circle.DrawCurve(picCanvas, Center, Color.DarkOrange);
            Circle = new CCircle(F, rC);
            Circle.DrawCurve(picCanvas, Center, Color.DarkOrange);
            mPen = new Pen(Color.Red, 3);

            mGraph.DrawLine(mPen, ToPointF(mP1), ToPointF(D));
            mGraph.DrawLine(mPen, ToPointF(mP2), ToPointF(E));
            mGraph.DrawLine(mPen, ToPointF(mP3), ToPointF(F));

            mPen = new Pen(Color.Brown, 3);

            mGraph.DrawLine(mPen, ToPointF(D), ToPointF(E));
            mGraph.DrawLine(mPen, ToPointF(E), ToPointF(F));
            mGraph.DrawLine(mPen, ToPointF(F), ToPointF(D));

            CRecta AC = new CRecta();
            CRecta BC = new CRecta();
            CRecta AB = new CRecta();

            AC.Pending(mP1, mP3);
            AC.Ecuation(mP1);
            BC.Pending(mP2, mP3);
            BC.Ecuation(mP2);

            AB.Pending(mP1, mP2);
            AB.Ecuation(mP1);

            EvaluateFunction(AC, picCanvas);
            EvaluateFunction(AB, picCanvas);
            EvaluateFunction(BC, picCanvas);
        }

        //Función que nos permite evaluar una funcion lineal (CRecta) y graficar
        //en el picturebox.
        public void EvaluateFunction(CRecta recta, PictureBox picCanvas)
        {
            float i; // Contador para controlar la función. // i - t(ángulo)
            int j;   // Contador para controlar el arreglo de puntos. // mP[]: 0,1,..,360
            PointF[] mP = new PointF[102];
            PointF v;
            for (i = -50, j = 0; i <= 50; i++, j++)
            {
                v = new PointF(i, ((-1 * (recta.CA * (i) + recta.CC)) / recta.CB));
                mP[j] = ToPointF(v);
            }
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 2);
            mGraph.DrawLine(mPen, mP[1], mP[100]);
        }

        //Funcion que permite cerrar el formulario
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
