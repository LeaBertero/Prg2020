using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaIf
{
    public partial class FrmSiguiente : Form
    {
        public FrmSiguiente()
        {
            InitializeComponent();
        }

        private void FrmSiguiente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pepe = new FrmArranque();
            pepe.ShowDialog();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            var formulario2 = new FrmSiguiente();
            formulario2.ShowDialog();
        }
    }
}
