package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio02 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		double a= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		double b= Double.parseDouble(JOptionPane.showInputDialog("Digite um valor"));
		
	    double R = a +b ;
	    
	    if(R <= 20)
	    {		
		JOptionPane.showMessageDialog(null, "o resultado é " +(R-5));
	    }
	    else
	    {
	     JOptionPane.showMessageDialog(null, "o resultado é " + "null");
	    }
	}

}
