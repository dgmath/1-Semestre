using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto_Interface
{
    public class Carrinho : ICarrinho
    {
        public float Valor { get; set; }

        //Criar uma lista para manipular os objetos
        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Listar()
        {
            if (carrinho.Count > 0)
            {
                foreach (Produto item in carrinho)
                {

                 Console.WriteLine(@$"
                 Código: {item.Codigo}
                 Nome: {item.Nome}
                 Preço: {item.Preco:c2}
                 ");
                    
                }
            }
            else
            {
                Console.WriteLine($"Carrinho Vazio");
            }
            
        }

        public void Atualizar(int codigo, Produto novoProduto)
        {
            carrinho.Find(x => x.Codigo == codigo)!.Nome = novoProduto.Nome;
            carrinho.Find(x => x.Codigo == codigo)!.Preco = novoProduto.Preco;
        }

        public void Remover(Produto produto)
        {
            carrinho.Remove(produto);
        }

        public void TotalCarrinho()
        {
            Valor = 0;
            if (carrinho.Count > 0)
            {
                foreach (Produto item in carrinho)
                {
                    Valor += item.Preco;
                }
                Console.WriteLine($"O total do seu carrinho é {Valor:c2}");
            }
            else
            {
                Console.WriteLine($"Carrinho Vazio");
            }
        }
    }



}
