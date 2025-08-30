using System;

public class Idade
{
   public static int Main(string[] args){
   
    string valorTexto = "530";

    // experimente com os valores "23.5", "arquivo" e
    // "659"

    // tenta efetuar a conversão de string para integer
    try{
      int valorInteiro = int.Parse(valorTexto);
      // exibe o resultado
      Console.WriteLine(valorInteiro);
    }
    catch(FormatException e){
      // exibe a informações sobre a exceção
      // Input string was not in a correct format. 
      Console.WriteLine(e.Message);
    }

    Console.WriteLine("Pressione uma tecla para sair...");
    Console.ReadKey();
   }
}