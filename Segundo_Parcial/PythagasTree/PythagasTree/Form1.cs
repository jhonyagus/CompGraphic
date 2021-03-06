using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PythagasTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(picCanvas.BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            try
            {
                int depth = (int)nudDepth.Value;
                int length = (int)nudLength.Value;
                float alpha = (float)((double)nudAlpha.Value * Math.PI / 180.0);
                float root_x = picCanvas.ClientSize.Width / 2;
                float root_y = picCanvas.ClientSize.Height * 0.9f;
                VectorF v_base = new VectorF(length, 0);
                PointF ll_corner = new PointF(root_x, root_y) - v_base / 2;

                Brush brush = null;
                if (chkFill.Checked) brush = Brushes.Green;

                DrawBranch(e.Graphics, Pens.Black, brush,
                    depth, ll_corner, v_base, alpha);
            }
            catch
            {
            }
        }

        // Re dibujo.
        private void parameter_ValueChanged(object sender, EventArgs e)
        {
            picCanvas.Refresh();
        }
        private void picCanvas_Resize(object sender, EventArgs e)
        {
            picCanvas.Refresh();
        }
        private void nud_KeyUp(object sender, KeyEventArgs e)
        {
            picCanvas.Refresh();
        }

        // Metodo recursivo
        private void DrawBranch(Graphics gr, Pen pen, Brush brush,
            int depth, PointF ll_corner, VectorF v_base, float alpha)
        {
            // Encuentra las esquinas del cuadro.
            VectorF v_height = v_base.PerpendicularCCW();
            PointF[] points =
            {
                ll_corner,
                ll_corner + v_base,
                ll_corner + v_base + v_height,
                ll_corner + v_height,
            };

            // Dibuja el cuadro.
            if (brush != null) gr.FillPolygon(brush, points);
            gr.DrawPolygon(pen, points);

            // Si la profundidad es > 0, dibuja las ramas.
            if (depth > 0)
            {
                // ***********
                // Rama Izq
                // ***********
                //  calcula el nuevo largo.
                double w1 = v_base.Length * Math.Cos(alpha);

                // Descompone el nuevo vector base en terminos de v_base and v_height.
                float wb1 = (float)(w1 * Math.Cos(alpha));
                float wh1 = (float)(w1 * Math.Sin(alpha));
                VectorF v_base1 = v_base.Scale(wb1) + v_height.Scale(wh1);

                // Encuentra la esquina mas baja.
                PointF ll_corner1 = ll_corner + v_height;

                // Dibuja rama izq.
                DrawBranch(gr, pen, brush, depth - 1, ll_corner1, v_base1, alpha);

                // ************
                // Rama derecha
                // ************
                // calcula el largo.
                double beta = Math.PI / 2.0 - alpha;
                double w2 = v_base.Length * Math.Sin(alpha);

                // Descompone el nuevo vector base en terminos de v_base and v_height.
                float wb2 = (float)(w2 * Math.Cos(beta));
                float wh2 = (float)(w2 * Math.Sin(beta));
                VectorF v_base2 = v_base.Scale(wb2) - v_height.Scale(wh2);

                // Encuentra la esquina mas baja.
                PointF ll_corner2 = ll_corner1 + v_base1;

                // Dibuja la rama derecha
                DrawBranch(gr, pen, brush, depth - 1, ll_corner2, v_base2, alpha);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFill_Click(object sender, EventArgs e)
        {

        }
    }
}
