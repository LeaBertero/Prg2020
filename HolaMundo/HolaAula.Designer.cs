﻿
namespace HolaMundo
{
    partial class HolaAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HolaAula));
            this.btAceptar = new System.Windows.Forms.Button();
            this.textMateria = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.TxbMensaje = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.Black;
            this.btAceptar.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.ForeColor = System.Drawing.Color.Red;
            this.btAceptar.Location = new System.Drawing.Point(312, 213);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(146, 58);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // textMateria
            // 
            this.textMateria.AutoSize = true;
            this.textMateria.BackColor = System.Drawing.Color.DeepPink;
            this.textMateria.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMateria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textMateria.Location = new System.Drawing.Point(219, 153);
            this.textMateria.Name = "textMateria";
            this.textMateria.Size = new System.Drawing.Size(118, 24);
            this.textMateria.TabIndex = 1;
            this.textMateria.Text = "MATERIA";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMensaje.ImageKey = "(ninguno)";
            this.lblMensaje.Location = new System.Drawing.Point(218, 68);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(79, 25);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "HOLA";
            // 
            // TxbMensaje
            // 
            this.TxbMensaje.BackColor = System.Drawing.Color.Aquamarine;
            this.TxbMensaje.ForeColor = System.Drawing.Color.Black;
            this.TxbMensaje.Location = new System.Drawing.Point(362, 155);
            this.TxbMensaje.Name = "TxbMensaje";
            this.TxbMensaje.Size = new System.Drawing.Size(230, 22);
            this.TxbMensaje.TabIndex = 3;
            this.TxbMensaje.TextChanged += new System.EventHandler(this.TxbMensaje_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Lime;
            this.btnSalir.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalir.Location = new System.Drawing.Point(476, 213);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(146, 58);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // HolaAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(872, 444);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.TxbMensaje);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.textMateria);
            this.Controls.Add(this.btAceptar);
            this.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HolaAula";
            this.Text = "Hola gente del Aula - PRIMER PROGRAMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label textMateria;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.TextBox TxbMensaje;
        private System.Windows.Forms.Button btnSalir;
    }
}