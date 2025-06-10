//Faça um algoritmo que calcule e mostre a tabuada de um número digitado pelo usuário.

int numero = 0;
int adicao, subtracao , multiplicacao, divisao;

Console.WriteLine("Digite um numero que gostaria de saber a tabuada:");
numero = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= 10; i++)
{
    adicao = numero + i;
     
    Console.WriteLine(i + " + " + numero + " = " + adicao);
    
}
for (int i = 1; i <= 10; i++)
{
    if(numero < i)
    {
        subtracao = (-1 * numero) + i;
    }

    else
    {
        subtracao = numero - i;
    }

    Console.WriteLine(i + " - " + numero + " = " + subtracao);
}

for (int i = 1; i <= 10; i++)
{

    multiplicacao = numero * i;

    Console.WriteLine(i + " * " + numero + " = " + multiplicacao);

}

for (int i = 1; i <=10; i++)
{

    divisao = numero / i;

    Console.WriteLine(i + " / " + numero + " = " + divisao);
}  