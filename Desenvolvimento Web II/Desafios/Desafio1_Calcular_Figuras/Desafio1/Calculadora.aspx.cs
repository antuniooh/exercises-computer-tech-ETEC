using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Desafio1
{
    public partial class Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtAltura.Visible = true;
            lblAltura.Visible = true;
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            double Base = 0, Resultado = 0; // Variaveis de entrada / saida - real
            Base = float.Parse(txtBase.Text); // entrada 1
            
            if (rdnQuadrado.Checked) //condicional 1
            {

                if (rdnArea.Checked) //condicional 2
                {
                    Resultado = Base * Base;  // processo 1
                    lblRotulo.Text = rdnQuadrado.Text; //  saida 1
                }
                if (rdnPerimetro.Checked) //condicional 1
                {
                    Resultado = Base * 4;  // processo 1
                    lblRotulo.Text = rdnQuadrado.Text; //  saida 1
                }
            }


            if (rdnRetangulo.Checked) //condicional 1
            {
                double Altura = 0;
                Altura = double.Parse(txtAltura.Text);

                if (rdnArea.Checked) //condicional 2
                {
                    Resultado = Base * Altura;  // processo 1
                    lblRotulo.Text = rdnRetangulo.Text; //  saida 1
                }
                if (rdnPerimetro.Checked) //condicional 1
                {
                    Resultado = (Base * 2) + (Altura * 2);  // processo 1
                    lblRotulo.Text = rdnRetangulo.Text; //  saida 1
                }
            }


            if (rdnTriangulo.Checked) //condicional 1
            {
                double Altura = 0;
                Altura = double.Parse(txtAltura.Text);
                if (rdnArea.Checked) //condicional 2
                {
                    Resultado = (Base * Altura) / 2;  // processo 1
                    lblRotulo.Text = rdnQuadrado.Text; //  saida 1
                }
                if (rdnPerimetro.Checked) //condicional 1
                {
                    Resultado = Base * 3;  // processo 1
                    lblRotulo.Text = rdnRetangulo.Text; //  saida 1
                }
            }

            if (rdnParalelograma.Checked) //condicional 1
            {
                double Altura = 0;
                Altura = double.Parse(txtAltura.Text);
                if (rdnArea.Checked) //condicional 2
                {
                    Resultado = (Base * Altura) / 2;  // processo 1
                    lblRotulo.Text = rdnParalelograma.Text; //  saida 1
                }
                if (rdnPerimetro.Checked) //condicional 1
                {
                    Resultado = (Base * 2) + (Altura * 2);  // processo 1
                    lblRotulo.Text = rdnParalelograma.Text; //  saida 1
                }
            }
            txtResultado.Text = Resultado.ToString(); // saida 
        }

        protected void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        protected void rdnQuadrado_CheckedChanged(object sender, EventArgs e)
        {
            txtAltura.Visible = false;
            lblAltura.Visible = false;
        }

        protected void rdnTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            txtAltura.Visible = true;
            lblAltura.Visible = true;
        }

        protected void rdnParalelograma_CheckedChanged(object sender, EventArgs e)
        {
            txtAltura.Visible = true;
            lblAltura.Visible = true;
        }
    }
}