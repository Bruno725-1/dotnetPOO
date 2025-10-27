
public class Conta
{
   int numero;
   double saldo;
   String titular;

   // Contrutor
   public Conta(int numero, double saldo)
   {
      this.numero = numero;
	  this.saldo = saldo;
   
   }
    // Faz débito em conta
   public void debita(double valor) throws SaldoInvalidoException
   {
      System.out.println("Debito em conta");
      if (saldo > valor)
      {
          System.out.println("Saldo anterior = " + saldo);

          saldo = (saldo - valor);

          System.out.println("Saldo atual    = " + saldo);
          System.out.println("Valor do debito= " + valor);
          System.out.println("Debito confirmado! ");
      }
      else
      {
         throw new SaldoInvalidoException("Saldo inválido");
      }
   }
    // Imprime o saldo da conta
   public void saldo()
   {
      System.out.println("Conta: " + numero + " Saldo = " + saldo);
   }
}
