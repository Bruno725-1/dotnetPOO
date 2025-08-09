/**
* PUC Minas, Campus Barreiro
* POO aula prática
* Data: 08/08/2025(Sexta-feira)
* @author [Bruno César Lima Araújo]
*Objetivo: Aul prática de nivelamento e revisão dos conteúdos aprendidos em ATP
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 0, soma = 0, contador = 0, menor = 100000000, maior = 0;
        double media = 0;
        do
        {
            Console.WriteLine("Digite um número positivo");
            num = int.Parse(Console.ReadLine());
            if(num >= 0)
                soma += num;
            if (num > maior)
                maior = num;
            if (num < menor && num >= 0)
                menor = num;
            contador++;
        }
        while (num >= 0);
        contador--; //como as instruções do loop são executadas antes da verificação, retrocedemos contador em 1 para corresponder ao número de valores válidos
        if (contador == 1 && num < 0)
        {
            Console.WriteLine("Não é possível calcular a média. Insira pelo menos um número positivo");
            return;
        }
        media = (double)soma / contador;
        Console.WriteLine($"Contador de valores válidos: {contador}");
        Console.WriteLine($"Soma dos números inseridos: {soma}");
        Console.WriteLine($"Média dos números inseridos: {media}");
        Console.WriteLine($"Menor valor válido informado: {menor}");
        Console.WriteLine($"Maior valor válido informado: {maior}");
    }
}
