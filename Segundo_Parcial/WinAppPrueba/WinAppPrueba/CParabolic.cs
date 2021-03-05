using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WinAppPrueba
{
    class CParabolic
    {
        // Datos miembro - Atributos.
        private const float gravity = 9.81f;
        private float mVelocity;
        private float mAngle;
        private float mDistance, mTime, mHeight;
        // Datos miembro que operan con el modo gráfico.
        private Graphics mGraph;
        private Pen mPen;


        private PointF Center;

        // Funciones miembro - Métodos.

        // Constructor sin parámetros.
        public CParabolic()
        {
            mDistance = 0.0f; mTime = 0.0f; mHeight = 0.0f;
        }

        //Funcion que permite inicializar el centro de nuestro grafico en este caso
        //las coordenadas (0, maximo altura del picturebox)
        public void Initialize(PictureBox picCanvas)
        {
            Center.X = 0;
            Center.Y = picCanvas.Height;
        }

        // Función que permite leer el ángulo de disparo y la velocidad incial
        public void ReadData(TextBox txtVel,TextBox txtAngle)
        {
            try
            {
                mVelocity = float.Parse(txtVel.Text);
                mAngle = float.Parse(txtAngle.Text);
            }
            catch
            {
                MessageBox.Show("Ingreso no válido...");
            }
        }

        // Función que permite imprimir la distancia, tiempo de vuelo y altura máxima.
        public void PrintData(TextBox txtDistance, TextBox txtHeight, TextBox txtTime)
        {
            txtDistance.Text = mDistance.ToString();
            txtHeight.Text = mHeight.ToString();
            txtTime.Text = (2*mTime).ToString();
        }

        // Función que permite inicializar los datos y controles que operan en 
        // la GUI.
        public void InitializeData(TextBox txtVel,
                                   TextBox txtAngle,
                                   TextBox txtDistance,
                                   TextBox txtTime,
                                   TextBox txtHeights,
                                   PictureBox picCanvas)
        {
            txtVel.Text = ""; txtAngle.Text = "";
            txtDistance.Text = ""; txtTime.Text = ""; txtHeights.Text = "";

            // Mantiene el cursor titilando en una caja de texto.
            txtVel.Focus();
            mDistance = 0.0f; mTime = 0.0f; mHeight = 0.0f;
            mVelocity = 0.0f; mAngle = 0.0f;
            picCanvas.Refresh();
        }

        //Funcion que nos permite transformar del mundo real a la computacion
        //gráfica
        public PointF ToPointF(PointF V, float SF)
        {
            return new PointF((float)V.X * SF + Center.X, (-1) * (float)V.Y * SF + Center.Y);
        }

        //Funcion que nos permite encontrar la distancia a la que cae el proyectil
        //conocida como XMax, mediante formula de tiro parabólico.
        public void CalculateDistance()
        {
            float angle = (float)(mAngle * (Math.PI / 180));
            mDistance = (float)(mVelocity * mVelocity * Math.Sin(2 * angle)) / (gravity);
        }

        //Funcion que nos permite encontrar el tiempo en donde el proyectil alcanza
        //la altura máxima, mediante formula de tiro parabólico.
        public void CalculateTime()
        {
            float angle = (float)(mAngle * (Math.PI / 180));
            mTime = (float)(mVelocity * Math.Sin(angle)) / (gravity);
        }

        //Funcion que nos permite encontrar la altura máxima en alcanzar el proyectil
        //es decir cuando la velocidad  = 0, mediante formula de tiro parabólico.
        public void CalculateHeight()
        {
            float angle = (float)(mAngle * (Math.PI / 180));
            mHeight = (float)(mVelocity * mVelocity * Math.Sin(angle) * Math.Sin(angle)) / (2 * gravity);
        }

        //Funcion que nos permite graficar el arco del ángulo de inclinacion
        //Ocupamos un circulo de nuestra clase CCircle
        public void GraphAngle(PictureBox picCanvas)
        {
            CCircle Circle = new CCircle(new PointF(0,0), 3, mAngle);
            Circle.DrawCurve(picCanvas, Center, Color.Red);
            GraphAxis(picCanvas);
        }

        //Funcion que nos permite graficar la línea de la velocidad tangente a
        //al arco de la trayectoria. Ocupamos una recta de nuestra clase CRecta.
        public void GraphLine(PictureBox picCanvas)
        {
            CRecta recta = new CRecta();
            float angle = (float)(mAngle * (Math.PI / 180));
            recta.Pending1 = (float)Math.Tan(angle);
            recta.Ecuation(new PointF(0,0));
            EvaluateFunction(recta, picCanvas);
        }

        //Funcion que nos permite graficar los ejes x,y de nuestro plano.
        public void GraphAxis(PictureBox picCanvas)
        {
            Initialize(picCanvas);
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Black, 5);
            mGraph.DrawLine(mPen, 0, 0, Center.X, Center.Y);
            mGraph.DrawLine(mPen, 0, Center.Y, picCanvas.Width, Center.Y);

        }

        //Función que nos permite graficar el arco de la trayectoria del tiro parabolico
        //ocupamos las formulas del movimiento parabolico x, y en fucncion del tiempo.
        public void GraphCurve(PictureBox picCanvas)
        {
            float angle = (float)(mAngle * (Math.PI / 180));
            float t; // Contador para controlar el tiempo
            int j;   // Contador para controlar el arreglo de puntos. // mP[]: 0,1,..,360
            PointF[] mP = new PointF[10001];
            PointF v;
            for (t = 0, j = 0; t <= 5000; t+=0.5f, j++)
            {
                v = new PointF((float)(mVelocity * Math.Cos(angle) * t),(float)((mVelocity * Math.Sin(angle) * t ) + (-0.5 * gravity * t * t)));
                mP[j] = ToPointF(v,5);
                Console.WriteLine(v + "\n");
            }
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Green, 2);
            mGraph.DrawCurve(mPen, mP);
            mPen = new Pen(Color.Blue, 2);
            mPen.CustomStartCap = new AdjustableArrowCap(4, 4);
            mPen.CustomEndCap = new AdjustableArrowCap(4, 4);
            mGraph.DrawLine(mPen, ToPointF(new PointF((float)(mVelocity * Math.Cos(angle) * mTime), 0),5), ToPointF(new PointF((float)(mVelocity * Math.Cos(angle) * mTime), (float)((mVelocity * Math.Sin(angle) * mTime) + (-0.5 * gravity * mTime * mTime))),5));
            GraphAxis(picCanvas);
        }

        //Función que nos permite evaluar una funcion lineal (CRecta) y graficar
        //en el picturebox.
        public void EvaluateFunction(CRecta recta, PictureBox picCanvas)
        {
            float i; // Contador para controlar la función. // i - t(ángulo)
            int j;   // Contador para controlar el arreglo de puntos. // mP[]: 0,1,..,360
            PointF[] mP = new PointF[6];
            PointF v;
            for (i = 0, j = 0; i <= 5; i++, j++)
            {
                v = new PointF(i, ((-1 * (recta.CA * (i) + recta.CC)) / recta.CB));
                mP[j] = ToPointF(v,20);
            }
            mGraph = picCanvas.CreateGraphics();
            mPen = new Pen(Color.Blue, 2);
            mPen.CustomEndCap = new AdjustableArrowCap(5, 5);
            mGraph.DrawLine(mPen, mP[0],mP[5]);
            GraphAxis(picCanvas);
        }

        //Funcion que nos permite cerrar el formulario actual.
        public void CloseForm(Form ObjForm)
        {
            ObjForm.Close();
        }

    }
}
