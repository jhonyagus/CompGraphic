namespace WinAppGeometricFiguresHomework
{
    partial class frmHexagons
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
            this.grbGraphic = new System.Windows.Forms.GroupBox();
            this.grbButtons = new System.Windows.Forms.GroupBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grbGraphic.SuspendLayout();
            this.grbButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbGraphic
            // 
            this.grbGraphic.Controls.Add(this.picCanvas);
            this.grbGraphic.Location = new System.Drawing.Point(10, 5);
            this.grbGraphic.Name = "grbGraphic";
            this.grbGraphic.Size = new System.Drawing.Size(670, 436);
            this.grbGraphic.TabIndex = 0;
            this.grbGraphic.TabStop = false;
            this.grbGraphic.Text = "Gráfico";
            // 
            // grbButtons
            // 
            this.grbButtons.Controls.Add(this.btnExit);
            this.grbButtons.Controls.Add(this.btnReset);
            this.grbButtons.Controls.Add(this.btnDraw);
            this.grbButtons.Location = new System.Drawing.Point(689, 16);
            this.grbButtons.Name = "grbButtons";
            this.grbButtons.Size = new System.Drawing.Size(106, 424);
            this.grbButtons.TabIndex = 1;
            this.grbButtons.TabStop = false;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(9, 16);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(84, 23);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Graficar";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(9, 45);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(9, 74);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(9, 20);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(649, 404);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // frmHexagons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbButtons);
            this.Controls.Add(this.grbGraphic);
            this.Name = "frmHexagons";
            this.Text = "frmHexagons";
            this.grbGraphic.ResumeLayout(false);
            this.grbButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbGraphic;
        private System.Windows.Forms.GroupBox grbButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}