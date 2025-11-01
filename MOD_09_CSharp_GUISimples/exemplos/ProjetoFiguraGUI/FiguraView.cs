using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controller;
using model;

namespace view
{
    public partial class FiguraView : Form
    {
        private ConjuntoHelper conjuntoHelper;

        public FiguraView()
        {
            InitializeComponent();
            conjuntoHelper = ConjuntoHelper.getInstance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FiguraVO figuraVO = null;
            int codigo = 0;
            string descricao;

            try
            {
                codigo = int.Parse(txtCodigo.Text);

            }
            catch (Exception e2)
            {
                MessageBox.Show("Código inválido!");
                return;
            }
            try
            {
                descricao = txtDescricao.Text;

            }
            catch (Exception e2)
            {
                MessageBox.Show("Descrição inválida!");
                return;
            }

            figuraVO = new FiguraVO(codigo, descricao);

            if (conjuntoHelper.adicionar(figuraVO) > 0)
            {
                MessageBox.Show("Objeto inserido com sucesso!");                
            }
            else
            {
                MessageBox.Show("Objeto não inserido!");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            FiguraVO figuraVO = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConjuntoHelper conjuntoHelper = ConjuntoHelper.getInstance();
            FiguraVO figuraVO = null;

            //retanguloVO = conjuntoHelper.pesquisar();

        }
    }
}
