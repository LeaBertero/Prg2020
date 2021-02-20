
namespace Ejemplo_Mientras_y_Repetir_Hasta_V1
{
    partial class Frm1
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
            this.BtnEmpezar = new System.Windows.Forms.Button();
            this.LblMov = new System.Windows.Forms.Label();
            this.BtnFin = new System.Windows.Forms.Button();
            this.LblDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEmpezar
            // 
            this.BtnEmpezar.BackColor = System.Drawing.SystemColors.MenuText;
            this.BtnEmpezar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEmpezar.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.BtnEmpezar.FlatAppearance.BorderSize = 20;
            this.BtnEmpezar.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmpezar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.BtnEmpezar.Location = new System.Drawing.Point(116, 12);
            this.BtnEmpezar.Name = "BtnEmpezar";
            this.BtnEmpezar.Size = new System.Drawing.Size(165, 60);
            this.BtnEmpezar.TabIndex = 0;
            this.BtnEmpezar.Text = "Travel left";
            this.BtnEmpezar.UseVisualStyleBackColor = false;
            this.BtnEmpezar.Click += new System.EventHandler(this.BtnEmpezar_Click);
            // 
            // LblMov
            // 
            this.LblMov.BackColor = System.Drawing.Color.Red;
            this.LblMov.Location = new System.Drawing.Point(0, 100);
            this.LblMov.Margin = new System.Windows.Forms.Padding(0);
            this.LblMov.Name = "LblMov";
            this.LblMov.Size = new System.Drawing.Size(50, 204);
            this.LblMov.TabIndex = 1;
            // 
            // BtnFin
            // 
            this.BtnFin.BackColor = System.Drawing.Color.Black;
            this.BtnFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFin.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFin.ForeColor = System.Drawing.SystemColors.Menu;
            this.BtnFin.Location = new System.Drawing.Point(363, 12);
            this.BtnFin.Name = "BtnFin";
            this.BtnFin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnFin.Size = new System.Drawing.Size(210, 60);
            this.BtnFin.TabIndex = 2;
            this.BtnFin.Text = "Travel left to right";
            this.BtnFin.UseVisualStyleBackColor = false;
            this.BtnFin.Click += new System.EventHandler(this.BtnFin_Click);
            // 
            // LblDe
            // 
            this.LblDe.BackColor = System.Drawing.Color.Red;
            this.LblDe.Location = new System.Drawing.Point(585, 100);
            this.LblDe.Name = "LblDe";
            this.LblDe.Size = new System.Drawing.Size(44, 204);
            this.LblDe.TabIndex = 3;
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 368);
            this.Controls.Add(this.LblDe);
            this.Controls.Add(this.BtnFin);
            this.Controls.Add(this.BtnEmpezar);
            this.Controls.Add(this.LblMov);
            this.Name = "Frm1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Mientras y Repetit Hasta - (While - Do While)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEmpezar;
        private System.Windows.Forms.Label LblMov;
        private System.Windows.Forms.Button BtnFin;
        private System.Windows.Forms.Label LblDe;
    }
}

