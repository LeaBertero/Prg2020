
namespace DesplazamientoLabel
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
            this.LblMov = new System.Windows.Forms.Label();
            this.BtnReady = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMov
            // 
            this.LblMov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LblMov.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LblMov.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMov.Location = new System.Drawing.Point(0, 40);
            this.LblMov.Name = "LblMov";
            this.LblMov.Size = new System.Drawing.Size(331, 57);
            this.LblMov.TabIndex = 0;
            this.LblMov.Text = "Moveme, si podés !";
            this.LblMov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnReady
            // 
            this.BtnReady.BackColor = System.Drawing.Color.Crimson;
            this.BtnReady.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnReady.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReady.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnReady.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReady.ForeColor = System.Drawing.Color.Yellow;
            this.BtnReady.Location = new System.Drawing.Point(28, 211);
            this.BtnReady.Name = "BtnReady";
            this.BtnReady.Size = new System.Drawing.Size(98, 52);
            this.BtnReady.TabIndex = 1;
            this.BtnReady.Text = "Eject";
            this.BtnReady.UseVisualStyleBackColor = false;
            this.BtnReady.Click += new System.EventHandler(this.BtnReady_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Black;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnSalir.Location = new System.Drawing.Point(195, 217);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(241, 40);
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.Text = "Salir del Formulario";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(540, 316);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnReady);
            this.Controls.Add(this.LblMov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Desplazamiento de Label";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblMov;
        private System.Windows.Forms.Button BtnReady;
        private System.Windows.Forms.Button BtnSalir;
    }
}

