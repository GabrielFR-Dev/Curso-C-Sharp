using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_Orientacao_Objeto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true) 
            {
                Console.Clear();
                Console.WriteLine("\nDeseja Iniciar o programa para ver a ação das pessoas \n");

                Console.WriteLine("(1) - SIM");
                Console.WriteLine("(2) - ENCERRAR");
                
              
                Console.Write("Digite sua escolha: ");
                string entrada = Console.ReadLine();
                int escolha;

                if (int.TryParse(entrada, out escolha))
                {
                    if (escolha == 1)
                    {
                        Console.Write("\nDigite seu nome: ");

                        string nome1 = Console.ReadLine();

                        Pessoa p1 = new Pessoa(nome1);
                        p1.Comer("Macarrão");
                        p1.Andar();
                        p1.Comer("Lanche");

                        Console.Write("\nDigite outro nome: ");
                        string nome2 = Console.ReadLine();

                        Pessoa p2 = new Pessoa(nome2);
                        p2.Andar();
                        p2.Comer("Lazanha");
                        p2.Andar();
                        Console.ReadKey();
                    }

                    else if (escolha == 2)
                    {
                        Console.WriteLine("\nEncerrando Programa....");
                        Console.WriteLine("\nObrigado Por Utilizar o programa");

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Ops: Opçao invalida, Tente Novamente !!");
                    }
                } else
                {
                    Console.WriteLine("\nops..!! Algo de errado, precione qualquer tecla: ");
                    Console.ReadKey();
                }
                
            }

            
           



        }
    }
}
