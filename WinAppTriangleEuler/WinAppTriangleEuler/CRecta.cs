using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinAppTriangleEuler
{
    class CRecta
    {
        private float cA, cB, cC, pending;

        public float CA { get => cA; set => cA = value; }
        public float CB { get => cB; set => cB = value; }
        public float CC { get => cC; set => cC = value; }
        public float Pending1 { get => pending; set => pending = value; }

        public CRecta()
        {
            CA = 0.0f; CB = 0.0f; CC = 0.0f; Pending1 = 0.0f;
        }

        public void Pending(PointF A, PointF B)
        {
            Pending1 = ((B.Y - A.Y) / (B.X - A.X));
        }

        public void Ecuation(PointF A)
        {
            CA = Pending1; CB = -1.0f; CC = A.Y - (Pending1 * A.X);
        }

        public PointF Intersection(CRecta A, CRecta B)
        {
            float x = (B.CB * A.CC - A.CB * B.CC) / (A.CB * B.CA - B.CB * A.CA);
            float y = (-1.0f / A.CB) * (A.CC + A.CA * x);
            return new PointF(x, y);
        }


    }
}
