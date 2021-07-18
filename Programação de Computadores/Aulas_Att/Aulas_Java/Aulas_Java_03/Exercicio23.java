package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio23 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double a= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double b= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double c= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double maior = 0;
		double intermediario = 0;
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
			intermediario = a;
		}
		if(b> a && b < c || b < a && b > c)
		{
			intermediario = b;
		}
		if(c> b && c < a || c < b && c > a)
		{
			intermediario = c;
		}
		if(a == b && a == c)
		{
			 System.out.println("os numeros são iguais");
		}
		 System.out.println("o maior numero é " + maior);
		 System.out.println("o numero intermediario é " + intermediario);
		 System.out.println("o menor numero é " + menor);
	}
}