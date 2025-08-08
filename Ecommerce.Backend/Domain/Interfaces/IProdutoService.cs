using Ecommerce.Backend.Domain.Entities;

namespace Ecommerce.Backend.Domain.Interfaces
{
    public interface IProdutoService
    {
        IEnumerable<Produto> ObterTodos();
        Produto? ObterPorId(int id);
        void Adicionar(Produto produto);
        void Atualizar(Produto produto);
        void Remover(int id);
    }
}