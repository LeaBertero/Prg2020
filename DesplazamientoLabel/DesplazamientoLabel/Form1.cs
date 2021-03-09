using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesplazamientoLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnReady_Click(object sender, EventArgs e)
        {
            int AnchoFormulario;
            int AnchoLabel;
            int AnchoBorde;
            int X;
            int Paso;
            int Repeticion = 0;
            int TotalRepeticion =2;

            do
            {
              AnchoFormulario = this.Width;
              AnchoLabel = this.LblMov.Width;
              AnchoBorde = 0;
              X = 0;
              Paso = 1;
              Repeticion = Repeticion + 1;

                

                while (X < AnchoFormulario - AnchoBorde - AnchoLabel)
                {
                    LblMov.Left = X;
                    this.Refresh();
                    X = X + Paso;
                }
            } while (Repeticion < TotalRepeticion);
            







        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
