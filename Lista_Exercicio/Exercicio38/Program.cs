//Faça um algoritmo que receba o ano de nascimento de uma pessoa e o ano atual, calcule e mostre:
//a) a idade dessa pessoa em anos;
//b) a didade dessa pessoa em meses;
//c) a idade dessa pessoa em dias;
//d) a idade dessa pessoa em semanas;


int idadeNascimento, anoAtual;
decimal anos, meses, dias, semanas;

Console.WriteLine("Qual seu ano de nascimento?");
idadeNascimento = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Qual o ano atual?");
anoAtual = Convert.ToInt32(Console.ReadLine());

anos = anoAtual - idadeNascimento;

meses = anos * 12;

dias = anos * 365;

semanas = anos * 52;

Console.WriteLine("Sua idade em anos é: " + anos + " anos.");
Console.WriteLine("Sua idade em meses é: " + meses + " meses.");
Console.WriteLine("Sua idade em dias é: " + dias + " dias.");
Console.WriteLine("Sua idade em semanas é: " + semanas + " semanas."); 