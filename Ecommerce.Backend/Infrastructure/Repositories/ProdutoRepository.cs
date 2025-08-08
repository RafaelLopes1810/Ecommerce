using Microsoft.EntityFrameworkCore;
using Ecommerce.Backend.Domain.Entities;
using Ecommerce.Backend.Domain.Interfaces;
using Ecommerce.Backend.Infrastructure.Persistence;

namespace Ecommerce.Backend.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProdutoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> GetAll()
        {
            return _context.Produtos.ToList();
        }

        public Produto? GetById(int id)
        {
            return _context.Produtos.Find(id);
        }

        public void Add(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Update(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var produto = _context.Produtos.Find(id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                _context.SaveChanges();
            }
        }
    }
}
