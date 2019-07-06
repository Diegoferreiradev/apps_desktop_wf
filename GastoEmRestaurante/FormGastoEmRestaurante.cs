using System;
using System.Windows.Forms;

namespace GastoEmRestaurante
{
    public partial class FormGastoEmRestaurante : Form
    {
        public FormGastoEmRestaurante()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (Convert.ToDouble(txtDespesa.Text) * 1.10).ToString("N");
        }

    }
}
