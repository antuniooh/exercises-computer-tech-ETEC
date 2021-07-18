package rev;

import javax.swing.*;

import java.awt.*;
import java.awt.event.*;

public class Rev_07 extends JFrame{
	JButton botaosair;
	public Rev_07(){
		super("Exemplo com JButton");
		Container tela = getContentPane();
		setLayout(null);
		
		botaosair = new JButton("Sair");
		botaosair.setBounds(100, 50, 100, 20);
		
		botaosair.addActionListener(
			new ActionListener(){
				public void actionPerformed(ActionEvent e){
					System.exit(0);
				}
				}
		);
		tela.add(botaosair);
		setSize(300,150);
		setVisible(true);
	}
		

	public static void main(String[] args) {
		Rev_07 app = new Rev_07();
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);}
		// TODO Auto-generated method stub
}
