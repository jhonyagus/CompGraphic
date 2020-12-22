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
            if (float.Parse(txtSide.Text) > 0)
            {
                ObjDodecagon.PerimeterDodecagon();
                ObjDodecagon.AreaDodecagon();
                ObjDodecagon.PrintData(txtPerimeter, txtArea);
                ObjDodecagon.GraphShape(picCanvas);
            }
            else
            {
                MessageBox.Show("Error...en el ingreso de datos",
                             "Mensaje de error");
            }
            
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
