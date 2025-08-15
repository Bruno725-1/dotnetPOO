using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 0, soma = 0, contador = 0, menor = 100000000, maior = 0;
        double media = 0;
        do
        {
            Console.WriteLine("Digite um número positivo. Para finalizar, digite um número negativo");
            num = int.Parse(Console.ReadLine());
            if (num >= 0)
                soma = NivelamentoHelper.Somar(soma, num);
            if (NivelamentoHelper.Maior(num, maior))
                maior = num;
            if (NivelamentoHelper.Menor(num, menor))
                menor = num;
            contador = NivelamentoHelper.Contador(num, contador);
        }
        while (num >= 0);
        if (contador == 0 && num < 0)
        {
            Console.WriteLine("Não é possível calcular a média. Insira pelo menos um número positivo");
            return;
        }
        media = NivelamentoHelper.Media(soma, contador);
        Console.WriteLine($"Contador de valores válidos: {contador}");
        Console.WriteLine($"Soma dos números inseridos: {soma}");
        Console.WriteLine($"Média dos números inseridos: {media}");
        Console.WriteLine($"Menor valor válido informado: {menor}");
        Console.WriteLine($"Maior valor válido informado: {maior}");
    }
}
