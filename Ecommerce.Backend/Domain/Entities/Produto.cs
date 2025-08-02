using System;

namespace Ecommerce.Backend.Domain.Entities
{
    public class Produto
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public int Estoque { get; private set; }

        // Construtor para criação do produto
        public Produto(string nome, string descricao, decimal preco, int estoque)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
        }

        // Método para atualizar dados
        public void Atualizar(string nome, string descricao, decimal preco, int estoque)
        {
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
        }

        // Método para remover ou adicionar estoque
        public void AlterarEstoque(int quantidade)
        {
            Estoque += quantidade;
        }
    }
}
