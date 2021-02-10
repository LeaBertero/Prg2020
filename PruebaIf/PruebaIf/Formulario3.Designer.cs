
namespace PruebaIf
{
    partial class FrmPink
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
            this.Frm3 = new System.Windows.Forms.Button();
            this.BtnSALIR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Frm3
            // 
            this.Frm3.BackColor = System.Drawing.Color.Black;
            this.Frm3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Frm3.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frm3.ForeColor = System.Drawing.Color.MediumBlue;
            this.Frm3.Location = new System.Drawing.Point(24, 24);
            this.Frm3.Name = "Frm3";
            this.Frm3.Size = new System.Drawing.Size(328, 167);
            this.Frm3.TabIndex = 0;
            this.Frm3.Text = "Volver al primer formulario";
            this.Frm3.UseVisualStyleBackColor = false;
            this.Frm3.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSALIR
            // 
            this.BtnSALIR.BackColor = System.Drawing.Color.DeepPink;
            this.BtnSALIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSALIR.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSALIR.ForeColor = System.Drawing.Color.Honeydew;
            this.BtnSALIR.Location = new System.Drawing.Point(607, 339);
            this.BtnSALIR.Name = "BtnSALIR";
            this.BtnSALIR.Size = new System.Drawing.Size(159, 99);
            this.BtnSALIR.TabIndex = 1;
            this.BtnSALIR.Text = "Salir";
            this.BtnSALIR.UseVisualStyleBackColor = false;
            this.BtnSALIR.Click += new System.EventHandler(this.BtnSALIR_Click);
            // 
            // FrmPink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSALIR);
            this.Controls.Add(this.Frm3);
            this.Name = "FrmPink";
            this.Text = "Formulario Rosado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Frm3;
        private System.Windows.Forms.Button BtnSALIR;
    }
}