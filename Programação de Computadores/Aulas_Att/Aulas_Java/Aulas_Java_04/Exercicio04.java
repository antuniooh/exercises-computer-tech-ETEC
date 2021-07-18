package Aulas_Java_04;

import javax.swing.JOptionPane;

public class Exercicio04 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		int x = 1;
		do {
			x = Integer.parseInt(
					JOptionPane.showInputDialog("Digite um numero "));
			if((x >= 100 && x <=200))
			{
				System.out.println(x + ", o numero está entre 200 e 100");
			}
			else
			{
				System.out.println(x + ", o numero não está entre 200 e 100: ");
			}			
		} while(x != 0);
	}
	
}
