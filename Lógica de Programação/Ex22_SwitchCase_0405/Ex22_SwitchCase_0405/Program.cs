using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22_SwitchCase_0405
{
    class Program
    {

        public static void linha()
        {
            for (int x = 1; x <= 70; x++)
            {
                Console.Write("=");
            }
        }


        static void Main(string[] args)
        {
            int opcao; // variavel - inteira entrada
            Console.Clear(); // Limpar Tela

            linha(); // processo 1 - chama o metodo
            Console.WriteLine("\nQual Linguagem Você programa? Escolha entre 1 e 6:"); // Entrada 1
            linha(); // Processo 2 - chama o metodo

            Console.WriteLine("\n1 - C#");
            Console.WriteLine("2 - Java");
            Console.WriteLine("3 - Asp.Net");
            Console.WriteLine("4 - PHP");
            Console.WriteLine("5 - C++");
            Console.WriteLine("6 - Outras");

            linha();

            try
            {
                Console.WriteLine("\nOpção[]");
                Console.SetCursorPosition(7, 10);
                opcao = int.Parse(Console.ReadLine());
                linha();
                Console.WriteLine();
                switch (opcao)
                {
                    case 1: Console.WriteLine("Você Programa no C#"); break;
                    case 2: Console.WriteLine("Você Programa no Java"); break;
                    case 3: Console.WriteLine("Você Programa no Asp.Net"); break;
                    case 4: Console.WriteLine("Você Programa no PHP"); break;
                    case 5: Console.WriteLine("Você Programa no C++"); break;
                    case 6: Console.WriteLine("Você Programa em outra Linguagem"); break;
                    default: Console.WriteLine("Opção Inválida, Digite entre 1 e 6"); break;
                }
                linha();
            }
            catch (Exception)
            {
                linha();
                Console.WriteLine("\nDigite apenas Números!!!");
                linha();
            }
            Console.ReadLine();
        }
    }
}
