using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleVerificar
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassDados cd = new ClassDados();

            Console.Write("Digite um número :");
            cd.num = int.Parse(Console.ReadLine());
            cd.Verifica();
            Console.ReadKey();
       }
    }
}
