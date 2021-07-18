package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio11 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		    double a= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));	
			
			if(a%3 == 0 && a%7 == 0)
			{
				 System.out.println("o numero é divisivel por 3 e 7");
			}
			else
			{
				System.out.println("o numero não é divisivel por 3 e 7");
			}
	}

}
