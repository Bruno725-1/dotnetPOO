/**
* PUC Minas, Campus Barreiro.
* POO Aula Prática 
* Data: 26/09/2025 (Sexta-feira)
* @author Bruno César Lima Araújo
* Objetivo: Início do RP6, o qual trata sobre herança de classes
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHeranca;

internal class Quadrado : Figura
{
    private double lado;

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