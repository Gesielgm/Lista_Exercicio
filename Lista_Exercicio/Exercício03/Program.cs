//A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada pãozinho custa R$0,12 ea broa custa R$ 1,50.
//Ao final do dia, o dono quer saber quanto arrecadou com a venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança ( 10 do total arrecadado );
//Você foi contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as quantidades de pães e de roas, e depois calcular os dados solicitados.

int broas, paes;
decimal valor, valorGuardar;

Console.WriteLine("Qual a quantidade de Broas vendidas no dia?");
broas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Qual a quantidade de Pães Franceses vendidas no dia?");
paes = Convert.ToInt32(Console.ReadLine());

valor = (paes * 0.12m) + (broas * 1.50m);

Console.WriteLine("O valor total de vendas foi: " + valor );

valorGuardar = valor * 0.1m;

Console.WriteLine("O valor que será guardado na poupança é R$ " + valorGuardar);