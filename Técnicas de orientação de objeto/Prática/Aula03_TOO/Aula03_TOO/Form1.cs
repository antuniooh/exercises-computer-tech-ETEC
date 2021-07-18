using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03_TOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Pessoa pes1 = new Pessoa("Josney", 34, 189);
            Aluno al1 = new Aluno("Carlos", 18, 177, 4324,86.5f/*Ffloat*/);

            label1.Text = pes1.Nome;
            /* onde será exibido, chamando a instancia, e chamando o acessor(GET)*/
            label2.Text = al1.RM.ToString();
            /*ToString convertendo, SET*/
            label3.Text = al1.Nome;
            /*SET*/
            /*Herança so faz sentido em duas ou mais subclasses, algumas classes são só pradoar, chamadas de Classe Abastrata(Pessoa)*/
        }
    }
}
