using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0; // declarando variavel
            int y = 0;

            try
            {
                Console.Write("Entre com o 1º número ");
                x = int.Parse(Console.ReadLine()); // covertendo pra REAL pra 10+10=20. Sem isso 10+10=1010

                Console.Write("Entre com o 2º número ");
                y = int.Parse(Console.ReadLine());

                Console.Write("A Soma dos Números : " + (x + y));

               
            }
            catch (Exception erro) // Menssagem de Erro
            {
                Console.Write("Digite somente números\n\n" + erro.Message); // o \n pula linha e mostra a mengem em inglês
            }
            finally
            {
                Console.Write("\n\n********** FIM DE EXECUÇAO **********");
                Console.ReadLine(); // faz o programa ficar aberto para ver a resposta, se não ele mostra e fecha muito rápido
            }

        }
    }
}
