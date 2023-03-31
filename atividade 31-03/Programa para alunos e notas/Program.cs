//Programa para media de alunos e sua frequencia
Console.WriteLine($"Vamos calcular a média e a frequencia do aluno e descobrir se ele sera aprovado, reprovado ou então está de recuperação");
Console.WriteLine($"Insira a frequencia do aluno (insira apenas o numero sem o sinal %)");
int freq = int.Parse(Console.ReadLine());

Console.WriteLine($"Insira a média do aluno:");
int media = int.Parse(Console.ReadLine());

if (freq < 75){Console.WriteLine($"O aluno esta reprovado por nao possuir a frequencia minima.");}

else if (media >= 3)
{
    if (media > 7){Console.WriteLine($"O aluno foi aprovado!");}
    
    else{Console.WriteLine($"O aluno podera fazer uma avaliação de recuperação");}  
}

else{Console.WriteLine($"O aluno foi reprovado!");}