import javax.swing.*;

import java.awt.*;
import java.awt.event.*;
public class Atv extends JFrame{

	JLabel Cadastro,Nome,Senha,Periodo,CursoIdiomas,CursoExtra,Sugestoes;
	JCheckBox Informatica,Idiomas,Música;
	JRadioButton sim,não;
	JTextField nome,senha, sugestoes;
	JButton enviar,limpar;
	JComboBox lista;
	String periodo [] = {"Manhã","Tarde","Noite"};
	
	public Atv(){
		super("Atividade PRC");
		Container tela = getContentPane();
		setLayout(null);
		
		Cadastro = new JLabel("Cadastro de Aluno");
		Nome = new JLabel("Nome");
		Senha = new JLabel("Senha");
		Periodo = new JLabel("Qual período deseja estudar?");
		CursoIdiomas = new JLabel("Já fez curso de idiomas?");
		CursoExtra = new JLabel("Qual curso extra deseja realizar?");
		Sugestoes = new JLabel("Espaço para Sugestões");
		
		lista = new JComboBox(periodo);
		lista.setMaximumRowCount(3);
		
		Informatica = new JCheckBox("Informática");
		Idiomas = new JCheckBox("Idiomas");
		Música = new JCheckBox("Música");
		
		sim = new JRadioButton("Sim");
		não = new JRadioButton("Não");
		
		nome = new JTextField(30);
		senha = new JTextField(20);
		sugestoes = new JTextField(200);
		
		enviar = new JButton("Enviar");
		limpar = new JButton("Limpar");
		
		Cadastro.setBounds(50,10,400,30);
		Nome.setBounds(50,60,100,20);
		nome.setBounds(100,60,200,20);
		Senha.setBounds(50,90,100,20);
		senha.setBounds(100,90,100,20);
		Periodo.setBounds(50,120,190,20);
		lista.setBounds(225,120,80,20);
		CursoIdiomas.setBounds(50,150,190,20);
		sim.setBounds(200,150,55,20);
		não.setBounds(255,150,55,20);
		CursoExtra.setBounds(50,180,190,20);
		Informatica.setBounds(50,210,190,20);
		Idiomas.setBounds(50,230,190,20);
		Música.setBounds(50,250,190,20);
		Sugestoes.setBounds(50,280,190,20);
		sugestoes.setBounds(50,310,250,65);
		enviar.setBounds(50,390,80,20);
		limpar.setBounds(220,390,80,20);
		
		Cadastro.setForeground(Color.blue);
		Nome.setForeground(Color.blue);
		Senha.setForeground(Color.blue);
		Periodo.setForeground(Color.blue);
		CursoIdiomas.setForeground(Color.blue);
		CursoExtra.setForeground(Color.blue);
		Sugestoes.setForeground(Color.blue);
		lista.setForeground(Color.blue);
		sim.setForeground(Color.blue);
		não.setForeground(Color.blue);
		Informatica.setForeground(Color.blue);
		Idiomas.setForeground(Color.blue);
		Música.setForeground(Color.blue);
		enviar.setForeground(Color.white);
		limpar.setForeground(Color.white);
		senha.setForeground(Color.white);
		nome.setForeground(Color.white);
		sugestoes.setForeground(Color.white);
		
		tela.setBackground(Color.white);
		sim.setBackground(Color.white);
		não.setBackground(Color.white);
		Informatica.setBackground(Color.white);
		Idiomas.setBackground(Color.white);
		Música.setBackground(Color.white);
		lista.setBackground(Color.white);
		
		enviar.setBackground(Color.blue);
		limpar.setBackground(Color.blue);
		nome.setBackground(Color.blue);
		senha.setBackground(Color.blue);
		sugestoes.setBackground(Color.blue);
		
		enviar.setMnemonic(KeyEvent.VK_E);
		limpar.setMnemonic(KeyEvent.VK_L);
		enviar.setToolTipText("Botao que envia o formulário");
		limpar.setToolTipText("Botao que limpar os campos");
		
		Cadastro.setFont(new Font("Verdana",Font.ITALIC,30));
		
		limpar.addActionListener(
				new ActionListener(){
					public void actionPerformed(ActionEvent e){
						nome.setText(null);
						senha.setText(null);
						sugestoes.setText(null);
						nome.requestFocus();
					}
				}
			);
		
		tela.add(Cadastro);
		tela.add(Nome);
		tela.add(Senha);
		tela.add(Periodo);
		tela.add(CursoIdiomas);
		tela.add(CursoExtra);
		tela.add(Sugestoes);
		tela.add(lista);
		tela.add(Informatica);
		tela.add(Idiomas);
		tela.add(Música);
		tela.add(sim);
		tela.add(não);
		tela.add(nome);
		tela.add(senha);
		tela.add(sugestoes);
		tela.add(enviar);
		tela.add(limpar);
		setSize(400,600);
		setLocationRelativeTo(null);
		setVisible(true);
	}		
	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Atv app = new Atv();
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);}
	}
