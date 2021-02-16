
namespace Seleccionar_Imagen
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
            this.BtnSeleccionarImagen = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PicMostrarImagen = new System.Windows.Forms.PictureBox();
            this.OfSeleccionarImagen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PicMostrarImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSeleccionarImagen
            // 
            this.BtnSeleccionarImagen.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionarImagen.Location = new System.Drawing.Point(92, 296);
            this.BtnSeleccionarImagen.Name = "BtnSeleccionarImagen";
            this.BtnSeleccionarImagen.Size = new System.Drawing.Size(163, 23);
            this.BtnSeleccionarImagen.TabIndex = 0;
            this.BtnSeleccionarImagen.Text = "Seleccionar Imagen";
            this.BtnSeleccionarImagen.UseVisualStyleBackColor = true;
            this.BtnSeleccionarImagen.Click += new System.EventHandler(this.SelecImg_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(531, 340);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(86, 46);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // PicMostrarImagen
            // 
            this.PicMostrarImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicMostrarImagen.Location = new System.Drawing.Point(92, 32);
            this.PicMostrarImagen.Name = "PicMostrarImagen";
            this.PicMostrarImagen.Size = new System.Drawing.Size(413, 244);
            this.PicMostrarImagen.TabIndex = 2;
            this.PicMostrarImagen.TabStop = false;
            // 
            // OfSeleccionarImagen
            // 
            this.OfSeleccionarImagen.Filter = "Archivos de mapas de bits|*.jpeg|png|*";
            this.OfSeleccionarImagen.Title = "Seleccionar Imagen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(629, 398);
            this.Controls.Add(this.PicMostrarImagen);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnSeleccionarImagen);
            this.Name = "Form1";
            this.Text = "Seleccionar Imagen";
            ((System.ComponentModel.ISupportInitialize)(this.PicMostrarImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSeleccionarImagen;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.PictureBox PicMostrarImagen;
        private System.Windows.Forms.OpenFileDialog OfSeleccionarImagen;
    }
}

