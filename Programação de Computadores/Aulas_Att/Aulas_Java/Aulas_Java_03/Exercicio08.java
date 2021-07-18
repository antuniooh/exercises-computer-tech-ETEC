package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio08 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double a= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double b= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double maior = 0;
		
		
		if(a > b)
		{
			 maior = (a);
		}
		else
		{
			 maior = (b);
		}
		
		 System.out.println("o maior numero é: " + maior);
		
	}

}
