//João recebeu seu salário de R$ 1200,00 e precisa pagar duas contas (C1 = R$200,00 e C2=R$120,00) que estão atrasadas.
//Como as contas estão atrasadas, João terá que pagar multa de 2% sobre cada conta. Faça um algoritmo que calcule e mostre
//quanto restará do salário do João.

decimal c1 = 200, c2 = 120, salario = 1200, restoSalario;

c1 = c1 + (c1 * 0.02m);
c2 = c2 + (c2 * 0.02m);

restoSalario = (salario - c1) - c2;
Console.WriteLine("Restará do salário de João: R$ " + restoSalario); 



