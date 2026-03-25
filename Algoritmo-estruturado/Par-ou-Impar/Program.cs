using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Par_ou_Impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                string numero;
                string resposta;

                Console.WriteLine("==== Indentificador de número par ou impar ====\n");

                Console.Write("Digite o numero que você quer indentificar: ");
                numero = Console.ReadLine();


                if (int.TryParse(numero, out int resultado))
                {
                    int indentificaodor = resultado % 2;

                    if (indentificaodor == 0)
                    {
                        Console.WriteLine($"\nO numero {resultado} é par.");
                    }
                    else
                    {
                        Console.WriteLine($"\nO numero {resultado} é impar.");
                    }
                }
                else
                {
                    Console.WriteLine("\nValor inválido, por favor digite um numero inteiro.");
                }

                Console.Write("\nPressione ENTER para continuar ou digite sair para fechar o programa: ");
                resposta = Console.ReadLine().ToLower();

                if(resposta == "sair")
                {
                    Console.WriteLine("\nEncerrando o programa");
                    break;
                }
            }
        }
    }
}
