// Nome e senha para um usuario

Console.WriteLine($"Informeo nome do usuario");
string nome = Console.ReadLine();

Console.WriteLine($"Informe a senha com 6 caracteres: ");
string senha = Console.ReadLine();

while (senha.Length != 6)
{
    Console.WriteLine($"Informe a senha novamente, é preciso ter 6 caracteres.");
    senha = Console.ReadLine();
}

Console.WriteLine($"Usuario e senha recebidos com sucesso!");
