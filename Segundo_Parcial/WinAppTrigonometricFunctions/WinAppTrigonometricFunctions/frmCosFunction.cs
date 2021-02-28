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
    public partial class frmCosFunction : Form
    {
        private CCosFunction ObjCCosFunction = new CCosFunction();
        public frmCosFunction()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCCosFunction.ReadData(txtA);
            ObjCCosFunction.DrawAxis(picCanvas);
            ObjCCosFunction.DrawCurve(picCanvas, lstX, lstY, lstXp, lstYp);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCCosFunction.InitializeData();
            ObjCCosFunction.InitializeControls(txtA, picCanvas, lstX,
                                                     lstY, lstXp, lstYp);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCosFunction_Load(object sender, EventArgs e)
        {
            ObjCCosFunction.InitializeData();
            ObjCCosFunction.InitializeControls(txtA, picCanvas, lstX,
                                                     lstY, lstXp, lstYp);
        }
    }
}
