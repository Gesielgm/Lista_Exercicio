//Faça um algoritmo para ler três notas de um aluno em uma disciplina e imprimir sua média ponderada (as notas têm pesos respectivos de 1, 2 e 3).

decimal nota1, nota2, nota3, media;

Console.WriteLine("Digite a primeira nota do aluno:");
nota1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a segunda nota do aluno:");
nota2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Dgite a terceira nota do aluno:");
nota3 = Convert.ToInt32(Console.ReadLine());

media = ( (nota1 * 1) + (nota2 * 2) + (nota3 * 3) )/ 6;

Console.WriteLine("A média ponderada do aluno é: " + media);