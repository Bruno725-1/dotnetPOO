using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoHeranca
{
    internal class Circulo:Figura
    {
        private double raio;

        public Circulo(int codigo, string descricao, double raio): base(codigo, descricao)
        {
            this.raio = raio;
        }

        public double Raio
        {
            get => raio;
            set => raio = value;
        }
        public override double calcularArea()
        {
            return (double.Pi* Math.Pow(raio, 2));
        }
        public override void imprimirDados()
        {
            base.imprimirDados();
            Console.Write("\nRaio: " + raio);
        }
    }
}
