//Faça um algoritmo que receba o preço de um produto, calcule e mostre o novo preço, sabendo-se que sofreu um desconto de 10%.

decimal preco, desconto;

Console.WriteLine("Digite o valor do produto:");
preco = Convert.ToDecimal(Console.ReadLine());

desconto = preco - (preco * 0.1m);

Console.WriteLine("O novo preço do produto é: R$ " + desconto + ".");

