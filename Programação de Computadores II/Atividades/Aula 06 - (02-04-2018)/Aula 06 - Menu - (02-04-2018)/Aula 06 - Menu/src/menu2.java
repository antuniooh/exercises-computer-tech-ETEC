import javax.swing.*;

import java.awt.*;
import java.awt.event.*;

public class menu2 extends JFrame{
	JMenuBar barra;
	JMenu opcoes,fonte,cor;
	JMenuItem limpar, sair, estilo, tamanho, azul, verde, vermelho, amarelo, preto;
	
	public menu2(){
		super("exemplo de menus com submenus");
		Container tela = getContentPane();
		tela.setLayout(null);
		
		barra = new JMenuBar();
		setJMenuBar(barra);
		
		opcoes = new JMenu("Opções");
		barra.add(opcoes);
		limpar = new JMenuItem("Limpar");
		
		fonte = new JMenu("Fonte");
		
		cor = new JMenu("Cor");
		azul = new JMenuItem("Azul");
		verde = new JMenuItem("verde");
		vermelho = new JMenuItem("vermelho");
		amarelo = new JMenuItem("amarelo");
		preto = new JMenuItem("preto");
		
		estilo = new JMenuItem("Estilo");
		tamanho = new JMenuItem("Tamanho");
		
		sair = new JMenuItem("Sair");
		
		limpar.setMnemonic(KeyEvent.VK_L);
		fonte.setMnemonic(KeyEvent.VK_F);
		sair.setMnemonic(KeyEvent.VK_S);
		cor.setMnemonic(KeyEvent.VK_C);
		estilo.setMnemonic(KeyEvent.VK_E);
		tamanho.setMnemonic(KeyEvent.VK_T);
		
		opcoes.add(limpar);
		opcoes.add(fonte);
		
		opcoes.addSeparator();
		
		opcoes.add(sair);
		fonte.add(cor);
		fonte.add(estilo);
		fonte.add(tamanho);
		cor.add(azul);
		cor.add(verde);
		cor.add(vermelho);
		cor.add(amarelo);
		cor.add(preto);
		
		setSize(500,300);
		setLocationRelativeTo(null);
		setVisible(true);}
		
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		menu2 app = new menu2();
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

	}

}
