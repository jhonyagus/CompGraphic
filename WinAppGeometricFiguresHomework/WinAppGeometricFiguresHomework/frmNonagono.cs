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
    public partial class frmNonagono : Form
    {
        CNonagon ObjNonagon = new CNonagon();
        public frmNonagono()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            ObjNonagon.ReadData(txtSide);
            if (float.Parse(txtSide.Text) > 0)
            {
                ObjNonagon.PerimeterNonagon();
                ObjNonagon.AreaNonagon();
                ObjNonagon.PrintData(txtPerimeter, txtArea);
                ObjNonagon.GraphShape(picCanvas);
            }
            else
            {
                MessageBox.Show("Error...en el ingreso de datos",
                             "Mensaje de error");
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjNonagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
