using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Pratica02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ola {0} você tem {1} anos", nome, idade);
        }
    }
}
