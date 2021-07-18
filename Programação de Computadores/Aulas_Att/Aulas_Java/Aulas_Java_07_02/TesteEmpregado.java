package Aulas_Java_07_02;
 public class TesteEmpregado{
   public static void main(String[] args){	    	  
	   
	   Horista h = new Horista("Joao da Silva",12.0, 150);
      System.out.println(h.toString());
      
      Tarefeiro t = new Tarefeiro("Joao da Silva",15.0, 150);
      System.out.println(t.toString());
      
      Mensalista m = new Mensalista("Joao da Silva",150.0);
      System.out.println(m.toString());

   }
}
