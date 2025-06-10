//Faça um algoritmo que receba dois números, calcule e mostre a divisão do primeiro número pelo segundo.
//Sabe-se que o segundo número não pode ser zero, portanto não é necessário se preocupar com validações.

int num1, num2, divisao;

Console.WriteLine("Digite o primeiro número da divisão:");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o primeiro número da divisão:");
num2 = Convert.ToInt32(Console.ReadLine());

if (num2 == 0)
{
    Console.WriteLine("Refaça a operação, o segundo número não pode ser igual a zero.");
}

else
{
    divisao = num1 / num2;

    Console.WriteLine("O resultado da divisão é: " + divisao);
}