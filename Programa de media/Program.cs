//Programa de media do aluno
Console.WriteLine($"Informe suas 5 notas finais");

Console.WriteLine($"Digite a sua primeira nota");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a sua segunda nota");
float nota2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a sua terceira nota");
float nota3 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a sua quarta nota");
float nota4 = float.Parse(Console.ReadLine());

Console.WriteLine($"Digite a sua quinta nota");
float nota5 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

Console.WriteLine($"Sua média é {media}");




