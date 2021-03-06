﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace WinAppPythagorean_tree
{
    public class VectorF
    {
        public float X, Y;

        public VectorF()
        {

        }

        public VectorF(float x, float y)
        {
            X = x;
            Y = y;
        }
        public VectorF(PointF point1, PointF point2)
        {
            X = point2.X - point1.X;
            Y = point2.Y - point1.Y;
        }
        public VectorF(VectorF v)
        {
            X = v.X;
            Y = v.Y;
        }

        public static VectorF operator +(VectorF v1, VectorF v2)
        {
            return new VectorF(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static VectorF operator -(VectorF v1, VectorF v2)
        {
            return new VectorF(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static PointF operator +(PointF point, VectorF vector)
        {
            return new PointF(point.X + vector.X, point.Y + vector.Y);
        }

        public static PointF operator -(PointF point, VectorF vector)
        {
            return new PointF(point.X - vector.X, point.Y - vector.Y);
        }

        public static VectorF operator -(VectorF vector)
        {
            return -1 * vector;
        }

        public static VectorF operator *(VectorF vector, float scale)
        {
            return new VectorF(vector.X * scale, vector.Y * scale);
        }
        public static VectorF operator *(float scale, VectorF vector)
        {
            return vector * scale;
        }

        public static VectorF operator /(VectorF vector, float scale)
        {
            return new VectorF(vector.X / scale, vector.Y / scale);
        }

        public float Length
        {
            get
            {
                return (float)Math.Sqrt(X * X + Y * Y);
            }
            set
            {
                float scale = value / Length;
                X *= scale;
                Y *= scale;
            }
        }

        public float DistancePoints(VectorF A, VectorF B)
        {
            return (float)Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        }

        public VectorF Scale(float scale)
        {
            return this * scale / Length;
        }

        public void Normalize()
        {
            Length = 1;
        }

        // Encuentra el vector perpendicular en sentido antihorario.
        public VectorF PerpendicularCCW()
        {
            return new VectorF(Y, -X);
        }
        public VectorF PerpendicularCW()
        {
            return new VectorF(-Y, X);
        }
    }
}
