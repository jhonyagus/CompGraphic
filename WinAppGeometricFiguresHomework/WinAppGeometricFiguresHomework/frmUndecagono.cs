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
            ObjUndecagon.PerimeterUndecagon();
            ObjUndecagon.AreaUndecagon();
            ObjUndecagon.PrintData(txtPerimeter, txtArea);
            picCanvas.Refresh();
            ObjUndecagon.GraphShape(picCanvas);
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
