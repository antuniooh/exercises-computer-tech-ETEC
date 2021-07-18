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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double SL; // Salario Liquido
            double SB; // Salario Bruto
            double GRAT; // Gratificação
            double IR; // Imposto de Renda 

            SB = double.Parse(txtSB.Text); // Transforma o Valor digitado e guarda em SB

            GRAT = 0;
            IR = 0;
            if (SB < 5000) 
            {
                if (SB < 3000) 
                {
                    if (SB < 2000) 
                    {
                        if (SB >= 1000) 
                        {
                            GRAT = SB * 0.1;
                        }
                    }
                    else
                    {
                        GRAT = SB * 0.2;

                    }
                }
                else
                {
                    GRAT = SB * 0.25;
                }
            
            }
            else
            {
                GRAT = SB * 0.3;
            }

            if (SB < 5079)
            {
                if (SB < 3800)
                {
                    if (SB > 1970)
                    {
                        IR = SB * 0.175;
                    }
                }
                else
                IR = SB * 0.225;
            }
            else 
            {
                IR = SB * 0.275;
            }

            SL = SB + GRAT - IR;

            lblResult.Text = "Imposto de Renda: R$ " + IR + "\n Salário líquido: R$ " + SL + "\n Gratificação: R$ " + GRAT;
        }
    }
}
