namespace WinAppExamen2P
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
            this.grbIn = new System.Windows.Forms.GroupBox();
            this.txtSideC = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.grbProcess = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbOuts = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExinscrita = new System.Windows.Forms.Button();
            this.btnCircunscrita = new System.Windows.Forms.Button();
            this.btnFeuerbach = new System.Windows.Forms.Button();
            this.grbGraphics = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbIn.SuspendLayout();
            this.grbProcess.SuspendLayout();
            this.grbOuts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbGraphics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbIn
            // 
            this.grbIn.Controls.Add(this.txtSideC);
            this.grbIn.Controls.Add(this.lblC);
            this.grbIn.Controls.Add(this.txtSideB);
            this.grbIn.Controls.Add(this.lblB);
            this.grbIn.Controls.Add(this.txtSideA);
            this.grbIn.Controls.Add(this.lblA);
            this.grbIn.Location = new System.Drawing.Point(9, 13);
            this.grbIn.Name = "grbIn";
            this.grbIn.Size = new System.Drawing.Size(261, 120);
            this.grbIn.TabIndex = 0;
            this.grbIn.TabStop = false;
            this.grbIn.Text = "Entradas";
            // 
            // txtSideC
            // 
            this.txtSideC.Location = new System.Drawing.Point(71, 83);
            this.txtSideC.Name = "txtSideC";
            this.txtSideC.Size = new System.Drawing.Size(114, 20);
            this.txtSideC.TabIndex = 5;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(13, 86);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(44, 13);
            this.lblC.TabIndex = 4;
            this.lblC.Text = "Lado C:";
            // 
            // txtSideB
            // 
            this.txtSideB.Location = new System.Drawing.Point(71, 57);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(114, 20);
            this.txtSideB.TabIndex = 3;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(13, 57);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(44, 13);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Lado B:";
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(71, 27);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(114, 20);
            this.txtSideA.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(13, 29);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(44, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "Lado A:";
            // 
            // grbProcess
            // 
            this.grbProcess.Controls.Add(this.btnReset);
            this.grbProcess.Controls.Add(this.btnCalculate);
            this.grbProcess.Location = new System.Drawing.Point(11, 142);
            this.grbProcess.Name = "grbProcess";
            this.grbProcess.Size = new System.Drawing.Size(259, 66);
            this.grbProcess.TabIndex = 1;
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
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(184, 176);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 22);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbOuts
            // 
            this.grbOuts.Controls.Add(this.txtArea);
            this.grbOuts.Controls.Add(this.label2);
            this.grbOuts.Controls.Add(this.txtPerimeter);
            this.grbOuts.Controls.Add(this.label1);
            this.grbOuts.Location = new System.Drawing.Point(13, 221);
            this.grbOuts.Name = "grbOuts";
            this.grbOuts.Size = new System.Drawing.Size(256, 72);
            this.grbOuts.TabIndex = 3;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExinscrita);
            this.groupBox1.Controls.Add(this.btnCircunscrita);
            this.groupBox1.Controls.Add(this.btnFeuerbach);
            this.groupBox1.Location = new System.Drawing.Point(13, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnExinscrita
            // 
            this.btnExinscrita.Location = new System.Drawing.Point(62, 61);
            this.btnExinscrita.Name = "btnExinscrita";
            this.btnExinscrita.Size = new System.Drawing.Size(103, 35);
            this.btnExinscrita.TabIndex = 4;
            this.btnExinscrita.Text = "Exinscritas";
            this.btnExinscrita.UseVisualStyleBackColor = true;
            this.btnExinscrita.Click += new System.EventHandler(this.btnExinscrita_Click);
            // 
            // btnCircunscrita
            // 
            this.btnCircunscrita.Location = new System.Drawing.Point(120, 19);
            this.btnCircunscrita.Name = "btnCircunscrita";
            this.btnCircunscrita.Size = new System.Drawing.Size(128, 36);
            this.btnCircunscrita.TabIndex = 1;
            this.btnCircunscrita.Text = "Circunscrita y Feuerbach";
            this.btnCircunscrita.UseVisualStyleBackColor = true;
            this.btnCircunscrita.Click += new System.EventHandler(this.btnCircunscrita_Click);
            // 
            // btnFeuerbach
            // 
            this.btnFeuerbach.Location = new System.Drawing.Point(12, 19);
            this.btnFeuerbach.Name = "btnFeuerbach";
            this.btnFeuerbach.Size = new System.Drawing.Size(102, 36);
            this.btnFeuerbach.TabIndex = 0;
            this.btnFeuerbach.Text = "Feuerbach";
            this.btnFeuerbach.UseVisualStyleBackColor = true;
            this.btnFeuerbach.Click += new System.EventHandler(this.btnFeuerbach_Click);
            // 
            // grbGraphics
            // 
            this.grbGraphics.Controls.Add(this.picCanvas);
            this.grbGraphics.Location = new System.Drawing.Point(278, 23);
            this.grbGraphics.Name = "grbGraphics";
            this.grbGraphics.Size = new System.Drawing.Size(796, 535);
            this.grbGraphics.TabIndex = 5;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 577);
            this.Controls.Add(this.grbGraphics);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbOuts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grbProcess);
            this.Controls.Add(this.grbIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbIn.ResumeLayout(false);
            this.grbIn.PerformLayout();
            this.grbProcess.ResumeLayout(false);
            this.grbOuts.ResumeLayout(false);
            this.grbOuts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grbGraphics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbIn;
        private System.Windows.Forms.TextBox txtSideC;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.GroupBox grbProcess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grbOuts;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExinscrita;
        private System.Windows.Forms.Button btnCircunscrita;
        private System.Windows.Forms.Button btnFeuerbach;
        private System.Windows.Forms.GroupBox grbGraphics;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}

