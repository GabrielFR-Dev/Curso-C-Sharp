/* ===== COMANDO READLINE ===== */

// Com esse comando podemos fazer com que o cliente envie informações via console para nossa aplicação

// PERGUNTA

Console.WriteLine("Digite seu nome: ");

// Cliente ira responder 

string ?nome = Console.ReadLine();

/*
    Por sua natureza o C# não converte uma informação nulla, Porque o comando readLine não garante que ira receber alguma informação
    Porem conseguimos flexibilizar isso no C# utilizando o ? antes do nome da variavel.
    Isso dira para o C# que a variavel pode receber uma informação nulla
 */


// CONCATENAÇÃO
Console.WriteLine($"Ola seja bem vindo {nome}");
