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
    public partial class frmDecagono : Form
    {
        CDecagon ObjDecagon = new CDecagon();
        public frmDecagono()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            ObjDecagon.ReadData(txtSide);
            if (float.Parse(txtSide.Text) > 0)
            {
                ObjDecagon.PerimeterDecagon();
                ObjDecagon.AreaDecagon();
                ObjDecagon.PrintData(txtPerimeter, txtArea);
                ObjDecagon.GraphShape(picCanvas);
            }
            else
            {
                MessageBox.Show("Error...en el ingreso de datos",
                             "Mensaje de error");
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjDecagon.InitializeData(txtSide,txtPerimeter, txtArea,picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
