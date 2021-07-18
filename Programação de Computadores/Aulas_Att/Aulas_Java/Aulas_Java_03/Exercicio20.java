package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio20 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double a= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double b= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));

	    if(a > b)
	    {		
	    	System.out.println("O quadrado do menor numero " + Math.pow(b, 2));
	    	System.out.println("A raiz Quadrada do maior numero " + Math.sqrt(a));
	    }
	    else if( a == b)
	    {
	    	System.out.println("Os numeros são iguais");
	    }
	    else
	    {
	    	System.out.println("O quadrado do menor numero " + Math.pow(a, 2));
	    	System.out.println("A raiz Quadrada do maior numero " + Math.sqrt(b));
	    }
	}
}
