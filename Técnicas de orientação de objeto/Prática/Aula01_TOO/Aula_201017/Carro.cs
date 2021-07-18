using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_201017
{
    class Carro
    {
        //atributos

        private string modelo;
        private bool ligado;
        private int ano;
        private float velocidade;

        // metodo construtor sem parametro

        public Carro()
        {
            this.modelo = null;
            this.ligado = false;
            this.ano = 0;
            this.velocidade = 0;
        }

        // metodo construtor com parametro

        public Carro(string modelo, bool ligado, int ano, float velocidade)
        {
            this.modelo = modelo;
            this.ligado = ligado;
            this.ano = ano;
            this.velocidade = velocidade;
        } // this faz referencia ao atributo da classe

        // metodo acessor e modificador

        private bool Ligado
        {
            get { return this.ligado; }
            set { this.ligado = value; }
        }

        private float Velocidade
        {
            get { return this.velocidade; }
            set { this.velocidade = value; }
        }
        //metodo ligar o carro

        public string ligar ()
        {
            if (this.ligado == false)
            {
                this.Ligado = true;//vai pro get ao contrario seria set
                return "Carro Ligado";
            }
            else
            {
                return "O carro já está ligado";
            }
        }

        // metodo desligar o carro

        public string desligar()
        {
            if(this.ligado == true && this.Velocidade ==0)
            {
                this.Ligado = false;
                return "Carro desligado";
            }
            else
            {
                return "O carro já esta desligado ou andando"; 
            }
        }

        // metodo acelerar, conferiundo se o carro está ligado ou nem

        public float acelerar(float velocidade)
        {
            if (this.ligado == true)
            {
                if (velocidade > 0)
                {
                    this.Velocidade = this.velocidade + velocidade;
                    return this.Velocidade; // get
                }
                else
                {
                    return this.Velocidade;
                }
            }
            else
            {
                return 0;
            }
        }

        // metodo frear, conferiundo se o carro está ligado ou nem

        public float frear(float velocidade)
        {
            if (this.velocidade < velocidade)
            {
                this.Velocidade = 0;
                return this.Velocidade;
            }

            else
            {
                this.Velocidade = (this.velocidade - velocidade);
                return this.Velocidade;
            }
        }
    }
}
