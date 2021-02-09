using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploConversion
{
    public partial class FrmConvert : Form
    {
        public FrmConvert()
        {
            InitializeComponent();
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            decimal Oper1 = System.Convert.ToDecimal (TxtOper1.Text);
            decimal Oper2 = System.Convert.ToDecimal (TxtOper2.Text);
            LblRes.Text = TxtOper1.Text + TxtOper2.Text;

            decimal res = Oper1 + Oper2;

            LblRes.Text = System.Convert.ToString(res);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtOper2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmConvert_Load(object sender, EventArgs e)
        {

        }

        private void TxtOper1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblSuma_Click(object sender, EventArgs e)
        {

        }
    }
}
