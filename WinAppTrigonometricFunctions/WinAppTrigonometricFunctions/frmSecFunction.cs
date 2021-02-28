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
    public partial class frmSecFunction : Form
    {
        CSecFunction ObjCSecFunction = new CSecFunction();
        public frmSecFunction()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCSecFunction.ReadData(txtA);
            ObjCSecFunction.DrawAxis(picCanvas);
            ObjCSecFunction.EvaluateFunction(lstX, lstY, lstXp, lstYp, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCSecFunction.InitializeData();
            ObjCSecFunction.InitializeControls(txtA, picCanvas, lstX,
                                                     lstY, lstXp, lstYp);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSecFunction_Load(object sender, EventArgs e)
        {
            ObjCSecFunction.InitializeData();
            ObjCSecFunction.InitializeControls(txtA, picCanvas, lstX,
                                                     lstY, lstXp, lstYp);
        }
    }
}
