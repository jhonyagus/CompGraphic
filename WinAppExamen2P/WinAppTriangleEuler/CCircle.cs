using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppExamen2P
{
    class CCircle
    {
        // Datos miembro - Atributos de la clase.
        // Coeficientes numéricos de la ecuación.
        //private float mA;
        // Activar el modo gráfico de Windows con GDI+ 
        // GDI+ (Graphic Device Interface with COM+ Technology).
        private Graphics mGraph;
        // Factor de escalamiento para hacer un Zoom In/Zoom Out.
        private const float SF = 10;
        // Pluma para graficar en el lienzo (canvas).
        private Pen ObjPen;
        // Arreglo de puntos (pixeles) de tipo Estructura Punto Plotante.
        private PointF[] mP = new PointF[361];
        // Valores de 'x' y de 'y'.
        private float r, mX, mY;
        // Valores de 'xp' y 'yp'.
        private float mXp, mYp;
        // Intervalos de la función.
        private float I1, I2;
        private PointF Center;

        // Constructores de la clase.
        // Constructor por defecto.
        public CCircle(PointF C, float radio)
        {
            //mA = 0.0f;
            Center = C;
            r = radio;
            mX = 0.0f; mY = 0.0f;
            mXp = 0.0f; mYp = 0.0f;
        }

        //Función para evaluar la función cuadrática.
        public void EvaluateFunction(PointF Plane)
        {
            float i; // Contador para controlar la función. // i - t(ángulo)
            int j;   // Contador para controlar el arreglo de puntos. // mP[]: 0,1,..,360
            // Rango (t): [0,360]
            // h = 1 grado (PI/180) rad (tamaño de paso o delta t)
            I1 = 0.0f; I2 = 2 * (float)Math.PI;
            for (i = I1, j = 0; i <= I2; i += (float)Math.PI / 180, j++)
            {
                // Tabla de valores del mundo real.                
                mX = r * (float)Math.Cos(i) + Center.X; 
                mY = r * (float)Math.Sin(i) + Center.Y; 
                //mX = (float)Math.Sin(7 * i) * (float)Math.Cos(10 * i); lstX.Items.Add(mX.ToString());
                //mY = (float)Math.Sin(7 * i) * (float)Math.Sin(10 * i); lstY.Items.Add(mY.ToString());
                // Tabla de valores del mundo de la computación gráfica.
                mXp = (float)(mX * SF + Plane.X); 
                mYp = (float)((-1) * mY * SF + Plane.Y); 
                // Arreglo de puntos de  tipo flotante.
                mP[j] = new PointF(mXp, mYp);
            }
        }

        // Función para graficar la curva.
        public void DrawCurve(PictureBox picCanvas, PointF Plane, Color color)
        {
            mGraph = picCanvas.CreateGraphics();
            ObjPen = new Pen(color,2);
            mP = new PointF[361];

            EvaluateFunction(Plane);

            mGraph.DrawCurve(ObjPen, mP);
            
           // mGraph.FillClosedCurve(new SolidBrush(Color.White), mP);
        }
    }
}
