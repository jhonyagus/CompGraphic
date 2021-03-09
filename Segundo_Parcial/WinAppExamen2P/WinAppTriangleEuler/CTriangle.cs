using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;

namespace WinAppExamen2P
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

        //Funcion que inicializa el Punto Center con el centro de nuestro PictureBox
        //recibe el picture box, calculamos las coordenadas del centro y guardamos en
        //punto Center

        public void Initialize(PictureBox picCanvas)
        {
            Center.X = picCanvas.Width/2;
            Center.Y = picCanvas.Height/2;
        }

        //Funcion que Calcula el punto medio de dos puntos.
        //Recibe dos puntos A y B. Retorna un punto con las coordenadas del punto medio 
        //entre A y B.

        public PointF HalfPoint(PointF A, PointF B)
        {
            return new PointF((A.X+B.X)/2 ,(A.Y+B.Y)/2);
        }

        // Función que permite leer los tres lados del triángulo.
        public void ReadData(TextBox txtSideA,
                             TextBox txtSideB,
                             TextBox txtSideC)
        {
            try
            {
                mA = float.Parse(txtSideA.Text);
                mB = float.Parse(txtSideB.Text);
                mC = float.Parse(txtSideC.Text);
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
        public void InitializeData(TextBox txtSideA,
                                   TextBox txtSideB,
                                   TextBox txtSideC,
                                   TextBox txtPerimeter,
                                   TextBox txtArea,
                                   PictureBox picCanvas)
        {
            txtSideA.Text = ""; txtSideB.Text = ""; txtSideC.Text = "";
            txtPerimeter.Text = ""; txtArea.Text = "";

            // Mantiene el cursor titilando en una caja de texto.
            txtSideA.Focus();
            mA = 0.0f; mB = 0.0f; mC = 0.0f;
            mPerimeter = 0.0f; mArea = 0.0f; mAngleA = 0.0f; mAngleB = 0.0f; mAngleC = 0.0f;
            picCanvas.Refresh();
        }

        // Función que permite validar la existencia de un triángulo.
        public bool CheckTriangle()
        {
            if ((mA + mB > mC) && (mA + mC > mB) && (mB + mC > mA))
            {
                return (true);
            }
            else // !((mA + mB > mC) && (mA + mC > mB) && (mB + mC > mA))
                return (false);
        }

        // Función que permite calcular los ángulos del triángulo, utilizando 
        // la Ley de Cosenos.
        private void CalculateAngles()
        {
            mAngleA = (float)Math.Acos((mB * mB + mC * mC - mA * mA) / (2 * mB * mC));
            mAngleB = (float)Math.Acos((mA * mA + mC * mC - mB * mB) / (2 * mA * mC));
            mAngleC = (float)Math.Acos((mA * mA + mB * mB - mC * mC) / (2 * mA * mB));
        }

        // Función que permite calcular los valores de los tres vértices del triángulo,
        // utilizando fórmulas de Geometría Analítica.
        private void CalculateVertexC()
        {
            mP1.X = 0; mP1.Y = 0;
            mP2.X = mC; mP2.Y = 0.0f;

            CalculateAngles();

            mP3.X = mB * (float)Math.Cos(mAngleA);
            mP3.Y = mB * (float)Math.Sin(mAngleA);
        }

        //Función que permite transformar una coordenada del mundo real a una de
        //la computación grafica. Usando los valores del Center.
        public PointF ToPointF(PointF V)
        {
            return new PointF((float)V.X * SF + Center.X, (-1) * (float)V.Y * SF + Center.Y);
        }

        //Función que permite calcular las coordenadas del Incentro, Ortocentro, Baricentro y Circuncentro
        //mediante formulas de geometria analítica.
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

            CalculateVertexC();
            mGraph.DrawLine(mPen, ToPointF(mP1) , ToPointF(mP2));
            mGraph.DrawLine(mPen, ToPointF(mP1), ToPointF(mP3));
            mGraph.DrawLine(mPen, ToPointF(mP2), ToPointF(mP3));
            CalculatePoints();
            
        }


        //Función que permite graficar los ejes del plano xy
        public void GraphAxis(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Black, 2);
            mGraph.DrawLine(mPen, Center.X, 0, Center.X, Center.Y * 2);
            mGraph.DrawLine(mPen, 0,Center.Y,Center.X * 2,Center.Y);
         
        }


        //Función que permite Graficar un punto en el plano.
        public void GraphPoint(PictureBox picCanvas, PointF p, Color col)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(col, 6);
            p = ToPointF(p);
            Rectangle r = new Rectangle((int)p.X, (int)p.Y, 3, 3);
            mGraph.DrawEllipse(mPen, r);
        }

        //Funcion que Grafica los puntos de las tres medianas de nuestro triangulo
        public void GraphMediansPoints(PictureBox picCanvas)
        {
            GraphPoint(picCanvas, HalfPoint(mP1, mP2), Color.Red);
            GraphPoint(picCanvas, HalfPoint(mP2, mP3), Color.Red);
            GraphPoint(picCanvas, HalfPoint(mP3, mP1), Color.Red);            
        }

        //Funcion que Grafica los tres puntos del punto medio entre los vertices y el ortocentro de nuestro triangulo
        public void GraphHalfPointsVH(PictureBox picCanvas)
        {
            GraphPoint(picCanvas, HalfPoint(H, mP1), Color.Brown);
            GraphPoint(picCanvas, HalfPoint(H, mP2), Color.Brown);
            GraphPoint(picCanvas, HalfPoint(H, mP3), Color.Brown);
        }

        //Función que nos permite Graficar la circunferencia de los 9 Puntos.
        public void GraphicFeuerbach(PictureBox picCanvas)
        {
            
            CRecta EI = new CRecta();
            CRecta DK = new CRecta();
            CRecta AC = new CRecta();
            CRecta BH2 = new CRecta();
            PointF E = HalfPoint(mP2, mP3);
            PointF I = HalfPoint(H, mP2);
            PointF D = HalfPoint(mP1, mP3);
            PointF G = HalfPoint(H,mP1);
            PointF R;

            EI.Pending(HalfPoint(E,I),HalfPoint(D,G));
            EI.Ecuation(HalfPoint(E, I));
            AC.Pending(mP1, mP3);
            AC.Ecuation(mP1);
            BH2.Pending1 = -1 / AC.Pending1;
            BH2.Ecuation(mP2);
            DK.Pending1 = -1 / AC.Pending1;
            DK.Ecuation(HalfPoint(BH2.Intersection(BH2, AC), D));
            R = DK.Intersection(DK, EI);
            GraphPoint(picCanvas, R, Color.Brown);
            CCircle Circle = new CCircle(R, DistancePoints(R, E));
            Circle.DrawCurve(picCanvas, Center,Color.Gray);
           

        }

        //Función que permite graficar los tres puntos de los pie de las alturas
        public void GraphHeightsPoints(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            
            PointF H3 = new PointF(mP3.X, 0);
            CRecta AC = new CRecta();
            CRecta BH2 = new CRecta();
            CRecta AH1 = new CRecta();
            CRecta BC = new CRecta();

            AC.Pending(mP1, mP3);
            AC.Ecuation(mP1);
            BH2.Pending1 = -1 / AC.Pending1;
            BH2.Ecuation(mP2);
            BC.Pending(mP2, mP3);
            BC.Ecuation(mP2);
            AH1.Pending1 = -1 / BC.Pending1;
            AH1.Ecuation(mP1);
            
            GraphPoint(picCanvas, AC.Intersection(AC, BH2), Color.Green);
            GraphPoint(picCanvas, AC.Intersection(BC, AH1), Color.Green);
            GraphPoint(picCanvas, H3, Color.Green);
            mPen = new Pen(Color.Brown, 1.5f);
            mGraph.DrawLine(mPen, ToPointF(mP2), ToPointF(AC.Intersection(AC, BH2)));
            mGraph.DrawLine(mPen, ToPointF(mP1), ToPointF(AC.Intersection(BC, AH1)));
            mGraph.DrawLine(mPen, ToPointF(mP3), ToPointF(new PointF(mP3.X, 0)));
            GraphPoint(picCanvas,H, Color.Green);
        }

        //Función que permite graficar el circulo circunscrito del triangulo
        public void GraphCircunscrito(PictureBox picCanvas)
        {
            CCircle Circunscrito = new CCircle(P, DistancePoints(P, mP1));
            Circunscrito.DrawCurve(picCanvas, Center, Color.Magenta);
        }

        //Funcion que permite encontrar la distancia entre dos puntos A y B
        public float DistancePoints(PointF A, PointF B)
        {
            return (float)Math.Sqrt(Math.Pow((B.X - A.X),2) + Math.Pow((B.Y - A.Y), 2));
        }

        //public void GraphEuler(PictureBox picCanvas)
        //{
        //    mGraph = picCanvas.CreateGraphics();
        //    mPen = new Pen(Color.LightPink, 3);
        //    mGraph.DrawLine(mPen, ToPointF(H), ToPointF(G));
        //    mGraph.DrawLine(mPen, ToPointF(G), ToPointF(P));
        //    mPen = new Pen(Color.Red, 3);
        //    mGraph.DrawLine(mPen, ToPointF(mP3), ToPointF(HalfPoint(mP1, mP2)));
        //    mGraph.DrawLine(mPen, ToPointF(mP1), ToPointF(HalfPoint(mP2, mP3)));
        //    mPen = new Pen(Color.Gray, 3);
        //    mGraph.DrawLine(mPen, ToPointF(HalfPoint(mP1, mP2)), ToPointF(P));
        //    mGraph.DrawLine(mPen, ToPointF(HalfPoint(mP2, mP3)), ToPointF(P));
        //    PointF H3 = new PointF(mP3.X, 0);
        //    CRecta AC = new CRecta();
        //    CRecta BC = new CRecta();
        //    CRecta AH1 = new CRecta();
        //    AC.Pending(mP1, mP3);
        //    AC.Ecuation(mP1);
        //    BC.Pending(mP2, mP3);
        //    BC.Ecuation(mP2);
        //    Console.WriteLine("a:"+BC.CA+"b:"+BC.CB+"c:"+BC.CC);
        //    AH1.Pending1 = -1 / BC.Pending1;
        //    AH1.Ecuation(mP1);
        //    mPen = new Pen(Color.Green, 3);
        //    mGraph.DrawLine(mPen, ToPointF(H3), ToPointF(mP3));
        //    mGraph.DrawLine(mPen, ToPointF(mP1), ToPointF(AC.Intersection(BC, AH1)));
        //}

        //Funcion que permite Graficar los circulos exinscritos del triangulo.
        public void GraphCircle(PictureBox picCanvas)
        {
            CCircle Circle = new CCircle(I, DistancePoints(I,new PointF(I.X,0)));
            Circle.DrawCurve(picCanvas,Center,Color.Magenta);
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Black, 3);
            mGraph.DrawLine(mPen, ToPointF(I), ToPointF(new PointF(I.X, 0)));

            float rA = (float)Math.Sqrt((mSemiperimeter * (mSemiperimeter - mB) * (mSemiperimeter - mC)) / (mSemiperimeter - mA));
            float rB = (float)Math.Sqrt((mSemiperimeter * (mSemiperimeter - mA) * (mSemiperimeter - mC)) / (mSemiperimeter - mB));
            float rC = (float)Math.Sqrt((mSemiperimeter * (mSemiperimeter - mB) * (mSemiperimeter - mA)) / (mSemiperimeter - mC));

            float alpha = ((float)Math.PI - mAngleA) / 2;
            float betha = ((float)Math.PI - mAngleB) / 2;
            float AT6 = rB / (float)Math.Tan(alpha);
            float BT2 = rA / (float)Math.Tan(betha);
            float AT7 = rC / (float)Math.Tan(alpha);

            PointF E = new PointF(-1 * AT6, rB);
            PointF D = new PointF(mC + BT2, rA);
            PointF F = new PointF(AT7, -1 * rC);

            Circle = new CCircle(E,rB);
            Circle.DrawCurve(picCanvas, Center,Color.DarkCyan);
            Circle = new CCircle(D, rA);
            Circle.DrawCurve(picCanvas, Center,Color.DarkCyan);
            Circle = new CCircle(F, rC);
            Circle.DrawCurve(picCanvas, Center, Color.DarkCyan);
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

        //Funcion que nos permite graficar una funcion lineal.
        public void EvaluateFunction(CRecta recta, PictureBox picCanvas)
        {
            float i; // Contador para controlar la función. // i - t(ángulo)
            int j;   // Contador para controlar el arreglo de puntos. // mP[]: 0,1,..,360
            PointF[] mP = new PointF[101];
            PointF v;
            for (i = -50, j = 0; i <= 50; i++, j++)
            {
                v = new PointF(i,((-1*(recta.CA * (i) + recta.CC) ) / recta.CB));
                mP[j] = ToPointF(v);
            }
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 2);
            mGraph.DrawCurve(mPen, mP);
        }

        //Función que nos permite cerrar el formulario.
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }
    }
}
