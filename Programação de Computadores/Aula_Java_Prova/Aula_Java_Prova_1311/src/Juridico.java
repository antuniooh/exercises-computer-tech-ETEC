
public class Juridico extends Pessoa {

		private int cnpj;
		private String ie;
		
		//construtor
		public Juridico(int codigo, String nome, String fone, String celular, int cnpj, String ie) {
			super(codigo, nome, fone, celular);
			this.cnpj = cnpj;
			this.ie = ie;	
		}
		//métodos de acesso
		public int getCNPJ() {
		return cnpj;
		}
		public String getIE() {
		return ie;
		}

		//métodos modificadores
		public void setCNPJ(int cnpj) {
		this.cnpj = cnpj;
		}
		public void setIE(String ie) {
		this.ie = ie;
		}
}
