//Programa para calcular idade em semanas

Console.WriteLine($"Informe seu ano de nascimento: ");

int anoN = int.Parse(Console.ReadLine());
int anoA = (DateTime.Now.Year - anoN);
int semana = (anoA * 52);
Console.WriteLine($"Você possui {anoA} anos e {semana} semanas");

