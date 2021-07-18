using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_TOO
{
    class Professor: Pessoa
    {
        private float ca;
        private string titulo;

        public Professor()
            : base()
        {
            this.ca = 0;
            this.titulo = null;
        }
    }
}
