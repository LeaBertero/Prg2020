
namespace PruebaIf
{
    partial class FrmArranque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArranque));
            this.BtnAraanque1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAraanque1
            // 
            this.BtnAraanque1.BackColor = System.Drawing.Color.HotPink;
            this.BtnAraanque1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAraanque1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BtnAraanque1.Location = new System.Drawing.Point(716, 351);
            this.BtnAraanque1.Name = "BtnAraanque1";
            this.BtnAraanque1.Size = new System.Drawing.Size(103, 61);
            this.BtnAraanque1.TabIndex = 0;
            this.BtnAraanque1.Text = "SALIR";
            this.BtnAraanque1.UseVisualStyleBackColor = false;
            this.BtnAraanque1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.Black;
            this.Btn2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.Color.Lime;
            this.Btn2.Location = new System.Drawing.Point(216, 132);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(162, 81);
            this.Btn2.TabIndex = 1;
            this.Btn2.Text = "Formulario verde";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.DeepPink;
            this.Btn3.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Btn3.Location = new System.Drawing.Point(500, 132);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(198, 87);
            this.Btn3.TabIndex = 2;
            this.Btn3.Tag = "Formulario Rosado";
            this.Btn3.Text = "Ir al Formulario Rosado";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmArranque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(842, 424);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.BtnAraanque1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmArranque";
            this.Text = "Formulario Arranque";
            this.Load += new System.EventHandler(this.FrmArranque_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAraanque1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
    }
}