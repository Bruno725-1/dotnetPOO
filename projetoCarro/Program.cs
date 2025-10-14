using System;
class Program
{
    public static void Main(string[] args)
    {
        Carro meuCarroTurbo = new Carro(5, "abc12234578910112");
        meuCarroTurbo.Abastecer(150);
        meuCarroTurbo.Andar(700);
        meuCarroTurbo.ImprimirDadosVeiculo();
        Carro palhoWeekend = new Carro(13, "abc12345678910112");
        palhoWeekend.Abastecer(35);
        palhoWeekend.Andar(400);
        palhoWeekend.ImprimirDadosVeiculo();
        Console.WriteLine($"Os carros são iguais? {meuCarroTurbo.Equals(palhoWeekend)}");
    }
}