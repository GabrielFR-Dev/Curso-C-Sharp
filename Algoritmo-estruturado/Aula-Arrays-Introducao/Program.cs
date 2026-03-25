using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Arrays_Introducao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string[] array = new string[] { "Segunda", "Terça", "Quarta", 
                                             "Quinta", "Sexta", "Sábado", "Domingo", "Segunda3"
                                            };

            // ITERAÇÃO, COM ESTRUTURA DE REPETIÇÃO
            // i++ == i+1

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Os dias da semana é: {array[i]} ");
            }

            // IRETAÇÃO COM FOR EACH
            Console.WriteLine("\n");

            foreach(string dia in array)
            {
                Console.WriteLine($"Os dias da semana é {dia}");
            }

            Console.WriteLine("A posição de quarta é: " + Array.IndexOf(array, "Quarta"));


            Console.ReadKey();



        }
    }
}
