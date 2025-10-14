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
        if (chassi.Length != 17)
            throw new ArgumentException("O número do chassi deve conter 17 caracteres");
    
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
            double combRestante = qtdCombustivel - combGasto;
            qtdCombustivel = combRestante;
        }
    }

    public void ImprimirDadosVeiculo()
    {
        Console.WriteLine($"Número do chassi: {chassi}");
        Console.WriteLine($"Consumo de combustível: {consumo} KM / L");
        Console.WriteLine($"Quantidade de combustível no tanque: {qtdCombustivel:F2} litros");
        Console.WriteLine($"{quilometragem} KM rodados");
    }

    public override string ToString()
    {
        return $"{chassi} {consumo} {qtdCombustivel:F2} {quilometragem}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Carro outro)
            return this.chassi == outro.chassi;

        return false;
    }

    public override int GetHashCode()
    {
        return chassi.GetHashCode();
    }
}
