import javax.swing.*;

import java.awt.*;
import java.awt.event.*;

public class atv_final extends JFrame{
	JMenuBar barra;
	JMenu opcoes,fonte,estilo,cor,tamanho;
	JMenuItem limpar, sair, azul, verde, vermelho, amarelo, preto;
	JCheckBoxMenuItem nomeE[];
	ButtonGroup grupoT, grupoE;
	JRadioButtonMenuItem tamanhoF[];
	String tam[] = {"12","14","16","18"};
	String est[] = {"Normal","Negrito","Italico","Negrito e Italico"};
	int estilofonte,tamfonte;
	JToolBar barraf;
	JButton direita, esquerda, centralizar, recortarBF, copiarBF,colarBF;
	ImageIcon imagens[];
	JTextArea texto;
	JPanel painel;
	JScrollPane rolagem;
	JPopupMenu opcoes1;
	JMenuItem recortar, copiar, colar;

	public atv_final(){
		super("Atividade de Avaliação");
		Container tela = getContentPane();
		tela.setLayout(null);
		estilofonte = Font.PLAIN;
		tamfonte=12;
		
		barra = new JMenuBar();
		setJMenuBar(barra);
		
		opcoes = new JMenu("Opções");
		barra.add(opcoes);
		
		limpar = new JMenuItem("Limpar");
		
		fonte = new JMenu("Fonte");
		
		cor = new JMenu("Cor");
		azul = new JMenuItem("Azul");
		verde = new JMenuItem("Verde");
		vermelho = new JMenuItem("Vermelho");
		amarelo = new JMenuItem("Amarelo");
		preto = new JMenuItem("Preto");

		TratadorE tratestilo = new TratadorE();
		estilo = new JMenu("Estilo");
		
		grupoE = new ButtonGroup();
		nomeE = new JCheckBoxMenuItem[4];
		for(int i= 0; i < 4; i++){
			nomeE[i] = new JCheckBoxMenuItem(est[i]);
			estilo.add(nomeE[i]);
			grupoE.add(nomeE[i]);
			nomeE[i].addItemListener(tratestilo);}
		
		TratadorT tratamanho= new TratadorT();
		tamanho = new JMenu("Tamanho");
		grupoT = new ButtonGroup();
		tamanhoF = new JRadioButtonMenuItem[4];
		for(int i = 0;i < 4;i++){
			tamanhoF[i] = new JRadioButtonMenuItem(tam[i]);
			tamanho.add(tamanhoF[i]);
			grupoT.add(tamanhoF[i]);
			tamanhoF[i].addItemListener(tratamanho);
		}
		
		sair = new JMenuItem("Sair");
		
		opcoes.setMnemonic(KeyEvent.VK_O);
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
		
		cor.add(azul);
		cor.add(verde);
		cor.add(vermelho);
		cor.add(amarelo);
		cor.add(preto);
		
		fonte.add(cor);
		fonte.add(estilo);
		fonte.add(tamanho);
		
		texto = new JTextArea(10,20);
		rolagem = new JScrollPane(texto);
		rolagem.setVerticalScrollBarPolicy(JScrollPane.VERTICAL_SCROLLBAR_ALWAYS);
		rolagem.setHorizontalScrollBarPolicy(JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);
		painel = new JPanel();
		painel.add(rolagem);
		
		painel.setBounds(30, 50, 250, 250);
		tela.add(painel);
		
		limpar.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e){
				texto.setText("");
				texto.requestFocus();
				}});
		azul.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e){
				texto.setForeground(Color.blue);
				repaint();
				}});
		verde.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e){
				texto.setForeground(Color.green);
				repaint();
				}});
		vermelho.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e){
				texto.setForeground(Color.red);
				repaint();
				}});
		amarelo.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e){
				texto.setForeground(Color.yellow);
				repaint();
				}});
		preto.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e){
				texto.setForeground(Color.black);
				repaint();
				}});
		sair.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e){
				int resposta;
				resposta = JOptionPane.showConfirmDialog
				(null, "Deseja realmente sair?","Mensagem do Programa",JOptionPane.YES_NO_OPTION);
				if(resposta ==0)
					System.exit(0);
				}});
		
		setSize(500,300);
		setLocationRelativeTo(null);
		setVisible(true);
		
		//barra de ferramentas
		setJMenuBar(barra);
		String icones[] = {"imagens/right.png",
				"imagens/left.png","imagens/center.png",
				"imagens/cut.png","imagens/copy.png",
				"imagens/paste.png"	};
				
			imagens = new ImageIcon[6];
			for(int i=0; i < 6;i++){
				imagens[i] = new ImageIcon(icones[i]);}
			direita = new JButton(imagens[0]);
			esquerda = new JButton(imagens[1]);
			centralizar = new JButton(imagens[2]);
			recortarBF = new JButton(imagens[3]);
			copiarBF = new JButton(imagens[4]);
			colarBF = new JButton(imagens[5]);

			direita.setToolTipText("Direita (Ctrl+d)");
			esquerda.setToolTipText("Esquerda (Ctrl+e)");
			centralizar.setToolTipText("Centralizar (Ctrl+z)");
			recortarBF.setToolTipText("Recortar (Ctrl+x)");
			copiarBF.setToolTipText("Copiar (Ctrl+c)");
			colarBF.setToolTipText("Colar (Ctrl+v)");
			barraf = new JToolBar("Barra de Ferramentas");
			
			UIManager.put("ToolTip.background", SystemColor.info);
			UIManager.put("ToolTip.foreground", Color.blue);
			barraf.setRollover(false);
			barraf.add(esquerda);
			barraf.add(centralizar);
			barraf.add(direita);

			barraf.addSeparator();
			
			barraf.add(recortarBF);
			barraf.add(copiarBF);
			barraf.add(colarBF);
			barraf.setBounds(1, 1, 260, 50);
			
			
		//popup
			texto.addMouseListener(new MouseAdapter(){
				
				public void mouseReleased(MouseEvent e){
					if(e.isPopupTrigger())
						opcoes1.show(e.getComponent(),e.getX(),e.getY());;
				}	
			}
		);

			Tratador tratmenu = new Tratador();
			opcoes1 = new JPopupMenu();
			recortar = new JMenuItem("Recortar");
			copiar = new JMenuItem("Copiar");
			colar = new JMenuItem("Colar");
			
			recortar.setMnemonic(KeyEvent.VK_R);
			copiar.setMnemonic(KeyEvent.VK_C);
			colar.setMnemonic(KeyEvent.VK_L);
			
			recortar.addActionListener(tratmenu);
			copiar.addActionListener(tratmenu);
			colar.addActionListener(tratmenu);
			
			opcoes1.add(recortar);
			opcoes1.add(copiar);
			
			opcoes1.addSeparator();
			
			opcoes1.add(colar);
			
		tela.add(barraf);
		tela.add(painel);
		setSize(500,300);
		setLocationRelativeTo(null);
		setVisible(true);}

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		atv_final app = new atv_final();
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	}
private class Tratador implements ActionListener{
	public void actionPerformed(ActionEvent e){
		if(e.getSource()==recortar)
			texto.cut();
		if(e.getSource()==copiar)
			texto.copy();
		if(e.getSource()==colar)
			texto.paste();
			repaint();		
}
}
	private class TratadorE implements ItemListener{
		public void itemStateChanged(ItemEvent e){
			if(nomeE[0].isSelected())
				estilofonte=Font.PLAIN;
			if(nomeE[1].isSelected())
				estilofonte=Font.BOLD;
			if(nomeE[2].isSelected())
				estilofonte=Font.ITALIC;
			if(nomeE[3].isSelected())
				estilofonte=Font.BOLD + Font.BOLD;
			texto.setFont(new Font("",estilofonte,tamfonte));
			repaint();		
		}
	}
	private class TratadorT implements ItemListener{
		public void itemStateChanged(ItemEvent e){
			if(tamanhoF[0].isSelected())
				tamfonte=12;
			if(tamanhoF[1].isSelected())
				tamfonte=14;
			if(tamanhoF[2].isSelected())
				tamfonte=16;
			if(tamanhoF[3].isSelected())
				tamfonte=18;
			texto.setFont(new Font("",estilofonte,tamfonte));
			repaint();		
}
}
}