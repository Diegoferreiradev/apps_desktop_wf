using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MatriculaDoAluno
{
    public partial class MatriculaDeAluno : Form
    {
        public MatriculaDeAluno()
        {
            InitializeComponent();
        }

        private void txtAniversario_TextChanged(object sender, EventArgs e)
        {
            if (txtNascimento.Text.Trim().Length < 4) {
                MessageBox.Show("É preciso informar o Ano de Nascimento com 4 Digitos", "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtNascimento.Focus();
            }

        }

        private void txtAniversario_Validating(object sender, CancelEventArgs e)
        {
            if (txtAniversario.Text != string.Empty && 
                Convert.ToInt32(txtAniversario.Text) <= 
                Convert.ToInt32(txtNascimento.Text)) {
                MessageBox.Show("O Ano do último Aniversário deve ser superior ao do Ano de Nascimento.", 
                    "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void btnIdentificarCategoria_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty ||
                txtNascimento.Text == string.Empty ||
                txtAniversario.Text == string.Empty)
            {
                MessageBox.Show("Todos os dados solicitados devem ser informados.", "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                int idade = Convert.ToInt32(txtAniversario.Text) -
                            Convert.ToInt32(txtNascimento.Text);
                if (idade > 17)
                {
                    lblCategoria.Text = "Adulto";
                }
                else if (idade > 13)
                {
                    lblCategoria.Text = "Juvenil B";
                }
                else if (idade > 10)
                {
                    lblCategoria.Text = "Juvenil A";
                }
                else if (idade > 7)
                {
                    lblCategoria.Text = "Infantil B";
                }
                else if (idade > 5)
                {
                    lblCategoria.Text = "Infantil A";
                }
                else
                {
                    lblCategoria.Text = "Essa Categoria Não Existe!";
                }

            }
        }

    }
}
