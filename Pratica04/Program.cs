using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Digite o primeiro numero: ");

            while(!int.TryParse(Console.ReadLine(), out a))
            {
                
                Console.Write("\nNumero Invalido\nDigite o primeiro numero número: ");
                
            }

            Console.Write("Digite o segundo numero: ");
            
            while(!int.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("\nNumero Invalido\nDigite o segundo numero: ");
              
            }

            Console.WriteLine($"\nA soma de {a} + {b} = {a + b}");

            Console.WriteLine($"A subtração de {a} - {b} = {a - b}");

            Console.WriteLine($"A multiplicação de {a} x {b} = {a * b}");
            
            if(b != 0) 
            {
                Console.WriteLine($"A divisão de {a} / {b} = {(double)a / b}");

                Console.WriteLine($"O resto de {a} % {b} = {a % b}");
            }
            else
            {
                Console.WriteLine("Não é possivel dividir ou obter o resto por zero. ");
            }

            Console.ReadKey();
        }
    }
}
