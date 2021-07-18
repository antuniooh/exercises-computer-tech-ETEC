package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio05 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double a= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		
		if(a >= 20 && a <= 90)
		{
			System.out.println("O numero "+a+" está compreendido entre 20 e 90");
		}
		else
		{
			System.out.println("O numero "+a+"nao esta compreendido entre 20 e 90");
		}
		
		 
			
	}

}
