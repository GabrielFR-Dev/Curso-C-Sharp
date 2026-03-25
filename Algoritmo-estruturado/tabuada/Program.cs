using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.WriteLine("|==================|");
                Console.WriteLine("|SISTEMA DE TABUABA|");
                Console.WriteLine("|==================|");

                Console.Write("\nDigite a tabuaba que quer saber: ");
                string tabuada = Console.ReadLine();

                if (int.TryParse(tabuada, out int num))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nTabuda do {num} \n");
                    for (int i = 0; i <= 10; i++)
                    {
                        Console.WriteLine($"{num} X {i} = {num * i}");
                    }
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.DarkBlue;

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\nNúmero inválido! Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    continue;
                }
                Console.Write("\nEscreva (sair) para finalizar o programa ou\n" +
                                "pressione (enter) para iniciar novamente: ");
                
                string escolha = Console.ReadLine().ToLower();

                if (escolha == "sair")
                {
                    Console.WriteLine("\nObrigado por usar o programa, até a próxima!");
                    break;
                }
  
            }
        }
    }
}
