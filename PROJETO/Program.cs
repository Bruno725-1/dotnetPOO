using System;

class Program
{
    public static void Main(string[] args)
    {
        Ponto p1 = new Ponto();
        Ponto p3 = new Ponto(25, 15, "Ponto p3");
        p3.ImprimirCoordenadas();
        double variavel = p3.GetX();
        p3.SetX(45);
        p3.SetY(55);
        p3.SetDescricao("Esta é a nova descrição deste ponto");
        p3.ImprimirCoordenadas();
        Console.WriteLine(variavel);
    }
}
