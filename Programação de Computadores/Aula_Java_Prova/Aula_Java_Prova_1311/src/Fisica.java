public class Fisica extends Pessoa{

	private int cpf;
	private String rg;
	
	//construtor
	public Fisica(int codigo, String nome, String fone, String celular, int cpf, String rg) {
		super(codigo, nome, fone, celular);
		this.cpf = cpf;
		this.rg = rg;	
	}
	//métodos de acesso
	public int getCPF() {
	return cpf;
	}
	public String getRG() {
	return rg;
	}

	//métodos modificadores
	public void setCPF(int cpf) {
	this.cpf = cpf;
	}
	public void setRG(String rg) {
	this.rg = rg;
	}
}
