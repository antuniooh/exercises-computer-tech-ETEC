using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula01_ASPNET_190717
{
    public partial class Tabuada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            int Numero, Resultado; // Variaveis Entrada e Saida

            Numero = int.Parse(txtEntrada.Text); // Entrada 1

            for (int i = 0; i <= 10; i++)// laço 1
            {
                if (i == 0) // Condição 1
                {
                    Resultado = i * Numero; // Processo 1
                    LblSaida1.Text = (Numero + " x " + i + " = " + Resultado); // Saida 1
                }
                if (i == 1) // Condição 2
                {
                    Resultado = i * Numero; // Processo 2
                    LblSaida2.Text = (Numero + " x " + i + " = " + Resultado); // Saida 2
                }
                if (i == 2) // Condição 3
                {
                    Resultado = i * Numero; // Processo 3
                    LblSaida3.Text = (Numero + " x " + i + " = " + Resultado); // Saida 3
                }
                if (i == 3) // Condição 4
                {
                    Resultado = i * Numero; // Processo 4
                    LblSaida4.Text = (Numero + " x " + i + " = " + Resultado); // Saida 4
                }
                if (i == 4) // Condição 5
                {
                    Resultado = i * Numero; // Processo 5
                    LblSaida5.Text = (Numero + " x " + i + " = " + Resultado); // Saida 5
                }
                if (i == 5) // Condição 6
                {
                    Resultado = i * Numero; // Processo 6
                    LblSaida6.Text = (Numero + " x " + i + " = " + Resultado); // Saida 6
                }
                if (i == 6) // Condição 7
                {
                    Resultado = i * Numero; // Processo 7
                    LblSaida7.Text = (Numero + " x " + i + " = " + Resultado); // Saida 7
                }
                if (i == 7) // Condição 8
                {
                    Resultado = i * Numero; // Processo 8
                    LblSaida8.Text = (Numero + " x " + i + " = " + Resultado); // Saida 8
                }
                if (i == 8) // Condição 9
                {
                    Resultado = i * Numero; // Processo 9
                    LblSaida9.Text = (Numero + " x " + i + " = " + Resultado); // Saida 9
                }

                if (i == 9) // Condição 10
                {
                    Resultado = i * Numero; // Processo 10
                    LblSaida10.Text = (Numero + " x " + i + " = " + Resultado); // Saida 10
                }
                if (i == 10) // Condição 11
                {
                    Resultado = i * Numero; // Processo 11
                    LblSaida11.Text = (Numero + " x " + i + " = " + Resultado); // Saida 11
                }
            }
        }
    }
}