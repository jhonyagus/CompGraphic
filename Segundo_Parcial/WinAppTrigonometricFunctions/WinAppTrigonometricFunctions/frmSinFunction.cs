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
    public partial class frmSinFunction : Form
    {
        private CSinFunction ObjectCSinFunction = new CSinFunction();
        public frmSinFunction()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjectCSinFunction.ReadData(txtA);
            ObjectCSinFunction.DrawAxis(picCanvas);
            ObjectCSinFunction.DrawCurve(picCanvas, lstX, lstY, lstXp, lstYp);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjectCSinFunction.InitializeData();
            ObjectCSinFunction.InitializeControls(txtA, picCanvas, lstX,
                                                     lstY, lstXp, lstYp);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSinFunction_Load(object sender, EventArgs e)
        {
            ObjectCSinFunction.InitializeData();
            ObjectCSinFunction.InitializeControls(txtA, picCanvas, lstX,
                                                     lstY, lstXp, lstYp);
        }
    }
}
