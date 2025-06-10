//Faça um algoritmo que receba o valor do salário mínimo e o valor do salário de um funcionário, calcule e mostre 
//a quantidade de salários mínimos que ganha esse funcionário.

decimal salarioMinimo, salarioFuncionario, salarios;

Console.WriteLine("Digite o valor do salário mínimo atualizado:");
salarioMinimo = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o valor do salário do funcionário:");
salarioFuncionario = Convert.ToDecimal(Console.ReadLine());

salarios = salarioFuncionario / salarioMinimo;

Console.WriteLine("O Funcionário recebe: " + salarios + " salários mínimos");

