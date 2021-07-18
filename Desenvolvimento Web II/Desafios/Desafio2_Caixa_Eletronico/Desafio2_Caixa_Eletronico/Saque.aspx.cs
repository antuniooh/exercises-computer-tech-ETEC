using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Desafio2_Caixa_Eletronico
{
    public partial class Saque : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int Dinheiro, cem, cinquenta, vinte, dez, cinco, dois, um, resto;

            Dinheiro = int.Parse(txtsaque.Text);

            cem = Dinheiro / 100; 
            resto = Dinheiro % 100; 

            cinquenta = resto / 50; 
            resto = resto % 50; 

            vinte = resto / 20; 
            resto = resto % 20;

            dez = resto / 10;
            resto = resto % 10;

            cinco = resto / 5; 
            resto = resto % 5;

            dois = resto / 2;

            um = resto % 2;
            
            lbl100.Text= cem + " notas";
            lbl50.Text = cinquenta + " notas";
            lbl20.Text = vinte + " notas";
            lbl10.Text = dez + " notas";
            lbl5.Text = cinco + " notas";
            lbl2.Text = dois + " notas";
            lbl1.Text = um + " notas";
        }
    }
}