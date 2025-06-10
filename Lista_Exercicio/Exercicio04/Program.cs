//Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui. Considere sempre anos completos, e que um ano possui 365 dias.
//Ex: uma pessoa com 19 anos possui 6935 dias de vida; eja um exemplo de saída: MARIA, VOCÊ JA VIVEU 6935 DIAS.

int dias, idade;
string nome;

Console.WriteLine("Qual o seu nome?");
nome = Console.ReadLine();

Console.WriteLine("Qual a sua idade, "+ nome + "?");
idade = Convert.ToInt32(Console.ReadLine());

dias = idade * 365;

Console.WriteLine(nome.ToUpper() + ", você já viveu " + dias + " dias");