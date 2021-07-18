package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio24 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double a= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double b= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double c= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double d= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double e= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		
		
		double maior = 0;
		double menor = 0;
		
		if(a > b && a > c && a > d && a > e)
		{
			 maior = (a);
		}
		if(b > a && b > c && b > d && b > e)
		{
			 maior = (b);
		}
		if(c > a && c> b && c > d && c > e)
		{
			 maior = (c);
		}
		if(d > a && d > b && d > c && d > e)
		{
			 maior = (d);
		}
		if(e > a && e > b && e > c && e > d)
		{
			 maior = (e);
		}
		
		if(a< b && a < c && a < d && a < e)
		{
			menor = a;
		}
		if(b <a && b <c && b < d && b < e)
		{
			menor = b;
		}
		if(c< b && c <a && b < d && b < e)
		{
			menor = c;
		}
		if(d < a && d < b && d < c && d < e)
		{
			 menor = (d);
		}
		if(e < a && e < b && e < c && e < d)
		{
			 menor = (e);
		}
		if(a == b && a == c)
		{
			 System.out.println("os numeros são iguais");
		}
		 System.out.println("o maior numero é " + maior);
		 System.out.println("o menor numero é " + menor);
	}
}
