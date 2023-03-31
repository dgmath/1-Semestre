// Programa maçã
Console.WriteLine($"Programa para calcular seu gasto com maçãs:");
Console.WriteLine($"Insira quantas maçãs voce pegou:");
int macas = int.Parse(Console.ReadLine());



if (macas >= 12)
{
float valor1 = (macas * 0.25F);
 Console.WriteLine($"O total foi de R${valor1}");
}
else 
{
    float valor2 = (macas * 0.30F);
    Console.WriteLine( "O total foi de " + Math.Round(valor2,2) );
}
