using System;
class Carro
{
    private string chassi;
    private double consumo;
    private double qtdCombustivel;
    private double quilometragem;
    public Carro(double consumo)
    {
        this.consumo = consumo;
    }

    public Carro(double consumo, string chassi) : this(consumo)
    {
        this.chassi = chassi;
    }

    public string Chassi => chassi;
    public double Combustivel => qtdCombustivel;
    public double Consumo => consumo;
    public double Quilometragem => quilometragem;

    public void Abastecer(double combustivel)
    {
        if (combustivel < 0)
        {
            Console.WriteLine("A quantidade de combustível não pode ser negativa");
            return;
        }
        qtdCombustivel = combustivel;
    }

    public void Andar(double distancia)
    {
        double maxDist = qtdCombustivel * consumo;
        if (distancia > maxDist)
        {
            quilometragem += maxDist; // permite o carro andar o máximo possível
            qtdCombustivel = 0;
            Console.WriteLine("Combustível insuficiente para percorrer toda a distância");
        }
        else
        {
            quilometragem += distancia;
            double combGasto = distancia / consumo;
            double combTotal = qtdCombustivel - combGasto;
            qtdCombustivel = combTotal;
        }
    }

    public void ImprimirDadosVeiculo()
    {
        Console.WriteLine($"Número do chassi: {chassi}");
        Console.WriteLine($"Consumo de combustível: {consumo} KM / L");
        Console.WriteLine($"Quantidade de combustível no tanque: {qtdCombustivel}");
        Console.WriteLine($"{quilometragem} KM rodados");
    }

    public override string ToString()
    {
        return $"{chassi} {consumo} {qtdCombustivel} {quilometragem}";
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }
}
