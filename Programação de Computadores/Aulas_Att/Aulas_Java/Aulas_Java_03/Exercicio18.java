package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio18 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double a= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double b= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));

	    if(a > b)
	    {		
	    	System.out.println("Em ordem Crescente: "+ b +","+ a);
	    }
	    else if( a == b)
	    {
	    	System.out.println("Os numeros são iguais");
	    }
	    else
	    {
	    	System.out.println("Em ordem Crescente: "+ a +","+ b);
	    }
	}
}
