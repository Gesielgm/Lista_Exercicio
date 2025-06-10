//A fábrica de refrigerantes Meia-Cola vende seu produtos em três formatos: lata de 350ml, garrafa de 600ml e garrafa de 2 litros. 
//Se um comerciante compra uma determinada quantidade de cada formato, faça um algoritmo para calcular quantos litros de refrigerante ele comprou.

int lata, garrafa600, garrafaLitro;
decimal ml, litros;

Console.WriteLine("Digite a quantidade de latas 350ml que deseja adquirir:");
lata = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de garrafas 600ml que deseja adquirir:");
garrafa600= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de garrafas 2litros que deseja adquirir:");
garrafaLitro = Convert.ToInt32(Console.ReadLine());

ml = (lata * 350) + (garrafa600 * 600);

ml = ml / 1000;

litros = (garrafaLitro * 2) + ml;

Console.WriteLine("A quantidade de litros necessários para atender o pedido é: " + litros + " litros."); 