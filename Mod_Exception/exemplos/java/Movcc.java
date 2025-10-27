public class Movcc
{
    public static void main(String[] args)
	{
	   Conta contaJoao = new Conta(1, 1000);
	   contaJoao.saldo();
		
	   contaJoao.debita(500);
	   
	   // Faz debito na conta do Joao
	   
	   try
	   {
	      contaJoao.debita(500);
	      contaJoao.saldo();
	      contaJoao.debita(1000);
		  
	   }
	   catch(SaldoInvalidoException e)
	   {
	      System.out.println(e.getMessage());
	   }
	   contaJoao.saldo();
	}
  
}