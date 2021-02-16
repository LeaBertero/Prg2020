
namespace Reloj_fecha_tiempo_real
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LblHora = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.Empezar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.BackColor = System.Drawing.Color.OrangeRed;
            this.LblHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblHora.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblHora.Location = new System.Drawing.Point(151, 114);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(130, 62);
            this.LblHora.TabIndex = 0;
            this.LblHora.Text = "Hora";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.Violet;
            this.LblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblFecha.Font = new System.Drawing.Font("Ink Free", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.DimGray;
            this.LblFecha.Location = new System.Drawing.Point(89, 269);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(152, 62);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Fecha";
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // Empezar
            // 
            this.Empezar.BackColor = System.Drawing.Color.LimeGreen;
            this.Empezar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Empezar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Empezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Empezar.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empezar.Location = new System.Drawing.Point(563, 33);
            this.Empezar.Name = "Empezar";
            this.Empezar.Size = new System.Drawing.Size(203, 98);
            this.Empezar.TabIndex = 2;
            this.Empezar.Text = "PushMe";
            this.Empezar.UseVisualStyleBackColor = false;
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(630, 362);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(124, 53);
            this.Salir.TabIndex = 3;
            this.Salir.Text = "Exit";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Empezar);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblHora);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 320);
            this.Name = "Form1";
            this.Text = "Hora / Fecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Timer HoraFecha;
        private System.Windows.Forms.Button Empezar;
        private System.Windows.Forms.Button Salir;
    }
}

