using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Mientras_y_Repetir_Hasta_V1
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void BtnEmpezar_Click(object sender, EventArgs e)
        {
            int AnchoFormulario = this.Width;
            int AnchoLblMov = this.Width;
            

            for (int X = 0; X < AnchoFormulario-65; X++)
            {
                LblMov.Left = X;   
            }
        }

        private void BtnFin_Click(object sender, EventArgs e)
        {
            int AnchoForm = this.Width;
            int TravelRight = this.Width;

            for (int Y = +80; Y < AnchoForm -60; Y++) 
            {
                LblDe.Left = Y;
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
