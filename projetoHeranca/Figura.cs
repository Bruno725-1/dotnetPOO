using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHeranca
{
    internal class Figura
    {
        protected int codigo;
        protected string descricao;
        protected Ponto ancora;

        public Figura()
        {
            this.ancora = new Ponto();
        }
        public Figura(int codigo, string descricao): this()
        {
            this.codigo = codigo;
            this.descricao = descricao;
        }
        public Figura(int codigo, string descricao, Ponto ancora): this(codigo, descricao)
        {
            this.ancora = ancora;
        }

        public int Codigo
        {
            get => codigo;
            set => codigo = value;
        }

        public Ponto Ancora
        {
            get => ancora;
            set => ancora = value;
        }

        public String Descricao
        {
            get => descricao;
            set => descricao = value;
        }

        public override string ToString()
        {
            return "Figura{" + "Código=" + codigo + ", descricao=" + descricao + '}';
        }
        public virtual double calcularArea()
        {
            return 0;
        }
        public virtual void imprimirDados()
        {
            Console.Write("\n\nCódigo: "+codigo+", \tdescrição: "+descricao);
        }
    }
}
