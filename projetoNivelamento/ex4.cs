using System;
using AED; //importa as estruturas de dados necessárias para o funcionamento do programa

class Ex4
{
    public static void Rodar()
    {
        //dicionário para armazenar os números digitados pelo usuário
        var sequencias = new CDicionario<int, CLista<int>>();
        int opcao;
        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1: Adicionar nova sequência de números");
            Console.WriteLine("2: Contar número de valores em uma sequência");
            Console.WriteLine("3: Calcular a soma de uma sequência");
            Console.WriteLine("4: Calcular a média dos valores");
            Console.WriteLine("5: Menor valor de uma sequência");
            Console.WriteLine("6: Maior valor de uma sequência");
            Console.WriteLine("7: Sair");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Ex4Helper.Adicionar(sequencias);
                    break;
                case 2:
                    Ex4Helper.Contar(sequencias);
                    break;
                case 3:
                    Ex4Helper.Somar(sequencias);
                    break;
                case 4:
                    Ex4Helper.CalcularMedia(sequencias);
                    break;
                case 5:
                    Ex4Helper.CalcularMenor(sequencias);
                    break;
                case 6:
                    Ex4Helper.CalcularMaior(sequencias);
                    break;
                case 7:
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Escolha uma das opções informadas acima.");
                    break;
            }
        }
        while (opcao != 7);
    }
}
