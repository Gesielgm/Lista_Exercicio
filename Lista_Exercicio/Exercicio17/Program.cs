//Alguns países medem temperaturas em graus Celsius, e outros em graus Farhrenheit. Faça um algoritmo para ler uma temperatura Celsius e 
//imprimi-la em Fahrenheit (pesquise como fazer esse tipo de conversão)

decimal celsius, fahrenheit;

Console.WriteLine("Digite a temperatura em graus Celsius");
celsius = Convert.ToDecimal(Console.ReadLine());

fahrenheit = ( celsius * 1.80m) + 32;


Console.WriteLine("Os graus celsius convertidos em Fahrenheit é: " + fahrenheit); 