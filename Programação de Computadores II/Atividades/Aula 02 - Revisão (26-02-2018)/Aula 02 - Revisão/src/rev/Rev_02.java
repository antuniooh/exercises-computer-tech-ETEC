package rev;

import java.awt.Color;
import java.awt.Container;

import javax.swing.JFrame;

public class Rev_02 extends JFrame{
	public Rev_02(){
	super("Definindo a cor de fundo para a janela");
	Container tela = getContentPane();
	tela.setBackground(Color.blue);
	setSize(200,100);
	setVisible(true);}


	public static void main(String[] args) {
		Rev_02 app = new Rev_02();
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);}

		// TODO Auto-generated method stub

	}
