//Entrar com o dia e o mês de uma data e informar quantos dias se passaram desde o inicio do ano. Esqueça a questão dos anos bissextos e considere sempre que um mês possui 30 dias.

int dia, mes, totalDias;

Console.WriteLine("Digite os dias");
dia = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o mês");
mes = Convert.ToInt32(Console.ReadLine());

mes = mes * 30;

totalDias = mes + dia;

Console.WriteLine("Se passaram " + totalDias + " dias.");