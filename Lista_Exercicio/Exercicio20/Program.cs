//Uma confecção produz X blusas de lã e para isto gasta uma certa quantidade de novelos. Faça um algoritmo para calcular quantos novelos
//de lã ela gasta por blusa.


int novelo, blusas, totalNovelos;

Console.WriteLine("Quantos novelos de lã precisa para confeccionar uma blusa:");
novelo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Quantas blusas deseja confeccionar?");
blusas = Convert.ToInt32(Console.ReadLine());


totalNovelos = novelo * blusas;

Console.WriteLine("Serão necessários " + totalNovelos + " novelos para confeccionar o total de blusas.");