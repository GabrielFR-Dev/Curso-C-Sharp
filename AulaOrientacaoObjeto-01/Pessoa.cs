using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AulaOrientacaoObjeto_01
{
    public class Pessoa
    {
        // Atributos  = características
        // Metodos = ações

        // Declaração de Atributos
        public string nome;
        public int idade;
        public double peso;
        public string sexo;


        public Pessoa(string _nome)
        {
            this.nome = _nome;
        }

        public void Andar()
        {
            Console.WriteLine($"{this.nome} Está Andando");
        }

        public void Comer(string _comida)
        {
            Console.WriteLine($"{this.nome} Está comendo " + _comida);
        }
    }
}
