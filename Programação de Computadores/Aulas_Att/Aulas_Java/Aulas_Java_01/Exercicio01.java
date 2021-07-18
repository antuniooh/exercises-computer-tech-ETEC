package Aulas_Java_01;

import javax.swing.JOptionPane;

public class Exercicio01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		String a = JOptionPane.showInputDialog("Digite uma palavra");
		String b = JOptionPane.showInputDialog("Digite uma palavra");
		String c = JOptionPane.showInputDialog("Digite uma palavra");

		JOptionPane.showMessageDialog(null, "As palavras são: "+ c + b + a);
	}
}