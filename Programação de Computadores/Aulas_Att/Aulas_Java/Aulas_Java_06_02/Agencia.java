package Aulas_Java_06_02;

public class Agencia {
	        //atributos
			private String nome;
			private int numero;
			private int digito;
			
			//construtor
			public Agencia(String nome, int digito,int numero) {
			this.nome = nome;
			this.numero = numero;
			this.digito = digito;
			}
			
			//métodos de acesso
			public int getNumero() {
				return numero;
			}
			public String getNome() {
			return nome;
			}
			public int getDigito() {
				return digito;
				}
			//métodos modificadores
			public void setNumero(int numero) {
				this.numero = numero;
			}
			public void setNome(String nome) {
			this.nome = nome;;
			}
			public void setDigito(int digito) {
			this.digito = digito;
			}
			
			{
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
