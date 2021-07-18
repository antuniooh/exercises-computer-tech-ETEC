package rev;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Rev_05 extends JFrame{
	JButton botao1,botao2,botao3,botao4;
	
	public Rev_05(){
		super("Exemplo com JButton");
		Container tela = getContentPane();
		setLayout(null);
		
		botao1 = new JButton("Procurar");
		botao2 = new JButton("Voltar >>");
		botao3 = new JButton("Próximo");
		botao4 = new JButton("Abrir");
		
		botao1.setBounds(50,20,100,20);
		botao2.setBounds(50,60,100,20);
		botao3.setBounds(50,100,100,20);
		botao4.setBounds(50,140,100,20);
		
		botao1.setBackground(Color.yellow);
		botao2.setBackground(Color.red);
		botao3.setBackground(Color.blue);
		botao4.setBackground(Color.white);
		
		botao1.setMnemonic(KeyEvent.VK_P);
		botao2.setMnemonic(KeyEvent.VK_V);
		botao3.setMnemonic(KeyEvent.VK_X);
		botao4.setMnemonic(KeyEvent.VK_A);
		
		botao1.setForeground(Color.blue);
		botao2.setForeground(Color.green);
		botao3.setForeground(Color.red);
		botao4.setForeground(Color.pink);
		
        tela.add(botao1);
        tela.add(botao2);
        tela.add(botao3);
        tela.add(botao4);
		setSize(400,250);
		setVisible(true);
	}

	public static void main(String[] args) {
		Rev_05 app = new Rev_05();
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);}
		// TODO Auto-generated method stub

	}
