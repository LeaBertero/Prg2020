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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int Nota = System.Convert.ToInt32(TxtNota.Text);

            switch (Nota)

            {
                case 1:
                    LblRes.Text = "APLAZADO";
                    break;

                case 2:
                    LblRes.Text = "APLAZADO";
                    break;

                case 3:
                    LblRes.Text = "APROBADO";
                    break;

                case 4:
                    LblRes.Text = "PROMOCIONADO";
                    break;

                case 5:
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
    }
}
