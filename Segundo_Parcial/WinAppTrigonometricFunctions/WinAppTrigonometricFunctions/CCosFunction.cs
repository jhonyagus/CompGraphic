using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WinAppTrigonometricFunctions
{
    class CCosFunction
    {
        // Datos miembro - Atributos de la clase.
        // Coeficientes numéricos de la ecuación.
        private float mA;
        // Activar el modo gráfico de Windows con GDI+ 
        // GDI+ (Graphic Device Interface with COM+ Technology).
        private Graphics mGraph;
        // Factor de escalamiento para hacer un Zoom In/Zoom Out.
        private const float SF = 20;
        // Pluma para graficar en el lienzo (canvas).
        private Pen ObjPen;
        // Arreglo de puntos (pixeles) de tipo Estructura Punto Plotante.
        private PointF[] mP = new PointF[49];
        // Valores de 'x' y de 'y'.
        private float mX, mY;
        // Valores de 'xp' y 'yp'.
        private float mXp, mYp;
        // Intervalos de la función.
        private float I1, I2;

        // Constructores de la clase.
        // Constructor por defecto.
        public CCosFunction()
        {
            mA = 0.0f;
            mX = 0.0f; mY = 0.0f;
            mXp = 0.0f; mYp = 0.0f;
        }

        // Funciones miembro - Métodos de la clase.
        // Función para leer el coeficiente numérico de la amplitud.
        public void ReadData(TextBox txtA)
        {
            mA = float.Parse(txtA.Text);
        }
        // Función para graficar los ejes coordenados.
        public void DrawAxis(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            ObjPen = new Pen(Color.Black);
            // Eje horizontal.
            mGraph.DrawLine(ObjPen, 0, 150, 400, 150);
            // Eje vertical.
            mGraph.DrawLine(ObjPen, 200, 0, 200, 300);
        }
        //Función para evaluar la función cuadrática.
        public void EvaluateFunction(ListBox lstX, ListBox lstY,
            ListBox lstXp, ListBox lstYp)
        {
            float i; // Contador para controlar la función. // i - mX
            int j;   // Contador para controlar el arreglo de puntos. // mP[j]: 0,1,...,48
            // Rango (x): [-2PI, 2PI]-> -360,-1; 0; 1-360
            // h = 15 grados (delta x) 15*PI/180 rad
            // 1,360 grados hay 24 ptos
            // -360, -1 grados hay 24 ptos
            // cero, 1 pto
            // Total 49 ptos
            // Cp(200,150)
            I1 = -2.0f * (float)Math.PI; I2 = 2.0f * (float)Math.PI;
            for (i = I1, j = 0; i <= I2; i += 15.0f * (float)Math.PI / 180, j++)
            {
                // Tabla de valores del mundo real.                
                mX = i; lstX.Items.Add(mX.ToString());
                mY = mA * (float)Math.Cos(mX); lstY.Items.Add(mY.ToString());
                // Tabla de valores del mundo de la computación gráfica.
                mXp = (float)(mX * SF + 200); lstXp.Items.Add(mXp.ToString());
                mYp = (float)((-1) * mY * SF + 150); lstYp.Items.Add(mYp.ToString());
                // Arreglo de puntos de  tipo flotante.
                mP[j] = new PointF(mXp, mYp);
            }
        }

        // Función para graficar la curva.
        public void DrawCurve(PictureBox picCanvas, ListBox lstX,
            ListBox lstY, ListBox lstXp, ListBox lstYp)
        {
            mGraph = picCanvas.CreateGraphics();
            ObjPen = new Pen(Color.Blue);
            mP = new PointF[49];

            EvaluateFunction(lstX, lstY, lstXp, lstYp);

            mGraph.DrawCurve(ObjPen, mP);
        }

        public void InitializeData()
        {
            mA = 0.0f;
            mX = 0.0f; mY = 0.0f;
            mXp = 0.0f; mYp = 0.0f;
        }

        public void InitializeControls(TextBox txtA, PictureBox picCanvas,
            ListBox lstX, ListBox lstY,
            ListBox lstXp, ListBox lstYp)
        {
            txtA.Text = ""; picCanvas.Refresh();
            lstX.Items.Clear(); lstY.Items.Clear();
            lstXp.Items.Clear(); lstYp.Items.Clear();
        }
    }
}
