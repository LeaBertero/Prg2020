
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
            this.SuspendLayout();
            // 
            // Frm3
            // 
            this.Frm3.BackColor = System.Drawing.Color.Black;
            this.Frm3.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frm3.ForeColor = System.Drawing.Color.MediumBlue;
            this.Frm3.Location = new System.Drawing.Point(206, 158);
            this.Frm3.Name = "Frm3";
            this.Frm3.Size = new System.Drawing.Size(196, 72);
            this.Frm3.TabIndex = 0;
            this.Frm3.Text = "Volver al primer formulario";
            this.Frm3.UseVisualStyleBackColor = false;
            this.Frm3.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Frm3);
            this.Name = "FrmPink";
            this.Text = "Formulario Rosado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Frm3;
    }
}