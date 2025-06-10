//Faça um algoritmo que receba o peso de uma pessoa em quilos, calcule e mostre esse peso em gramas.

decimal quilos, gramas;

Console.WriteLine("Digite o peso da pessoa em quilos:");
quilos = Convert.ToDecimal(Console.ReadLine());

gramas = quilos * 1000;

Console.WriteLine("O peso da pessoa ( em quilos ) convertido em gramas é: " +  gramas);