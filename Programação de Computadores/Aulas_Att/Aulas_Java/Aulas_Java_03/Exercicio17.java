package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio17 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double a= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double b= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));

	    if(a == b)
	    {		
	    	System.out.println("Os numeros s�o iguais");
	    }
	    if(a < b)
	    {
	    	System.out.println("o Menor numero � "+ a);
	    }
	    else
	    {
	    	System.out.println( "o Menor numero � "+ b);
	    }
	}

}
