//A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões deum terreno e depois exibir a área do terreno.

decimal comprimento, largura;

Console.WriteLine("Digite o comprimento do terreno:");
comprimento = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a largura do terreno:");
largura = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("A área do terreno é: " + comprimento * largura);