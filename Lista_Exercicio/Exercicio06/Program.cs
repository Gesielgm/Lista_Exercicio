//O restaurante a quilo Bem-Bão cobra R$ 12,00 por cada quilo de refeição. Escreva um algoritmo que leia o peso do prato montado pelo cliente (em kilos) e
//imprima o valor a pagar. Assuma que a balança já desconte o peso do prato.

decimal peso, valor;

Console.WriteLine("Quantos quilos ficou a pesagem do prato?");
peso = Convert.ToDecimal(Console.ReadLine());

valor = (peso * 12.00m);

Console.WriteLine("O peso do prato é: R$  " + valor);