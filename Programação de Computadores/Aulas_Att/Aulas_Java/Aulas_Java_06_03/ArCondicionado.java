package Aulas_Java_06_03;

public class ArCondicionado {
	
	//atributos
	private boolean ligado;
	private Termostato termostato;
	
	//construtor
	public ArCondicionado() {
    this.termostato = new Termostato();
    ligado = false;
   }
	
	//m�todos de acesso
	public boolean getLigado() {
	return ligado;
	}
	public Termostato getTermostato() {
	return termostato;
	}
	
	// metodos ligar e desligar e aumentar e reduzir temperatura
	
	public void ligar()
	{
	   ligado = true;
	   System.out.println("o termostato est� ligado");	
	}
	public void desligar()
	{
		ligado = false;
		System.out.println("o termostato est� desligado");	
	}
	
	public void aumentarTemperatura()
	{
		if(ligado == false)
		{
			System.out.println("N�o � possivel aumentar a temepratura, est� desligado o termostato");	
		}
		else
		{
		     if(termostato.getTemperatura() == 28)
	     	{
	    	System.out.println("N�o � possivel aumentar mais a temepratura, atingiu-se o limite");	
		    }
		    else
		    {
	     	termostato.setTemperatura(termostato.getTemperatura() + 1);
	     	System.out.println("Temperatura atual " + termostato.getTemperatura());	
	        }
		}
	}
	public void reduzirTemperatura()
	{
		if(ligado == false)
		{
			System.out.println("N�o � possivel aumentar a temepratura, est� desligado o termostato");	
		}
		else
		{
		if(termostato.getTemperatura() == 15)
		{
		System.out.println("N�o � possivel reduzir mais a temepratura, atingiu-se o limite");	
		}
		else
		{
		termostato.setTemperatura(termostato.getTemperatura() - 1);
		System.out.println("Temperatura atual " + termostato.getTemperatura());	
	    }
		}
	}
	public void imprimirTemperatura()
	{
		System.out.println("Temperatura atual " + termostato.getTemperatura());	
	}
	}
