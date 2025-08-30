public class Construtor
{
   int tamInicial = 10;
   int tamFinal = 20;
   String texto = "Texto inicial";

   public Construtor(String t)
   {
      this.texto = t;
   }

   public Construtor(int i, int f)
   {
      this.tamInicial = i;
      this.tamFinal = f;
   }

   public Construtor(int i, int f, String t)
   {
      this(i, f);
      this.texto = t;
   }


    // Método main
   public static void main(String[] args)
   {

      Construtor c = new Construtor("Novo texto");
      Construtor c = new Construtor(); //vai dar erro de compilacao

      c.imprime();
   }

   public void imprime()
   {
      System.out.println(texto);
   }
}

