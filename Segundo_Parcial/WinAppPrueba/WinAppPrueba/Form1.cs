using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppPrueba
{
    public partial class Form1 : Form
    {
        CParabolic ObjParabolic = new CParabolic();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            ObjParabolic.ReadData(txtVelocity, txtAngle);
            ObjParabolic.GraphAxis(picCanvas);
            ObjParabolic.CalculateDistance();
            ObjParabolic.CalculateHeight();
            ObjParabolic.CalculateTime();
            ObjParabolic.PrintData(txtDistance, txtHeight, txtTime);
            ObjParabolic.GraphAngle(picCanvas);
            ObjParabolic.GraphLine(picCanvas);
            ObjParabolic.GraphCurve(picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ObjParabolic.CloseForm(this);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjParabolic.InitializeData(txtVelocity,txtAngle,txtDistance,txtTime,txtHeight,picCanvas);
        }
    }
}
