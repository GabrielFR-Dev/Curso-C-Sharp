using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletim_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();

                string nomeAluno;
                string nota1;
                string nota2;
                string nota3;
                string nota4;
                double resultado;


                Console.WriteLine("==== Boletim escolar ====\n");

                Console.Write("Digite o nome do aluno: ");
                nomeAluno = Console.ReadLine().ToLower();

                Console.Write($"\nDigite a primeira nota do {nomeAluno}: ");
                nota1 = Console.ReadLine();

                Console.Write($"\nDigite a segunda nota: ");
                nota2 = Console.ReadLine();

                Console.Write($"\nDigite a terceira nota: ");
                nota3 = Console.ReadLine();

                Console.Write($"\nDigite a quarta nota: ");
                nota4 = Console.ReadLine();

                resultado = (Convert.ToDouble(nota1) + Convert.ToDouble(nota2) + Convert.ToDouble(nota3) + Convert.ToDouble(nota4)) / 4;

                if (resultado >= 6)
                {
                    Console.WriteLine($"\nA média do {nomeAluno} é: {resultado}");
                    Console.WriteLine($"O {nomeAluno} foi aprovado, PARABÉNS !!!");

                }
                else if (resultado > 4 && resultado < 6)
                {
                    Console.WriteLine($"\nA média do {nomeAluno} é: {resultado}");
                    Console.WriteLine($"O {nomeAluno} ficou de recuperação estude mais !!!");
                }
                else
                {
                    Console.WriteLine($"\nA média do {nomeAluno} é: {resultado}");
                    Console.WriteLine($"O {nomeAluno} foi reprovado, estude mais !!!");
                }

                Console.Write("\n\nPressione ENTER para continuar o programa ou digite sair para finalizar: ");
                string resposta = Console.ReadLine().ToLower();

                if (resposta == "sair")
                {
                    Console.WriteLine("Programa finalizado. Até mais!");
                    break;
                }
                else
                {
                    continue;
                }

            }



        }
    }
}
