using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D; // dibujar lineas de puntos

namespace WinAppVectors2D
{
    class CVector2D
    {
        //Datos miembbro -Atributos de la clase.
        //Componentes del vector en 2d
        private float mX, mY;
        //Activar el modo gráfico
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        //Propiedades - Descriptores de acceso (set y get).
        public float X { get => mX; set => mX = value; }
        public float Y { get => mY; set => mY = value; }

        //Constructor sin parámetros.
        public CVector2D()
        {
            mX = 0.0f; mY = 0.0f;
            //X = 0.0f; Y = 0.0f;
        }

        //Constructor con 2 parámetros.
        public CVector2D(float x, float y)
        {
            mX = x; mY = y;
            //X = x; Y = y;
        }

        //Constructor copia.
        public CVector2D(CVector2D V)
        {
           // mX = V.mX; mY = V.mY;
            //Se utilizan getters y setters.
            mX = V.X; mY = V.Y;
        }
        //Funciones miembro - Métodos de la clase.
        //Los parametros nudXVectorV y nudYVectorV reciben 2 objetos tipo NumericUpDown

        public void ReadData(NumericUpDown nudXVectorV, NumericUpDown nudYVectorV)
        {
            //Casting - convertir de valor decimal a float.
            mX = (float)(nudXVectorV.Value); //txt.Text (String)
            mY = (float)(nudYVectorV.Value);
        }

        public void PrintData(TextBox txtXVectorV, TextBox txtYVectorV)
        {
            //Casting - convertir
            txtXVectorV.Text = mX.ToString();
            txtYVectorV.Text = mY.ToString();
        }

        //C = C.Addition(A,B) C es this
        //A y B son argumentos
        //U y V son parametros

        public CVector2D Addition(CVector2D U, CVector2D V)
        {
            CVector2D Temp = new CVector2D();
            Temp.mX = U.mX + V.mX;
            Temp.mY = U.mY + V.mY;
            
            return Temp;
        }

        //C = A.Addition(B) A es this

        public CVector2D Addition(CVector2D V)
        {
            CVector2D Temp = new CVector2D();
            //mX y mY pertenecen a this
            Temp.mX = mX + V.mX;
            Temp.mY = mY + V.mY;

            return Temp;
        }

        public CVector2D AdditionOp(CVector2D V)
        {    
            //mX y mY pertenecen a this
            return (new CVector2D(mX+V.mX, mY+V.mY));
        }

        public CVector2D Subtraction(CVector2D U, CVector2D V)
        {
            CVector2D Temp = new CVector2D();
            Temp.mX = U.mX - V.mX;
            Temp.mY = U.mY - V.mY;

            return Temp;
        }

        public CVector2D Substraction(CVector2D V)
        {
            CVector2D Temp = new CVector2D();
            //mX y mY pertenecen a this
            Temp.mX = mX - V.mX;
            Temp.mY = mY - V.mY;

            return Temp;
        }

        public CVector2D SubstractionOp(CVector2D V)
        {
            //mX y mY pertenecen a this
            return (new CVector2D(mX - V.mX, mY - V.mY));
        }

        //Area de Dibujo: 400x300
        //Pinicial(0,0);
        //Centro (200,150);
        public void GraphAxis(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Black);

            //Dibujar eje horizontal
            //P1 (0,150); y  P2(400,150)
            mGraph.DrawLine(mPen,0,150,400,150);

            //Dibujar eje vertica
            //P1 (200,0); y P2(200,300)
            mGraph.DrawLine(mPen, 200, 0, 200, 300);
            //Nuevo Centro trasladado
            //Nuevo centro C'(200,150)

        }

        /*Convertit un punto del mundo real al mundo de la comp grafica
         Nuevo centro c'(200,150)
         Se aplican formulas de traslacion de ejes lineales
         x' = x*SF+200; y'= (-1)*y*SF+150
         A(2i, 2j) Vector
         A(2,2)mundo real
         A'(240,110) mundo comp grafica
         A: Line(200,150,240,110)
         B(2i, -3j) Vector
         B(2,-3) mundo real
         Punto B'(240,210) mundo comp grafica
         B: Line(200,150,240,210) Centro C' al B'
         */
         public PointF VectorToPointF(CVector2D V)
         {
            return new PointF((float)V.X * SF + 200, (-1)*(float)V.Y * SF +150);
         }

        /*Graficar vector A
         A.DrawVector(A, Color.Red, picCanvas);
         V = A; color = Color.red; 
         A(2,2)
         Graficar vector B
         B.DrawVector(B, Color.Blue, picCanvas);
         v= B
         B(2,-3)
         Graficar C
         C(4,-1)      
         */
         public void DrawVector(CVector2D V, Color color, PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(color, 4);
            mPen.StartCap = LineCap.RoundAnchor; //punto en la linea
            mPen.EndCap = LineCap.ArrowAnchor; //flecha al final de la linea
            //O' (200,150)
            PointF origin = VectorToPointF(new CVector2D(0, 0));
            //A'(240,110)
            //B'(240,210)
            //C'(280,170)
            PointF end = VectorToPointF(V);
            mGraph.DrawLine(mPen, origin, end);
         }
        /*
         Graficar A'

         */
         public void DrawVector(CVector2D U, CVector2D V, Color color, PictureBox picCanvas)
        {
            float[] dashValues = { 2, 1, 2, 1 };
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(color, 4);
            mPen.DashPattern = dashValues;
            //mPen.DashStyle = DashStyle.DashDotDot;
            //mPen.DashStyle = DashStyle.DashDot;
            PointF origin = VectorToPointF(U);
            PointF end = VectorToPointF(V);
            mGraph.DrawLine(mPen, origin, end);
        }

    }
}
