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
    public partial class frmDodecagono : Form
    {
        CDodecagon ObjDodecagon = new CDodecagon();
        public frmDodecagono()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            ObjDodecagon.ReadData(txtSide);
            ObjDodecagon.PerimeterDodecagon();
            ObjDodecagon.AreaDodecagon();
            ObjDodecagon.PrintData(txtPerimeter, txtArea);
            picCanvas.Refresh();
            ObjDodecagon.GraphShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjDodecagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
