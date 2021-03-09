
namespace Ejemplo_While
{
    partial class EjemploWhile
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
            this.BtnGo = new System.Windows.Forms.Button();
            this.Lbldes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGo
            // 
            this.BtnGo.BackColor = System.Drawing.Color.LawnGreen;
            this.BtnGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGo.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGo.ForeColor = System.Drawing.Color.Red;
            this.BtnGo.Location = new System.Drawing.Point(168, 12);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(140, 44);
            this.BtnGo.TabIndex = 0;
            this.BtnGo.Text = "Derecha";
            this.BtnGo.UseVisualStyleBackColor = false;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // Lbldes
            // 
            this.Lbldes.BackColor = System.Drawing.Color.Yellow;
            this.Lbldes.Location = new System.Drawing.Point(0, 100);
            this.Lbldes.Name = "Lbldes";
            this.Lbldes.Size = new System.Drawing.Size(50, 50);
            this.Lbldes.TabIndex = 1;
            // 
            // EjemploWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.Lbldes);
            this.Controls.Add(this.BtnGo);
            this.Name = "EjemploWhile";
            this.Text = "Ejemplo While";
            this.Load += new System.EventHandler(this.EjemploWhile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.Label Lbldes;
    }
}

