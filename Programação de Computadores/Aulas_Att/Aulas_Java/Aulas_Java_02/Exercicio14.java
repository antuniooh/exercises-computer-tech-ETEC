package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio14 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		 double a = Double.parseDouble(JOptionPane.showInputDialog("Digite um numero"));
		 double b = Double.parseDouble(JOptionPane.showInputDialog("Digite um numero"));
		 double c = Double.parseDouble(JOptionPane.showInputDialog("Digite um numero"));
		 
		 double X = (2 *((a - c)/ 8) - b * 5);
		 
		 System.out.println(" Resultado é : "+ X);
	}

}
