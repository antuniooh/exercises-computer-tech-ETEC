using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula01_ASPNET_190717
{
    public partial class Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void BtnCalcular_Click(object sender, EventArgs e)
        {
            double Valor1, Valor2 =0, Resultado =0; // Variaveis de entrada / saida - real
            Valor1 = float.Parse(TxtValor1.Text); // entrada 1
            Valor2 = float.Parse(TxtValor2.Text); // entrada 2

            if(RdnADD.Checked) //condicional 1
            {
                Resultado = Valor1 + Valor2;  // processo 1
                LblRótulo.Text = RdnADD.Text; //  saida 1
               
            }
            if (RdnSub.Checked) //condicional 2
            {
                Resultado = Valor1 - Valor2;  // processo 2
                LblRótulo.Text = RdnSub.Text; //  saida 2

            }
            if (RdnMulti.Checked) //condicional 3
            {
                Resultado = Valor1 * Valor2;  // processo 3
                LblRótulo.Text = RdnMulti.Text; //  saida 3

            }
            if (RdnDiv.Checked) //condicional 4
            {
                Resultado = Valor1 / Valor2;  // processo 4
                LblRótulo.Text = RdnDiv.Text; //  saida 4

            }
            if (RdnResto.Checked) //condicional 5
            {
                Resultado = Valor1 % Valor2;  // processo 5
                LblRótulo.Text = RdnResto.Text; //  saida 5

            }
            if (RdnPotencia.Checked) //condicional 6
            {
                Resultado = Math.Pow (Valor1 ,Valor2);  // processo 6
                LblRótulo.Text = RdnPotencia.Text; //  saida 6

            }
            if (RdnRaiz.Checked) //condicional 7
            {
                Resultado = Math.Sqrt (Valor1);  // processo 7
                LblRótulo.Text = RdnRaiz.Text; //  saida 7
                Valor2 = 0; // processo 8
            }
            LblResultado.Text = Resultado.ToString(); // saida 8
        }

        protected void RdnADD_CheckedChanged(object sender, EventArgs e)
        {
            LblRótulo.Text = RdnADD.Text; //Processo / saida
        }
        protected void ItemOpcao(object sender, EventArgs e)
        {
            if (RdnADD.Checked) LblRótulo.Text = RdnADD.Text;
            if (RdnSub.Checked) LblRótulo.Text = RdnSub.Text;
            if (RdnMulti.Checked) LblRótulo.Text = RdnMulti.Text;
            if (RdnDiv.Checked) LblRótulo.Text = RdnDiv.Text;
            if (RdnResto.Checked) LblRótulo.Text = RdnResto.Text;
            if (RdnPotencia.Checked) LblRótulo.Text = RdnPotencia.Text;
            if (RdnRaiz.Checked) LblRótulo.Text = RdnRaiz.Text;
        }

        protected void RdnPotencia_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}