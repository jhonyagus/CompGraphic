using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppExercise9
{
    public partial class Form1 : Form
    {
        CTriangle ObjCTriangle = new CTriangle();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjCTriangle.CloseForm(this);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            bool Validate;

            ObjCTriangle.ReadData(txtAX, txtAY, txtBX, txtBY, txtCX, txtCY);
            Validate = ObjCTriangle.CheckTriangle();

            if (Validate == true)
            {
                ObjCTriangle.GraphAxis(picCanvas);
                ObjCTriangle.PerimeterTriangle();
                ObjCTriangle.AreaTriangle();
                ObjCTriangle.PrintData(txtPerimeter, txtArea);
                ObjCTriangle.GraphShape(picCanvas);
                ObjCTriangle.GraphCircle(picCanvas);
            }
            else // !(Validate == true)
            {
                MessageBox.Show("Error...en el ingreso de datos",
                                "Mensaje de error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCTriangle.InitializeData(txtAX, txtAY, txtBX, txtBY, txtCX, txtCY,txtPerimeter,txtArea,picCanvas);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ObjCTriangle.Initialize(picCanvas);
        }
    }
}
