//Programa para calcular idade e seus respectivos valores

Console.WriteLine($"Calcule quantos dias, mesês, horas, e minutos você possui:");

Console.WriteLine($"Insira sua idade: ");
int idade = int.Parse(Console.ReadLine());
int meses = (idade * 12);
int dias = (meses * 30);
int horas = (dias * 24);
float minutos = (horas * 60);
Console.WriteLine($"Você tem {idade} anos {meses} mesês {dias} dias {horas} horas e {minutos} minutos");

