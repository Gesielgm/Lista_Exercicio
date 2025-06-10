//Um funcionário recebe um salário fixo mais 4% de comissão sobre as vendas. Faça um algoritmo que receba o salário fixo
//de um funcionário e o valor de suas vendas, calcule e mostre a comissão e o salário final do funcionário.

decimal salario, vendas, comissao, salarioTotal;

Console.WriteLine("Digite o salário do colaborador:");
salario = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o total de vendas do colaborador");
vendas = Convert.ToDecimal(Console.ReadLine());

comissao = vendas * 0.04m;

salarioTotal = salario + comissao;

Console.WriteLine("O salário total do colaborador é: R$ " + salarioTotal);
Console.WriteLine("O total de comissões é: R$ " + comissao);