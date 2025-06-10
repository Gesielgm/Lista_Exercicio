//Uma fábrica de camisetas produz os tamanhos pequeno, médio e grande, cada uma sendo vendida respectivamente por 10, 12 e 15 reais. Construa um algoritmo
//em que o usuário forneça a quantidade de camisetas pequenas, médias e grandes referentes a uma venda, e a máquina informe quanto será o valor arrecadado.

int pequena, media, grande;
decimal valorArrecadado;

Console.WriteLine("Você precisa de quantas camisas pequenas?");
pequena = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Você precisa de quantas camisas médias");
media = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Você precisa de quantas camisas grandes?");
grande = Convert.ToInt32(Console.ReadLine());

valorArrecadado = (pequena*10) + (media*12) + (grande*15);


Console.WriteLine("O valor arrecadado é: R$ " + valorArrecadado);