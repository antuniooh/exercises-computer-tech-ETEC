package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio21 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double a= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double b= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double c= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));

	    if(a > b && a > c)
	    {		
	    	System.out.println("O maior numero � " + a);
	    }
	    else if( a == b && a == c)
	    {
	    	System.out.println("Os numeros s�o iguais");
	    }
	    else if(b > a && b > c)
	    {		
	    	System.out.println("O maior numero � " + b);
	    }
	    else
	    {
	    	System.out.println("O maior numero � " + c);
	    }
	}
}
