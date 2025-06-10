//Faça um algoritmo que receba o peso de uma pessoa, calcule e mostre:
//a) o novo peso se a pessoa engordar 15% sobre o peso digitado.
//b) o novo peso se a pessoa emagrecer 20% sobre o peso digitado.


decimal peso, engordar, emagrecer;

Console.WriteLine("Digite o peso da pessoa:");
peso = Convert.ToDecimal(Console.ReadLine());

if ( peso < 0 || peso == 0)
{
    Console.WriteLine("Digite um peso válido");
}

else
{
    engordar = peso + ( peso * 0.15m);
    emagrecer = peso - ( peso * 0.20m);

    Console.WriteLine("O novo peso se a pessoa emagrecer é: " + emagrecer);
    Console.WriteLine("O novo peso se a pessoa engordar é: " + engordar); 
}