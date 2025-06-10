//Faça um algoritmo que calcule e mostre a área de um trapézio. Sabe-se que:
// A = ((base maior + base menor ) * altura ) / 2


decimal baseMaior, baseMenor, altura, area;

Console.WriteLine("Digite a base menor do trapézio em metros:");
baseMenor = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a base maior do trapézio em metros:");
baseMaior = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a altura do trapézio em metros:");
altura = Convert.ToDecimal(Console.ReadLine());


area = ((baseMenor + baseMaior) * altura) / 2;

Console.WriteLine("A área do trapézio é: " + area + "m²."); 