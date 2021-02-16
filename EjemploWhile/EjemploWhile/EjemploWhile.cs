using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploWhile
{
    public partial class EjemploWhile : Form
    {
        public EjemploWhile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            
           int AnchoFormulario = this.Width;
            int AnchoLabel= Lbl.Width;

            for (int X = 0; X < AnchoFormulario - AnchoLabel; X++)
            {
                Lbl.Left = X;

            }



        }

        private void Lbl_Click(object sender, EventArgs e)
        {

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            int AnchoFormulario = this.Width;
            int AnchoLbl2 = this.Width;

             AnchoLbl2 = Lbl2.Width;

            for (int Y = 30; Y < AnchoFormulario - AnchoLbl2 ; Y++)
            {
                Lbl2.Left = Y;

            }
        }
    }
}
