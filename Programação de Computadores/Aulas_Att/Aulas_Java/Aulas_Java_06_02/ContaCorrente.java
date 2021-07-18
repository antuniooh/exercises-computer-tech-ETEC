package Aulas_Java_06_02;

public class ContaCorrente {
	    
	    //atributos
		private int numero;
		private int digito;
		private double saldo;
		private Agencia agencia;
		
		//construtor
		public ContaCorrente(int numero, int digito, double saldo, Agencia agencia) {
		this.numero = numero;
		this.digito = digito;
		this.saldo= saldo;
		this.agencia = agencia;
		}
		
		//métodos de acesso
		public int getNumero() {
		return numero;
		}
		public int getDigito() {
			return digito;
			}
		public double getSaldo() {
			return saldo;
		}
		public Agencia getAgencia() {
			return agencia;
		}
		//métodos modificadores
		public void setNumero(int numero) {
		this.numero = numero;
		}
		public void setDigito(int digito) {
		this.digito = digito;
		}
		public void setSaldo(double saldo) {
			this.saldo = saldo;
		}
		public void setAgencia(Agencia agencia) {
			this.agencia = agencia;
		}
		
		public void depositar(double valorDeposito) {
			saldo = getSaldo() + valorDeposito;
			  System.out.println("Depósito feito com Sucesso " +"R$ "+ getSaldo());
		}
		public void sacar(double valorSaque) {
		     if(saldo == valorSaque || saldo > valorSaque)
		        {
			     saldo = getSaldo() - valorSaque;
			     System.out.println("Saque feito com Sucesso " +"R$ "+ valorSaque);
		        }
			    
		     else {
		     System.out.println("Saque não efetuado, conta não pode ficar negativa");
	         valorSaque =0;
		}
		}
		public void consultarSaldo() {
			System.out.println("Saldo R$" + getSaldo());
		}
		public void ImprimirSaldo() {
		System.out.println("Número conta corrente: " + numero + "\n Digito: " + digito +
				"\n Numero da conta com digito" + numero + digito + "\n Saldo: "+ getSaldo());
		{
			
		}
		if(numero > 0 && Integer.toString(numero).length() == 4) {
			
			String um= Integer.toString(numero).substring(0,1);
			String dois= Integer.toString(numero).substring(1,2);
			String tres= Integer.toString(numero).substring(2,3);
			String quatro= Integer.toString(numero).substring(3,4);
			
			int UM =Integer.parseInt(um);
			int DOIS =Integer.parseInt(dois);
			int TRES =Integer.parseInt(tres);
			int QUATRO =Integer.parseInt(quatro);
			
			digito =((UM * 4)+(DOIS * 6)+(TRES * 8) + (QUATRO * 2) )% 11;
			
			if(digito == 10) { digito = 0;}
		}
		else
		{
			numero = 0;
		}
		}
}