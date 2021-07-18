using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleVerificar
{
    class ClassDados
    {
        public int num { get; set; }
        // private int num;
       /* public int getNumero
       {
           get
           {
               return num;
           }
           set
           {
               num = value;
           }
       }
       */public void Verifica()
        {
            if (num % 2 == 0)
            {
                Console.Write("O Número " + num.ToString() + " é Par");
            }
            else
            {
                Console.Write("O Número " + num.ToString() + "é Impar");
            }
        }
    }
}
