using Microsoft.AspNetCore.Mvc;
using Ecommerce.Backend.Domain.Interfaces;
using Ecommerce.Backend.Domain.Entities;

namespace Ecommerce.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        // GET: api/produto
        [HttpGet]
        public IActionResult Get()
        {
            var produtos = _produtoService.ObterTodos();
            return Ok(produtos);
        }

        // GET: api/produto/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var produto = _produtoService.ObterPorId(id);
            if (produto == null)
                return NotFound();

            return Ok(produto);
        }

        // POST: api/produto
        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _produtoService.Adicionar(produto);
            return CreatedAtAction(nameof(Get), new { id = produto.Id }, produto);
        }

        // PUT: api/produto/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Produto produto)
        {
            if (id != produto.Id)
                return BadRequest("ID do produto não confere.");

            _produtoService.Atualizar(produto);
            return NoContent();
        }

        // DELETE: api/produto/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var produto = _produtoService.ObterPorId(id);
            if (produto == null)
                return NotFound();

            _produtoService.Remover(id);
            return NoContent();
        }
    }
}
