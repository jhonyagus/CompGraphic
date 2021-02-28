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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            frmSinFunction frmObject = new frmSinFunction();
            frmObject.Show();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            frmCosFunction frmObject = new frmCosFunction();
            frmObject.Show();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            frmTanFunction frmObject = new frmTanFunction();
            frmObject.Show();
        }

        private void btnCtg_Click(object sender, EventArgs e)
        {
            frmCtgFunction frmObject = new frmCtgFunction();
            frmObject.Show();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            frmSecFunction frmObject = new frmSecFunction();
            frmObject.Show();
        }

        private void btnCsc_Click(object sender, EventArgs e)
        {
            frmCscFunction frmObject = new frmCscFunction();
            frmObject.Show();
        }
    }
}
