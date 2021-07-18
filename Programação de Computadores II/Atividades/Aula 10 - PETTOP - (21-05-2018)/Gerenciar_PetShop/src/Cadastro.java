import java.awt.Rectangle;
import java.awt.event.KeyEvent;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class Cadastro extends JFrame{
	usuario usr = new usuario();
	usuario_bd usrBD = new usuario_bd();
	private static final long serialVersionUID=1L;
	private JPanel jContentPane = null;
	
	private JTextField txtCPF =null;
	private JLabel lblCPF =null;
	
	private JLabel lblNome =null;
	private JTextField txtNome =null;
	
	private JLabel lblEmail =null;
	private JTextField txtEmail =null;
	
	private JTextField txtTelefone =null;
	private JLabel lblTelefone =null;
	
	private JLabel lblTipo =null;
	private JComboBox cmbTipo =null;
	
	private JComboBox cmbServico =null;
	private JLabel lblServico =null;
	
	private JLabel lblLogin =null;
	private JTextField txtLogin =null;
	
	private JTextField txtSenha =null;
	private JLabel lblSenha =null;

	private JButton cmdIncluir =null;
	private JButton cmdAlterar =null;
	private JButton cmdExcluir =null;
	private JButton cmdSair =null;
	private JButton cmdConsultar =null;
	private JButton Limpar =null;
	private JButton cmdTeste =null;
	private JButton cmdPesquisar =null;
	
	public Cadastro(){
		super();
		initialize();
	}
	//inicialização do JContentPane (que eh o formulario propriamente dito)
	private void initialize(){
		this.setSize(364, 342);
		this.setContentPane(getJContentPane());
		this.setTitle("Cadastro de usuarios do PetTop");
	}
	
	//Montagem do JContentPane (inserção dos componentes na tela)
	private JPanel getJContentPane(){
		if(jContentPane==null){
			lblCPF = new JLabel();
			lblCPF.setBounds(new Rectangle (10,20,50,15));
			lblCPF.setName("lblCPF");
			lblCPF.setText("CPF: ");
			
			lblNome = new JLabel();
			lblNome.setBounds(new Rectangle (10,50,45,15));
			lblNome.setName("lblNome");
			lblNome.setText("Nome: ");
			
			lblEmail = new JLabel();
			lblEmail.setBounds(new Rectangle (10,90,45,15));
			lblEmail.setName("lblEmail");
			lblEmail.setText("Email: ");
			
			lblTelefone = new JLabel();
			lblTelefone.setBounds(new Rectangle (10,20,50,15));
			lblTelefone.setName("lblTelefone");
			lblTelefone.setText("Telefone: ");
			
			lblTipo = new JLabel();
			lblTipo.setBounds(new Rectangle (10,130,45,15));
			lblTipo.setName("lblTipo");
			lblTipo.setText("Espécie Pet: ");
			lblTipo.setDisplayedMnemonic(KeyEvent.VK_UNDEFINED);
			
			lblServico = new JLabel();
			lblServico.setBounds(new Rectangle (10,130,45,15));
			lblServico.setName("lblServico");
			lblServico.setText("Serviço: ");
			lblServico.setDisplayedMnemonic(KeyEvent.VK_UNDEFINED);
			
			lblLogin = new JLabel();
			lblLogin.setBounds(new Rectangle (10,170,45,15));
			lblLogin.setName("lblLogin");
			lblLogin.setText("Login: ");		
			
			lblSenha = new JLabel();
			lblSenha.setBounds(new Rectangle (10,210,45,15));
			lblSenha.setName("lblSenha");
			lblSenha.setText("Senha: ");
			
			jContentPane = new JPanel();
			jContentPane.setLayout(null);
			jContentPane.add(lblCPF,null);
			jContentPane.add(getTxtCPF(),null);
			jContentPane.add(lblNome, null);
			jContentPane.add(getTxtNome(),null);
			jContentPane.add(lblEmail,null);
			jContentPane.add(getTxtEmail(),null);
			jContentPane.add(lblTelefone,null);
			jContentPane.add(getTxtTelefone(),null);
			jContentPane.add(lblTipo,null);
			jContentPane.add(getCmbTipo(),null);
			jContentPane.add(lblServico,null);
			jContentPane.add(getCmbServico(),null);
			jContentPane.add(lblLogin,null);
			jContentPane.add(getTxtLogin(),null);
			jContentPane.add(lblSenha, null);
			jContentPane.add(getTxtSenha(),null);
			
			jContentPane.add(getCmdIncluir(),null);
			jContentPane.add(getCmdAlterar(),null);
			jContentPane.add(getCmdExcluir(),null);
			jContentPane.add(getCmdSair(),null);
			jContentPane.add(getLimpar(),null);
			jContentPane.add(getCmdConsultar(),null);
			jContentPane.add(getCmdTeste(),null);
			jContentPane.add(getCmdPesquisar(),null);

		}
		return jContentPane;
	}
	private JTextField getTxtCPF(){
		if(txtCPF==null){
			txtCPF =new JTextField();
			txtCPF.setBounds(new Rectangle(70,10,100,22));
			txtCPF.setName("txtCPF");
			txtCPF.setText("");
		}
		return txtCPF;
	}
	private JTextField getTxtNome(){
		if(txtNome==null){
			txtNome =new JTextField();
			txtNome.setBounds(new Rectangle(70,50,270,22));
			txtNome.setName("txtNome");
		}
		return txtNome;
	}
	private JTextField getTxtEmail(){
		if(txtEmail==null){
			txtEmail =new JTextField();
			txtEmail.setBounds(new Rectangle(70,90,270,22));
			txtEmail.setName("txtEmail");
		}
		return txtEmail;
	}
	private JTextField getTxtTelefone(){
		if(txtTelefone==null){
			txtTelefone =new JTextField();
			txtTelefone.setBounds(new Rectangle(70,120,100,22));
			txtTelefone.setName("txtTelefone");
			txtTelefone.setText("");
		}
		return txtTelefone;
	}
	private JComboBox getCmbTipo(){
		if(cmbTipo ==null){
			cmbTipo =new JComboBox();
			cmbTipo.setBounds(new Rectangle(70,150,150,22));
			cmbTipo.setName("cmbTipo");
			cmbTipo.addItem("Catchocho");
			cmbTipo.addItem("Gatineo");
			cmbTipo.addItem("Hamster");
			cmbTipo.addItem("Cobra");
			cmbTipo.addItem("Passarinho");
			cmbTipo.addItem("Tartaruga");
			cmbTipo.addItem("Peixe");
		}
		return cmbTipo;
	}
	private JComboBox getCmbServico(){
		if(cmbServico ==null){
			cmbServico =new JComboBox();
			cmbServico.setBounds(new Rectangle(70,130,150,22));
			cmbServico.setName("cmbTipo");
			cmbServico.addItem("Banho");
			cmbServico.addItem("Tosa");
			cmbServico.addItem("Saúde Bucal");
			cmbServico.addItem("Manicure e Pedicure");
			cmbServico.addItem("Veterinário");

		}
		return cmbServico;
	}
	private JTextField getTxtLogin(){
		if(txtLogin==null){
			txtLogin =new JTextField();
			txtLogin.setBounds(new Rectangle(70,170,270,22));
			txtLogin.setName("txtLogin");
		}
		return txtLogin;
	}
	private JTextField getTxtSenha(){
		if(txtSenha==null){
			txtSenha =new JTextField();
			txtSenha.setBounds(new Rectangle(70,210,270,22));
			txtSenha.setName("txtSenha");
		}
		return txtSenha;
	}
	private JButton getCmdPesquisar(){
		if(cmdPesquisar==null){
			cmdPesquisar =new JButton();
			cmdPesquisar.setBounds(new Rectangle(240,10,100,25));
			cmdPesquisar.setText("Pesquisar");
			cmdPesquisar.setName("Pesquisar");
			cmdPesquisar.addActionListener(new java.awt.event.ActionListener(){
				public void actionPerformed(java.awt.event.ActionEvent e){
					usuario usrPesquisa = new usuario();
					usr.setCPF(Integer.parseInt(txtCPF.getText()));
					usrPesquisa= usrBD.Pesquisar(usr);
					txtNome.setText(usrPesquisa.getNome());
					txtEmail.setText(usrPesquisa.getEmail());
					if(usrPesquisa.getTipo().equals("Banho")){
						cmbTipo.setSelectedIndex(0);
					}
					if(usrPesquisa.getTipo().equals("Tosa")){
						cmbTipo.setSelectedIndex(1);
					}
					if(usrPesquisa.getTipo().equals("Saúde Bucal")){
						cmbTipo.setSelectedIndex(2);
					}
					if(usrPesquisa.getTipo().equals("Manicure e Pedicure")){
						cmbTipo.setSelectedIndex(3);
					}
					else{
						cmbTipo.setSelectedIndex(4);
					}
					txtLogin.setText(usrPesquisa.getLogin());
					txtSenha.setText(usrPesquisa.getSenha());
				}
			});
		}
		return cmdPesquisar;
	}
	private JButton getCmdIncluir(){
		if(cmdIncluir==null){
			cmdIncluir =new JButton();
			cmdIncluir.setBounds(new Rectangle(240,10,100,25));
			cmdIncluir.setText("Incluir");
			cmdIncluir.setName("cmdIncluir");
			cmdIncluir.addActionListener(new java.awt.event.ActionListener(){
				public void actionPerformed(java.awt.event.ActionEvent e){
					usr.setCPF(Integer.parseInt(txtCPF.getText()));
					usr.setNome(txtNome.getText());
					usr.setEmail(txtEmail.getText());
					usr.setTelefone(Integer.parseInt(txtTelefone.getText()));
					usr.setTipo(cmbTipo.getSelectedItem().toString());
					usr.setServico(cmbServico.getSelectedItem().toString());
					usr.setLogin(txtLogin.getText());
					usr.setSenha(txtSenha.getText());
						usrBD.Incluir(usr);
						
						JOptionPane.showMessageDialog(null, "Inclusão Realizada com sucesso!",
						"Confirmação",JOptionPane.INFORMATION_MESSAGE);
				}
			});
		}
		return cmdIncluir;
	}
	private JButton getCmdAlterar(){
		if(cmdAlterar==null){
			cmdAlterar =new JButton();
			cmdAlterar.setBounds(new Rectangle(125,240,100,25));
			cmdAlterar.setText("Alterar");
			cmdAlterar.setName("cmdAlterar");
			cmdAlterar.addActionListener(new java.awt.event.ActionListener(){
				public void actionPerformed(java.awt.event.ActionEvent e){
					usr.setNome(txtNome.getText());
					usr.setEmail(txtEmail.getText());
					usr.setTelefone(Integer.parseInt(txtTelefone.getText()));
					usr.setTipo(cmbTipo.getSelectedItem().toString());
					usr.setServico(cmbServico.getSelectedItem().toString());
					usr.setLogin(txtLogin.getText());
					usr.setSenha(txtSenha.getText());
						usrBD.Alterar(usr);
						
						JOptionPane.showMessageDialog(null, "Alteração Realizada com sucesso!",
						"Confirmação",JOptionPane.INFORMATION_MESSAGE);
				}
			});
		}
		return cmdAlterar;
	}
	private JButton getCmdExcluir(){
		if(cmdExcluir==null){
			cmdExcluir =new JButton();
			cmdExcluir.setBounds(new Rectangle(240,240,100,25));
			cmdExcluir.setText("Excluir");
			cmdExcluir.setName("cmdExcluir");
			cmdExcluir.addActionListener(new java.awt.event.ActionListener(){
				public void actionPerformed(java.awt.event.ActionEvent e){
					usr.setCPF(Integer.parseInt(txtCPF.getText()));
						usrBD.Excluir(usr);
						
						JOptionPane.showMessageDialog(null, "Exclusão Realizada com sucesso!",
						"Confirmação",JOptionPane.INFORMATION_MESSAGE);
				}
			});
		}
		return cmdExcluir;
	}
	//Consultar
	private JButton getCmdConsultar(){
		if(cmdConsultar==null){
			cmdConsultar =new JButton();
			cmdConsultar.setBounds(new Rectangle(10,275,100,25));
			cmdConsultar.setText("Consultar");
			cmdConsultar.setName("cmdConsultar");
			cmdConsultar.addActionListener(new java.awt.event.ActionListener(){
				public void actionPerformed(java.awt.event.ActionEvent e){
						usrBD.Consultar();
						
						JOptionPane.showMessageDialog(null, "Exclusão Realizada com sucesso!",
						"Confirmação",JOptionPane.INFORMATION_MESSAGE);
				}
			});
		}
		return cmdConsultar;
	}
	//Conexão
	private JButton getCmdTeste(){
		if(cmdTeste==null){
			cmdTeste =new JButton();
			cmdTeste.setBounds(new Rectangle(125,275,100,25));
			cmdTeste.setText("Consultar");
			cmdTeste.addActionListener(new java.awt.event.ActionListener(){
				public void actionPerformed(java.awt.event.ActionEvent e){
					//chama o metodo testeconexão do objeto usrBd e apresenta mesngaens de acordo com oretorno
					if(usrBD.testaConexao()){
						JOptionPane.showMessageDialog(null, "Conexão com Banco de Dados Realizada com sucesso!",
								"Confirmação",JOptionPane.INFORMATION_MESSAGE);
					}else{	
						JOptionPane.showMessageDialog(null, "erro ao conectar com o banco de dados",
						"Confirmação",JOptionPane.ERROR_MESSAGE);
				}
			}
			});
		}
		return cmdTeste;
	}
	//sair
	private JButton getCmdSair(){
		if(cmdSair==null){
			cmdSair =new JButton();
			cmdSair.setBounds(new Rectangle(10,275,100,25));
			cmdSair.setText("Sair");
			cmdSair.setName("cmdSair");
			cmdSair.addActionListener(new java.awt.event.ActionListener(){
				public void actionPerformed(java.awt.event.ActionEvent e){
						System.exit(0);
				}
			});
		}
		return cmdSair;
	}

	//limpar
	private JButton getLimpar(){
	Limpar =new JButton();
	Limpar.setBounds(new Rectangle(10,240,100,25));
	Limpar.setText("Limpar");
	Limpar.setName("limpar");
	Limpar.addActionListener(new java.awt.event.ActionListener(){
		public void actionPerformed(java.awt.event.ActionEvent e){
			txtCPF.setText("");
			txtNome.setText("");
			txtEmail.setText("");
			txtTelefone.setText("");
			txtLogin.setText("");
			txtSenha.setText("");
		}
	});
	return Limpar;
	}		
	public static void main(String[] args) {
		// TODO Auto-generated method stub
}
}
