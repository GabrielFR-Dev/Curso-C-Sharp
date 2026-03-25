using System;


namespace Aula07_Condicao_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");


            if (int.TryParse(Console.ReadLine(), out int idade))
            {
                if (idade >= 18 && idade < 60)
                {
                    Console.WriteLine($"\nCadastro feito com sucesso {nome} você ja tem {idade} anos");
                }
                else if (idade >= 60)
                {
                    Console.WriteLine($"\nSeja bem vindo Sr {nome} você tem {idade} anos, por isso acaba de ganhar um desconto de 30% em qualquer compra");
                }
                else
                {
                    Console.WriteLine($"\nCadastro negado {nome} você ainda tem {idade} anos");
                }
            }
            else
            {
                Console.WriteLine("\nErro! Digite sua idade");
            }
        }
    }
}
