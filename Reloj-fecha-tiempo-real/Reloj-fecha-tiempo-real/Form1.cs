using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reloj_fecha_tiempo_real
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("H:mm:ss");
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
