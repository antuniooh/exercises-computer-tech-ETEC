package Aulas_Java_07_02;

public class Desempregado extends PessoaFisica{
	
	
	// atributos
		private double seguroDesemprego;
		
		// construtor com parametro
				public Desempregado(double seguroDesemprego)
				{
					this.setSeguroDesemprego(seguroDesemprego);
				}
			// construtor sem parametro
					public Desempregado()
					{
						this.setSeguroDesemprego(0.0);
					}
					public double getSeguroDesemprego() {
						return seguroDesemprego;
					}
					public void setSeguroDesemprego(double seguroDesemprego) {
						this.seguroDesemprego = seguroDesemprego;
					}
					
					public String dados(){
						
						return "Seguro Desemprego: " + getSeguroDesemprego();
					}
}
