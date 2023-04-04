// //calculadora

Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine(@$"
-----------------------
|  Seja bem vindo ao  |
|   Lar das bebidas   |
-----------------------
"); Console.ResetColor();
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(@$"
----------------------
|      Cardápio:     |
|                    |
|----> Coca cola (1) |
|----> Pepsi (2)     |
|----> Fanta (3)     |
|----> Monster (4)   |
|                    |
|  Informe a bebida  |
|   de sua escolha   |
|     em número:     |
----------------------
"); Console.ResetColor();
int bebida = int.Parse(Console.ReadLine()!);

switch (bebida)
{
    case 1:
    Console.WriteLine($"A bebida escolhida foi Coca cola");
    Console.WriteLine($"Deseja adicionar gelo? Digite 1 para sim e 2 pra não:");
    int gelo = int.Parse(Console.ReadLine()!);
   
    if (gelo == 1)
    {
    Console.WriteLine($"Coca cola com gelo.");}

    else
    {
        Console.WriteLine($"Coca cola sem gelo");
    }
        break;
    
        case 2:
    Console.WriteLine($"A bebida escolhida foi Pepsi");
    Console.WriteLine($"Deseja adicionar gelo? Digite 1 para sim e 2 pra não:");
    int gelo2 = int.Parse(Console.ReadLine()!);
   
    if (gelo2 == 1)
    {
    Console.WriteLine($"Pepsi com gelo.");}

    else
    {
        Console.WriteLine($"Pepsi sem gelo");
    }
        break;

            case 3:
    Console.WriteLine($"A bebida escolhida foi Fanta");
    Console.WriteLine($"Deseja adicionar gelo? Digite 1 para sim e 2 pra não:");
    int gelo3 = int.Parse(Console.ReadLine()!);
   
    if (gelo3 == 1)
    {
    Console.WriteLine($"Fanta com gelo.");}

    else
    {
        Console.WriteLine($"Fanta sem gelo");
    }
        break;

            case 4:
    Console.WriteLine($"A bebida escolhida foi Monster");        
    Console.WriteLine($"Deseja adicionar gelo? Digite 1 para sim e 2 pra não:");
    int gelo4 = int.Parse(Console.ReadLine()!);
   
    if (gelo4 == 1)
    {
    Console.WriteLine($"Monster com gelo.");}

    else
    {
        Console.WriteLine($"Monster sem gelo");
    }
        break;

    default:
    Console.WriteLine($"Desculpe, é preciso que você informe o valor novamente.");
    
        break;
}

// //Algoritmo

// //1. informar a operacao
// //2. informar o primeiro numero
// //3. infrmar o segundo numero
// //4. processar os dados
// //5. exibir resultado

// //entrada

// Console.WriteLine(@$"
// ---------------------------
// | Programa de calculadora |
// |                         |
// |   Informe a operação    |
// |                         |
// |   (+) Soma              |
// |   (-) Subtração         |
// |   (*) Multiplicação     |
// |   (/) Divisão           |
// |                         |
// ---------------------------
// ");

// char operacao = char.Parse(Console.ReadLine());

// Console.WriteLine($"Informe o primeiro número: ");
// double num1 = double.Parse(Console.ReadLine());

// Console.WriteLine($"Informe o segundo número: ");
// double num2 = double.Parse(Console.ReadLine());

// double resultado = 0;

// //processamento

// switch (operacao)
// {
//     case '+':
//     resultado = (num1 + num2);
//     Console.WriteLine($"O resultado da Conta é {resultado}");
    
//         break;

//     case '-':
//         resultado = (num1 - num2);
//             Console.WriteLine($"O resultado da Conta é {resultado}");
//         break;

//     case '*':
//         resultado = (num1 * num2);
//             Console.WriteLine($"O resultado da Conta é {resultado}");
//         break;

//     case '/':
//         resultado = (num1 / num2);
//             Console.WriteLine($"O resultado da Conta é {resultado}");
//         break;

//     default:
//             Console.WriteLine($"Operação invalida, repita o processo corretamente.");
//         break;
// }

//Coca cola
//Pepsi
//Fanta
//Monster

//Crie um menu de opções e peça para o usuário escolher uma das opções
//Dependendo da opção, exiba uma mensagem se gostaria de acrescentar gelo
//Se sim, exiba uma mensagem que a bebida em questao sera com adicional de gelo 
//Caso o contrario a bebida é sem gelo adicional.]