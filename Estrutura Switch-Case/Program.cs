//switch (//valor que quero comparar)

//    case x: 
    //bloco de codigo a ser executado
 //   break;

//    case y: 
    //bloco de codigo a ser executado
 //   break;
    
 //   case z: 
    //bloco de codigo a ser executado
 //   break;

 //   default: //encerramento
    //bloco de codigo ou mensagem 
  //  break;

//programa para identificar qual o dia da semana

Console.WriteLine($"Informe o numero correspondente ao dia da semana: ");
int diaSemana = int.Parse(Console.ReadLine());

switch (diaSemana)
{
    case 1:
    //bloco de codigos
    Console.WriteLine($"Domingo");
    break;

    case 2:
    //bloco de codigos
    Console.WriteLine($"Segunda-Feira");
    break;

    case 3:
    //bloco de codigos
    Console.WriteLine($"Terça-Feira");
    break;

    case 4:
    //bloco de codigos
    Console.WriteLine($"Quarta-Feira");
    break;

    case 5:
    //bloco de codigos
    Console.WriteLine($"Quinta-Feira");
    break;

    case 6:
    //bloco de codigos
    Console.WriteLine($"Sexta-Feira");
    break;

    case 7:
    //bloco de codigos
    Console.WriteLine($"Sabado");
    break;

    default:
    Console.WriteLine($"Desculpe, o número informado não é válido, informe um número de 1 a 7 e tente novamente.");
    break;
}
