using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_Orientacao_Objeto_02
{
    public class Pessoa
    {
        public string nome;
        public int idade;

        public void Cadastro(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;

            Console.WriteLine("Cadastro realizado com sucesso !!");


        }



    }
}
