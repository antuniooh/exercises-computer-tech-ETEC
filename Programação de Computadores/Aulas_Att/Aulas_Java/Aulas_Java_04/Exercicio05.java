package Aulas_Java_04;

import javax.swing.JOptionPane;

public class Exercicio05 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		String nome = null;
		do {
			nome = JOptionPane.showInputDialog("Digite um nome");
			System.out.println("o nome digitado foi: " + nome );		
		} while(!nome.equals("FIM"));
	}
}
