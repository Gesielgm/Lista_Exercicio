//Faça um algoritmo que receba o valor dos catetos de um triângulo, calcule e mostre o valor da hipotenusa.
//a² = b² + c²

double a, b, c;

Console.WriteLine("Digite o valor do primeiro cateto");
b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor do segundo cateto");
c = Convert.ToDouble(Console.ReadLine());

a = Math.Pow(b,2) + Math.Pow(c,2);

a = Math.Sqrt(a);


Console.WriteLine("O resultado da hipotenusa é: " + a); 
