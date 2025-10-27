using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoTesteException;

internal class CirculoVO : FiguraVO
{
    private double raio;

    public CirculoVO(int codigo, string descricao, double raio) : base(codigo, descricao)
    {
        this.raio = raio;
    }

    public void setRaio(double raio)
    {
        this.raio = raio;
    }
    public double getRaio()
    {
        return raio;
    }
    public override double CalcularArea()
    {
        return (double.Pi * Math.Pow(raio, 2));
    }
    public override void ImprimirDados()
    {
        base.ImprimirDados();
        Console.Write("\nRaio: " + raio);
        Console.WriteLine("\nID da figura: " + idFigura);
    }
}
