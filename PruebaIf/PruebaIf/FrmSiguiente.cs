﻿using System;
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
            var pepe2 = new FrmSiguiente();
            pepe2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pepe = new FrmArranque();
            pepe.Show();
        }
    }
}