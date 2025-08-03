using Ecommerce.Backend.Domain.Entities;

namespace Ecommerce.Backend.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();
        Produto? GetById(Guid id);
        void Add(Produto produto);
        void Update(Produto produto);
        void Delete(Guid id);
    }
}
