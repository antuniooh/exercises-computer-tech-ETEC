using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EX02_Aula02_AspNet_18072017
{
    public partial class Tabuada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNCalcular_Click(object sender, EventArgs e)
        {
            int Numero, Resultado; // Variáveis de Entrada e Saída
            
            Numero = int.Parse(TXTEntrada.Text); // Entrada 1

            for (int i = 1; i <= 10; i++) // Laço 1
            {
                if (i == 0) // Condição 1
                {
                    Resultado = i * Numero; // Processo 1 
                    LBLsaída1.Text = (Numero + " x " + i + " = " + Resultado); // Saída 1
                }
                  if (i == 1) // Condição 2
                {
                      Resultado = i * Numero; // Processo 2
                      LBLsaída2.Text = (Numero + " x " + i + " = " + Resultado); // Saída 2
                }
                  if (i == 2) // Condição 3
                {
                      Resultado = i * Numero; // Processo 3
                      LBLsaída3.Text = (Numero + " x " + i + " = " + Resultado); // Saída 3
                } 
                if (i == 3) // Condição 4
                {
                    Resultado = i * Numero; // Processo 4 
                    LBLsaída4.Text = (Numero + " x " + i + " = " + Resultado); // Saída 4
                }
                  if (i == 4) // Condição 5
                {
                      Resultado = i * Numero; // Processo 5
                      LBLsaída5.Text = (Numero + " x " + i + " = " + Resultado); // Saída 5
                }
                  if (i == 5) // Condição 6
                {
                      Resultado = i * Numero; // Processo 6
                      LBLsaída6.Text = (Numero + " x " + i + " = " + Resultado); // Saída 6
                }
                  if (i == 6) // Condição 7
                {
                      Resultado = i * Numero; // Processo 7
                      LBLsaída7.Text = (Numero + " x " + i + " = " + Resultado); // Saída 7
                }
                  if (i == 7) // Condição 8
                {
                      Resultado = i * Numero; // Processo 8
                      LBLsaída8.Text = (Numero + " x " + i + " = " + Resultado); // Saída 8
                }
                  if (i == 8) // Condição 9
                {
                      Resultado = i * Numero; // Processo 9
                      LBLsaída9.Text = (Numero + " x " + i + " = " + Resultado); // Saída 9
                }
                  if (i == 9) // Condição 10
                {
                      Resultado = i * Numero; // Processo 10 
                      LBLsaída10.Text = (Numero + " x " + i + " = " + Resultado); // Saída 10
                }
                  if (i == 10) // Condição 11
                {
                      Resultado = i * Numero; // Processo 11 
                      LBLsaída11.Text = (Numero + " x " + i + " = " + Resultado); // Saída 11
                }
            }

        }
    }
}