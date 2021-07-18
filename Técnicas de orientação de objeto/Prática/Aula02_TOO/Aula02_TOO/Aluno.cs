using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02_TOO
{
    class Aluno
    {
        private string nome;
        private int nota;
        private float frequencia;

        public Aluno()
        {
            this.nome = null;
            this.nota = 0;
            this.frequencia = 0;
        }
        public Aluno(string nome, int nota, float frequencia)
        {
            this.nome = nome;
            this.nota = nota;
            this.frequencia = frequencia;
        }
        public string Nome
        {
            get {return this.nome;}
            set { this.nome = value; }
        }
        public int Nota
        {
            get { return this.nota; }
            set
            {
                if (value >= 0) { this.nota = value; } else { this.nota = 0; }
            }
        }
        public float Frequencia
        {
            get { return this.frequencia; } // da classe secundaria para principal
            set { this.frequencia = value; } // da principal para a secundaria
        }
        public string calcularNota(){ 
        if (this.nota >=6)
           { return "Aprovado";} 
         else{return "Reprovado";}
        }
    }
}
