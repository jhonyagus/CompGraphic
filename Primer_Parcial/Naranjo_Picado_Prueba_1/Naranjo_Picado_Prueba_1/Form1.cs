using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naranjo_Picado_Prueba_1
{
    public partial class Form1 : Form
    {
        Complex A = new Complex();
        Complex B = new Complex();
        Complex C = new Complex();
        Complex D = new Complex();
        public Form1()
        {
            InitializeComponent();
        }

        private void Graphic()
        {
            picCanvas.Refresh();
            C.GraphAxis(picCanvas);
            A.DrawVector(A, Color.Red, picCanvas);
            B.DrawVector(B, Color.Blue, picCanvas);
            C.DrawVector(C, Color.Green, picCanvas);
            B.DrawVector(B, D, Color.Blue, picCanvas);
            A.DrawVector(A, D, Color.Red, picCanvas);
            C.DrawVector(C, D, Color.Green, picCanvas);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXComplexA, nudYComplexA);
            B.ReadData(nudXComplexB, nudYComplexB);

            C = A.Addition(B);
            C.PrintData(txtXComplexC, txtYComplexC);
            Graphic();
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXComplexA, nudYComplexA);
            B.ReadData(nudXComplexB, nudYComplexB);
            C = A.Substraction(B);
            C.PrintData(txtXComplexC, txtYComplexC);
            Graphic();
        }

        private void lblScalar_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXComplexA, nudYComplexA);
            B.ReadData(nudXComplexB, nudYComplexB);
            C = A.Multiplication(B);
            C.PrintData(txtXComplexC, txtYComplexC);
            Graphic();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXComplexA, nudYComplexA);
            B.ReadData(nudXComplexB, nudYComplexB);
            C = A.Division(B);
            C.PrintData(txtXComplexC, txtYComplexC);
            Graphic();
        }

        private void btnScalar_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXComplexA, nudYComplexA);
            B.ReadData(nudXComplexB, nudYComplexB);
            float scalar = (float)nudScalar.Value;
            A = A.VectorEscalarProduct(scalar);
            txtPXComplexA.Text = A.MX.ToString();
            txtPYComplexA.Text = A.MY.ToString();
            B = B.VectorEscalarProduct(scalar);
            txtPXComplexB.Text = B.MX.ToString();
            txtPYComplexB.Text = B.MY.ToString();

            C.MX = float.Parse(txtXComplexC.Text);
            C.MY = float.Parse(txtYComplexC.Text);
            C = C.VectorEscalarProduct(scalar);
            txtPXComplexC.Text = C.MX.ToString();
            txtPYComplexC.Text = C.MY.ToString();
            Graphic();
        }

        private void btnAngle_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXComplexA, nudYComplexA);
            B.ReadData(nudXComplexB, nudYComplexB);
            txtAComplexA.Text = A.Argument().ToString();
            txtAComplexB.Text = B.Argument().ToString();
            C.MX = float.Parse(txtXComplexC.Text);
            C.MY = float.Parse(txtYComplexC.Text);
            txtAComplexC.Text = C.Argument().ToString();
           // Graphic();
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXComplexA, nudYComplexA);
            B.ReadData(nudXComplexB, nudYComplexB);
            txtMComplexA.Text = A.Module().ToString();
            txtMComplexB.Text = B.Module().ToString();
            C.MX = float.Parse(txtXComplexC.Text);
            C.MY = float.Parse(txtYComplexC.Text);
            txtMComplexC.Text = C.Module().ToString();
           // Graphic();
        }
    }
}
