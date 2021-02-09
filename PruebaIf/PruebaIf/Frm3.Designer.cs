
namespace PruebaIf
{
    partial class Frm3
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
            this.BtnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.MediumOrchid;
            this.BtnVolver.Font = new System.Drawing.Font("MV Boli", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnVolver.Location = new System.Drawing.Point(184, 119);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(150, 70);
            this.BtnVolver.TabIndex = 0;
            this.BtnVolver.Text = "INICIO";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // Frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVolver);
            this.Name = "Frm3";
            this.Text = "Frm3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVolver;
    }
}