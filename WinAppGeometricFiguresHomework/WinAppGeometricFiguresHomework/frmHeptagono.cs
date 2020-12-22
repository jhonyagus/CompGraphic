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
            if (float.Parse(txtSide.Text) > 0)
            {
                ObjHeptagon.PerimeterHeptagon();
                ObjHeptagon.AreaHeptagon();
                ObjHeptagon.PrintData(txtPerimeter, txtArea);
                ObjHeptagon.GraphShape(picCanvas);
            }
            else
            {
                MessageBox.Show("Error...en el ingreso de datos",
                             "Mensaje de error");
            }
            
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
