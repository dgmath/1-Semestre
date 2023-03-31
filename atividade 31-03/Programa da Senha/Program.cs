// Programa Senha
Console.WriteLine($"Identifique se sua senha é válida:");
Console.WriteLine($"Digite sua senha:");
int senha = int.Parse(Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine($"ACESSO PERMITIDO");
}
else
{
    Console.WriteLine($"ACESSO NEGADO");
}

