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
    public partial class frmOctagono : Form
    {
        COctagono ObjOctagon = new COctagono();
        public frmOctagono()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjOctagon.ReadData(txtSide);
            ObjOctagon.PerimeterOctagon();
            ObjOctagon.AreaOctagon();
            ObjOctagon.PrintData(txtPerimeter, txtArea);
            picCanvas.Refresh();
            ObjOctagon.GraphShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjOctagon.InitializeData(txtSide, txtPerimeter,
               txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
