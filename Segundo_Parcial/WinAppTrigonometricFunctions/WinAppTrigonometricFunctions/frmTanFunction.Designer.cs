﻿namespace WinAppTrigonometricFunctions
{
    partial class frmTanFunction
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
            this.grbOptions = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbTableValues = new System.Windows.Forms.GroupBox();
            this.lstYp = new System.Windows.Forms.ListBox();
            this.lstXp = new System.Windows.Forms.ListBox();
            this.lstY = new System.Windows.Forms.ListBox();
            this.lstX = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grbOptions.SuspendLayout();
            this.grbInput.SuspendLayout();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbTableValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOptions
            // 
            this.grbOptions.Controls.Add(this.btnExit);
            this.grbOptions.Controls.Add(this.btnReset);
            this.grbOptions.Controls.Add(this.btnCalculate);
            this.grbOptions.Location = new System.Drawing.Point(294, 4);
            this.grbOptions.Name = "grbOptions";
            this.grbOptions.Size = new System.Drawing.Size(200, 106);
            this.grbOptions.TabIndex = 21;
            this.grbOptions.TabStop = false;
            this.grbOptions.Text = "Opciones";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(19, 71);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(163, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(19, 44);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(163, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(19, 16);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(163, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.label8);
            this.grbInput.Controls.Add(this.label5);
            this.grbInput.Controls.Add(this.label2);
            this.grbInput.Controls.Add(this.label1);
            this.grbInput.Controls.Add(this.txtA);
            this.grbInput.Location = new System.Drawing.Point(27, 4);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(261, 106);
            this.grbInput.TabIndex = 20;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Datos de entrada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(103, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "tan(x)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "y =";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(41, 46);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(34, 20);
            this.txtA.TabIndex = 0;
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(27, 116);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(467, 330);
            this.grbCanvas.TabIndex = 22;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Gráfico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(32, 19);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(400, 300);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // grbTableValues
            // 
            this.grbTableValues.Controls.Add(this.lstYp);
            this.grbTableValues.Controls.Add(this.lstXp);
            this.grbTableValues.Controls.Add(this.lstY);
            this.grbTableValues.Controls.Add(this.lstX);
            this.grbTableValues.Controls.Add(this.label13);
            this.grbTableValues.Controls.Add(this.label12);
            this.grbTableValues.Controls.Add(this.label11);
            this.grbTableValues.Controls.Add(this.label10);
            this.grbTableValues.Location = new System.Drawing.Point(500, 10);
            this.grbTableValues.Name = "grbTableValues";
            this.grbTableValues.Size = new System.Drawing.Size(273, 436);
            this.grbTableValues.TabIndex = 23;
            this.grbTableValues.TabStop = false;
            this.grbTableValues.Text = "Tabla de valores";
            // 
            // lstYp
            // 
            this.lstYp.FormattingEnabled = true;
            this.lstYp.Location = new System.Drawing.Point(204, 40);
            this.lstYp.Name = "lstYp";
            this.lstYp.Size = new System.Drawing.Size(60, 381);
            this.lstYp.TabIndex = 19;
            // 
            // lstXp
            // 
            this.lstXp.FormattingEnabled = true;
            this.lstXp.Location = new System.Drawing.Point(138, 40);
            this.lstXp.Name = "lstXp";
            this.lstXp.Size = new System.Drawing.Size(60, 381);
            this.lstXp.TabIndex = 18;
            // 
            // lstY
            // 
            this.lstY.FormattingEnabled = true;
            this.lstY.Location = new System.Drawing.Point(72, 40);
            this.lstY.Name = "lstY";
            this.lstY.Size = new System.Drawing.Size(60, 381);
            this.lstY.TabIndex = 17;
            // 
            // lstX
            // 
            this.lstX.FormattingEnabled = true;
            this.lstX.Location = new System.Drawing.Point(6, 41);
            this.lstX.Name = "lstX";
            this.lstX.Size = new System.Drawing.Size(60, 381);
            this.lstX.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(212, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "yp";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(140, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "xp";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(82, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "y";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "x";
            // 
            // frmTanFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbOptions);
            this.Controls.Add(this.grbInput);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbTableValues);
            this.Name = "frmTanFunction";
            this.Text = "frmTanFunction";
            this.Load += new System.EventHandler(this.frmTanFunction_Load);
            this.grbOptions.ResumeLayout(false);
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbTableValues.ResumeLayout(false);
            this.grbTableValues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOptions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grbTableValues;
        private System.Windows.Forms.ListBox lstYp;
        private System.Windows.Forms.ListBox lstXp;
        private System.Windows.Forms.ListBox lstY;
        private System.Windows.Forms.ListBox lstX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}