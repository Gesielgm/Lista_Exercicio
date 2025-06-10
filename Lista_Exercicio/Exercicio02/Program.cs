//Faça um algoritmo para calcular quantas ferraduras são necessárias para equipar todos os cavalos comrpados para um haras.

int quantCavalos;

Console.WriteLine("Quantos cavalos foram comprados?");
quantCavalos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Serão necessários comprar " + quantCavalos * 4 + " ferraduras para equipar todos os cavalos");