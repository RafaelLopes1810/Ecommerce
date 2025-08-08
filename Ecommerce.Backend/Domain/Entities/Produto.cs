using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Backend.Domain.Entities;

public class Produto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public decimal Preco { get; private set; }
    public int Estoque { get; private set; }

    public Produto(string nome, string descricao, decimal preco, int estoque)
    {
        Nome = nome;
        Descricao = descricao;
        Preco = preco;
        Estoque = estoque;
    }

    public void Atualizar(string nome, string descricao, decimal preco, int estoque)
    {
        Nome = nome;
        Descricao = descricao;
        Preco = preco;
        Estoque = estoque;
    }

    public void AlterarEstoque(int quantidade)
    {
        Estoque += quantidade;
    }

    // EF Core precisa de um construtor vazio (opcionalmente, pode ser protected)
    protected Produto() { }
}
