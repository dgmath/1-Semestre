// Programa lados
Console.WriteLine($"Informe os lados de seu triângulo");
Console.WriteLine($"Primeiro lado");
float lado1 = float.Parse(Console.ReadLine());
Console.WriteLine($"Segundo lado");
float lado2 = float.Parse(Console.ReadLine());
Console.WriteLine($"Terceiro lado");
float lado3 = float.Parse(Console.ReadLine());

if (lado1 == lado2 && lado1 == lado3 && lado2== lado3)
{
    Console.WriteLine($"Seu triângulo Equilatero");
    
}
else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
{
    Console.WriteLine($"Seu triângulo Escaleno");
}
else
{
    Console.WriteLine($"Seu triângulo Isosceles");
    
}