using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao_Social
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== Condição Social ====\n");

                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine();

                Console.Write("\nDigite seu salário R$: ");
                string salario = Console.ReadLine();

                if (double.TryParse(salario, out double resultado))
                {
                    if (resultado > 5000)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nMuito bom {nome} Sua renda é alta");
                        Console.ResetColor();
                    }
                    else if (resultado >= 2001)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"\nBom {nome} Sua renda é média");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nRuim {nome} Sua renda é baixa");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.WriteLine("Numero inválido");
                }

                Console.Write("\n\nPressione ENTER para continuar ou Digite sair para finalizar o programa: ");
                string resposta = Console.ReadLine().ToLower();
                
                if(resposta == "sair")
                { 
                    Console.WriteLine("\n\nFinalizando o programa.. Pressione enter para sair");
                    Console.ReadKey();
                    break;
                } else
                {
                    continue;
                }

            }
        }
    }
}
