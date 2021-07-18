using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleVerificarExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassDados cd = new ClassDados();

            Console.Write("Digite um número :");
            cd.X = double.Parse(Console.ReadLine());
            cd.Calcular();
            Console.ReadKey();
        }
    }
}
