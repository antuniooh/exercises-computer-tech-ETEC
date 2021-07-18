using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula04_AspNet_23082017
{
    public partial class Timer_Noticia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Controle_Tick(object sender, EventArgs e)
        {
            int n = new Random().Next(0, 7); // cria obj random com parametros
            string[] arrNoticias = new string[8]; // Arrary noticias

            arrNoticias[0] = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            arrNoticias[1] = "YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY";
            arrNoticias[2] = "ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ";
            arrNoticias[3] = "44444444444444444444444444444444444444444444444444444444444";
            arrNoticias[4] = "55555555555555555555555555555555555555555555555555555555555";
            arrNoticias[5] = "66666666666666666666666666666666666666666666666666666666666";
            arrNoticias[6] = "77777777777777777777777777777777777777777777777777777777777";
            arrNoticias[7] = "88888888888888888888888888888888888888888888888888888888888";

            LblNoticia.Text = arrNoticias[n]; // saida 1
            ImgNoticia.ImageUrl = "Imagem/Figura" + n + ".jpg"; // saida 2


        }
    }
}