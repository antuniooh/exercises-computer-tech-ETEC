package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio16 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		 int a = Integer.parseInt(JOptionPane.showInputDialog("Digite um numero"));
		 int b = Integer.parseInt(JOptionPane.showInputDialog("Digite um numero"));
		 
		 int dividendo = a;
		 int divisor = b;
		 int quociente = a/b;
		 int resto = a % b;
		 
		 System.out.println("o Dividendo é: " + dividendo);
		 System.out.println("o Divisor é: " + divisor);
		 System.out.println("o quociente é: " + quociente);
		 System.out.println("o resto é: " + resto);
	}

}
