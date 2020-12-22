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
    public partial class frmPentagono : Form
    {
        CPentagon ObjPentagon = new CPentagon(); 
        public frmPentagono()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjPentagon.ReadData(txtSide);
            
            if (float.Parse(txtSide.Text) > 0)
            {
                //ObjPentagon.PerimeterSquare();
                //ObjPentagon.AreaSquare();
                ObjPentagon.PrintData(txtPerimeter, txtArea);
                ObjPentagon.GraphShape(picCanvas);
            }
            else
            {
                MessageBox.Show("Error...en el ingreso de datos",
                             "Mensaje de error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjPentagon.InitializeData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
