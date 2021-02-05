using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class FrmPrueba : Form
    {
        string PrimerVariable = "Leandro";

        public FrmPrueba()
        {
            string SegundaVariable = "¿Que Tal?";
            InitializeComponent();
            Label1.Text = " Hola  " + PrimerVariable + SegundaVariable;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
