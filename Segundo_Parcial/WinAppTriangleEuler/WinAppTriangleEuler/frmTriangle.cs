using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTriangleEuler
{
    public partial class Form1 : Form
    {
        CTriangle ObjCTriangle = new CTriangle();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            bool Validate;

            ObjCTriangle.ReadData(txtSideA, txtSideB, txtSideC);
            Validate = ObjCTriangle.CheckTriangle();

            if (Validate == true)
            {
                ObjCTriangle.GraphAxis(picCanvas);
                ObjCTriangle.PerimeterTriangle();
                ObjCTriangle.AreaTriangle();
                ObjCTriangle.PrintData(txtPerimeter, txtArea);
                ObjCTriangle.GraphShape(picCanvas);
            }
            else // !(Validate == true)
            {
                MessageBox.Show("Error...en el ingreso de datos",
                                "Mensaje de error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ObjCTriangle.Initialize(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCTriangle.InitializeData(txtSideA,txtSideB,txtSideC,txtPerimeter,txtArea,picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjCTriangle.CloseForm(this);
        }

        private void btnMedians_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            ObjCTriangle.GraphAxis(picCanvas);
            ObjCTriangle.GraphShape(picCanvas);
            ObjCTriangle.GraphMedians(picCanvas);
        }

        private void btnMediatrix_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            ObjCTriangle.GraphAxis(picCanvas);
            ObjCTriangle.GraphShape(picCanvas);
            ObjCTriangle.GraphMediatrix(picCanvas);
        }

        private void btnHeights_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            ObjCTriangle.GraphAxis(picCanvas);
            ObjCTriangle.GraphShape(picCanvas);
            ObjCTriangle.GraphHeigths(picCanvas);
        }

        private void btnEuler_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            ObjCTriangle.GraphAxis(picCanvas);
            ObjCTriangle.GraphShape(picCanvas);
            ObjCTriangle.GraphEuler(picCanvas,lblEuler);
        }

        private void btnBisectrix_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            ObjCTriangle.GraphAxis(picCanvas);
            ObjCTriangle.GraphShape(picCanvas);
            ObjCTriangle.GraphCircle(picCanvas);
        }
    }
}
