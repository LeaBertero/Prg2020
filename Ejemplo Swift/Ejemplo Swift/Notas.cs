using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Swift
{
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int Nota = System.Convert.ToInt32(TxtNota.Text);

            switch (Nota)

            {
                case 1:
                case 2:
                    LblRes.Text = "APLAZADO";
                    break;

                case 5:
                    LblRes.Text = "APROBADO";
                    break;

                case 4:
                    LblRes.Text = "REGULAR";
                    break;
                case 7:
                    LblRes.Text = "PROMOCIONADO";
                    break;
                   
                default: 
                    LblRes.Text = "Nota no valida";
                    break; 

            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtNota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
