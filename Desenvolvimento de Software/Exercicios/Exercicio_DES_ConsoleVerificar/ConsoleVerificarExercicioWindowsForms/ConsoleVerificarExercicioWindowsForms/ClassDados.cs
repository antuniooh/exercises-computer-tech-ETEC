using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleVerificarExercicio
{
    class ClassDados
    {
       public double X { get; set; }
        /* private double X
       public double getNumero
       {
           get
           {
               return X;
           }
           set
           {
               X = value;
           }
       }
 */
       public void Calcular()
        {
          //Console.Write("A raiz quadrade de " + X.ToString() + " é "+ Math.Sqrt(X).ToString());
            MessageBox.Show("A raiz quadrade de " + X.ToString() + " é " + Math.Sqrt(X),"*** RAIZ QUADRADA ***", MessageBoxButtons.OK,MessageBoxIcon.Information);
         }
    }
}
