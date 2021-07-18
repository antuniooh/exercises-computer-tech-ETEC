using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança_TOO_220917
{
    class Professor : Pessoa
    {
        private float ca;
        private string titulo;

        public Professor():base () //Construtor sem parametros
        {
            this.ca = 0;
            this.titulo = null;
        }

        //Construtor com paramentros
        public Professor(string nome, int idade, int altura, float ca, string titulo):base(nome, idade, altura)
        {
            this.ca = ca;
            this.titulo = titulo;
        }

        public float Ca // metodos get/set do Carga Horaria (Ca)
        {
            get { return this.ca; }
            set { this.ca = value; }
        }

        public string Titulo // metodos get/set do Titulo
        {
            get { return this.titulo; }
            set { this.titulo = value; }
        }


    }
}
