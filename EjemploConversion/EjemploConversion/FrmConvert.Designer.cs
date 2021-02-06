
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConvert));
            this.TxtOper1 = new System.Windows.Forms.TextBox();
            this.TxtOper2 = new System.Windows.Forms.TextBox();
            this.BtnSuma = new System.Windows.Forms.Button();
            this.LblSuma = new System.Windows.Forms.Label();
            this.LblRes = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtOper1
            // 
            this.TxtOper1.Location = new System.Drawing.Point(210, 141);
            this.TxtOper1.Name = "TxtOper1";
            this.TxtOper1.Size = new System.Drawing.Size(100, 20);
            this.TxtOper1.TabIndex = 0;
            this.TxtOper1.TextChanged += new System.EventHandler(this.TxtOper1_TextChanged);
            // 
            // TxtOper2
            // 
            this.TxtOper2.Location = new System.Drawing.Point(433, 141);
            this.TxtOper2.Name = "TxtOper2";
            this.TxtOper2.Size = new System.Drawing.Size(100, 20);
            this.TxtOper2.TabIndex = 1;
            this.TxtOper2.TextChanged += new System.EventHandler(this.TxtOper2_TextChanged);
            // 
            // BtnSuma
            // 
            this.BtnSuma.BackColor = System.Drawing.Color.Lime;
            this.BtnSuma.Font = new System.Drawing.Font("Jokerman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSuma.ForeColor = System.Drawing.Color.Black;
            this.BtnSuma.Location = new System.Drawing.Point(584, 119);
            this.BtnSuma.Name = "BtnSuma";
            this.BtnSuma.Size = new System.Drawing.Size(107, 63);
            this.BtnSuma.TabIndex = 2;
            this.BtnSuma.Text = "=";
            this.BtnSuma.UseVisualStyleBackColor = false;
            this.BtnSuma.Click += new System.EventHandler(this.BtnSuma_Click);
            // 
            // LblSuma
            // 
            this.LblSuma.AutoSize = true;
            this.LblSuma.Font = new System.Drawing.Font("Jokerman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSuma.ForeColor = System.Drawing.Color.Black;
            this.LblSuma.Location = new System.Drawing.Point(348, 127);
            this.LblSuma.Name = "LblSuma";
            this.LblSuma.Size = new System.Drawing.Size(43, 55);
            this.LblSuma.TabIndex = 3;
            this.LblSuma.Text = "+";
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.Location = new System.Drawing.Point(716, 125);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(0, 46);
            this.LblRes.TabIndex = 4;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Lime;
            this.BtnSalir.Font = new System.Drawing.Font("Jokerman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(787, 297);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(127, 66);
            this.BtnSalir.TabIndex = 5;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(948, 385);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.LblSuma);
            this.Controls.Add(this.BtnSuma);
            this.Controls.Add(this.TxtOper2);
            this.Controls.Add(this.TxtOper1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConvert";
            this.Text = "Tercer Programa - OPERADORES";
            this.Load += new System.EventHandler(this.FrmConvert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOper1;
        private System.Windows.Forms.TextBox TxtOper2;
        private System.Windows.Forms.Button BtnSuma;
        private System.Windows.Forms.Label LblSuma;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Button BtnSalir;
    }
}

