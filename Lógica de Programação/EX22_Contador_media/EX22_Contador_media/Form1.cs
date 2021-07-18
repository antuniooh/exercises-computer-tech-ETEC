using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX22_Contador_media

{
    public partial class Form1 : Form
    {
        double soma;
        double media; 
        int cont;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            double numero;

            Lista.Enabled = true;
            numero = double.Parse(txtnumero.Text);
            soma = soma + numero;

            Lista.Items.Add(numero);

           
            cont++;
        }

        private void btnmedia_Click(object sender, EventArgs e)
        {
                media = soma / cont;
                btnadd.Enabled = false;
                txtmedia.Text = media.ToString();
        }
    }
}
