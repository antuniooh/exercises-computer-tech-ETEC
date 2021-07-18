import java.awt.Container;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JTextField;

public class CadastroCliente extends JFrame implements ActionListener{

	private JTextField txtCodigo, txtNome, txtFone, txtCelular, txtTipoPessoa, txtCPF_CNPJ, txtRG_IE;
    private JButton btnSalvar, btnLimpar, btnSair;
    private JLabel Codigo, Nome, Fone, Celular, TipoPessoa, CPF_CNPJ, RG_IE;
    
    public CadastroCliente(){
       super("Interface");
       
       txtCodigo = new JTextField(" ");
       txtNome = new JTextField(" ");
       txtFone = new JTextField(" ");
       txtCelular = new JTextField(" ");
       txtTipoPessoa = new JTextField(" ");
       txtCPF_CNPJ = new JTextField(" ");
       txtRG_IE = new JTextField(" ");
       
       btnSalvar = new JButton("Salvar");
       btnLimpar = new JButton("Limpar");
       btnSair = new JButton("Sair");
       
       Codigo = new JLabel("Código: ");
       Nome = new JLabel("Nome: ");
       Fone = new JLabel("Telefone: ");
       Celular = new JLabel("Celular: ");
       TipoPessoa = new JLabel("Tipo de pessoa: ");
       CPF_CNPJ = new JLabel("CPF/CNPJ: ");
       RG_IE = new JLabel("RG/I.E: ");    
       
       Container caixa = getContentPane();
       caixa.setLayout(new GridLayout(5,3));
       
       caixa.add(Codigo);
       caixa.add(txtCodigo);
       caixa.add(Nome);
       caixa.add(txtNome);
       caixa.add(Fone);
       caixa.add(txtFone);
       caixa.add(Celular);
       caixa.add(txtCelular);
       caixa.add(TipoPessoa);
       caixa.add(txtTipoPessoa);
       caixa.add(CPF_CNPJ);
       caixa.add(txtCPF_CNPJ);
       caixa.add(RG_IE);
       caixa.add(txtRG_IE);
       caixa.add(btnSalvar);
       caixa.add(btnLimpar);
       caixa.add(btnSair);
       
       btnSalvar.addActionListener(this);
       btnLimpar.addActionListener(this);
       btnSair.addActionListener(this);
       
       setSize(500,500);
       setLocationRelativeTo(null);
       setVisible(true);
       setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);  
    }
    public void actionPerformed(ActionEvent e)
    {
       if (e.getSource()==btnSalvar)
       {
    	  String sText = txtTipoPessoa.getText();
    	  
    	  if(sText.equals("Física"))
    	  {
    		  int Codigo = Integer.parseInt(txtCodigo.getText());
    		  String Nome = txtNome.getText();
    		  String Fone = txtFone.getText();
    		  String Celular = txtCelular.getText();
    		  int CPF = Integer.parseInt(txtCPF_CNPJ.getText());
    		  String RG = txtRG_IE.getText();
    		  
    		  Fisica f = new Fisica(Codigo, Nome, Fone, Celular,CPF, RG);
    	  
    		 JOptionPane.showMessageDialog(null,"Pessoa Física: " 
        			+ "\nCódigo: " + f.getCodigo() 
        			+ "\nNome: " + f.getNome() 
        			+ "\nFone: " + f.getFone() 
        			+ "\nCelular: " + f.getCelular()
        			+ "\nCNPJ: " + f.getCPF()
        			+ "\nI.E: " + f.getRG());
    	  }
    	 
          if(sText.equals("Jurídica"))
    	  {
    		  int Codigo = Integer.parseInt(txtCodigo.getText());
    		  String Nome = txtNome.getText();
    		  String Fone = txtFone.getText();
    		  String Celular = txtCelular.getText();
    		  int CNPJ = Integer.parseInt(txtCPF_CNPJ.getText());
    		  String IE = txtRG_IE.getText();
    		  Juridico j = new Juridico(Codigo, Nome, Fone, Celular,CNPJ, IE);
    	  
          JOptionPane.showMessageDialog(null,"Pessoa Juridica: " 
        			+ "\nCódigo: " + j.getCodigo() 
        			+ "\nNome: " + j.getNome() 
        			+ "\nFone: " + j.getFone() 
        			+ "\nCelular: " + j.getCelular()
        			+ "\nCNPJ: " + j.getCNPJ()
        			+ "\nIE: " + j.getIE());
    	  }  
    	  
       }
       if(e.getSource()==btnLimpar)
       {
          txtCodigo.setText("");     
          txtNome.setText("");  
          txtFone.setText("");  
          txtCelular.setText("");  
          txtTipoPessoa.setText("");  
          txtCPF_CNPJ.setText("");  
          txtRG_IE.setText("");  
       }
        if(e.getSource()==btnSair)
       {
    	   System.exit(0);
       }
}
}


