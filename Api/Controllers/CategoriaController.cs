using Dto.Dto.Request;
using Dto.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly IBaseCategoriaServico _servicoCategoria;

        public CategoriaController(IBaseCategoriaServico servicoCategoria)
        {
            _servicoCategoria = servicoCategoria;
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarCategorias()
        {
            var result = await _servicoCategoria.BuscarTodos();
            if (result.Any())
                return Ok(result);

            return NoContent();
        }

        [HttpGet("buscar/{referencia}")]
        public async Task<IActionResult> BuscarPorReferencia(string referencia)
        {
            var result = await _servicoCategoria.BuscarPorReferencia(referencia);
            if (result is not null)
                return Ok(result);

            return NoContent();
        }

        [HttpPut("atualizar")]
        public async Task<IActionResult> AtualizarCategoria(CategoriaRequestDto entity)
        {
            var result = await _servicoCategoria.Atualizar(entity);
            if (result is null)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("criar")]
        public async Task<IActionResult> CriarCategoria(CategoriaRequestDto entity)
        {
            var result = await _servicoCategoria.Criar(entity);
            if (result is null)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpDelete("deletetar/{id}")]
        public async Task<IActionResult> DeletarCategoria(int id)
        {
            var result = await _servicoCategoria.Deletar(id);
            if (result)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
