//Um motorista deseja colocar no seu tanque X reais de gasolina. Escreva um algoritmo para ler o preço do litro da gasolina e o valor do pagamento, e exibir quantos
//litros ele conseguiu colocar no tanque

decimal litros, valorGasolina, valorTotal;

Console.WriteLine("Qual o valor da gasolina?");
valorGasolina = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Qual o valor do pagamento?");
valorTotal = Convert.ToDecimal(Console.ReadLine());

litros = valorTotal / valorGasolina;

Console.WriteLine("Foram abastecidos " + litros + " litros.");
