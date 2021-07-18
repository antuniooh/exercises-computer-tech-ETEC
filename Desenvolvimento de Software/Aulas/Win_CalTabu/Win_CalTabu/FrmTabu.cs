using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_CalTabu
{
    public partial class FrmTabu : Form
    {
        int a, b, c;
        string saida;
        public FrmTabu()
        {

            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                saida = "";
                a = int.Parse(txtNumero.Text);
               /* for (b = 1; b <= 10; b++) // atribuição; condição; incremento;
                {
                    c = (a * b);
                    saida = saida + a.ToString() + "x" + b.ToString() + "=" + c.ToString() + '\n';
                }
                */

               /* b = 1;
                while (b <= 10)
                {
                    c = (a * b);
                    saida = saida + a.ToString() + "x" + b.ToString() + "=" + c.ToString() + '\n'; b++;
                }    */

              /*  b = 1;
                do{
                    c = (a * b);
                    saida = saida + a.ToString() + "x" + b.ToString() + "=" + c.ToString() + '\n'; b++;
                } while (b <= 10); */


                b = 1;
                for (; b <= 10; )
                {
                    c = (a * b);
                    saida = saida + a.ToString() + "x" + b.ToString() + "=" + c.ToString() + '\n'; b++;
                }
                lblExibir.Text = saida;
            }
            catch (FormatException erro)
            {
                MessageBox.Show(erro.Message, "*** ERRO ***", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
