namespace WinAppTrigonometricFunctions
{
    partial class frmMenu
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
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnCtg = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.btnCsc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(154, 33);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(123, 28);
            this.btnSin.TabIndex = 0;
            this.btnSin.Text = "Función Seno";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(154, 77);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(123, 28);
            this.btnCos.TabIndex = 1;
            this.btnCos.Text = "Función Coseno";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(154, 124);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(123, 28);
            this.btnTan.TabIndex = 2;
            this.btnTan.Text = "Función Tangente";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnCtg
            // 
            this.btnCtg.Location = new System.Drawing.Point(154, 167);
            this.btnCtg.Name = "btnCtg";
            this.btnCtg.Size = new System.Drawing.Size(123, 28);
            this.btnCtg.TabIndex = 3;
            this.btnCtg.Text = "Función Cotangente";
            this.btnCtg.UseVisualStyleBackColor = true;
            this.btnCtg.Click += new System.EventHandler(this.btnCtg_Click);
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(154, 211);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(123, 28);
            this.btnSec.TabIndex = 4;
            this.btnSec.Text = "Función Secante";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // btnCsc
            // 
            this.btnCsc.Location = new System.Drawing.Point(154, 254);
            this.btnCsc.Name = "btnCsc";
            this.btnCsc.Size = new System.Drawing.Size(123, 28);
            this.btnCsc.TabIndex = 5;
            this.btnCsc.Text = "Función Cosecante";
            this.btnCsc.UseVisualStyleBackColor = true;
            this.btnCsc.Click += new System.EventHandler(this.btnCsc_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 344);
            this.Controls.Add(this.btnCsc);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.btnCtg);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnCtg;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Button btnCsc;
    }
}