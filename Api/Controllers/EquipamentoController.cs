using Dto.Dto.Request;
using Dto.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipamentoController : ControllerBase
    {
        private readonly IBaseEquipamentoServico _equipamentoServico;

        public EquipamentoController(IBaseEquipamentoServico equipamentoServico)
        {
            _equipamentoServico = equipamentoServico;
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarEquipamentos()
        {
            var result = await _equipamentoServico.BuscarTodos();
            if (result is null)
                return NoContent();

            return Ok(result);
        }

        [HttpGet("buscar/{referencia}")]
        public async Task<IActionResult> BuscarEquipamentos(string referencia)
        {
            var result = await _equipamentoServico.BuscarPorReferencia(referencia);
            if (result is null)
                return NoContent();

            return Ok(result);
        }

        [HttpPut("atualizar")]
        public async Task<IActionResult> AtualizarEquipamentos(EquipamentoRequestDto equipamentoRequestDto)
        {
            var result = await _equipamentoServico.Atualizar(equipamentoRequestDto);
            if (result is null)
                return NoContent();

            return Ok(result);
        }

        [HttpPost("criar")]
        public async Task<IActionResult> CriarEquipamentos(EquipamentoRequestDto equipamentoRequestDto)
        {
            var result = await _equipamentoServico.Criar(equipamentoRequestDto);
            if (result is null)
                return NoContent();

            return Ok(result);
        }

        [HttpGet("deletar/{id}")]
        public async Task<IActionResult> DeletarEquipamentos(int id)
        {
            var result = await _equipamentoServico.Deletar(id);
            if (result)
                return NotFound();

            return Ok(result);
        }
    }
}
