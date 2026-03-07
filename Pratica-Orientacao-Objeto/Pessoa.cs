using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_Orientacao_Objeto
{
    public class Pessoa
    {
        public string nome;
        public string idade;

        public Pessoa(string _nome)
        {
            this.nome = _nome;
        }

        public void Andar()
       {
            Console.WriteLine($"{this.nome} está andando");
       }

       public void Comer(string _comida)
       {
            Console.WriteLine($"{this.nome} está comendo {_comida}");
       }


    }
}
