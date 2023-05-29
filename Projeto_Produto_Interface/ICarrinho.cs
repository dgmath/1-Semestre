using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto_Interface
{
    public interface ICarrinho
    {
        //regras do "Contrato"
        //métodos que deverão aqui ser apenas declarados

        //CRUD : Create, Read, Update, Delete
        //Modelo padrão de método
        //tipo Nome(parametros)

        // Create
        void Adicionar(Produto produto);

        // Read
        void Listar();

        // Update
        void Atualizar(int codigo, Produto produto);

        // Delete
        void Remover(Produto produto);

    }
}