using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_IF_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            
            
            {
                int Edad = System.Convert.ToInt32(TxtEdad.Text);

                if (Edad < 12)
                {
                    LblRes.Text = "NIÑO";
                }
                else if (Edad >= 12 && Edad < 18)
                {
                    LblRes.Text = "ADOLESCENTE";
                }
                else if (Edad >= 18 && Edad < 60)
                {
                    LblRes.Text = "ADULTO";

                }
                else

                {
                    LblRes.Text = "ADULTO MAYOR";
                }
                
            }
        }

        private void TxtEdad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
