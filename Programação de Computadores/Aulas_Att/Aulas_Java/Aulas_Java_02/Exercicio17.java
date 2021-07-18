package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio17 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		 double a = Double.parseDouble(JOptionPane.showInputDialog("Digite um numero"));
		 
		 double quadrado = Math.pow(a, 2);
		 double raiz = Math.sqrt(a);
		 
		 System.out.println("o Quadrado de "+ a+ " é: " + quadrado);
		 System.out.println("a raiz quadrada de "+ a+ " é: " + raiz);
	
	}

}
