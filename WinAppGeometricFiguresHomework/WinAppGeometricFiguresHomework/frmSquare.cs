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
    public partial class frmSquare : Form
    {
        private CSquare ObjCSquare = new CSquare();

        public frmSquare()
        {
            InitializeComponent();
            ObjCSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void frmSquare_Load(object sender, EventArgs e)
        {
            ObjCSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCSquare.ReadData(txtSide);          
            if (float.Parse(txtSide.Text) > 0)
            {
                ObjCSquare.PerimeterSquare();
                ObjCSquare.AreaSquare();
                ObjCSquare.PrintData(txtPerimeter, txtArea);
                ObjCSquare.GraphShape(picCanvas);
            }
            else
            {
                MessageBox.Show("Error...en el ingreso de datos",
                             "Mensaje de error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCSquare.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjCSquare.CloseForm(this);
        }
    }
}
