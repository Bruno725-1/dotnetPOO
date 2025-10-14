using System;
class Program
{
    public static void Main(string[] args)
    {
        Carro carro = new Carro(13);
        carro.Abastecer(4);
        carro.Andar(15);
        carro.Abastecer(5);
        carro.Andar(15);
        carro.Abastecer(10);
        carro.Andar(15);
        carro.Abastecer(20);
        carro.Andar(15);
        carro.Abastecer(5.5);
        carro.Andar(15);
    }
}