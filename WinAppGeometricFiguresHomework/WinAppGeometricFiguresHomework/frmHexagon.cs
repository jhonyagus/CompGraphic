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
    public partial class frmHexagon : Form
    {
        CHexagon ObjHexagon = new CHexagon();

        public frmHexagon()
        {
            InitializeComponent();
        }

        private void frmHexagon_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjHexagon.ReadData(txtSide);
            if (float.Parse(txtSide.Text) > 0)
            {
                //ObjHexagon.PerimeterUndecagon();
                //ObjHexagon.AreaUndecagon();
                ObjHexagon.PrintData(txtPerimeter, txtArea);
                ObjHexagon.GraphShape(picCanvas);
            }
            else
            {
                MessageBox.Show("Error...en el ingreso de datos",
                             "Mensaje de error");
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjHexagon.InitializeData(txtSide, txtPerimeter,
                txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
