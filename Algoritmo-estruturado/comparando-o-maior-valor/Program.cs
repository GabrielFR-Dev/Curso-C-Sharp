using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace comparando_o_maior_valor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
            */

            //3 Comparador de senha

            /*
            string senha, usuario;

            Console.Write("Digite o usúario: ");
            usuario = Console.ReadLine().ToString();

            Console.Write("Digite a senha: ");
            senha = Console.ReadLine();

            if(usuario == "gabriel" && senha == "123a")
            {
                Console.WriteLine("\nLogin efetuado com sucesso");
            }
            else if(usuario == "" || senha == "")
            {
                Console.WriteLine("\nPreencha todas as informações");
            }
            else
            {
                Console.WriteLine("\nUsuario ou senha inválido!!");
            }
             */


            /*
            //4 Numero positivo ou negativo

            Console.Write("Digite um numero: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("\nO numero digitado é positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("\nO numero digitado é negativo");
            }
            else
            {
                Console.WriteLine("\nO numero digitado é zero");
            }
            */

            /*
             // Exercicio 5

            int idade;
            Console.Write("Digite sua idade: ");

            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("\nVocê já é maior de idade");
            }
            else
            {
                Console.WriteLine("\nVocê ainda é de menor");
            }
             */

            /*
             //6 Boletin escolar com entrada de dado, nome do aluno

            string nomeAluno;
            double nota1, nota2, nota3, nota4, resultado;
            

            Console.Write("Digite o nome do aluno: ");
            nomeAluno = Console.ReadLine();

            Console.Write($"\nDigite a primeira nota do {nomeAluno}: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write($"Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write($"Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write($"Digite a quarta nota: ");
            nota4 = double.Parse(Console.ReadLine());

            resultado = (nota1 + nota2 + nota3 + nota4) / 4;

            if(resultado >= 7)
            {
                Console.WriteLine($"\nA média total do {nomeAluno} é de {resultado}");
                Console.WriteLine($"\nO {nomeAluno} foi aprovado.. Párabens !!!");
            }
            else if (resultado >= 5 && resultado < 7)
            {
                Console.WriteLine($"\nA média total do {nomeAluno} é de {resultado}");
                Console.WriteLine($"\nO {nomeAluno} ficou de recuperação.. estude mais !!!");
            }
            else
            {
                Console.WriteLine($"\nA média total do {nomeAluno} é de {resultado}");
                Console.WriteLine($"\nO {nomeAluno} reprovou...");
            }
             */

            /*
            //7 Swtich complete o codigo, verificar o dia da semana
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
            */
        }
    }
}
