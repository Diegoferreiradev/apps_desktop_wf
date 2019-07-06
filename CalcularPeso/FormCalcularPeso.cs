using System;
using System.Windows.Forms;

namespace CalcularPeso
{
    public partial class FormCalcularPeso : Form
    {
        RadioButton rbnSelecionado = null;

        public FormCalcularPeso()
        {
            InitializeComponent();
        }

        private void rbnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;

            if (rbn.Checked)
            {
                rbnSelecionado = rbn;
                SetPesoIdeal();
            }
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            SetPesoIdeal();
        }

        private void SetPesoIdeal()
        {
            try
            {
                double altura = Convert.ToDouble(txtAltura.Text);
                double pesoIdeal;
                if (rbnSelecionado.Text.Equals("Masculino"))
                    pesoIdeal = (72.7 * altura) - 58;
                else
                    pesoIdeal = (62.1 * altura) - 44.7;
                lblPesoIdeal.Text = pesoIdeal.ToString("N");
            }
            catch (Exception e)
            {
                MessageBox.Show("Selecione o Sexo e informe a Altura corretamente", "Atenção!", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


    }
}
