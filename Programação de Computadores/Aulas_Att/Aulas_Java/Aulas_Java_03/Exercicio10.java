package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio10 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

         double a= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));	
		
		if(a%5 == 0)
		{
			 System.out.println("o numero é divisivel por 5");
		}
		else
		{
			System.out.println("o numero não é divisivel por 5");
		}
		
	}

}
