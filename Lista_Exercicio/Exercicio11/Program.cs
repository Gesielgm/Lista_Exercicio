//Uma fábrica controla o tempo de trabalho sem acidentes pela quantidade de dias. Faça um algoritmo para converter este tempo em anos, meses e dias.
//Assuma que cada mês possui sempre 30 dias.

int dias, meses, anos, tempoAcidentes, resto;

Console.WriteLine("Qual a quantidade de dias sem acidentes?");
tempoAcidentes = Convert.ToInt32(Console.ReadLine());

anos = tempoAcidentes / 360; 
resto = tempoAcidentes % 360;
meses = resto / 30;
dias = resto % 30;

Console.WriteLine("O tempo sem acidentes é: " + dias+ " dias / " + meses + " meses / " + anos + " anos.");
