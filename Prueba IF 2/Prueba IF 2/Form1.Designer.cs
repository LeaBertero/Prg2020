
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
            this.TxtIngreso = new System.Windows.Forms.TextBox();
            this.LblEtique = new System.Windows.Forms.Label();
            this.Edad = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtIngreso
            // 
            this.TxtIngreso.Location = new System.Drawing.Point(124, 80);
            this.TxtIngreso.Name = "TxtIngreso";
            this.TxtIngreso.Size = new System.Drawing.Size(100, 20);
            this.TxtIngreso.TabIndex = 0;
            // 
            // LblEtique
            // 
            this.LblEtique.AutoSize = true;
            this.LblEtique.Location = new System.Drawing.Point(121, 35);
            this.LblEtique.Name = "LblEtique";
            this.LblEtique.Size = new System.Drawing.Size(38, 13);
            this.LblEtique.TabIndex = 1;
            this.LblEtique.Text = "Edad?";
            // 
            // Edad
            // 
            this.Edad.AutoSize = true;
            this.Edad.Location = new System.Drawing.Point(121, 157);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(0, 13);
            this.Edad.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(260, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "Click Aquí";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Edad);
            this.Controls.Add(this.LblEtique);
            this.Controls.Add(this.TxtIngreso);
            this.Name = "Form1";
            this.Text = "Prueba IF 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtIngreso;
        private System.Windows.Forms.Label LblEtique;
        private System.Windows.Forms.Label Edad;
        private System.Windows.Forms.Button button1;
    }
}

