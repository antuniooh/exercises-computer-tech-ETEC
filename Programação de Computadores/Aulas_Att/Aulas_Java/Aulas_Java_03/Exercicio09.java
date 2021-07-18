package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio09 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double a= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));	
		
		if(a%3 == 0)
		{
			 System.out.println("o numero é multiplo de 3");
		}
		else
		{
			System.out.println("o numero não é multiplo de 3");
		}
		
	}

}
