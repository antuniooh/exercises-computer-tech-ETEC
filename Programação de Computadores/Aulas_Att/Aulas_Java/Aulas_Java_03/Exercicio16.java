package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio16 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double a= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double b= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));

	    if(a == b)
	    {		
	    	System.out.println( "Os numeros são iguais");
	    }
	    else
	    {
	    	System.out.println( "Os numeros sao diferentes");
	    }
	}

}
