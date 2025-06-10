// Ler um número inteiro ( assuma até 3 dígitos ) e imprima a saída da seguinte forma: CENTENA = X; DEZENA = X; UNIDADE = X.

int numero, centena, dezena, unidade;

Console.WriteLine("Digite um número de até 3 digitos:");
numero = Convert.ToInt32(Console.ReadLine());

centena = numero / 100;

dezena = (numero % 100) / 10;

unidade = numero % 10;

Console.WriteLine("CENTENA = " + centena);
Console.WriteLine("DEZENA = " + dezena);
Console.WriteLine("UNIDADE = " + unidade);