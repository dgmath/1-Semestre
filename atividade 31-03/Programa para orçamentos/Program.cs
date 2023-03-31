//Programa de orçamentos

Console.WriteLine($"Gerenciando seu orçamento");
Console.WriteLine($"Digite o valor do seu salario recebido:");
float salario = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite todo o valor de seus gasto:");
float gasto = float.Parse(Console.ReadLine());

if (salario > gasto)
{
    Console.WriteLine($"Gastos dentro do orçamento.");
    
}
else
{
    Console.WriteLine($"Orçamento estourado");
    
}