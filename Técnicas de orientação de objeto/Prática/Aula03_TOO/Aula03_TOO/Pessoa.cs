using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_TOO
{
     class Pessoa /* este comando transforma-a em "abstract", fazendo com que não se possa instancia-la*/
    {
        protected string nome;
        protected int idade;
        protected int altura;
        /*private falha pois não permte acesso, Metodos acessores devem ser públicos*/


        public Pessoa()
        {
            this.nome = null;
            this.idade = 0;
            this.altura = 0;
        }

        public Pessoa(string nome, int idade, int altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        public int Idade
        {
            get { return this.idade; }
            set { this.idade = value; }
        }
        public int Altura
        {
            get { return this.altura; }
            set { this.altura = value; }
        }
    }
}
