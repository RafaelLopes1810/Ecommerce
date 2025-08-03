using Ecommerce.Backend.Domain.Interfaces;
using Ecommerce.Backend.Domain.Entities;

namespace Ecommerce.Backend.Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> ObterTodos()
        {
            return _produtoRepository.GetAll();
        }

        public Produto? ObterPorId(Guid id)
        {
            return _produtoRepository.GetById(id);
        }

        public void Adicionar(Produto produto)
        {
            _produtoRepository.Add(produto);
        }

        public void Atualizar(Produto produto)
        {
            _produtoRepository.Update(produto);
        }

        public void Remover(Guid id)
        {
            _produtoRepository.Delete(id);
        }
    }
}
