//PROGRAMA IMC

//Faça um programa que calcule o imc de uma pessoa recebendo os dados no console,ao final imprima o resultado no console
Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine(@$"
------------------
|  Programa para |
|  calcular IMC  |
------------------
");
Console.ResetColor();

Console.BackgroundColor = ConsoleColor.Blue;
Console.WriteLine($"Informe o nome do paciente: ");
string nome = Console.ReadLine();

Console.WriteLine($"Informe o peso atual do paciente: ");
float peso = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a altura do paciente: ");
float altura = float.Parse(Console.ReadLine());

float imc = peso / ((float)Math.Pow(altura,2));
Console.ResetColor();
//concatenacao
//Console.WriteLine("O paciente " + nome + " tem o imc igual a: " + imc);

Console.ForegroundColor = ConsoleColor.Magenta;
//interpolacao
Console.WriteLine($"O paciente {nome} tem o imc igual a: {imc}");
Console.ResetColor();


 