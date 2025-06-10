//Um tonel de refresco é feito com 8 partes de água mineral e 2 partes de suco de maracujá. Faça um algoritmo para calcular quantos 
//litros de água e de suco são necessários para se fazer X litros de refrsco ( informados pelo usuário ).


//Considerando que cada parte são equivalentes a 100ml


decimal agua, suco, litros; 

Console.WriteLine("Quantos litros de refresco serão feitos?");
litros = Convert.ToInt32(Console.ReadLine());

agua = litros * (0.8m);

suco = litros * (0.2m);

Console.WriteLine("Serão necessários " + agua + " litros de água e " + suco + " litros de suco."); 