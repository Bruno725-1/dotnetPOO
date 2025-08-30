public class FeiraMain
{
    public static void main(String args[])
	{
	   Citros umaLrnj = new Citros("Laranja", 50, 30, 500);
	   umaLrnj.imprimeFruta();

  	   Citros umLimao = new Citros("Limao");
	   umLimao.setAcidoCitrico(2000);
	   umLimao.imprimeFruta();


	  Fruta mamao = new Fruta("Mamao");
	  mamao = umLimao; // OK
	  mamao.imprimeFruta();
	  umaLrnj = mamao; // Oops!
	}

}