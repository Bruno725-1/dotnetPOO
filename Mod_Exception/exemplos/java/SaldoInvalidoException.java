public class SaldoInvalidoException extends Exception
{
   private String razao;
   
   public SaldoInvalidoException(String causa)
   {
      razao = causa;
   }
   public String getMessage()
   {
       return razao;
   }
}
