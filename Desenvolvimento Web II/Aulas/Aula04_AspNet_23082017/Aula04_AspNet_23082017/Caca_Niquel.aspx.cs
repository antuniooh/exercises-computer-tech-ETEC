using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula04_AspNet_23082017
{
    public partial class Caca_Niquel : System.Web.UI.Page
    {
        int cont;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnGirar_Click(object sender, EventArgs e)
        {
            Random random = new Random(); // objeto random - aleatorio
            string a, b, c; // variavel(s) de entrada(s) - text(s)
            
            if (lblSaida.Text == "0")
            {
                cont = 0;
            }
            else
            {
                cont = int.Parse(lblSaida.Text);
            }
            cont++;
            lblSaida.Text = cont.ToString();

            a = Convert.ToString(Convert.ToInt32(Math.Floor(10 * random.NextDouble()))); // gerar numero random - processo 1
            lblA.Text = a; // saida 1

            b = Convert.ToString(Convert.ToInt32(Math.Floor(10 * random.NextDouble()))); // gerar numero random - processo 2
            lblB.Text = b; // saida 2

            c = Convert.ToString(Convert.ToInt32(Math.Floor(10 * random.NextDouble()))); // gerar numero random - processo 3
            lblC.Text = c; // saida 3

            if (a == "7" && b == "7" && c == "7") // condicional 1
            {
                lblSaida.Text = "do caralho mesmo NAUHR "; // saida 4
                btnGirar.Enabled = false; // processo 4


            }
        }
    }
}