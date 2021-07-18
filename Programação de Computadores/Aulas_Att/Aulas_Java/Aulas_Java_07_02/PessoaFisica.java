package Aulas_Java_07_02;

public class PessoaFisica {
	
	// atributos
	private String nome,sobrenome,cpf;
		
		// construtor com parametro
		public PessoaFisica(String nome, String sobrenome, String cpf)
		{
			this.setNome(nome);
			this.setSobrenome(sobrenome);
			this.setCpf(cpf);
		}
		// construtor sem parametro
				public PessoaFisica()
				{
					this.setNome("Walace");
					this.setSobrenome("Alface");
					this.setCpf("503.334.308-40");
				}
				
		// gets e sets
				public String getCpf() {
					return cpf;
				}
				public void setCpf(String cpf) {
					this.cpf = cpf;
				}
				public String getSobrenome() {
					return sobrenome;
				}
				public void setSobrenome(String sobrenome) {
					this.sobrenome = sobrenome;
				}
				public String getNome() {
					return nome;
				}
				public void setNome(String nome) {
					this.nome = nome;
				}
				
				// metodo dados
			    public String dados() {
					return "Nome: " + getNome() + "Sobrenome: " + getSobrenome() + "CPF: " + getCpf();
				}

}
