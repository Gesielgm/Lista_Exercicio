//Três amigos, carlos, André e Felipe, decidiram rachar igualmente a conta de um bar. Faça um algoritmo para ler o valor total da conta 
// e imprimir quanto cada um deve pagar, mas faça que Carlos e André não paguem centavos.
//EX: uma conta de R$ 101,53 resulta em R$ 33,00 para Carlos, R$ 33,00 para André e R$ 35,53 para Felipe

decimal valorConta, centavos, valorDividido, valorFelipe, restoDividido;

Console.WriteLine("Digite o valor da conta:");
valorConta = Convert.ToDecimal(Console.ReadLine());

valorDividido = valorConta / 3;

centavos = valorDividido % 1; // Para calcular os centavos.

valorDividido = valorDividido - centavos;

valorFelipe = valorDividido + (centavos * 3);



Console.WriteLine("O valor que o Carlos deverá pagar é: R$ " + valorDividido);
Console.WriteLine("O valor que o André deverá pagar é: R$ " + valorDividido);
Console.WriteLine("O valor que o André deverá pagar é: R$ " + valorFelipe); 

