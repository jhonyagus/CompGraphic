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
    public partial class frmChessBoard : Form
    {
        CChessBoard A = new CChessBoard();
        public frmChessBoard()
        {
            InitializeComponent();
        }

        private void btnGraphic_Click(object sender, EventArgs e)
        {
            A.PlotShape(picCanvas);
        }
    }
}
