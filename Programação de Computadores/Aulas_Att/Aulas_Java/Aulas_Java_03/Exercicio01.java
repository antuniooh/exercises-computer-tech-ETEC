package Aulas_Java_03;

import javax.swing.JOptionPane;

public class Exercicio01 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int a= Integer.parseInt(JOptionPane.showInputDialog("Digite um valor"));
		int b= Integer.parseInt(JOptionPane.showInputDialog("Digite um valor"));
		
	    int R = a +b;
	    
	    if(R> 10)
	    {		
		JOptionPane.showMessageDialog(null, "o resultado é " + R);
	    }
	    else
	    {
	     JOptionPane.showMessageDialog(null, "o resultado é " + "null");
	    }
	}

}
