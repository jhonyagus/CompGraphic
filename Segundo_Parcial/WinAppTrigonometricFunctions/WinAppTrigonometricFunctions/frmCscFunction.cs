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
    public partial class frmCscFunction : Form
    {
        private CCscFunction ObjCCscFunction = new CCscFunction();
        public frmCscFunction()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjCCscFunction.ReadData(txtA);
            ObjCCscFunction.DrawAxis(picCanvas);
            ObjCCscFunction.EvaluateFunction(lstX, lstY, lstXp, lstYp, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCCscFunction.InitializeData();
            ObjCCscFunction.InitializeControls(txtA, picCanvas, lstX,
                                                     lstY, lstXp, lstYp);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCscFunction_Load(object sender, EventArgs e)
        {
            ObjCCscFunction.InitializeData();
            ObjCCscFunction.InitializeControls(txtA, picCanvas, lstX,
                                                     lstY, lstXp, lstYp);

        }    
    }
}
