//variáveis

//declarando uma variável
//tipo name = valor
// string name = "Matheus";
// const int idade = 36;
// Console.WriteLine("A idade do " + name + " é " + idade + " anos");

// tipos de dados
// int quantidade = 10;
// double preco = 4.99D;
// float altura = 1.80F;
// bool careca = true;
// Console.WriteLine(careca);
// string texto = "Olá, mundo";
// char letra = 'C';

// operador de atribuicao
// int idade = 36;

// operadores aritmeticos

//   soma
//  Console.WriteLine(4 + 4);
//   Console.WriteLine(4 + "4");

//   subtracao
//  Console.WriteLine(10 - 5);
//   multiplicacao
//  Console.WriteLine(5 * 9);
//   divisao
//  Console.WriteLine(10 / 2);
//   modular
//  Console.WriteLine(5 % 2);




// // operadores de comparacao - resposta true or false

// // igual a
// Console.WriteLine(5 == 5);

// // maior ou igual a
// Console.WriteLine(5 >= 4);

// // menor ou igual a
// Console.WriteLine(4 <= 3);
// Console.WriteLine(4 <= 4);

// // maior que
// Console.WriteLine(5 > 1);

// // menor que
// Console.WriteLine(5 < 2);

// // diferente de
// Console.WriteLine(5 != 8);


// operadores logicos e tabela verdade

// && : e
// || : ou
//  ! : negacao

// // &&
//  Console.WriteLine(5 == 5 && 8 == 8);// TRUE && TRUE = TRUE
//  Console.WriteLine(5 == 5 && 8 == 8);// TRUE && FALSE = FALSE
// //  ||
//  Console.WriteLine(2 == 2 || 3 == 3); //TRUE || TRUE = TRUE
//  Console.WriteLine(2 == 2 || 3 == 4); //TRUE || FALSE = TRUE
//  Console.WriteLine(1 == 2 || 3 == 4); //FALSE || FALSE = FALSE
// //  !
// Console.WriteLine(!(2 == 3 || 3 == 2));//FALSE || FALSE = TRUE (INVERTE)


// crie um programa para calcular o IMC de uma pessoa

// Inicio
string nome = "Matheus";
float peso = 60.2F;
float altura = 1.68F;

//  Processamento
float imc = peso / (altura * altura);

// Resposta
Console.WriteLine("O IMC do " + nome + " é de : " + Math.Round(imc,2));
