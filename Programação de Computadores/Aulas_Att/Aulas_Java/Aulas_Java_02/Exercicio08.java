package Aulas_Java_02;

import javax.swing.JOptionPane;

public class Exercicio08 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

         double angulo = Double.parseDouble(JOptionPane.showInputDialog("Digite um angulo"));
         
         double seno = Math.sin(angulo);
         double cosseno = Math.cos(angulo);
         double tangente = Math.tan(angulo);
         double secante = 1/cosseno;
         double cossecante = 1/seno;
         double cotangente = 1/tangente;
		
		System.out.println("Seu angulo é : " + angulo);
		System.out.println("o cosseno de seu angulo é : " + cosseno);
		System.out.println("o seno de seu angulo é : " + seno);
		System.out.println("a tangente de seu angulo é : " + tangente);
		System.out.println("a secante de seu angulo é : " + secante);
		System.out.println("a cossecante de seu angulo é : " + cossecante);
		System.out.println("a cotangente de seu angulo é : " + cotangente);
	}

}
