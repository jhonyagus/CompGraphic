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
    public partial class frmHeptagono : Form
    {
        CHeptagon ObjHeptagon = new CHeptagon();
        public frmHeptagono()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            ObjHeptagon.ReadData(txtSide);
            ObjHeptagon.PerimeterHeptagon();
            ObjHeptagon.AreaHeptagon();
            ObjHeptagon.PrintData(txtPerimeter, txtArea);
            ObjHeptagon.GraphShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjHeptagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
