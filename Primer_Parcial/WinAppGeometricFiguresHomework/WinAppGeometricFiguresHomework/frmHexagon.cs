﻿using System;
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
    public partial class frmHexagon : Form
    {
        CHexagon ObjHexagon = new CHexagon();

        public frmHexagon()
        {
            InitializeComponent();
        }

        private void frmHexagon_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ObjHexagon.ReadData(txtSide);
            ObjHexagon.PerimeterHexagon();
            ObjHexagon.AreaHexagon();
            ObjHexagon.PrintData(txtPerimeter, txtArea);
            picCanvas.Refresh();
            ObjHexagon.GraphShape(picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjHexagon.InitializeData(txtSide, txtPerimeter,
                txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
