namespace WinAppVectors2D
{
    partial class frmVectors2D
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtYVectorPer = new System.Windows.Forms.TextBox();
            this.txtXVectorPer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYVectorPro = new System.Windows.Forms.TextBox();
            this.txtXVectorPro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProjection = new System.Windows.Forms.Button();
            this.txtYVectorC = new System.Windows.Forms.TextBox();
            this.txtXVectorC = new System.Windows.Forms.TextBox();
            this.lblSeparator1 = new System.Windows.Forms.Label();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.nudYVectorB = new System.Windows.Forms.NumericUpDown();
            this.nudXVectorB = new System.Windows.Forms.NumericUpDown();
            this.nudYVectorA = new System.Windows.Forms.NumericUpDown();
            this.nudXVectorA = new System.Windows.Forms.NumericUpDown();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblVectorC = new System.Windows.Forms.Label();
            this.lblVectorB = new System.Windows.Forms.Label();
            this.lblVectorA = new System.Windows.Forms.Label();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.grbOperations = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYVectorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVectorB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYVectorA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVectorA)).BeginInit();
            this.grbCanvas.SuspendLayout();
            this.grbOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(6, 20);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(600, 488);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // txtYVectorPer
            // 
            this.txtYVectorPer.Enabled = false;
            this.txtYVectorPer.Location = new System.Drawing.Point(155, 264);
            this.txtYVectorPer.Name = "txtYVectorPer";
            this.txtYVectorPer.Size = new System.Drawing.Size(36, 20);
            this.txtYVectorPer.TabIndex = 21;
            // 
            // txtXVectorPer
            // 
            this.txtXVectorPer.Enabled = false;
            this.txtXVectorPer.Location = new System.Drawing.Point(114, 264);
            this.txtXVectorPer.Name = "txtXVectorPer";
            this.txtXVectorPer.Size = new System.Drawing.Size(36, 20);
            this.txtXVectorPer.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Vector Perpendicular:";
            // 
            // txtYVectorPro
            // 
            this.txtYVectorPro.Enabled = false;
            this.txtYVectorPro.Location = new System.Drawing.Point(155, 240);
            this.txtYVectorPro.Name = "txtYVectorPro";
            this.txtYVectorPro.Size = new System.Drawing.Size(36, 20);
            this.txtYVectorPro.TabIndex = 18;
            // 
            // txtXVectorPro
            // 
            this.txtXVectorPro.Enabled = false;
            this.txtXVectorPro.Location = new System.Drawing.Point(114, 241);
            this.txtXVectorPro.Name = "txtXVectorPro";
            this.txtXVectorPro.Size = new System.Drawing.Size(36, 20);
            this.txtXVectorPro.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Proyección A/B:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(50, 303);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProjection
            // 
            this.btnProjection.Location = new System.Drawing.Point(50, 203);
            this.btnProjection.Name = "btnProjection";
            this.btnProjection.Size = new System.Drawing.Size(114, 23);
            this.btnProjection.TabIndex = 14;
            this.btnProjection.Text = "Proyección A/B";
            this.btnProjection.UseVisualStyleBackColor = true;
            // 
            // txtYVectorC
            // 
            this.txtYVectorC.Enabled = false;
            this.txtYVectorC.Location = new System.Drawing.Point(114, 161);
            this.txtYVectorC.Name = "txtYVectorC";
            this.txtYVectorC.Size = new System.Drawing.Size(36, 20);
            this.txtYVectorC.TabIndex = 13;
            // 
            // txtXVectorC
            // 
            this.txtXVectorC.Enabled = false;
            this.txtXVectorC.Location = new System.Drawing.Point(63, 161);
            this.txtXVectorC.Name = "txtXVectorC";
            this.txtXVectorC.Size = new System.Drawing.Size(36, 20);
            this.txtXVectorC.TabIndex = 12;
            // 
            // lblSeparator1
            // 
            this.lblSeparator1.AutoSize = true;
            this.lblSeparator1.Location = new System.Drawing.Point(6, 136);
            this.lblSeparator1.Name = "lblSeparator1";
            this.lblSeparator1.Size = new System.Drawing.Size(175, 13);
            this.lblSeparator1.TabIndex = 11;
            this.lblSeparator1.Text = "____________________________";
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(166, 92);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(28, 23);
            this.btnSubtraction.TabIndex = 10;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            this.btnSubtraction.Click += new System.EventHandler(this.btnSubtraction_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(166, 47);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(28, 23);
            this.btnAddition.TabIndex = 9;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // nudYVectorB
            // 
            this.nudYVectorB.Location = new System.Drawing.Point(114, 95);
            this.nudYVectorB.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudYVectorB.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudYVectorB.Name = "nudYVectorB";
            this.nudYVectorB.Size = new System.Drawing.Size(36, 20);
            this.nudYVectorB.TabIndex = 8;
            // 
            // nudXVectorB
            // 
            this.nudXVectorB.Location = new System.Drawing.Point(63, 95);
            this.nudXVectorB.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudXVectorB.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudXVectorB.Name = "nudXVectorB";
            this.nudXVectorB.Size = new System.Drawing.Size(36, 20);
            this.nudXVectorB.TabIndex = 7;
            // 
            // nudYVectorA
            // 
            this.nudYVectorA.Location = new System.Drawing.Point(114, 50);
            this.nudYVectorA.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudYVectorA.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudYVectorA.Name = "nudYVectorA";
            this.nudYVectorA.Size = new System.Drawing.Size(36, 20);
            this.nudYVectorA.TabIndex = 6;
            // 
            // nudXVectorA
            // 
            this.nudXVectorA.Location = new System.Drawing.Point(63, 50);
            this.nudXVectorA.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudXVectorA.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudXVectorA.Name = "nudXVectorA";
            this.nudXVectorA.Size = new System.Drawing.Size(36, 20);
            this.nudXVectorA.TabIndex = 5;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(123, 19);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 4;
            this.lblY.Text = "Y";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(71, 20);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X";
            // 
            // lblVectorC
            // 
            this.lblVectorC.AutoSize = true;
            this.lblVectorC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblVectorC.Location = new System.Drawing.Point(6, 168);
            this.lblVectorC.Name = "lblVectorC";
            this.lblVectorC.Size = new System.Drawing.Size(51, 13);
            this.lblVectorC.TabIndex = 2;
            this.lblVectorC.Text = "Vector C:";
            // 
            // lblVectorB
            // 
            this.lblVectorB.AutoSize = true;
            this.lblVectorB.ForeColor = System.Drawing.Color.Blue;
            this.lblVectorB.Location = new System.Drawing.Point(6, 102);
            this.lblVectorB.Name = "lblVectorB";
            this.lblVectorB.Size = new System.Drawing.Size(51, 13);
            this.lblVectorB.TabIndex = 1;
            this.lblVectorB.Text = "Vector B:";
            // 
            // lblVectorA
            // 
            this.lblVectorA.AutoSize = true;
            this.lblVectorA.ForeColor = System.Drawing.Color.Red;
            this.lblVectorA.Location = new System.Drawing.Point(6, 57);
            this.lblVectorA.Name = "lblVectorA";
            this.lblVectorA.Size = new System.Drawing.Size(51, 13);
            this.lblVectorA.TabIndex = 0;
            this.lblVectorA.Text = "Vector A:";
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(237, 11);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(626, 531);
            this.grbCanvas.TabIndex = 1;
            this.grbCanvas.TabStop = false;
            // 
            // grbOperations
            // 
            this.grbOperations.Controls.Add(this.txtYVectorPer);
            this.grbOperations.Controls.Add(this.txtXVectorPer);
            this.grbOperations.Controls.Add(this.label2);
            this.grbOperations.Controls.Add(this.txtYVectorPro);
            this.grbOperations.Controls.Add(this.txtXVectorPro);
            this.grbOperations.Controls.Add(this.label1);
            this.grbOperations.Controls.Add(this.btnExit);
            this.grbOperations.Controls.Add(this.btnProjection);
            this.grbOperations.Controls.Add(this.txtYVectorC);
            this.grbOperations.Controls.Add(this.txtXVectorC);
            this.grbOperations.Controls.Add(this.lblSeparator1);
            this.grbOperations.Controls.Add(this.btnSubtraction);
            this.grbOperations.Controls.Add(this.btnAddition);
            this.grbOperations.Controls.Add(this.nudYVectorB);
            this.grbOperations.Controls.Add(this.nudXVectorB);
            this.grbOperations.Controls.Add(this.nudYVectorA);
            this.grbOperations.Controls.Add(this.nudXVectorA);
            this.grbOperations.Controls.Add(this.lblY);
            this.grbOperations.Controls.Add(this.lblX);
            this.grbOperations.Controls.Add(this.lblVectorC);
            this.grbOperations.Controls.Add(this.lblVectorB);
            this.grbOperations.Controls.Add(this.lblVectorA);
            this.grbOperations.Location = new System.Drawing.Point(10, 11);
            this.grbOperations.Name = "grbOperations";
            this.grbOperations.Size = new System.Drawing.Size(221, 340);
            this.grbOperations.TabIndex = 2;
            this.grbOperations.TabStop = false;
            // 
            // frmVectors2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 540);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbOperations);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVectors2D";
            this.Text = "Operaciones de Vectores en 2D";
            this.Load += new System.EventHandler(this.frmVectors2D_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYVectorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVectorB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYVectorA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXVectorA)).EndInit();
            this.grbCanvas.ResumeLayout(false);
            this.grbOperations.ResumeLayout(false);
            this.grbOperations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TextBox txtYVectorPer;
        private System.Windows.Forms.TextBox txtXVectorPer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYVectorPro;
        private System.Windows.Forms.TextBox txtXVectorPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProjection;
        private System.Windows.Forms.TextBox txtYVectorC;
        private System.Windows.Forms.TextBox txtXVectorC;
        private System.Windows.Forms.Label lblSeparator1;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.NumericUpDown nudYVectorB;
        private System.Windows.Forms.NumericUpDown nudXVectorB;
        private System.Windows.Forms.NumericUpDown nudYVectorA;
        private System.Windows.Forms.NumericUpDown nudXVectorA;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblVectorC;
        private System.Windows.Forms.Label lblVectorB;
        private System.Windows.Forms.Label lblVectorA;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.GroupBox grbOperations;
    }
}

