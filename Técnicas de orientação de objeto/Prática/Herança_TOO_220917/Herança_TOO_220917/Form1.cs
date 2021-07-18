using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herança_TOO_220917
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Pessoa pes1 = new Pessoa("Josney", 34, 189);
            Aluno al1 = new Aluno("Carlos", 18, 177, 4324, 86.5f);
            label1.Text = pes1.Nome;
            label2.Text = al1.Rm.ToString();
            label3.Text = al1.Nome;

            Professor prof1 = new Professor("Rômulo", 43, 195, 34.5f, "Especialista");
            label4.Text = prof1.Nome;
            al1.Nome = "João";
            

        }
    }
}
