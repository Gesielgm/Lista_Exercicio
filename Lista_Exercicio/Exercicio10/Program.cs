//Construa um algoritmo para calcular a distância entre dois pontos do plano cartesiano. Cada ponto é um par ordenado (x,y)

int x1, x2, y1, y2, distancia1, distancia2;

Console.WriteLine("Digite o valor de x1");
x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de x2");
x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de y1");
y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de y2");
y2 = Convert.ToInt32(Console.ReadLine());

distancia1 = (x2 - x1);
distancia2 = (y2 - y1);

double quadrado1 = Math.Pow(distancia1, 2);
double quadrado2 = Math.Pow(distancia2, 2);

double raiz = Math.Sqrt(quadrado1 + quadrado2);


Console.WriteLine("A distância é aproximadamente: " + raiz);