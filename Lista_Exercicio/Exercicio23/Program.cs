//Num dia de sol, você deseja medir a altura de um prédio, porém, a trena não é suficientemente longa.
//Assumindo que seja possíel medir sua sombra e a do prédio no chão, e que você lembre a sua altura, faça um algoritmo
//para ler os dados necessários e calcular a altura do prédio.


decimal altura, sombra, alturaPredio, sombraPredio;

Console.WriteLine("Digite sua altura:");
altura = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o tamanho da sua sombra em metros: (EX: 0,60)");
sombra = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite o tamanho da sombra do prédio:");
sombraPredio = Convert.ToDecimal(Console.ReadLine());



alturaPredio = (altura * sombraPredio) / sombra;



Console.WriteLine("A altura do prédio é: " + alturaPredio); 

