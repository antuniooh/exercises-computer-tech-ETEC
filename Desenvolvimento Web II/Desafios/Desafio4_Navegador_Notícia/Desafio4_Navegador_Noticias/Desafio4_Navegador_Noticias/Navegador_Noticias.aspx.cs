using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Desafio4_Navegador_Noticias
{
    public partial class Navegador_Noticias : System.Web.UI.Page
    {
           

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVoltar2_Click(object sender, EventArgs e)
        {
            string[] arrNoticias = new string[5]; // Arrary noticias

            arrNoticias[0] = "NOTICIA 01";
            arrNoticias[1] = "NOTICIA 02";
            arrNoticias[2] = "NOTICIA 03";
            arrNoticias[3] = "NOTICIA 04";
            arrNoticias[4] = "NOTICIA 05";

            txtNoticia.Text = arrNoticias[0];
            ImgNoticia.ImageUrl = "Figura" + 0 + ".jpg";
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string[] arrNoticias = new string[5]; // Arrary noticias

            arrNoticias[0] = "NOTICIA 01";
            arrNoticias[1] = "NOTICIA 02";
            arrNoticias[2] = "NOTICIA 03";
            arrNoticias[3] = "NOTICIA 04";
            arrNoticias[4] = "NOTICIA 05";

            txtNoticia.Text = arrNoticias[2];
            ImgNoticia.ImageUrl = "Figura" + 2 + ".jpg";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] arrNoticias = new string[5]; // Arrary noticias

            arrNoticias[0] = "NOTICIA 01";
            arrNoticias[1] = "NOTICIA 02";
            arrNoticias[2] = "NOTICIA 03";
            arrNoticias[3] = "NOTICIA 04";
            arrNoticias[4] = "NOTICIA 05";

            txtNoticia.Text = arrNoticias[0];
            ImgNoticia.ImageUrl = "Figura" + 0 + ".jpg";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string[] arrNoticias = new string[5]; // Arrary noticias

            arrNoticias[0] = "NOTICIA 01";
            arrNoticias[1] = "NOTICIA 02";
            arrNoticias[2] = "NOTICIA 03";
            arrNoticias[3] = "NOTICIA 04";
            arrNoticias[4] = "NOTICIA 05";

            txtNoticia.Text = arrNoticias[1];
            ImgNoticia.ImageUrl = "Figura" + 1 + ".jpg";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string[] arrNoticias = new string[5]; // Arrary noticias

            arrNoticias[0] = "NOTICIA 01";
            arrNoticias[1] = "NOTICIA 02";
            arrNoticias[2] = "NOTICIA 03";
            arrNoticias[3] = "NOTICIA 04";
            arrNoticias[4] = "NOTICIA 05";

            txtNoticia.Text = arrNoticias[3];
            ImgNoticia.ImageUrl = "Figura" + 3 + ".jpg";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string[] arrNoticias = new string[5]; // Arrary noticias

            arrNoticias[0] = "NOTICIA 01";
            arrNoticias[1] = "NOTICIA 02";
            arrNoticias[2] = "NOTICIA 03";
            arrNoticias[3] = "NOTICIA 04";
            arrNoticias[4] = "NOTICIA 05";

            txtNoticia.Text = arrNoticias[4];
            ImgNoticia.ImageUrl = "Figura" + 4 + ".jpg";
        }

        protected void btnAvançar2_Click(object sender, EventArgs e)
        {
            string[] arrNoticias = new string[5]; // Arrary noticias

            arrNoticias[0] = "NOTICIA 01";
            arrNoticias[1] = "NOTICIA 02";
            arrNoticias[2] = "NOTICIA 03";
            arrNoticias[3] = "NOTICIA 04";
            arrNoticias[4] = "NOTICIA 05";

            txtNoticia.Text = arrNoticias[4];
            ImgNoticia.ImageUrl = "Figura" + 4 + ".jpg";
        }
    }
}