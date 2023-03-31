//Programa para calcular o valor de um alimento com base em seu peso
Console.WriteLine($"Vamos calcular em reais o valor do kg de seu alimento");
Console.WriteLine($"Digite o valor para o kg do seu alimento: ");
float preco = float.Parse(Console.ReadLine());

Console.WriteLine($"Agora digite o peso em kg do seu alimento: ");
float peso = float.Parse(Console.ReadLine());

float valor = (preco * peso);
Console.WriteLine($"O valor em kg do seu alimento é R${valor}");
