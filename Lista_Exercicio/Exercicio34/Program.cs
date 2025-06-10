//Faça um algoritmo que calcule e mostre a área de um quadrado. Sabe-se que: A = lado * lado.

decimal lado, area;

Console.WriteLine("Digite o lado do quadrado em metros:");
lado = Convert.ToDecimal(Console.ReadLine());

area = lado * lado;

Console.WriteLine("A área do quadrado é: " + area + " m²");