
namespace EjemploConversion
{
    partial class FrmConvert
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
            this.TxtOper1 = new System.Windows.Forms.TextBox();
            this.TxtOper2 = new System.Windows.Forms.TextBox();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.LblSuma = new System.Windows.Forms.Label();
            this.LblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtOper1
            // 
            this.TxtOper1.Location = new System.Drawing.Point(84, 108);
            this.TxtOper1.Name = "TxtOper1";
            this.TxtOper1.Size = new System.Drawing.Size(100, 20);
            this.TxtOper1.TabIndex = 0;
            // 
            // TxtOper2
            // 
            this.TxtOper2.Location = new System.Drawing.Point(345, 108);
            this.TxtOper2.Name = "TxtOper2";
            this.TxtOper2.Size = new System.Drawing.Size(100, 20);
            this.TxtOper2.TabIndex = 1;
            // 
            // BtnSuma
            // 
            this.BtnSuma.BackColor = System.Drawing.Color.Pink;
            this.BtnSuma.Font = new System.Drawing.Font("Jokerman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSuma.ForeColor = System.Drawing.Color.Black;
            this.BtnSuma.Location = new System.Drawing.Point(500, 94);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(107, 63);
            this.BtnSuma.TabIndex = 2;
            this.BtnSuma.Text = "=";
            this.BtnSuma.UseVisualStyleBackColor = false;
            // 
            // LblSuma
            // 
            this.LblSuma.AutoSize = true;
            this.LblSuma.Font = new System.Drawing.Font("Jokerman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSuma.ForeColor = System.Drawing.Color.Red;
            this.LblSuma.Location = new System.Drawing.Point(243, 93);
            this.LblSuma.Name = "LblSuma";
            this.LblSuma.Size = new System.Drawing.Size(43, 55);
            this.LblSuma.TabIndex = 3;
            this.LblSuma.Text = "+";
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.Location = new System.Drawing.Point(671, 102);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(0, 46);
            this.LblRes.TabIndex = 4;
            // 
            // FrmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 249);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.LblSuma);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.TxtOper2);
            this.Controls.Add(this.TxtOper1);
            this.Name = "FrmConvert";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOper1;
        private System.Windows.Forms.TextBox TxtOper2;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Label LblSuma;
        private System.Windows.Forms.Label LblRes;
    }
}

