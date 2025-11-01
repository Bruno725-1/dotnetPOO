using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using view;

namespace ProjetoFiguraGUI
{
    public partial class ProjetoPrincipalMainView : Form
    {
        private FiguraView retanguloView;
        private RelatorioFiguraView figuraView;
        

        public ProjetoPrincipalMainView()
        {
            InitializeComponent();
        }

        private void manutençãoDeFigurasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (retanguloView == null)
            {
                retanguloView = new FiguraView();
            }
            retanguloView.ShowDialog();
        }

        private void todasAsFigurasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (figuraView == null)
            {
                figuraView = new RelatorioFiguraView();
            }
            figuraView.ShowDialog();
        }
    }
}
