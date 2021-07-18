using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_TOO_220917
{
     class Pessoa
    {
        protected string nome; //protegido p/ ser acessado pela propria familia
        protected int idade; //protegido p/ ser acessado pela propria familia
        protected int altura; //protegido p/ ser acessado pela propria familia

        public Pessoa() // metodo construtor (sem parametros)
        {
            this.nome = null;
            this.idade = 0;
            this.altura = 0;
        }

        public Pessoa(string nome, int idade, int altura) // metodo construtor (com parametros)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }

        public string Nome // metodos get/set do nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public int Idade // metodos get/set da idade
        {
            get { return this.idade; }
            set { this.idade = value; }
        }

        public int Altura // metodos get/set da altura
        {
            get { return this.altura; }
            set { this.altura = value; }
        }


    }
}
