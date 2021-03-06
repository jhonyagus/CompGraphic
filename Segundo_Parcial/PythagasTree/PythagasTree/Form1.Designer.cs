
namespace PythagasTree
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkFill = new System.Windows.Forms.CheckBox();
            this.nudAlpha = new System.Windows.Forms.NumericUpDown();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.nudDepth = new System.Windows.Forms.NumericUpDown();
            this.btnFill = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkFill);
            this.groupBox1.Controls.Add(this.nudAlpha);
            this.groupBox1.Controls.Add(this.nudLength);
            this.groupBox1.Controls.Add(this.nudDepth);
            this.groupBox1.Controls.Add(this.btnFill);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 404);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // chkFill
            // 
            this.chkFill.AutoSize = true;
            this.chkFill.Location = new System.Drawing.Point(53, 191);
            this.chkFill.Name = "chkFill";
            this.chkFill.Size = new System.Drawing.Size(55, 17);
            this.chkFill.TabIndex = 8;
            this.chkFill.TabStop = false;
            this.chkFill.Text = "Llenar";
            this.chkFill.UseVisualStyleBackColor = true;
            this.chkFill.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nudAlpha
            // 
            this.nudAlpha.Location = new System.Drawing.Point(76, 92);
            this.nudAlpha.Name = "nudAlpha";
            this.nudAlpha.Size = new System.Drawing.Size(120, 20);
            this.nudAlpha.TabIndex = 6;
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(76, 66);
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(120, 20);
            this.nudLength.TabIndex = 5;
            // 
            // nudDepth
            // 
            this.nudDepth.Location = new System.Drawing.Point(76, 33);
            this.nudDepth.Name = "nudDepth";
            this.nudDepth.Size = new System.Drawing.Size(120, 20);
            this.nudDepth.TabIndex = 4;
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(53, 141);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(75, 23);
            this.btnFill.TabIndex = 3;
            this.btnFill.Text = "Llenar";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alpha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Largo";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(6, 35);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(64, 13);
            this.lblP.TabIndex = 0;
            this.lblP.Text = "Profundidad";
            this.lblP.Click += new System.EventHandler(this.label1_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(6, 19);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(520, 379);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picCanvas);
            this.groupBox2.Location = new System.Drawing.Point(256, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 404);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Canvas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudAlpha;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.NumericUpDown nudDepth;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.CheckBox chkFill;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

