//Pedrinhotem um coffrinho com muitas moedas e deseja saber quantos reais conseguiu poupar.
//Faça um algoritmo para ler a quantidade de cada tipo de moeda e imprimir o valor total economizado, em reais.
//Considere que existam moedas de 1, 4, 10, 25 e 50 centavos, e ainda moedas e 1 real. Não havendo moedas de um tipo,
//a quantidade respectiva é zero

decimal umCentavo, cincoCentavos, dezCentavos, vinte5Centavos, cinquentaCent, umReal, somaCent, somaTotal;

Console.WriteLine("Digite a quantidade de moedas de 1 centavo guardadas:");
umCentavo = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 5 centavo guardadas:");
cincoCentavos = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 10 centavo guardadas:");
dezCentavos = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 25 centavo guardadas:");
vinte5Centavos = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 50 centavo guardadas:");
cinquentaCent = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a quantidade de moedas de 1 real guardadas:");
umReal = Convert.ToDecimal(Console.ReadLine());


somaCent = (umCentavo * 0.01m) + (cincoCentavos * 0.05m) + (dezCentavos * 0.10m) + (vinte5Centavos * 0.25m) + (cinquentaCent * 0.5m);

somaTotal = umReal + somaCent;

Console.WriteLine("Você economizou: R$ " + somaTotal + ".");