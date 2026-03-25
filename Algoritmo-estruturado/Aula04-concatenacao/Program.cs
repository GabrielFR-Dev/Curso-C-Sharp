/* ===== CONCATENAÇÃO ===== */

/* === FORMA SIMPLES === */

// Hoje aprenderemos sobre a concatenação, nada mais e nada menos a concatenação é juntar partes de variaveis ao texto

// Utilizamos o + para juntar as partes das variaveis ao texto, esse é o formato mas simples

string nome = "Gabriel";
string cidade = "Severinia SP";
int idade = 18;
string dataNascimento = "21/03/2007";

Console.WriteLine("O " +nome+ " Mora em "+cidade);

/* ==== SEGUNDO FORMATO DE CONCATENAÇÃO FORMA MODERNA ==== */

// Aqui utilizamos esse formato de concatenação chamado de interpolação de string ($" texto {Nome variavel } texto {Nome variavel}");

Console.WriteLine($"O {nome} tem {idade} anos e nasceu na data de {dataNascimento}");

