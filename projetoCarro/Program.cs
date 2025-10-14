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
        Console.WriteLine("Teste do ToString:");
        Console.WriteLine(meuCarroTurbo);
        Console.WriteLine(palhoWeekend);
        Console.WriteLine($"Qual o número do chassi do meu carro turbo? {meuCarroTurbo.Chassi}");
        Console.WriteLine($"Quanto ainda tem de combustível no tanque dele? {meuCarroTurbo.Combustivel}");
        Console.WriteLine($"Quantos quilômetros o Palho Weekend faz por litro? {palhoWeekend.Consumo}");
        Console.WriteLine($"Esse palho tem quantos quilômetros rodados? {palhoWeekend.Quilometragem}");
    }
}