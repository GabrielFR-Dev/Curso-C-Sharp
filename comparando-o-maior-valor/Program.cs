using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparando_o_maior_valor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;

            Console.Write("Digite o primeiro numero: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            y = double.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro numero: ");
            z = double.Parse(Console.ReadLine());

            if (x > y && x > z)
            {
                Console.WriteLine($"\no primeiro numero é maior");
            }
                 else if (y > x && y > z)
                    {
                        Console.WriteLine($"\nO segundo numero é maior");
                         }
                 else if (z > y && z > x)
                    {
                        Console.WriteLine($"\nO terceiro numero é maior");
                        }
                 else 
                    {
                        Console.WriteLine("\nOs numeros são iguais");
                    }
            
        }
    }
}
