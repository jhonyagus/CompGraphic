using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace WinAppPythagorean_tree
{
    public partial class Form1 : Form
    {
        VectorF p1 = new VectorF();
        VectorF p2 = new VectorF();
        int num = 1;
        int a = 1;

        public Form1()
        {
            InitializeComponent();
            
        }

        // Se dibuja el arbol.
        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(picCanvas.BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            try
            {
                int depth = 8;
                int length = (int)p1.DistancePoints(p1,p2);
                float alpha = (float)(45 * Math.PI / 180.0);
                float root_x = p1.X;
                float root_y = p2.Y;
                VectorF v_base = new VectorF(length, p2.Y-p1.Y);
                PointF ll_corner = new PointF(root_x, root_y) - v_base / 2;

                SolidBrush brush = new SolidBrush(Color.DarkCyan);
    
                DrawBranch(e.Graphics, Pens.Black, brush,
                    depth, ll_corner, v_base, alpha);
            }
            catch
            {
            }
        }

        // Dibujamos otra vez.
        private void parameter_ValueChanged(object sender, EventArgs e)
        {
            picCanvas.Refresh();
        }
        private void picCanvas_Resize(object sender, EventArgs e)
        {
            picCanvas.Refresh();
        }

        private Color RandomColor(Color color)
        {
            Color rColor;
            do
            {
                Random r = new Random();
                KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
                KnownColor rColorName = names[r.Next(names.Length)];
                rColor = Color.FromKnownColor(rColorName);
                
            } while (color == rColor);
            return rColor;
        }

        // Dibujado recursivo de cada rama del arbol.
        private void DrawBranch(Graphics gr, Pen pen, SolidBrush brush,
            int depth, PointF ll_corner, VectorF v_base, float alpha)
        { 
            // Buscar las esquinas de la caja.
            VectorF v_height = v_base.PerpendicularCCW();
            PointF[] points =
            {
                ll_corner,
                ll_corner + v_base,
                ll_corner + v_base + v_height,
                ll_corner + v_height,
            };

            // Dibuja la caja.
            if (brush != null) { 
                gr.FillPolygon(brush, points);
            }
            gr.DrawPolygon(pen, points);

            // Si la profundidad es > 0, dibuja las ramas adjuntas.
            if (depth > 0)
            {
                // ***********
                // Rama Izq
                // ***********
                // Calcule la nueva longitud del lado.
                double w1 = v_base.Length * Math.Cos(alpha);

                // Descompone el nuevo vector base en términos de v_base and v_height.
                float wb1 = (float)(w1 * Math.Cos(alpha));
                float wh1 = (float)(w1 * Math.Sin(alpha));
                VectorF v_base1 = v_base.Scale(wb1) + v_height.Scale(wh1);
               
                // Encuentra la esquina inferior izquierda.
                PointF ll_corner1 = ll_corner + v_height;

                // Dibuja la rama izquierda.
                DrawBranch(gr, pen, new SolidBrush(RandomColor(brush.Color)), depth - 1, ll_corner1, v_base1, alpha);

                // ************
                // Rama derecha
                // ************
          
                double beta = Math.PI / 2.0 - alpha;
                double w2 = v_base.Length * Math.Sin(alpha);

                float wb2 = (float)(w2 * Math.Cos(beta));
                float wh2 = (float)(w2 * Math.Sin(beta));
                VectorF v_base2 = v_base.Scale(wb2) - v_height.Scale(wh2);

                PointF ll_corner2 = ll_corner1 + v_base1;

                DrawBranch(gr, pen, new SolidBrush(RandomColor(brush.Color)), depth - 1, ll_corner2, v_base2, alpha);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void picCanvas_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            
            if(num == 1)
            {
                p1.X = coordinates.X; p1.Y = coordinates.Y;
                num++;
            }
            else if(num == 2)
            {
                p2.X = coordinates.X; p2.Y = coordinates.Y;
                picCanvas.Refresh();
                picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
                num = 1;
            }

            a++;
        }
    }
}
