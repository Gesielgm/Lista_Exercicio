//A granja Frangotech possui um controle automatizado de cada frango da sua produção.
//No pé direito do frango há um anel com um chip de indentificação; no pé esquerdo são dois anéis para indicar o tipo de alimento que ele 
//deve consumir. Sabendo que o anel com chip custa R$ 4,00 e o anel de alimento custa R$ 3,50, façaum algoritmo para calcular o gasto total
// da granja para marcar todos os seus frangos.

int frangos;
decimal  anelChip, anelAlimento, valorTotal;

Console.WriteLine("Quantos frangos existem na granja?");
frangos = Convert.ToInt32(Console.ReadLine());

anelChip = frangos * 4.00m;
anelAlimento = frangos * 3.50m;

valorTotal = anelChip + (anelAlimento * 2);

Console.WriteLine("O valor total para equipar os frangos é: R$ " + valorTotal); 
