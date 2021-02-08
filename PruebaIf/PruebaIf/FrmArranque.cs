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
    public partial class FrmArranque : Form
    {
        public FrmArranque()
        {
            InitializeComponent();
        }

        private void FrmArranque_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pepe = new FrmArranque();
            pepe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pepe2 = new FrmSiguiente();
            pepe2.Show();
        }
    }
}
