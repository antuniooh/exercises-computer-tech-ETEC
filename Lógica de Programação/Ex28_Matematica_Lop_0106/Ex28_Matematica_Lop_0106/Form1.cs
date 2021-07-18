using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex28_Matematica_Lop_0106
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float Valor1 = 0, Valor2 = 0, Resultado = 0; // variaveis de entrada - real privadav

                Valor1 = float.Parse(txtvalor1.Text); // entrada 1
                Valor2 = float.Parse(txtvalor2.Text); // entrada 2

                if (rdnAdd.Checked) Resultado = Valor1 + Valor2; // condicional 1 - processo 1
                if (rdnSub.Checked) Resultado = Valor1 - Valor2; // condicional 2 - processo 2
                if (rdnMulti.Checked) Resultado = Valor1 * Valor2; // condiocional 3 - processo 3
                if (rdnDivi.Checked) Resultado = Valor1 / Valor2; // condiocional 4 - processo 4
                if (rdnResto.Checked) Resultado = Valor1 % Valor2; // condiocional 5 - processo 5

                txtresultado.Text = Resultado.ToString(); // Saida 1
            }
            catch
            {
                MessageBox.Show("Digite um Valor Válido");
            }
        }
    }
}
