
public class Pessoa {

	     // atributos
		private int codigo;
		private String nome,fone,celular;
		
		//construtor
		public Pessoa(int codigo, String nome, String fone, String celular) {
		this.codigo = codigo;
		this.nome = nome;
		this.fone = fone;
		this.celular =celular;
		}
		//métodos de acesso
		public int getCodigo() {
		return codigo;
		}
		public String getNome() {
		return nome;
		}
		public String getFone() {
		return fone;
		}
		public String getCelular() {
		return celular;
		}
		//métodos modificadores
		public void setCodigo(int codigo) {
		this.codigo = codigo;
		}
		public void setNome(String nome) {
		this.nome = nome;
		}
		public void setFone(String fone) {
		this.fone = fone;
		}
		public void setCelular(String celular) {
		this.celular = celular;
		}
}
