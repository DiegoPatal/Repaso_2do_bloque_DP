using System;
using System.Windows.Forms;

namespace Repaso_2do_bloque_DP
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumeroAleatorio repaso1 = new NumeroAleatorio();
            repaso1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlumnoAleatorio repaso2 = new AlumnoAleatorio();
            repaso2.Show();
        }
    }
}
