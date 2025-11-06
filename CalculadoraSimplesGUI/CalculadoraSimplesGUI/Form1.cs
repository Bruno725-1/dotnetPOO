using System;
using System.Windows.Forms;

namespace CalculadoraSimplesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            try

            {
                double x = double.Parse(txtX.Text);
                double y = double.Parse(txtY.Text);
                double resultado = x + y;
                txtResultado.Text = resultado.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Por favor, digite números válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtX.Text);
                double y = double.Parse(txtY.Text);
                double resultado = x - y;
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, digite números válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtX.Text);
                double y = double.Parse(txtY.Text);
                double resultado = x * y;
                txtResultado.Text = resultado.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Por favor, digite números válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtX.Text);
                double y = double.Parse(txtY.Text);
                if (y == 0)
                {
                    MessageBox.Show("Não é possível dividir por zero!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                double resultado = x / y;
                txtResultado.Text = resultado.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Por favor, digite números válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
            txtResultado.Clear();
            txtX.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
