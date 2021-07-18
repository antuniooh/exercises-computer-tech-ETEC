using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula03_AspNet_09082017
{
    public partial class Matriz_Venda : System.Web.UI.Page
    {
        int[,] ProdVend = new int[4,5]; // matriz math three XXX four
        protected void Page_Load(object sender, EventArgs e)
        {
            ProdVend[1, 1] = 14;
            ProdVend[1, 2] = 10;
            ProdVend[1, 3] = 13;
            ProdVend[1, 4] = 17;

            ProdVend[2, 1] = 9;
            ProdVend[2, 2] = 13;
            ProdVend[2, 3] = 15;
            ProdVend[2, 4] = 12;

            ProdVend[3, 1] = 11;
            ProdVend[3, 2] = 18;
            ProdVend[3, 3] = 14;
            ProdVend[3, 4] = 16;
        }

        protected void btnTotalVendedor_Click(object sender, EventArgs e)
        {
            int NumVend; // Numero Vendedor
            int Soma = 0; // Numero soma vendido

            NumVend = int.Parse(txtVendedor.Text); // Entrada

            if (NumVend <= 3 && NumVend >= 1) // condicional 1
            {
                for (int i = 1; i <= 4; i++) // laço 1
                {
                    Soma = Soma + ProdVend[NumVend, i]; // processo 1
                }
                lblResultado.Text = "O vendedor: " + NumVend + " vendeu " + Soma; // 
            }
            else // negaçaõ
            {
                lblResultado.Text = " Digite um número de vendedor valido"; //
            }
        }

        protected void btnTotalProduto_Click(object sender, EventArgs e)
        {
            int NumProd; // Numero produtor
            int Soma = 0; // Numero soma produtor

            NumProd = int.Parse(txtProduto.Text); // Entrada

            if (NumProd <= 4 && NumProd >= 1) // condicional 1
            {
                for (int j = 1; j <= 4; j++) // laço 1
                {
                    Soma = Soma + ProdVend[j, NumProd]; // processo 1
                }
                lblResultado.Text = "O vendedor: " + NumProd + " vendeu " + Soma; // 
            }
            else // negaçaõ
            {
                lblResultado.Text = " Digite um número de vendedor valido"; //
            }
        }

        protected void btnTotalV_Click(object sender, EventArgs e)
        {
            int NumTotal;
            int Soma = 0;

            NumTotal = Soma + ProdVend[1, 1] + ProdVend[1, 2] +   ProdVend[1, 3] + ProdVend[1, 4] +
            ProdVend[2, 1] + ProdVend[2, 2] + ProdVend[2, 3] + ProdVend[2, 4] + ProdVend[3, 1] +
            ProdVend[3, 2] + ProdVend[3, 3] + ProdVend[3, 4] ;

            lblResultado.Text = "Venda total : " + NumTotal; 

        }
    }
}