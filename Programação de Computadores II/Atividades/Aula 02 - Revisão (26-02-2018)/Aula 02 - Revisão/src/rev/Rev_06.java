package rev;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


public class Rev_06 extends JFrame {
	JPasswordField caixa;
	JLabel rotulo;
	public Rev_06(){
		super("Exemplo com JPasswordField");
		Container tela = getContentPane();
		setLayout(null);
		
		rotulo = new JLabel("Senha: ");
		caixa = new JPasswordField(10);
		rotulo.setBounds(50, 20, 100, 20);
		caixa.setBounds(50, 60, 100, 20);
		
		caixa.setForeground(Color.blue);
		caixa.setBackground(Color.yellow);
		caixa.setFont(new Font("Ariel",Font.BOLD,20));
		caixa.setEchoChar('*');
		
		tela.add(rotulo);
		tela.add(caixa);
		setSize(400,250);
		setVisible(true);
	}

	public static void main(String[] args) {
		Rev_06 app = new Rev_06();
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);}
		// TODO Auto-generated method stub

	}
