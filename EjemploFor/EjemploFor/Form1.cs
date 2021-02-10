using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploFor
{
    public partial class FrmContador : Form
    {
        public FrmContador()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnContar_Click(object sender, EventArgs e)
        {

            for (int i = System.Convert.ToInt32(TxbDesde.Text); //DESDE
                i <= + System.Convert.ToInt32(TxbHasta.Text); //HASTA
                i = i + System.Convert.ToInt32(TxbPaso.Text) ) //PASO
            {
                LblRes.Text = i.ToString(); //RESULTADO
                this.Refresh();
            }
        }

        private void TxbDesde_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxbPaso_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmContador_Load(object sender, EventArgs e)
        {

        }
    }
}
