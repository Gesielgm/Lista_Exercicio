//Faça um algoritmo que receba duas notas, calcule e mostra a média ponderada dessas notas, considerando peso 2 para a primeira nota e 
//peso 3 para a primeira nota.


decimal nota1, nota2, media;

Console.WriteLine("Digite a primeira nota do aluno:");
nota1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a segunda nota do aluno:");
nota2 = Convert.ToInt32(Console.ReadLine());


media = ((nota1 * 2) + (nota2 * 3) )/ 5;

Console.WriteLine("A média ponderada do aluno é: " + media); 