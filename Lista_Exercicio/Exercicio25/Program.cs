//Calcule o volume de uma caixa d'água cilíndrica.

decimal altura, comprimento, largura, volumeM, volume;

Console.WriteLine("Qual a altura da caixa d'água em metros?");
altura = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Qual o comprimento da caixa dágua em metros?");
comprimento = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Qual a largura da caixa dágua em metros?");
largura = Convert.ToDecimal(Console.ReadLine());


volumeM = (altura * comprimento) * largura;

Console.WriteLine("O volume em metros cúbicos da caixa d'água é: " + volumeM + " m³.");

volume = volumeM * 1000;

Console.WriteLine("O volume em litros da caixa é: " + volume + " litros.");
