//Faça um algoritmo que calcule a área de um losango. Sabe-se que: A = (diagonal_maior * diagonal_menor)/2.

decimal diagonalMaior, diagonalMenor, area;

Console.WriteLine("Digite a diagonal maior do losango em metros:");
diagonalMaior = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a diagonal menor do losango em metros:");
diagonalMenor = Convert.ToDecimal(Console.ReadLine());


area = (diagonalMaior * diagonalMenor) / 2;

Console.WriteLine("A área do losango é: " + area + " m²."); 