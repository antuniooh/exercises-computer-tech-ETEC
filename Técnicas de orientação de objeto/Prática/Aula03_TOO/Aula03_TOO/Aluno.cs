using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_TOO
{
    class Aluno : Pessoa /* Herança*/
    {
        private int rm;
        private float frequencia;

        public Aluno()
            : base()
        {
            this.rm = 0;
            this.frequencia = 0;
        }
        public Aluno(string nome, int idade, int altura, int rm, float frequencia)
            : base(nome, idade, altura)
        {
            this.rm = rm;
            this.frequencia = frequencia;
        }
        public int RM 
        {
            get { return this.rm; }
            set { this.rm = value; }
        }
        public float Frequencia
        {
            get { return this.frequencia; }
            set { this.frequencia = value; }
        }
    }
}
