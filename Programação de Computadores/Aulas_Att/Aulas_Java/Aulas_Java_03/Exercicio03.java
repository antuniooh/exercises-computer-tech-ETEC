package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double a= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		
		if(a < 0)
		{
			JOptionPane.showMessageDialog(null, "o quadrado é " +(Math.pow(a, 2)));
		}
		else
		{
			JOptionPane.showMessageDialog(null, "a raiz é " +(Math.sqrt(a)));
		}
	}

}
