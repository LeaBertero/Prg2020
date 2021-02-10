
namespace EjemploFor
{
    partial class FrmContador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContador));
            this.LblEtiqueta1 = new System.Windows.Forms.Label();
            this.LblRes = new System.Windows.Forms.Label();
            this.TxbDesde = new System.Windows.Forms.TextBox();
            this.TxbHasta = new System.Windows.Forms.TextBox();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.TxbPaso = new System.Windows.Forms.TextBox();
            this.TxtPaso = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnContar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEtiqueta1
            // 
            this.LblEtiqueta1.AutoSize = true;
            this.LblEtiqueta1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEtiqueta1.Location = new System.Drawing.Point(135, 160);
            this.LblEtiqueta1.Name = "LblEtiqueta1";
            this.LblEtiqueta1.Size = new System.Drawing.Size(58, 21);
            this.LblEtiqueta1.TabIndex = 1;
            this.LblEtiqueta1.Text = "Desde";
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRes.Location = new System.Drawing.Point(315, 297);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(0, 28);
            this.LblRes.TabIndex = 2;
            // 
            // TxbDesde
            // 
            this.TxbDesde.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxbDesde.Location = new System.Drawing.Point(139, 219);
            this.TxbDesde.Name = "TxbDesde";
            this.TxbDesde.Size = new System.Drawing.Size(100, 20);
            this.TxbDesde.TabIndex = 3;
            this.TxbDesde.TextChanged += new System.EventHandler(this.TxbDesde_TextChanged);
            // 
            // TxbHasta
            // 
            this.TxbHasta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxbHasta.Location = new System.Drawing.Point(318, 219);
            this.TxbHasta.Name = "TxbHasta";
            this.TxbHasta.Size = new System.Drawing.Size(100, 20);
            this.TxbHasta.TabIndex = 4;
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(314, 160);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(58, 21);
            this.Lbl2.TabIndex = 5;
            this.Lbl2.Text = "Hasta";
            // 
            // TxbPaso
            // 
            this.TxbPaso.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxbPaso.Location = new System.Drawing.Point(493, 219);
            this.TxbPaso.Name = "TxbPaso";
            this.TxbPaso.Size = new System.Drawing.Size(100, 20);
            this.TxbPaso.TabIndex = 6;
            this.TxbPaso.TextChanged += new System.EventHandler(this.TxbPaso_TextChanged);
            // 
            // TxtPaso
            // 
            this.TxtPaso.AutoSize = true;
            this.TxtPaso.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPaso.Location = new System.Drawing.Point(545, 160);
            this.TxtPaso.Name = "TxtPaso";
            this.TxtPaso.Size = new System.Drawing.Size(48, 21);
            this.TxtPaso.TabIndex = 7;
            this.TxtPaso.Text = "Paso";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.HotPink;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(318, 412);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(146, 67);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "Finalizar ";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnContar
            // 
            this.BtnContar.BackColor = System.Drawing.Color.HotPink;
            this.BtnContar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnContar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnContar.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContar.ForeColor = System.Drawing.Color.Black;
            this.BtnContar.Image = global::EjemploFor.Properties.Resources._9a152be4a778abbe025784d9d3ec19f6__pink_panthers_cartoon;
            this.BtnContar.Location = new System.Drawing.Point(688, 80);
            this.BtnContar.Name = "BtnContar";
            this.BtnContar.Size = new System.Drawing.Size(252, 305);
            this.BtnContar.TabIndex = 0;
            this.BtnContar.Text = "Hago click?";
            this.BtnContar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnContar.UseVisualStyleBackColor = false;
            this.BtnContar.Click += new System.EventHandler(this.BtnContar_Click);
            // 
            // FrmContador
            // 
            this.AcceptButton = this.BtnContar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1027, 525);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtPaso);
            this.Controls.Add(this.TxbPaso);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.TxbHasta);
            this.Controls.Add(this.TxbDesde);
            this.Controls.Add(this.LblRes);
            this.Controls.Add(this.LblEtiqueta1);
            this.Controls.Add(this.BtnContar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmContador";
            this.Text = "Ejemplo For (Para)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblEtiqueta1;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.TextBox TxbDesde;
        private System.Windows.Forms.TextBox TxbHasta;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.TextBox TxbPaso;
        private System.Windows.Forms.Label TxtPaso;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnContar;
    }
}

