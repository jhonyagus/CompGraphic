namespace WinAppGeometricFiguresV2
{
    partial class frmHexagon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSide = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbOutput.SuspendLayout();
            this.grbInput.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(377, 13);
            this.grbCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Padding = new System.Windows.Forms.Padding(4);
            this.grbCanvas.Size = new System.Drawing.Size(420, 337);
            this.grbCanvas.TabIndex = 15;
            this.grbCanvas.TabStop = false;
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(8, 53);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(400, 246);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(177, 66);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(132, 22);
            this.txtArea.TabIndex = 5;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(36, 76);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 17);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Área:";
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(177, 34);
            this.txtPerimeter.Margin = new System.Windows.Forms.Padding(4);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.ReadOnly = true;
            this.txtPerimeter.Size = new System.Drawing.Size(132, 22);
            this.txtPerimeter.TabIndex = 3;
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(36, 44);
            this.lblPerimeter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(73, 17);
            this.lblPerimeter.TabIndex = 2;
            this.lblPerimeter.Text = "Perimetro:";
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.txtArea);
            this.grbOutput.Controls.Add(this.lblArea);
            this.grbOutput.Controls.Add(this.txtPerimeter);
            this.grbOutput.Controls.Add(this.lblPerimeter);
            this.grbOutput.Location = new System.Drawing.Point(22, 227);
            this.grbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Padding = new System.Windows.Forms.Padding(4);
            this.grbOutput.Size = new System.Drawing.Size(347, 123);
            this.grbOutput.TabIndex = 14;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Salidas";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(239, 23);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(36, 33);
            this.lblSide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(112, 17);
            this.lblSide.TabIndex = 0;
            this.lblSide.Text = "Ingrese el lado l:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(128, 23);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(20, 23);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(177, 23);
            this.txtSide.Margin = new System.Windows.Forms.Padding(4);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(132, 22);
            this.txtSide.TabIndex = 1;
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.txtSide);
            this.grbInput.Controls.Add(this.lblSide);
            this.grbInput.Location = new System.Drawing.Point(22, 13);
            this.grbInput.Margin = new System.Windows.Forms.Padding(4);
            this.grbInput.Name = "grbInput";
            this.grbInput.Padding = new System.Windows.Forms.Padding(4);
            this.grbInput.Size = new System.Drawing.Size(347, 132);
            this.grbInput.TabIndex = 12;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Entradas";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Location = new System.Drawing.Point(22, 152);
            this.grbProcess.Margin = new System.Windows.Forms.Padding(4);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Padding = new System.Windows.Forms.Padding(4);
            this.grbProcess.Size = new System.Drawing.Size(347, 68);
            this.grbProcess.TabIndex = 13;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Proceso";
            // 
            // frmHexagon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 359);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbOutput);
            this.Controls.Add(this.grbInput);
            this.Controls.Add(this.grbProcess);
            this.Name = "frmHexagon";
            this.Text = "frmHexagon";
            this.Load += new System.EventHandler(this.frmHexagon_Load);
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbOutput.ResumeLayout(false);
            this.grbOutput.PerformLayout();
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.GroupBox grbProcess;
    }
}