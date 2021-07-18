
public class Novo {

	    // criou os atributos
		private double valorAdicional;
		private Imovel imovel;

		//metodo construtor
		public Novo(double va, Imovel i)
		{
			valorAdicional = va;
			imovel = i;
		}
		// metodos modificadores
		public void setValorAdicional(double va)
		{
			this.valorAdicional = va;
		}
		public void setImovel(Imovel i)
		{
			this.imovel = i;
		}
		
		//metodos acessores
		public double getValorAdicional()
		{
			return valorAdicional;
		}
		public Imovel getImovel()
		{
			return imovel;
		}
		
		// metodo soma
		public double Calcular(double total)
		{
			total = (imovel.getValor() + valorAdicional);
			return total;
		}
		
		//metodo getDados
		public String getDados()
		{
			return "Novo [Imovel=" + imovel + "\n Valor Adicional=" + valorAdicional +"]";
		}
}
