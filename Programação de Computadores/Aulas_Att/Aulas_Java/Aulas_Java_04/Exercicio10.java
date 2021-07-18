package Aulas_Java_04;

import javax.swing.JOptionPane;

public class Exercicio10 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int x = 1;
		do {
			x = Integer.parseInt(
				JOptionPane.showInputDialog("Digite um numero "));
				System.out.println(" a raiz quadrada do numero digitado: " + (Math.sqrt(x)));
		
		} while(x != -999);
		
	}
}
