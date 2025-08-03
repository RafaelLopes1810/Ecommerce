using Ecommerce.Backend.Domain.Entities;

namespace Ecommerce.Backend.Domain.Interfaces
{
    public interface IProdutoService
    {
        IEnumerable<Produto> ObterTodos();
        Produto? ObterPorId(Guid id);
        void Adicionar(Produto produto);
        void Atualizar(Produto produto);
        void Remover(Guid id);
    }
}