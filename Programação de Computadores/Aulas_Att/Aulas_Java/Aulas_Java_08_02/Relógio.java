package Aulas_Java_08_02;

public class Relógio {

	public Mostrador hora;
	public Mostrador minuto;
	public String mostrador;
	
	public Relógio() {	
		hora = new Mostrador(24);
		minuto = new Mostrador(60);
		atualizaMostrador();
	}
	public void ticTac() 
	{
		minuto.incrementa();
		
	   if(minuto.getValor()==0)
		{
			hora.incrementa();
		}
		atualizaMostrador();
	}
	public void minuto() 
	{		
	   if(minuto.getValor() >= 0 && minuto.getValor() < 60)
		{
			minuto.incrementa();
		}
		atualizaMostrador();
	}
	public void hora() 
	{		
	   if(hora.getValor() >= 0 && hora.getValor() < 24)
		{
			hora.incrementa();
		}
		atualizaMostrador();
	}
	
	private void atualizaMostrador()
	{
		mostrador = hora.mostra() + ":" + minuto.mostra();		
	}
	
	public String mostra() 
	{
		return mostrador;
	}
	
}
