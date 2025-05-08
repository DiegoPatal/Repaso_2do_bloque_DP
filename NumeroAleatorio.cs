using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_2do_bloque_DP
{
    public partial class NumeroAleatorio : Form
    {
        public NumeroAleatorio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParase(textBox1.Text, out int numMax))
            {

            }
        }
    }
}
