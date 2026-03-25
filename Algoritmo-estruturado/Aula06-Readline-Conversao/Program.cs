using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_Readline_Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write($"\nOlá {nome}, Agora preciso que digite sua idade: ");
            
            if(int.TryParse(Console.ReadLine(), out int idade))
            {
                Console.WriteLine($"\nCadastro feito com sucesso {nome}, Você tem {idade} anos, Está muito novo ainda !!!");
            }
            else
            {
                Console.WriteLine("\n Idade Inválida, digite sua idade");
            }
        }
    }
}
