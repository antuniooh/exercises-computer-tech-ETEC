package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio12 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double a= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));	
		
		if(a%10 == 0 && a%5 == 0 && a%2 ==0)
		{
			 System.out.println("o numero é divisivel por 10, 5 e 2");
		}
		if(a%10 == 0)
		{
		 System.out.println("o numero é divisivel por 10");
		}
		if(a%5 == 0)
		{
		 System.out.println("o numero é divisivel por 5");
		}
		if(a%2 == 0)
		{
		 System.out.println("o numero é divisivel por 2");
		}
		if(a%10 >0 && a%5 > 0 && a%2 > 0)
		{
			System.out.println("o numero não é divisivel por 10, 5 e 2");
		}
	}

}
