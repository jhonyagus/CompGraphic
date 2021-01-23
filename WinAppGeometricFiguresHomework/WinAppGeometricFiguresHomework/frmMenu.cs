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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            frmTriangle ObjForm = new frmTriangle();
            ObjForm.Show();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            frmSquare ObjForm = new frmSquare();
            ObjForm.Show();
        }

        private void btnHexagon_Click(object sender, EventArgs e)
        {
            frmHexagon ObjForm = new frmHexagon();
            ObjForm.Show();
        }

        private void btnOctagon_Click(object sender, EventArgs e)
        {
            frmOctagono ObjForm = new frmOctagono();
            ObjForm.Show();
        }

        private void btnPentagon_Click(object sender, EventArgs e)
        {
            frmPentagono ObjForm = new frmPentagono();
            ObjForm.Show();
        }

        private void btnHeptagon_Click(object sender, EventArgs e)
        {
            frmHeptagono ObjForm = new frmHeptagono();
            ObjForm.Show();
        }

        private void btnNonagon_Click(object sender, EventArgs e)
        {
            frmNonagono ObjForm = new frmNonagono();
            ObjForm.Show();
        }

        private void btnDecagon_Click(object sender, EventArgs e)
        {
            frmDecagono ObjForm = new frmDecagono();
            ObjForm.Show();
        }

        private void btnUndecagon_Click(object sender, EventArgs e)
        {
            frmUndecagono ObjForm = new frmUndecagono();
            ObjForm.Show();
        }

        private void btnDodecagon_Click(object sender, EventArgs e)
        {
            frmDodecagono ObjForm = new frmDodecagono();
            ObjForm.Show();
        }

        private void btnChessboard_Click(object sender, EventArgs e)
        {
            frmChessBoard ObjForm = new frmChessBoard();
            ObjForm.Show();
        }

        private void btnConcentricSquares_Click(object sender, EventArgs e)
        {
            frmConcentricSquares ObjForm = new frmConcentricSquares();
            ObjForm.Show();
        }

        private void btnDashedLines_Click(object sender, EventArgs e)
        {
            frmDashedLines ObjForm = new frmDashedLines();
            ObjForm.Show();
        }

        private void btnHexagons_Click(object sender, EventArgs e)
        {
            frmHexagons ObjForm = new frmHexagons();
            ObjForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
