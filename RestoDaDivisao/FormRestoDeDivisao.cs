using System;
using System.Windows.Forms;

namespace RestoDaDivisao
{
    public partial class FormRestoDeDivisao : Form
    {
        public FormRestoDeDivisao()
        {
            InitializeComponent();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            int dividendo = Convert.ToInt32(txtDividendo.Text);
            int divisor = Convert.ToInt32(txtDivisor.Text);
            int restoDivisao = dividendo % divisor;
            txtResto.Text = restoDivisao.ToString();
        }
    }
}
