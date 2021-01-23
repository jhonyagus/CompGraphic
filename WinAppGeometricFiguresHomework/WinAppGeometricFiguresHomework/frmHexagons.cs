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
    public partial class frmHexagons : Form
    {
        CHexagons Obj = new CHexagons();
        public frmHexagons()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Obj.GraphShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
