using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;
            string nomeCompleto;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();

            nomeCompleto = nome + " " + sobrenome;

            Console.WriteLine($"Ola seu nome completo é {nomeCompleto}");
            Console.WriteLine($"Seu nome tem {nome.Length} caracteres");
            Console.WriteLine($"Olá {nome.ToUpper()} ");
            Console.WriteLine($"Olá {sobrenome.ToLower()}");
            Console.WriteLine($"Olá {nomeCompleto.ToUpper()}");


            string fragmento = nomeCompleto.Substring(0, 7);

            Console.WriteLine($"Fragmento = {fragmento}");


            Console.ReadKey();


        }
    }
}
