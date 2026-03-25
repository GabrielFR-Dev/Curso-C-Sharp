using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia_da_Semana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:
                    Console.WriteLine("\nDomingo");
                    break;
                case 2:
                    Console.WriteLine("\nSegunda-feira");
                    break;
                case 3:
                    Console.WriteLine("\nTerça-feira");
                    break;
                case 4:
                    Console.WriteLine("\nQuarta-feira");
                    break;
                case 5:
                    Console.WriteLine("\nQuinta-feira");
                    break;
                case 6:
                    Console.WriteLine("\nSexta-feira");
                    break;
                case 7:
                    Console.WriteLine("\nSábado");
                    break;
                default:
                    Console.WriteLine("\nEsse dia da semana não existe !!");
                    break;
            }
        }
    }
}
