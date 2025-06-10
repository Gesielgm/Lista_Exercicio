//Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de impostos.
//Imprima o salário inicial, o salário com aumento e o salario com desconto.

decimal salario, salarioAumento, salarioFinal;

Console.WriteLine("Qual o salário do funcionario?");
salario = Convert.ToDecimal(Console.ReadLine());

salarioAumento = (salario * 0.15m) + salario;


salarioFinal = salarioAumento - (salarioAumento * 0.08m);

Console.WriteLine("O salário inicial é: R$ " + salario);
Console.WriteLine("O salário com aumento é: R$ " + salarioAumento);
Console.WriteLine("O salário com desconto é: R$ " + salarioFinal); 
