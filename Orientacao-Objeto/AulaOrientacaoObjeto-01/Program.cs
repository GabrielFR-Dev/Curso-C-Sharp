using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaOrientacaoObjeto_01
{
    internal class Program
    {
        // Classes -> Objetos, Atributos, Métodos, Laço Try Catch, Método Construtor
        static void Main(string[] args)
        {
            try
            {
                // Instâniciando o o objeto pessoa (classse "vira" Objeto)

                Pessoa p1 = new Pessoa("Gabriel");
                p1.Comer("Pizza");
                p1.Andar();

                p1.Comer("Lazanha");

                Console.WriteLine("\n");

                Pessoa p2 = new Pessoa("Fernanda");
                p2.Comer("Churrasco");
                p2.Comer("Sorvete");
                p2.Andar();


                Console.ReadKey();

            }
            catch (Exception ex) 
            {
                Console.WriteLine("Ops, deu um erro: " + ex.Message);   
            }
        }
    }
}
