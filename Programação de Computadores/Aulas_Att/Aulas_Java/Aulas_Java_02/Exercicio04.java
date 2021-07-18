package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio04 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double numero = Double.parseDouble(JOptionPane.showInputDialog("Digite um numero"));
		
		double Valor = Math.pow(numero, 2);
		
		JOptionPane.showMessageDialog(null, "O numero ao quadrado é: "+ Valor);
	}

}
