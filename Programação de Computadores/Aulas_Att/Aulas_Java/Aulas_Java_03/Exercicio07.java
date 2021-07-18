package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio07 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		String nome= JOptionPane.showInputDialog("Digite seu nome");
		int idade= Integer.parseInt(JOptionPane.showInputDialog("Digite sua idade"));
		String sexo= JOptionPane.showInputDialog("Digite seu sexo");

	    if("f".equals(sexo) || "F".equals(sexo) && idade < 25)
	    {		
		JOptionPane.showMessageDialog(null, nome + ", aceita");
	    }
	    else
	    {
	     JOptionPane.showMessageDialog(null,nome + ", não aceita");
	    }
	}

}
