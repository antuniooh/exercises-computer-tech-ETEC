package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio14 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		String a= JOptionPane.showInputDialog("Digite um valor");
		
		 String milhar = a.substring(0,1);
		 String centena = a.substring(1,2);
		 
		 String numero = milhar + centena;
		 int N = Integer.parseInt(numero);
		    
		 if(N%4 ==0)
		{		
			 System.out.println("O numero é multiplo de quatro");
	    }
		    else
		    {
		    	System.out.println( "O numero não é multiplo de quatro");
		    }
	}

}
