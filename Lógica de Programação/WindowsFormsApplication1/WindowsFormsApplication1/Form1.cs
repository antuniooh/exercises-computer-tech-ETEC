using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int QZ;
        int QN;
        int QP;
        int soma;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int numero;
            
            numero = int.Parse(txtnumero.Text);

            Lista.Items.Add(numero);

            soma = soma + numero;
            
            if (numero == 0)
            {
                QZ = (QZ + 1);
            }
            else if (numero > 0)
            {
               QP = (QP + 1);
            }
            else if (numero < 0)
            {
                QN = (QN + 1);
            }

           txtnegativo.Text = QN.ToString(); 
           txtpositivo.Text = QP.ToString();
           txttodosnum.Text = soma.ToString();
           txtzero.Text = QZ.ToString();


        }
    }
}
