package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio09 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

         double numero = Double.parseDouble(JOptionPane.showInputDialog("Digite um numero"));	
		
		double log = Math.log10(numero);
		System.out.println(" O logaritmo de seu numero na base dez é: "+ log);
	}

}
