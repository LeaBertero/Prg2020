
namespace EjemploWhile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm1));
            this.PicBigote = new System.Windows.Forms.PictureBox();
            this.PicPantera = new System.Windows.Forms.PictureBox();
            this.BtnComenzar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBigote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPantera)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBigote
            // 
            resources.ApplyResources(this.PicBigote, "PicBigote");
            this.PicBigote.Name = "PicBigote";
            this.PicBigote.TabStop = false;
            this.PicBigote.Click += new System.EventHandler(this.PicBigote_Click);
            // 
            // PicPantera
            // 
            this.PicPantera.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.PicPantera, "PicPantera");
            this.PicPantera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicPantera.Name = "PicPantera";
            this.PicPantera.TabStop = false;
            this.PicPantera.Click += new System.EventHandler(this.PicPantera_Click);
            // 
            // BtnComenzar
            // 
            this.BtnComenzar.BackColor = System.Drawing.Color.Black;
            this.BtnComenzar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnComenzar, "BtnComenzar");
            this.BtnComenzar.ForeColor = System.Drawing.Color.DeepPink;
            this.BtnComenzar.Name = "BtnComenzar";
            this.BtnComenzar.UseVisualStyleBackColor = false;
            this.BtnComenzar.Click += new System.EventHandler(this.BtnComenzar_Click);
            // 
            // Frm1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PicBigote);
            this.Controls.Add(this.BtnComenzar);
            this.Controls.Add(this.PicPantera);
            this.Name = "Frm1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBigote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPantera)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBigote;
        private System.Windows.Forms.Button BtnComenzar;
        private System.Windows.Forms.PictureBox PicPantera;
    }
}

