using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DIV_Noticia
{
    public partial class Noticias : System.Web.UI.Page
    {

        
        
        protected void Page_Load(object sender, EventArgs e)
        {

            LblTitulo.Text = "Brasil ganha a primeira escola austríaca";
            LblNoticia.Text = "Ontem foi inaugurada a primeira escola de pensamento com base no liberalismo economico, ou seja com base na Escola Austríaca, e principal membro Ludwvig Von Mises(foto)";
           
        }

        protected void BtnInicial_Click(object sender, EventArgs e)
        {

            Label1.Text = "0";
            Image1.ImageUrl = "Imagens/Figura" + Label1.Text + ".jpg";
            switch (Label1.Text)
            {
                case "0":
                   LblTitulo.Text = "Brasil ganha a primeira escola austríaca";
                    LblNoticia.Text = "Ontem foi inaugurada a primeira escola de pensamento com base no liberalismo economico, ou seja com base na Escola Austríaca, e principal membro Ludwvig Von Mises(foto)";
                    break;
                case "1":
                   LblTitulo.Text = "Cristiano Roanldo sofre suspensão!";
                    LblNoticia.Text = "Após suposta agressão em árbitro, o jogador Cristiano Ronaldo sofreu um suspensão de cinco jogos, o que o deixará muita atrás na competição ";
                    break;
                case "2":
                    LblTitulo.Text = "Revogado Estatuto do Desarmamento ";
                    LblNoticia.Text = "Esta semana foi revogado o Estatuto do Desarmamento, em declaração dos que defenderam a aprovação, é citado que o cidadão poderá defender a si e a sua família, ainda há muita controversa sobre o tema";
                    break;
                case "3":
                     LblTitulo.Text = "São Bernardo do Campo";
                     LblNoticia.Text = "Segundo o IBGE, a cidade de São bernardo do Campo tem o quinto maior PIB do País";
                    break;
                case "4":
                    LblTitulo.Text = "Anunciado terceiro filme de Thor";
                    LblNoticia.Text = "No dia 26 de Outubro, chegará aos telões o mais novo filme do super heroi: 'Thor: Ragnarok'";
                    break;
            }
            
       
        }

        protected void BtnAnterior_Click(object sender, EventArgs e)
        {

            
            if (Label1.Text == "0")
            {
                Label1.Text = "4";    
            }
            else
            {
                int numero = int.Parse(Label1.Text);
                Label1.Text = (numero-1).ToString();
            }
            Image1.ImageUrl = "Imagens/Figura" + Label1.Text + ".jpg";

            switch (Label1.Text)
            {
                case "0":
                    LblTitulo.Text = "Brasil ganha a primeira escola austríaca";
                    LblNoticia.Text = "Ontem foi inaugurada a primeira escola de pensamento com base no liberalismo economico, ou seja com base na Escola Austríaca, e principal membro Ludwvig Von Mises(foto)";
                    break;
                case "1":
                    LblTitulo.Text = "Cristiano Roanldo sofre suspensão!";
                    LblNoticia.Text = "Após suposta agressão em árbitro, o jogador Cristiano Ronaldo sofreu um suspensão de cinco jogos, o que o deixará muita atrás na competição ";
                    break;
                case "2":
                    LblTitulo.Text = "Revogado Estatuto do Desarmamento ";
                    LblNoticia.Text = "Esta semana foi revogado o Estatuto do Desarmamento, em declaração dos que defenderam a aprovação, é citado que o cidadão poderá defender a si e a sua família, ainda há muita controversa sobre o tema";
                    break;
                case "3":
                    LblTitulo.Text = "São Bernardo do Campo";
                    LblNoticia.Text = "Segundo o IBGE, a cidade de São bernardo do Campo tem o quinto maior PIB do País";
                    break;
                case "4":
                    LblTitulo.Text = "Anunciado terceiro filme de Thor";
                    LblNoticia.Text = "No dia 26 de Outubro, chegará aos telões o mais novo filme do super heroi: 'Thor: Ragnarok'";
                    break;
            }

        }

        protected void BtnPosterior_Click(object sender, EventArgs e)
        {

            if (Label1.Text != "4")
            {
                int numero = int.Parse(Label1.Text);
                Label1.Text = (numero + 1).ToString();

            }
            else
            {
                Label1.Text = "0";
            }
            Image1.ImageUrl = "Imagens/Figura" + Label1.Text + ".jpg";

            switch (Label1.Text)
            {
                c                case "0":
                   LblTitulo.Text = "Brasil ganha a primeira escola austríaca";
                    LblNoticia.Text = "Ontem foi inaugurada a primeira escola de pensamento com base no liberalismo economico, ou seja com base na Escola Austríaca, e principal membro Ludwvig Von Mises(foto)";
                    break;
                case "1":
                   LblTitulo.Text = "Cristiano Roanldo sofre suspensão!";
                    LblNoticia.Text = "Após suposta agressão em árbitro, o jogador Cristiano Ronaldo sofreu um suspensão de cinco jogos, o que o deixará muita atrás na competição ";
                    break;
                case "2":
                    LblTitulo.Text = "Revogado Estatuto do Desarmamento ";
                    LblNoticia.Text = "Esta semana foi revogado o Estatuto do Desarmamento, em declaração dos que defenderam a aprovação, é citado que o cidadão poderá defender a si e a sua família, ainda há muita controversa sobre o tema";
                    break;
                case "3":
                     LblTitulo.Text = "São Bernardo do Campo";
                     LblNoticia.Text = "Segundo o IBGE, a cidade de São bernardo do Campo tem o quinto maior PIB do País";
                    break;
                case "4":
                    LblTitulo.Text = "Anunciado terceiro filme de Thor";
                    LblNoticia.Text = "No dia 26 de Outubro, chegará aos telões o mais novo filme do super heroi: 'Thor: Ragnarok'";
                    break;
            }
            

        }

        protected void BtnFinal_Click(object sender, EventArgs e)
        {
            Label1.Text = "4";
            Image1.ImageUrl = "Imagens/Figura" + Label1.Text +".jpg";

            switch (Label1.Text)
            {
                case "0":
                    LblTitulo.Text = "Brasil ganha a primeira escola austríaca";
                    LblNoticia.Text = "Ontem foi inaugurada a primeira escola de pensamento com base no liberalismo economico, ou seja com base na Escola Austríaca, e principal membro Ludwvig Von Mises(foto)";
                    break;
                case "1":
                    LblTitulo.Text = "Cristiano Roanldo sofre suspensão!";
                    LblNoticia.Text = "Após suposta agressão em árbitro, o jogador Cristiano Ronaldo sofreu um suspensão de cinco jogos, o que o deixará muita atrás na competição ";
                    break;
                case "2":
                    LblTitulo.Text = "Revogado Estatuto do Desarmamento ";
                    LblNoticia.Text = "Esta semana foi revogado o Estatuto do Desarmamento, em declaração dos que defenderam a aprovação, é citado que o cidadão poderá defender a si e a sua família, ainda há muita controversa sobre o tema";
                    break;
                case "3":
                    LblTitulo.Text = "São Bernardo do Campo";
                    LblNoticia.Text = "Segundo o IBGE, a cidade de São bernardo do Campo tem o quinto maior PIB do País";
                    break;
                case "4":
                    LblTitulo.Text = "Anunciado terceiro filme de Thor";
                    LblNoticia.Text = "No dia 26 de Outubro, chegará aos telões o mais novo filme do super heroi: 'Thor: Ragnarok'";
                    break;
            }
           
            
        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            Label1.Text = "0";
            Image1.ImageUrl = "Imagens/Figura" + Label1.Text +".jpg";

            switch (Label1.Text)
            {
                case "0":
                    LblTitulo.Text = "Brasil ganha a primeira escola austríaca";
                    LblNoticia.Text = "Ontem foi inaugurada a primeira escola de pensamento com base no liberalismo economico, ou seja com base na Escola Austríaca, e principal membro Ludwvig Von Mises(foto)";
                    break;
                case "1":
                    LblTitulo.Text = "Cristiano Roanldo sofre suspensão!";
                    LblNoticia.Text = "Após suposta agressão em árbitro, o jogador Cristiano Ronaldo sofreu um suspensão de cinco jogos, o que o deixará muita atrás na competição ";
                    break;
                case "2":
                    LblTitulo.Text = "Revogado Estatuto do Desarmamento ";
                    LblNoticia.Text = "Esta semana foi revogado o Estatuto do Desarmamento, em declaração dos que defenderam a aprovação, é citado que o cidadão poderá defender a si e a sua família, ainda há muita controversa sobre o tema";
                    break;
                case "3":
                    LblTitulo.Text = "São Bernardo do Campo";
                    LblNoticia.Text = "Segundo o IBGE, a cidade de São bernardo do Campo tem o quinto maior PIB do País";
                    break;
                case "4":
                    LblTitulo.Text = "Anunciado terceiro filme de Thor";
                    LblNoticia.Text = "No dia 26 de Outubro, chegará aos telões o mais novo filme do super heroi: 'Thor: Ragnarok'";
                    break;
            }
        }

        protected void Btn2_Click(object sender, EventArgs e)
        {
            Label1.Text  = "1";
            Image1.ImageUrl = "Imagens/Figura" + Label1.Text  +".jpg";

            switch (Label1.Text)
            {
                case "0":
                    LblTitulo.Text = "Brasil ganha a primeira escola austríaca";
                    LblNoticia.Text = "Ontem foi inaugurada a primeira escola de pensamento com base no liberalismo economico, ou seja com base na Escola Austríaca, e principal membro Ludwvig Von Mises(foto)";
                    break;
                case "1":
                    LblTitulo.Text = "Cristiano Roanldo sofre suspensão!";
                    LblNoticia.Text = "Após suposta agressão em árbitro, o jogador Cristiano Ronaldo sofreu um suspensão de cinco jogos, o que o deixará muita atrás na competição ";
                    break;
                case "2":
                    LblTitulo.Text = "Revogado Estatuto do Desarmamento ";
                    LblNoticia.Text = "Esta semana foi revogado o Estatuto do Desarmamento, em declaração dos que defenderam a aprovação, é citado que o cidadão poderá defender a si e a sua família, ainda há muita controversa sobre o tema";
                    break;
                case "3":
                    LblTitulo.Text = "São Bernardo do Campo";
                    LblNoticia.Text = "Segundo o IBGE, a cidade de São bernardo do Campo tem o quinto maior PIB do País";
                    break;
                case "4":
                    LblTitulo.Text = "Anunciado terceiro filme de Thor";
                    LblNoticia.Text = "No dia 26 de Outubro, chegará aos telões o mais novo filme do super heroi: 'Thor: Ragnarok'";
                    break;
            }

        }

        protected void Btn3_Click(object sender, EventArgs e)
        {
            Label1.Text = "2";
            Image1.ImageUrl = "Imagens/Figura" + Label1.Text + ".jpg";

            switch (Label1.Text)
            {
                case "0":
                    LblTitulo.Text = "Brasil ganha a primeira escola austríaca";
                    LblNoticia.Text = "Ontem foi inaugurada a primeira escola de pensamento com base no liberalismo economico, ou seja com base na Escola Austríaca, e principal membro Ludwvig Von Mises(foto)";
                    break;
                case "1":
                    LblTitulo.Text = "Cristiano Roanldo sofre suspensão!";
                    LblNoticia.Text = "Após suposta agressão em árbitro, o jogador Cristiano Ronaldo sofreu um suspensão de cinco jogos, o que o deixará muita atrás na competição ";
                    break;
                case "2":
                    LblTitulo.Text = "Revogado Estatuto do Desarmamento ";
                    LblNoticia.Text = "Esta semana foi revogado o Estatuto do Desarmamento, em declaração dos que defenderam a aprovação, é citado que o cidadão poderá defender a si e a sua família, ainda há muita controversa sobre o tema";
                    break;
                case "3":
                    LblTitulo.Text = "São Bernardo do Campo";
                    LblNoticia.Text = "Segundo o IBGE, a cidade de São bernardo do Campo tem o quinto maior PIB do País";
                    break;
                case "4":
                    LblTitulo.Text = "Anunciado terceiro filme de Thor";
                    LblNoticia.Text = "No dia 26 de Outubro, chegará aos telões o mais novo filme do super heroi: 'Thor: Ragnarok'";
                    break;
            }

        }

        protected void Btn4_Click(object sender, EventArgs e)
        {
            Label1.Text = "3";
            Image1.ImageUrl = "Imagens/Figura" + Label1.Text + ".jpg";

            switch (Label1.Text)
            {
                case "0":
                    LblTitulo.Text = "Brasil ganha a primeira escola austríaca";
                    LblNoticia.Text = "Ontem foi inaugurada a primeira escola de pensamento com base no liberalismo economico, ou seja com base na Escola Austríaca, e principal membro Ludwvig Von Mises(foto)";
                    break;
                case "1":
                    LblTitulo.Text = "Cristiano Roanldo sofre suspensão!";
                    LblNoticia.Text = "Após suposta agressão em árbitro, o jogador Cristiano Ronaldo sofreu um suspensão de cinco jogos, o que o deixará muita atrás na competição ";
                    break;
                case "2":
                    LblTitulo.Text = "Revogado Estatuto do Desarmamento ";
                    LblNoticia.Text = "Esta semana foi revogado o Estatuto do Desarmamento, em declaração dos que defenderam a aprovação, é citado que o cidadão poderá defender a si e a sua família, ainda há muita controversa sobre o tema";
                    break;
                case "3":
                    LblTitulo.Text = "São Bernardo do Campo";
                    LblNoticia.Text = "Segundo o IBGE, a cidade de São bernardo do Campo tem o quinto maior PIB do País";
                    break;
                case "4":
                    LblTitulo.Text = "Anunciado terceiro filme de Thor";
                    LblNoticia.Text = "No dia 26 de Outubro, chegará aos telões o mais novo filme do super heroi: 'Thor: Ragnarok'";
                    break;
            }

        }

        protected void Btn5_Click(object sender, EventArgs e)
        {
            Label1.Text = "4";
            Image1.ImageUrl = "Imagens/Figura" + Label1.Text + ".jpg";

            switch (Label1.Text)
            {
                case "0":
                    LblTitulo.Text = "Brasil ganha a primeira escola austríaca";
                    LblNoticia.Text = "Ontem foi inaugurada a primeira escola de pensamento com base no liberalismo economico, ou seja com base na Escola Austríaca, e principal membro Ludwvig Von Mises(foto)";
                    break;
                case "1":
                    LblTitulo.Text = "Cristiano Roanldo sofre suspensão!";
                    LblNoticia.Text = "Após suposta agressão em árbitro, o jogador Cristiano Ronaldo sofreu um suspensão de cinco jogos, o que o deixará muita atrás na competição ";
                    break;
                case "2":
                    LblTitulo.Text = "Revogado Estatuto do Desarmamento ";
                    LblNoticia.Text = "Esta semana foi revogado o Estatuto do Desarmamento, em declaração dos que defenderam a aprovação, é citado que o cidadão poderá defender a si e a sua família, ainda há muita controversa sobre o tema";
                    break;
                case "3":
                    LblTitulo.Text = "São Bernardo do Campo";
                    LblNoticia.Text = "Segundo o IBGE, a cidade de São bernardo do Campo tem o quinto maior PIB do País";
                    break;
                case "4":
                    LblTitulo.Text = "Anunciado terceiro filme de Thor";
                    LblNoticia.Text = "No dia 26 de Outubro, chegará aos telões o mais novo filme do super heroi: 'Thor: Ragnarok'";
                    break;
            }

        }
    }
}