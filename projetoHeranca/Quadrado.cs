using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHeranca;

internal class Quadrado : Figura
{
    private double lado;

    public Quadrado() { }

    public Quadrado(double lado)
    {
        this.lado = lado;
    }

    public override double calcularArea()
    {
        return lado * lado;
    }

    public override void imprimirDados()
    {
        base.imprimirDados();
        Console.Write("\nLado: " + lado + "\nÁrea: " + lado * lado);
    }
}
/*Ao removermos a palavra virtual da assinatura do método CalcularArea da classe Figura, o compilador deixa de aceitar substituições/sobrescritas para este método.*/
/* O que acontece se removermos o construtor vazio da classe Figura?
O construtor vazio é responsável por inicializar o atributo âncora de qualquer figura. Uma vez que ele não existe mais, e que os construtores dessa classe funcionam com encadeamento (antes de executar as instruções de seu próprio corpo, um construtor sempre chama um com menos parâmetros do que ele), o atributo âncora nunca será inicializado e sempre terá o valor nulo, além de retornar erro de compilação no caso da implementação de outros construtores vazios em outras classes que herdem de Figura.
*/