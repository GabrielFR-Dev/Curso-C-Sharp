using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ==== Cadastro de Produto ==== ");

            Console.Write("\nQual Produto deseja cadastrar: ");
            string produto = Console.ReadLine();

            Console.Write($"Tem certeza que deseja cadastrar o {produto}: ");
            string resposta = Console.ReadLine();
            string conversao = resposta.ToLower();
            
            switch (conversao)
            {
                case "sim":
                    Console.WriteLine($" {produto} cadastrato com sucesso ");
                    break;
                case "nao":
                    Console.WriteLine("Produto não cadastrato !! ");
                    break;
                default: 
                    Console.WriteLine("Resposta invalida !! digite: sim ou nao ");
                    break;
            }
        }
    }
}
