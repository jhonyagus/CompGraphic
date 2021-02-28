using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppVectors2D
{
    public partial class frmVectors2D : Form
    {
        //Datos miembro-Atributos
        //Composición: Se agrega 4 objetos de tipo CVector2D
        //como parte de la clase frmvector2D.
        CVector2D A = new CVector2D();
        CVector2D B = new CVector2D();
        CVector2D C = new CVector2D();
        CVector2D D = new CVector2D();

        public frmVectors2D()
        {
            InitializeComponent();
        }

        private void frmVectors2D_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            //El objeto A llama a la función ReadData()
            // Se envia los argumentos nuxXVectorA, nudYVectorA.
            A.ReadData(nudXVectorA, nudYVectorA);
            B.ReadData(nudXVectorB, nudYVectorB);
            //Lectura de datos usando setters de la clase CVector2D.
            //A.X = (float)(float)(nudXVectorA.Value); A.Y = (float)(float)(nudYVectorA.Value);
            //B.X = (float)(float)(nudXVectorB.Value); B.Y = (float)(float)(nudYVectorB.Value);

            //C = new CVector2D(A);
            //C.PrintData(txtXVectorC, txtYVectorC);
            //C = C.Addition(A, B);
            C = A.Addition(B);
            C.PrintData(txtXVectorC, txtYVectorC);
            picCanvas.Refresh();
            C.GraphAxis(picCanvas);
            A.DrawVector(A, Color.Red, picCanvas);
            B.DrawVector(B, Color.Blue, picCanvas);
            C.DrawVector(C, Color.Green, picCanvas);

            A.DrawVector(B, C, Color.Red, picCanvas);
            C.DrawVector(A, C, Color.Blue, picCanvas);
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            A.ReadData(nudXVectorA, nudYVectorA);
            B.ReadData(nudXVectorB, nudYVectorB);
            C = C.Subtraction(A, B);
            C.PrintData(txtXVectorC, txtYVectorC);
            picCanvas.Refresh();
            C.GraphAxis(picCanvas);
            A.DrawVector(A, Color.Red, picCanvas);
           // B.DrawVector(B, Color.Blue, picCanvas);
            C.DrawVector(C, Color.Green, picCanvas);

            B.X = B.X * (-1.0f); B.Y = B.Y * (-1.0f);
            B.DrawVector(B, Color.Blue, picCanvas);
            C.DrawVector(C, Color.Green, picCanvas);
            A.DrawVector(B, C, Color.Red, picCanvas);
            B.DrawVector(A, C, Color.Blue,picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
