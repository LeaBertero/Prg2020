
namespace Prueba_IF_2
{
    partial class Form1
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
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.LblTique = new System.Windows.Forms.Label();
            this.LblRes = new System.Windows.Forms.Label();
            this.BtAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtEdad
            // 
            this.TxtEdad.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEdad.Location = new System.Drawing.Point(239, 204);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(113, 33);
            this.TxtEdad.TabIndex = 0;
            // 
            // LblTique
            // 
            this.LblTique.AutoSize = true;
            this.LblTique.Font = new System.Drawing.Font("Jokerman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTique.Location = new System.Drawing.Point(230, 83);
            this.LblTique.Name = "LblTique";
            this.LblTique.Size = new System.Drawing.Size(322, 51);
            this.LblTique.TabIndex = 1;
            this.LblTique.Text = "Indique su edad:";
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.Location = new System.Drawing.Point(371, 318);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(0, 28);
            this.LblRes.TabIndex = 2;
            // 
            // BtAceptar
            // 
            this.BtAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtAceptar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAceptar.Location = new System.Drawing.Point(398, 192);
            this.BtAceptar.Name = "BtAceptar";
            this.BtAceptar.Size = new System.Drawing.Size(145, 70);
            this.BtAceptar.TabIndex = 3;
            this.BtAceptar.Text = "Click Aquí";
            this.BtAceptar.UseVisualStyleBackColor = false;
            this.BtAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtAceptar);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.LblTique);
            this.Controls.Add(this.TxtEdad);
            this.Name = "Form1";
            this.Text = "Prueba IF 2 - EDAD DE LA PERSONA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label LblTique;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Button BtAceptar;
    }
}

