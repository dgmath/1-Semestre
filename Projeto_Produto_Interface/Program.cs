//instância do objeto carrinho
using Projeto_Produto_Interface;

Carrinho carrinho = new Carrinho();

//instanciar objeto(s) da classe produto
Produto p1 = new Produto(1,"Vitoria", 100f);
Produto p2 = new Produto(2,"Vinicius", 50f);
Produto p3 = new Produto(3,"Dudu", 70f);

//chama o método Adicionar e passa os objetos como parametros
carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

//chama o metodo Listar
carrinho.Listar();

//chama o metodo TotalCarrinho
carrinho.TotalCarrinho();
Console.WriteLine();
Console.WriteLine($"Após a remoção de um item");

//chama o metodo remover
carrinho.Remover(p1);
carrinho.Remover(p2);

//chama o metodo Listar
carrinho.Listar();

//chama o metodo TotalCarrinho
carrinho.TotalCarrinho();
//chama o metodo Atualizar, passando 

Console.WriteLine($"Agora vamos atualizar um objeto");

//criar um objeto com os dados atualizados

Produto novoProduto = new Produto();
novoProduto.Nome = "Fifa 2023";
novoProduto.Preco = 300f;

carrinho.Atualizar(3,novoProduto);

carrinho.Listar();

carrinho.TotalCarrinho();