public class TesteException {
  public static void main (String args[]) {
    int i = 0;

    String greetings [] = 
    {
      "Hello world!",
      "No, I mean it!",
      "HELLO WORLD!!"
    };

    while (i < 4) 
    {
      try {
      	
        System.out.println (greetings[i]);
      } 
      catch (ArrayIndexOutOfBoundsException e)
      {
        System.out.println("Posição inválida do array");
      } 
      finally // bloco opcional e sempre executado
      {
        System.out.println("Sempre executado!");
        i++;
      }
      
    }
  }
}
