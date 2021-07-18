using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula03_AspNet_02082017
{
    public partial class Cronometro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConverter_Click(object sender, EventArgs e)
        {
            int Tempo, Segundos, Minutos, Horas, Resto; // Variaveis inteiras - entrada/saida

            Tempo = int.Parse(txtValor.Text); // entrada 1

            Horas = Tempo / 3600; // processo 1 - isola horas
            Resto = Tempo % 3600; // processo 2 - isola resto

            Minutos = Resto / 60; // processo 3 - isola minutos
            Segundos = Resto % 60; // processo 4 - isola segundos

            lblResultado.Text = Horas + " h " + Minutos + " m " + Segundos + " s "; // saida 1 
        }
    }
}