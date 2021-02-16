
namespace EjemploWhile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EjemploWhile));
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Lbl = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.LblDerecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.Red;
            this.Btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.Color.GhostWhite;
            this.Btn1.Location = new System.Drawing.Point(969, 23);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(146, 73);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "River Plate";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.DarkBlue;
            this.Btn2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.Color.Gold;
            this.Btn2.Location = new System.Drawing.Point(44, 23);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(154, 73);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "Boca Juniors";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Lbl
            // 
            this.Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lbl.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl.Image = global::EjemploWhile.Properties.Resources.descarga;
            this.Lbl.Location = new System.Drawing.Point(38, 141);
            this.Lbl.Name = "Lbl";
            this.Lbl.Size = new System.Drawing.Size(306, 314);
            this.Lbl.TabIndex = 1;
            this.Lbl.Text = "RIVER PLATE";
            this.Lbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Lbl.Click += new System.EventHandler(this.Lbl_Click);
            // 
            // Lbl2
            // 
            this.Lbl2.BackColor = System.Drawing.Color.DarkBlue;
            this.Lbl2.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.ForeColor = System.Drawing.Color.Gold;
            this.Lbl2.Image = global::EjemploWhile.Properties.Resources.descarga__1_;
            this.Lbl2.Location = new System.Drawing.Point(898, 132);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(254, 323);
            this.Lbl2.TabIndex = 3;
            this.Lbl2.Text = "BOCA JUNIORS";
            this.Lbl2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LblDerecha
            // 
            this.LblDerecha.AutoSize = true;
            this.LblDerecha.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDerecha.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LblDerecha.Location = new System.Drawing.Point(477, 160);
            this.LblDerecha.Name = "LblDerecha";
            this.LblDerecha.Size = new System.Drawing.Size(177, 39);
            this.LblDerecha.TabIndex = 4;
            this.LblDerecha.Text = "River ---->";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(471, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "<---- Boca ";
            // 
            // EjemploWhile
            // 
            this.AcceptButton = this.Btn1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1232, 541);
            this.Controls.Add(this.Lbl);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.LblDerecha);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EjemploWhile";
            this.Text = "EJEMPLO WHILE (MIENTRAS) - BOCA / RIVER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Label Lbl;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label LblDerecha;
        private System.Windows.Forms.Label label1;
    }
}

