using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTrigonometricFunctions
{
    public partial class frmCtgFunction : Form
    {
        private CCotanFunction ObjCotanFunction = new CCotanFunction();
        public frmCtgFunction()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCotanFunction.ReadData(txtA);
            ObjCotanFunction.DrawAxis(picCanvas);
            ObjCotanFunction.EvaluateFunction(lstX, lstY, lstXp, lstYp, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCotanFunction.InitializeData();
            ObjCotanFunction.InitializeControls(txtA, picCanvas, lstX,
                                                     lstY, lstXp, lstYp);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCtgFunction_Load(object sender, EventArgs e)
        {
            ObjCotanFunction.InitializeData();
            ObjCotanFunction.InitializeControls(txtA, picCanvas, lstX,
                                                     lstY, lstXp, lstYp);
        }
    }
}
