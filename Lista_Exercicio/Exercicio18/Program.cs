//A empresa Hipotheticus paga R$ 100,00 por hora normal trabalhada, e R$ 15,00 por hora extra.
//Faça um algoritmo para calcular e imprimir o salário bruto e o salário liquido de um determinado funcionário.
//Considere que o salário líquido é igual ao salário bruto descontando-se 10% de impostos.


decimal horasTrab, horasExtras, salarioBruto, salarioLiquido;


Console.WriteLine("Foram trabalhadas quantas horas?");
horasTrab = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Foram feitas quantas horas extras?");
horasExtras = Convert.ToDecimal(Console.ReadLine());

salarioBruto = (horasExtras * 15.00m) + (horasTrab * 100.00m);

salarioLiquido = salarioBruto - ( salarioBruto * 0.1m) ;

Console.WriteLine("O salário bruto é: R$ " + salarioBruto);
Console.WriteLine("O salário liquido é: R$ " + salarioLiquido); 

