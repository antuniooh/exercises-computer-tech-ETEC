package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio04 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double a= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double b= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double c= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double maior = 0;
		double meio = 0;
		double menor = 0;
		
		if(a > b && a > c)
		{
			 maior = (a);
		}
		if(b > a && b > c)
		{
			 maior = (b);
		}
		if(c > a && c> b)
		{
			 maior = (c);
		}
		if(a< b && a <c)
		{
			menor = a;
		}
		if(b <a && b <c)
		{
			menor = b;
		}
		if(c< b && c <a)
		{
			menor = c;
		}
		if(a> b && a < c || a < b && a > c)
		{
			meio = a;
		}
		if(b> a && b < c || b < a && b > c)
		{
			meio = b;
		}
		if(c> b && c < a || c < b && c > a)
		{
			meio = c;
		}
		 System.out.println("os numeros em ordem crescente: " + menor+"," + meio+"," + maior);
		
	}

}
