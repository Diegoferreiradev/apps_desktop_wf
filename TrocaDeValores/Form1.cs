using System;
using System.Windows.Forms;

namespace TrocaDeValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            string auxiliar;
            auxiliar = txtValor1.Text;
            txtValor1.Text = txtValor2.Text;
            txtValor2.Text = auxiliar;

            MessageBox.Show("Troca de valores concluída", "Informação",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
