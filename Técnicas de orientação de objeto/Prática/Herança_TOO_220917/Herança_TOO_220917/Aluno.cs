using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_TOO_220917
{
    class Aluno:Pessoa //Representação da herança
    {
        private int rm; //proibe o acesso externo
        private float frequencia;

        public Aluno():base() //
        {
            this.rm = 0;
            this.frequencia = 0;
        }

        public Aluno(string nome, int idade, int altura, int rm, float frequencia):base(nome, idade, altura)
        {
            this.rm = rm;
            this.frequencia = frequencia;
        }

        public int Rm // metodos get/set do Registro de Matricula
        {
            get { return this.rm; }
            set { this.rm = value; }
        }

        public float Frequencia // metodos get/set da Frequencia
        {
            get { return this.frequencia; }
            set { this.frequencia = value; }
        }
    }
}
