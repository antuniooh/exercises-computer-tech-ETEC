using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula04_AspNet_23082017
{
    public partial class Sortear_Imagem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSortear_Click(object sender, EventArgs e)
        {
            Random foto = new Random(); // obj randomico - alatorio
            int a; // variavel de entrada
            a = Convert.ToInt32(Math.Floor(8 * foto.NextDouble())); // processo 1

            imgSortear.ImageUrl = "Imagem/Figura" + a + ".jpg"; //saida
        }
    }
}