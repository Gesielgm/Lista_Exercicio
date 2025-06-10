//A lanchonee Gostosura vende apenas um tipo de sanduíche, cujo recheio inclui duas fatias de queijo, uma fatia de presunto e uma rodela de 
//hamburguer. Sabendo que cada fatia de queijo ou presunto pesa 50 gramas, e que a rodela de hambúrguer pesa 100 gramas
//faça um algoritmo que o dono forneça a quantidade de sanduúches a fazer, e a máquina informe as quantidades ( em quilos) de queijo,
//presunto e carne necessários para compra.


decimal quantSanduiches, queijo, presunto, carne;

Console.WriteLine("Qual a quantidade de hambúrgueres?");
quantSanduiches = Convert.ToDecimal(Console.ReadLine());

carne = (quantSanduiches * 100) / 1000;
queijo = (2* (quantSanduiches * 50)) / 1000;
presunto = (quantSanduiches * 50) / 1000;


Console.WriteLine("A quantidade necessária (em quilos) de carne é: " + carne);
Console.WriteLine("A quantidade necessária (em quilos) de queijo é: " + queijo);
Console.WriteLine("A quantidade necessária (em quilos) de presunto é: " + presunto); 
