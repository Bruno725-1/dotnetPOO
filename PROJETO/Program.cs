using System;

class Program
{
    public static void Main(string[] args)
    {
        int opcao;
        do
        {
            Console.WriteLine("Menu de opções");
            Console.WriteLine("Perímetro do círculo: 1");
            Console.WriteLine(); Console.WriteLine("Perímetro do retângulo: 2");
            Console.WriteLine("Perímetro do triângulo: 3");
            Console.WriteLine("Sair: 4");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Informe o raio da circunferência: ");
                    double r = double.Parse(Console.ReadLine());
                    double perimetroCirculo = FiguraHelper.CalcularPerimetro(r);
                    Console.WriteLine($"Perímetro da circunferência: {perimetroCirculo:F2}");
                    break;

                case 2:
                    Console.WriteLine("Informe a base");
                    double comprimento = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a altura");
                    double altura = double.Parse(Console.ReadLine());
                    double perimetroRetangulo = FiguraHelper.CalcularPerimetro(comprimento, altura);
                    Console.WriteLine($"Perímetro do retângulo: {perimetroRetangulo:F2}");
                    break;

                case 3:
                    Console.WriteLine("Informe os lados do triângulo. Separe os valores por espaços");
                    string[] linha = Console.ReadLine().Split(' ');
                    double l1 = double.Parse(linha[0]);
                    double l2 = double.Parse(linha[1]);
                    double l3 = double.Parse(linha[2]);
                    double perimetroTriangulo = FiguraHelper.CalcularPerimetro(l1, l2, l3);
                    Console.WriteLine($"Perímetro do triângulo: {perimetroTriangulo:F2}");
                    break;

                case 4:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Digite uma das opções informadas no menu");
                    break;
            }
        }
        while (opcao != 4);
    }
}
