package Aulas_Java_04;

import javax.swing.JOptionPane;

public class Exercicio03 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		/*int x = 1;
		do {
			x = Integer.parseInt(
			JOptionPane.showInputDialog("Digite um numero "));
			System.out.println("a media dos resultados é" + (x)/);
		while(x != 0);*/
		
		for(int i = 1; i != 0; i +=i)
		{
			i= Integer.parseInt(
			JOptionPane.showInputDialog("Digite um numero "));
			System.out.println("a media dos resultados é" + (i));
	}
	}
}