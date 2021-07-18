package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio06 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

         double a= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		
		if(a > 20 )
		{
			System.out.println("O numero "+a+" é maior que 20");
		}
		else if( a < 20)
		{
			System.out.println("O numero "+a+" é menor que 20");
		}
		else
		{
			System.out.println("O numero "+a+" é igual a 20");
		}
	}

}
