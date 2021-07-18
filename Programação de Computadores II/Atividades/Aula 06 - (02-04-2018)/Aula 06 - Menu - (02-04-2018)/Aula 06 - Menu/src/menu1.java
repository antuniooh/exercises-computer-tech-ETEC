import javax.swing.*;

import java.awt.*;
import java.awt.event.*;

public class menu1 extends JFrame{

	JMenuBar barra;
	JMenu opcoes;
	JMenuItem limpar, fonte, sair;
	
	public menu1(){
		super("exemplo de menus");
		Container tela = getContentPane();
		tela.setLayout(null);
		
		barra = new JMenuBar();
		setJMenuBar(barra);
		opcoes = new JMenu("Opções");
		barra.add(opcoes);
		limpar = new JMenuItem("Limpar");
		fonte = new JMenuItem("Fonte");
		sair = new JMenuItem("Sair");
		
		limpar.setMnemonic(KeyEvent.VK_L);
		fonte.setMnemonic(KeyEvent.VK_F);
		sair.setMnemonic(KeyEvent.VK_S);
		opcoes.add(limpar);
		opcoes.add(fonte);
		opcoes.addSeparator();
		opcoes.add(sair);
		
		setSize(500,300);
		setLocationRelativeTo(null);
		setVisible(true);}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		menu1 app = new menu1();
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}

}
