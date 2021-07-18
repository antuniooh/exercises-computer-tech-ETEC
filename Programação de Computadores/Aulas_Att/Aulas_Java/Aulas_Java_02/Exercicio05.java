package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio05 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		String a = JOptionPane.showInputDialog("Digite uma palavra");
		String b = JOptionPane.showInputDialog("Digite uma palavra");
		String c = JOptionPane.showInputDialog("Digite uma palavra");
		
		int A = a.length();
		int B = b.length();
		int C = c.length();
		
		int total = A + B + C;
		
		System.out.println("o Comprimento das palavras é " + total);
		
	}

}
