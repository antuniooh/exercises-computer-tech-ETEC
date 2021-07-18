using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula02_TOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Aluno aluno1 = new Aluno();
            Aluno aluno2 = new Aluno("Júlio Túlio", 6, 79.6f);
            string nome = aluno2.Nome;
            aluno2.Nome = "Antonio Augusto";
            lblNome.Text = aluno2.Nome;
            lblNota.Text = aluno2.Nota.ToString();
            lblFrequencia.Text = aluno2.Frequencia.ToString();

            lblResultado.Text = aluno2.calcularNota();
        }
       
        }
    }
