using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinAppExercise9
{
    class CRecta
    {
        // Datos miembro - Atributos de la clase.
        private float cA, cB, cC, pending;
        //Getters y Setters de la clase
        public float CA { get => cA; set => cA = value; }
        public float CB { get => cB; set => cB = value; }
        public float CC { get => cC; set => cC = value; }
        public float Pending1 { get => pending; set => pending = value; }

        //Constructor vacio, incializa los atributos
        public CRecta()
        {
            CA = 0.0f; CB = 0.0f; CC = 0.0f; Pending1 = 0.0f;
        }

        //Funcion que calcula la pendiente de la recta mediante dos puntos que 
        //pertenezcan a la misma.
        public void Pending(PointF A, PointF B)
        {
            Pending1 = ((B.Y - A.Y) / (B.X - A.X));
        }

        //Funcion que permite encontrar los coeficientes de la ecuacion
        //general de una recta, mediante un punto de la recta.
        public void Ecuation(PointF A)
        {
            CA = Pending1; CB = -1.0f; CC = A.Y - (Pending1 * A.X);
        }

        //Función que permite encontrar el punto de interseccion entre dos rectas.
        public PointF Intersection(CRecta A, CRecta B)
        {
            float x = (B.CB * A.CC - A.CB * B.CC) / (A.CB * B.CA - B.CB * A.CA);
            float y = (-1.0f / A.CB) * (A.CC + A.CA * x);
            return new PointF(x, y);
        }


    }
}
