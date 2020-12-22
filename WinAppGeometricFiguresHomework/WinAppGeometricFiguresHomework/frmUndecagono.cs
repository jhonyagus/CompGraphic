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
    public partial class frmUndecagono : Form
    {
        CUndecagon ObjUndecagon = new CUndecagon();
        public frmUndecagono()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            ObjUndecagon.ReadData(txtSide);
            if (float.Parse(txtSide.Text) > 0)
            {
                ObjUndecagon.PerimeterUndecagon();
                ObjUndecagon.AreaUndecagon();
                ObjUndecagon.PrintData(txtPerimeter, txtArea);
                ObjUndecagon.GraphShape(picCanvas);
            }
            else
            {
                MessageBox.Show("Error...en el ingreso de datos",
                             "Mensaje de error");
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjUndecagon.InitializeData(txtSide,txtPerimeter,txtArea,picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
