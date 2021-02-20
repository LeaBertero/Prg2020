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
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnComenzar_Click(object sender, EventArgs e)
        {
            int Anchoformulario = this.Width;
            int AnchoPicbigote = PicBigote.Width;
            int X = 050;
            int AnchoBorde = 30;

            for (int x = 0; x < Anchoformulario - AnchoBorde; x++)
            {
                PicBigote.Left = X;
            }

        }

        private void PicPantera_Click(object sender, EventArgs e)
        {

        }

        private void PicBigote_Click(object sender, EventArgs e)
        {

        }
    }
    }

