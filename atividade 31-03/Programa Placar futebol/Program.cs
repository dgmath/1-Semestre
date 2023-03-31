// Programa Placar

Console.WriteLine($"Vamos descobrir a colocação do time após sua partida:");
Console.WriteLine($"Informe a quantidade de gols do primeiro time:");
int gols1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Agora informe a quantidade de gols do segundo time:");
int gols2 = int.Parse(Console.ReadLine());

if (gols1 == gols2)
{
    Console.WriteLine($"O placar é de empate");
}

else if (gols1 > gols2)
{
    Console.WriteLine($"O primeiro time foi o vencedor!"); 
}

else
{
    Console.WriteLine($"O segundo time foi o vencedor!");
}