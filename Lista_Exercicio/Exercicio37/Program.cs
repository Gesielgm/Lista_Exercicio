//Faça um algoritmo que calcule e mostre a tabuada de um número digitado pelo usuário.

int numero = 0;
int adicao, subtracao , multiplicacao, divisao;

Console.WriteLine("Digite um numero que gostaria de saber a tabuada:");
numero = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i < 11; i++)
{
    adicao = numero + i;
     
    Console.WriteLine(numero + " + " + i + " = " + adicao);
    
}
for (int i = 1; i < 11; i++)
{

    subtracao = numero - i;

    Console.WriteLine(numero + " - " + i + " = " + subtracao);

}

for (int i = 1; i < 11; i++)
{

    multiplicacao = numero * i;

    Console.WriteLine(numero + " * " + i + " = " + multiplicacao);

}

for (int i = 1; i < 11; i++)
{

    divisao = numero / i;

    Console.WriteLine(numero + " / " + i + " = " + divisao);
} 