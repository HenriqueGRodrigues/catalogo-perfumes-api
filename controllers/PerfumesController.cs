using Microsoft.AspNetCore.Mvc;
using CatalogoPerfumesApi.Models;

namespace CatalogoPerfumesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerfumesController : ControllerBase
    {
        private static readonly List<Perfume> _perfumes = new()
        {
            new Perfume { Id = 1, Nome = "Versus Pour Homme", Marca = "ITB", Categoria = "Eau de Toilette", Preco = 450.00m },
            new Perfume { Id = 2, Nome = "MySlf", Marca = "ITB", Categoria = "Eau de Parfum", Preco = 320.00m }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Perfume>> ObterTodos()
        {
            return Ok(_perfumes);
        }

        [HttpGet("{id}")]
        public ActionResult<Perfume> ObterPorId(int id)
        {
            var perfume = _perfumes.FirstOrDefault(p => p.Id == id);
            if (perfume == null)
            {
                return NotFound(new { mensagem = "Perfume não encontrado." });
            }
            return Ok(perfume);
        }

        [HttpPost]
        public ActionResult<Perfume> Criar(Perfume novoPerfume)
        {
            novoPerfume.Id = _perfumes.Any() ? _perfumes.Max(p => p.Id) + 1 : 1;
            _perfumes.Add(novoPerfume);
            return CreatedAtAction(nameof(ObterPorId), new { id = novoPerfume.Id }, novoPerfume);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var perfume = _perfumes.FirstOrDefault(p => p.Id == id);
            if (perfume == null)
            {
                return NotFound(new { mensagem = "Perfume não encontrado." });
            }

            _perfumes.Remove(perfume);
            return NoContent();
        }
    }
}