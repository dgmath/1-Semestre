// Atividade while programa de validação
//nome
bool nomeCorreto = false;
do
{
Console.WriteLine($"Digite seu nome: ");
string name = Console.ReadLine()!;

if (name == "")
{
    Console.WriteLine($"Por favor insira algum nome valido.");
    nomeCorreto = false;
}
else
{
    Console.WriteLine($"Parabéns seu nome foi verificado!");
    nomeCorreto = true;
}
}while(nomeCorreto == false);

// Idade

bool idadeCerta = false;
do{
Console.WriteLine($"Digite sua Idade: ");
int idade = int.Parse(Console.ReadLine()!);

if (idade >= 0 && idade <= 100)
{
    Console.WriteLine($"Parabéns sua idade foi verificada!");
    idadeCerta = true;
}
else 
{
    Console.WriteLine($"Por favor insira uma idade valida.");
    idadeCerta = false;
}
}while(idadeCerta == false);

//salario

bool salarioCerto = false;
do
{
Console.WriteLine($"Digite o seu salário: ");
float salario = float.Parse(Console.ReadLine()!);

if (salario <= 0)
{
    Console.WriteLine($"Insira um valor valido para o salario.");
    salarioCerto = false;
}
else
{
    Console.WriteLine($"Parabéns seu salário esta verificado.");
    salarioCerto = true;
}
}while(salarioCerto == false);

//estado civil
bool estadoCerto = false;
do
{
Console.WriteLine($"Digite seu estado civil:('s'(solteiro(a)), 'c'(casado(a)), 'v'(viúvo(a)), 'd'(divorciado(a)))");
char civil = char.Parse(Console.ReadLine()!);

if (civil != 's' && civil != 'c' && civil != 'v' && civil != 'd')
{
    Console.WriteLine($"Por favor insira novamente seu estado civil.");
    estadoCerto = false;
}
else{
    Console.WriteLine($"Parabéns seu estado civil foi verificado.");
   estadoCerto = true; 
}
}while(estadoCerto == false);

Console.WriteLine($"Cadastro realizado com sucesso!");
