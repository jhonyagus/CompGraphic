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

        private void btnSum_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXComplexA, nudYComplexA);
            B.ReadData(nudXComplexB, nudYComplexB);

            C = A.Addition(B);
            C.PrintData(txtXComplexC, txtYComplexC);
            picCanvas.Refresh();
            C.GraphAxis(picCanvas);
            A.DrawVector(A, Color.Red, picCanvas);
            B.DrawVector(B, Color.Blue, picCanvas);
            C.DrawVector(C, Color.Green, picCanvas);
            B.DrawVector(B, D, Color.Blue, picCanvas);
            A.DrawVector(A, D, Color.Red, picCanvas);
            C.DrawVector(C, D, Color.Green, picCanvas);
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXComplexA, nudYComplexA);
            B.ReadData(nudXComplexB, nudYComplexB);
            C = A.Substraction(B);
            C.PrintData(txtXComplexC, txtYComplexC);
            picCanvas.Refresh();
            C.GraphAxis(picCanvas);
            A.DrawVector(A, Color.Red, picCanvas);

            C.DrawVector(C, Color.Green, picCanvas);

            B.MX = B.MX * (-1.0f); B.MY = B.MY * (-1.0f);
            B.DrawVector(B, Color.Blue, picCanvas);
            C.DrawVector(C, Color.Green, picCanvas);
            A.DrawVector(B, C, Color.Red, picCanvas);
            B.DrawVector(A, C, Color.Blue, picCanvas);
        }

        private void lblScalar_Click(object sender, EventArgs e)
        {

        }
    }
}
