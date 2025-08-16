using System;
using AED;
class Ex4Helper
{
    public static void Adicionar(CDicionario<int, CLista<int>> sequencias)
    {
        CLista<int> lista = new CLista<int>();
        int num;
        do
        {
            Console.WriteLine("Digite um número positivo para adicioná-lo à sequência ou um negativo para finalizar");
            num = int.Parse(Console.ReadLine());
            if (num >= 0)
                lista.InsereFim(num);
        }
        while (num >= 0);
        sequencias.Adiciona(sequencias.Quantidade() + 1, lista); //a chave correspondente a cada sequência será sempre a quantidade de itens já adicionados + 1
    }

    public static void Contar(CDicionario<int, CLista<int>> sequencias)
    {
        Console.WriteLine("Informe a chave da sequência a consultar (1 para a primeira sequência adicionada, 2 segunda, 3 terceira, etc)");
        int chave = int.Parse(Console.ReadLine());
        if (!sequencias.ContemChave(chave))
        {
            Console.WriteLine("A sequência informada não foi encontrada.");
            return;
        }
        CLista<int> aux = sequencias.RetornaValor(chave);
        Console.WriteLine($"Esta sequência possui {aux.Quantidade()} números.");
    }

    public static void Somar(CDicionario<int, CLista<int>> sequencias)
    {
        Console.WriteLine("Informe a chave da sequência a somar (1 para a primeira sequência adicionada, 2 segunda, 3 terceira, etc)");
        int chave = int.Parse(Console.ReadLine());
        if (!sequencias.ContemChave(chave))
        {
            Console.WriteLine("A sequência informada não foi encontrada.");
            return;
        }
        CLista<int> aux = sequencias.RetornaValor(chave);
        int soma = 0;
        for (int i = 1; i <= aux.Quantidade(); i++)
            soma += aux.RetornaIndice(i);
        Console.WriteLine($"Soma dos valores da sequência {chave}: {soma}");
    }

    public static void CalcularMedia(CDicionario<int, CLista<int>> sequencias)
    {
        Console.WriteLine("Informe a chave da sequência a consultar (1 para a primeira sequência adicionada, 2 segunda, 3 terceira, etc)");
        int chave = int.Parse(Console.ReadLine());
        if (!sequencias.ContemChave(chave))
        {
            Console.WriteLine("A sequência informada não foi encontrada.");
            return;
        }
        CLista<int> aux = sequencias.RetornaValor(chave);
        int soma = 0;
        for (int i = 1; i <= aux.Quantidade(); i++)
            soma += aux.RetornaIndice(i);
        double media = (double)soma / aux.Quantidade();
        Console.WriteLine($"Média dos valores desta sequência: {media:F2}");
    }

    public static void CalcularMenor(CDicionario<int, CLista<int>> sequencias)
    {
        Console.WriteLine("Informe a chave da sequência a consultar (1 para a primeira sequência adicionada, 2 segunda, 3 terceira, etc)");
        int chave = int.Parse(Console.ReadLine());
        if (!sequencias.ContemChave(chave))
        {
            Console.WriteLine("A sequência informada não foi encontrada.");
            return;
        }
        CLista<int> aux = sequencias.RetornaValor(chave);
        int menor = 100000000;
        for (int i = 1; i <= aux.Quantidade(); i++)
        {
            int index = aux.RetornaIndice(i);
            if (index < menor)
                menor = index;
        }
        Console.WriteLine("Menor valor da sequência: " + menor);
    }

    public static void CalcularMaior(CDicionario<int, CLista<int>> sequencias)
    {
        Console.WriteLine("Informe a chave da sequência a consultar (1 para a primeira sequência adicionada, 2 segunda, 3 terceira, etc)");
        int chave = int.Parse(Console.ReadLine());
        if (!sequencias.ContemChave(chave))
        {
            Console.WriteLine("A sequência informada não foi encontrada.");
            return;
        }
        CLista<int> aux = sequencias.RetornaValor(chave);
        int maior = 0;
        for (int i = 1; i <= aux.Quantidade(); i++)
        {
            int index = aux.RetornaIndice(i); //guarda o valor do índice numa variável, para evitar a necessidade de chamar o método duas vezes
            if (index > maior)
                maior = index;
        }
        Console.WriteLine("Maior valor da sequência: " + maior);
    }
}