package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio15 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		 double raio = Double.parseDouble(JOptionPane.showInputDialog("Digite o raio do circulo"));
		 double pi = 3.14159;
		 
		 double area = (pi*raio*raio);
		 
		 System.out.println("A area do circulo é : "+ area);
	}

}
