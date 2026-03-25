/* =====  VARIAVEIS ===== */

// Utilizando as variaveis do tipo (String, Char, Int, Double, Bool)

string nome = " Gabriel ferreira da silva "; // Variavel utilizada para armazenar textos

char primeiraLetra = 'G'; /* Variavel utilizada para armazenas apenas uma letra, Repare que utilizamos as aspas simples ''
                           Porque estamos armazenando apenas uma caractere, se quisermos armazenar mais de uma
                            passamos para o valor string e utilimos as "" */

int idade = 18; // Variavel utilizada para armazenar um número inteiro

double saldo = 580.50; // Variavel utilizada para armazenar o numero decimal

bool estuda = true; // Variavel utilizada para armazenar Verdadeiro(true) ou Falso(false)


/* ===== Exibindo as Variaveis ===== */


// Utilizamos o comando Console.Writeline(), para escrever na tela

Console.WriteLine("Meu nome é " + nome); // Ira escrever na tela o texto armazenado na variavel
Console.WriteLine("Minha primeira letra do nome é " + primeiraLetra); // Ira escrever na tela a primeira letra armazenado na variavel
Console.WriteLine("Tenho " + idade); // Ira escrever na tela o numero inteiro armazenado na variavel
Console.WriteLine("Minha conta está " + saldo); // Ira escrever na tela o numero decimal armazenado na varivel 
Console.WriteLine("Eu passei de ano " + estuda); // Ira escrever na tela o valor armazenado na variavel bool, no caso (TRUE ou FALSE)

Console.ReadLine(); // Mantém o console aberto