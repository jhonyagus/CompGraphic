using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppGeometricFiguresHomework
{
    public partial class frmTriangle : Form
    {
        private CTriangle ObjCTriangle = new CTriangle();

        public frmTriangle()
        {
            InitializeComponent();
            ObjCTriangle.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void frmTriangle_Load(object sender, EventArgs e)
        {
            ObjCTriangle.InitializeData(txtSide,txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            ObjCTriangle.ReadData(txtSide);
            if (float.Parse(txtSide.Text) > 0)
            {
                ObjCTriangle.PerimeterTriangle();
                ObjCTriangle.AreaTriangle();
                ObjCTriangle.PrintData(txtPerimeter, txtArea);
                picCanvas.Refresh();
                ObjCTriangle.GraphShape(picCanvas);
            }
            else
            {
                MessageBox.Show("Error...en el ingreso de datos",
                             "Mensaje de error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCTriangle.InitializeData(txtSide,txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjCTriangle.CloseForm(this);
        }
    }
}
