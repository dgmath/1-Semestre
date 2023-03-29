//Programa para calcular idade em semanas

Console.WriteLine($"Informe sua data de nascimento: ");

int anoN = int.Parse(Console.ReadLine());
int anoA = (2023 - anoN);
int semana = (anoA * 52);
Console.WriteLine($"Você possui {anoA} anos e {semana} semanas");

