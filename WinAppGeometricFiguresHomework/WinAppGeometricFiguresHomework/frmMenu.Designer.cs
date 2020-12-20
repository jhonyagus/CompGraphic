namespace WinAppGeometricFiguresHomework
{
    partial class frmMenu
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
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnPentagon = new System.Windows.Forms.Button();
            this.btnHexagon = new System.Windows.Forms.Button();
            this.btnHeptagon = new System.Windows.Forms.Button();
            this.btnOctagon = new System.Windows.Forms.Button();
            this.btnNonagon = new System.Windows.Forms.Button();
            this.btnDecagon = new System.Windows.Forms.Button();
            this.btnUndecagon = new System.Windows.Forms.Button();
            this.btnDodecagon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(108, 82);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(178, 41);
            this.btnTriangle.TabIndex = 0;
            this.btnTriangle.Text = "Triángulo Equilátero";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Location = new System.Drawing.Point(108, 129);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(178, 41);
            this.btnSquare.TabIndex = 1;
            this.btnSquare.Text = "Cuadrado";
            this.btnSquare.UseVisualStyleBackColor = true;
            // 
            // btnPentagon
            // 
            this.btnPentagon.Location = new System.Drawing.Point(108, 176);
            this.btnPentagon.Name = "btnPentagon";
            this.btnPentagon.Size = new System.Drawing.Size(178, 41);
            this.btnPentagon.TabIndex = 2;
            this.btnPentagon.Text = "Pentágono";
            this.btnPentagon.UseVisualStyleBackColor = true;
            // 
            // btnHexagon
            // 
            this.btnHexagon.Location = new System.Drawing.Point(108, 223);
            this.btnHexagon.Name = "btnHexagon";
            this.btnHexagon.Size = new System.Drawing.Size(178, 41);
            this.btnHexagon.TabIndex = 3;
            this.btnHexagon.Text = "Hexágono";
            this.btnHexagon.UseVisualStyleBackColor = true;
            // 
            // btnHeptagon
            // 
            this.btnHeptagon.Location = new System.Drawing.Point(108, 270);
            this.btnHeptagon.Name = "btnHeptagon";
            this.btnHeptagon.Size = new System.Drawing.Size(178, 41);
            this.btnHeptagon.TabIndex = 4;
            this.btnHeptagon.Text = "Heptágono";
            this.btnHeptagon.UseVisualStyleBackColor = true;
            // 
            // btnOctagon
            // 
            this.btnOctagon.Location = new System.Drawing.Point(108, 317);
            this.btnOctagon.Name = "btnOctagon";
            this.btnOctagon.Size = new System.Drawing.Size(178, 41);
            this.btnOctagon.TabIndex = 5;
            this.btnOctagon.Text = "Octágono";
            this.btnOctagon.UseVisualStyleBackColor = true;
            // 
            // btnNonagon
            // 
            this.btnNonagon.Location = new System.Drawing.Point(108, 366);
            this.btnNonagon.Name = "btnNonagon";
            this.btnNonagon.Size = new System.Drawing.Size(178, 41);
            this.btnNonagon.TabIndex = 6;
            this.btnNonagon.Text = "Nonágono";
            this.btnNonagon.UseVisualStyleBackColor = true;
            // 
            // btnDecagon
            // 
            this.btnDecagon.Location = new System.Drawing.Point(108, 413);
            this.btnDecagon.Name = "btnDecagon";
            this.btnDecagon.Size = new System.Drawing.Size(178, 41);
            this.btnDecagon.TabIndex = 7;
            this.btnDecagon.Text = "Decágono";
            this.btnDecagon.UseVisualStyleBackColor = true;
            // 
            // btnUndecagon
            // 
            this.btnUndecagon.Location = new System.Drawing.Point(108, 460);
            this.btnUndecagon.Name = "btnUndecagon";
            this.btnUndecagon.Size = new System.Drawing.Size(178, 41);
            this.btnUndecagon.TabIndex = 8;
            this.btnUndecagon.Text = "Undecágono";
            this.btnUndecagon.UseVisualStyleBackColor = true;
            // 
            // btnDodecagon
            // 
            this.btnDodecagon.Location = new System.Drawing.Point(108, 507);
            this.btnDodecagon.Name = "btnDodecagon";
            this.btnDodecagon.Size = new System.Drawing.Size(178, 41);
            this.btnDodecagon.TabIndex = 9;
            this.btnDodecagon.Text = "Dodecágono";
            this.btnDodecagon.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 589);
            this.Controls.Add(this.btnDodecagon);
            this.Controls.Add(this.btnUndecagon);
            this.Controls.Add(this.btnDecagon);
            this.Controls.Add(this.btnNonagon);
            this.Controls.Add(this.btnOctagon);
            this.Controls.Add(this.btnHeptagon);
            this.Controls.Add(this.btnHexagon);
            this.Controls.Add(this.btnPentagon);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnTriangle);
            this.Name = "frmMenu";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnPentagon;
        private System.Windows.Forms.Button btnHexagon;
        private System.Windows.Forms.Button btnHeptagon;
        private System.Windows.Forms.Button btnOctagon;
        private System.Windows.Forms.Button btnNonagon;
        private System.Windows.Forms.Button btnDecagon;
        private System.Windows.Forms.Button btnUndecagon;
        private System.Windows.Forms.Button btnDodecagon;
    }
}

