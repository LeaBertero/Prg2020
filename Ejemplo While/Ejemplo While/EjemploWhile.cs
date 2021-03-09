using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_While
{
    public partial class EjemploWhile : Form
    {
        public EjemploWhile()
        {
            InitializeComponent();
        }

        private void EjemploWhile_Load(object sender, EventArgs e)
        {

        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            int AnchoFormulario;
            int AnchoLbl;
            int AnchoBorde;
            int X;
            int paso;

            do
            while (true)
            {

            }    
                
           

            AnchoFormulario = this.Width;
            AnchoLbl = Lbldes.Width;
            AnchoBorde = 20;
            X = 0;
            paso = 1;

            //Instrucción PARA

            // for (int X = 0; X < AnchoFormulario-AnchoLbl-AnchoBorde; X++)
            // {
            //     Lbldes.Left = X;
            // }

            //Instrucción SEGÚN
            while (X < AnchoFormulario - AnchoBorde - AnchoLbl)
            {
                Lbldes.Left = X; //se mueve de izquierda a derecha
                //Lbldes.Top = X; //se mueve hacia arriba
                this.Refresh();
                X = X + paso;
            }
        }

        
        }
    }

