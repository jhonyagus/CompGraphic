namespace WinAppExercise9
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbGraphics = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbOuts = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbIn = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCY = new System.Windows.Forms.TextBox();
            this.txtBY = new System.Windows.Forms.TextBox();
            this.txtAY = new System.Windows.Forms.TextBox();
            this.txtCX = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtBX = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtAX = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.grbGraphics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbOuts.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbGraphics
            // 
            this.grbGraphics.Controls.Add(this.picCanvas);
            this.grbGraphics.Location = new System.Drawing.Point(281, 13);
            this.grbGraphics.Name = "grbGraphics";
            this.grbGraphics.Size = new System.Drawing.Size(796, 535);
            this.grbGraphics.TabIndex = 11;
            this.grbGraphics.TabStop = false;
            this.grbGraphics.Text = "Gráfico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(6, 28);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(784, 501);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // grbOuts
            // 
            this.grbOuts.Controls.Add(this.txtArea);
            this.grbOuts.Controls.Add(this.label2);
            this.grbOuts.Controls.Add(this.txtPerimeter);
            this.grbOuts.Controls.Add(this.label1);
            this.grbOuts.Location = new System.Drawing.Point(12, 327);
            this.grbOuts.Name = "grbOuts";
            this.grbOuts.Size = new System.Drawing.Size(256, 72);
            this.grbOuts.TabIndex = 9;
            this.grbOuts.TabStop = false;
            this.grbOuts.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(78, 45);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(114, 20);
            this.txtArea.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Área";
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(78, 19);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.ReadOnly = true;
            this.txtPerimeter.Size = new System.Drawing.Size(114, 20);
            this.txtPerimeter.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Perimetro";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(173, 34);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 22);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Controls.Add(this.btnExit);
            this.grbProcess.Location = new System.Drawing.Point(12, 194);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(259, 66);
            this.grbProcess.TabIndex = 7;
            this.grbProcess.TabStop = false;
            this.grbProcess.Text = "Procesos";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(90, 34);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(77, 22);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(7, 34);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(77, 22);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbIn
            // 
            this.grbIn.Controls.Add(this.label4);
            this.grbIn.Controls.Add(this.label3);
            this.grbIn.Controls.Add(this.txtCY);
            this.grbIn.Controls.Add(this.txtBY);
            this.grbIn.Controls.Add(this.txtAY);
            this.grbIn.Controls.Add(this.txtCX);
            this.grbIn.Controls.Add(this.lblC);
            this.grbIn.Controls.Add(this.txtBX);
            this.grbIn.Controls.Add(this.lblB);
            this.grbIn.Controls.Add(this.txtAX);
            this.grbIn.Controls.Add(this.lblA);
            this.grbIn.Location = new System.Drawing.Point(12, 13);
            this.grbIn.Name = "grbIn";
            this.grbIn.Size = new System.Drawing.Size(261, 120);
            this.grbIn.TabIndex = 6;
            this.grbIn.TabStop = false;
            this.grbIn.Text = "Entradas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "X";
            // 
            // txtCY
            // 
            this.txtCY.Location = new System.Drawing.Point(123, 82);
            this.txtCY.Name = "txtCY";
            this.txtCY.Size = new System.Drawing.Size(35, 20);
            this.txtCY.TabIndex = 8;
            // 
            // txtBY
            // 
            this.txtBY.Location = new System.Drawing.Point(123, 56);
            this.txtBY.Name = "txtBY";
            this.txtBY.Size = new System.Drawing.Size(35, 20);
            this.txtBY.TabIndex = 7;
            // 
            // txtAY
            // 
            this.txtAY.Location = new System.Drawing.Point(123, 26);
            this.txtAY.Name = "txtAY";
            this.txtAY.Size = new System.Drawing.Size(35, 20);
            this.txtAY.TabIndex = 6;
            // 
            // txtCX
            // 
            this.txtCX.Location = new System.Drawing.Point(71, 83);
            this.txtCX.Name = "txtCX";
            this.txtCX.Size = new System.Drawing.Size(35, 20);
            this.txtCX.TabIndex = 5;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(13, 86);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(17, 13);
            this.lblC.TabIndex = 4;
            this.lblC.Text = "C:";
            // 
            // txtBX
            // 
            this.txtBX.Location = new System.Drawing.Point(71, 57);
            this.txtBX.Name = "txtBX";
            this.txtBX.Size = new System.Drawing.Size(35, 20);
            this.txtBX.TabIndex = 3;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(13, 57);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 13);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B:";
            // 
            // txtAX
            // 
            this.txtAX.Location = new System.Drawing.Point(71, 27);
            this.txtAX.Name = "txtAX";
            this.txtAX.Size = new System.Drawing.Size(35, 20);
            this.txtAX.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(13, 29);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 554);
            this.Controls.Add(this.grbGraphics);
            this.Controls.Add(this.grbOuts);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbGraphics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbOuts.ResumeLayout(false);
            this.grbOuts.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbIn.ResumeLayout(false);
            this.grbIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGraphics;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbOuts;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbIn;
        private System.Windows.Forms.TextBox txtCX;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtBX;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtAX;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtCY;
        private System.Windows.Forms.TextBox txtBY;
        private System.Windows.Forms.TextBox txtAY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

