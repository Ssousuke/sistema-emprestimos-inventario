using Dto.Dto.Request;
using Dto.Dto.Response;

namespace Dto.Services.IServices
{
    public interface IBaseEquipamentoServico
    {
        Task<IEnumerable<EquipamentoResponseDto>> BuscarTodos();
        Task<EquipamentoResponseDto> BuscarPorReferencia(string referencia);
        Task<EquipamentoResponseDto> Criar(EquipamentoRequestDto entity);
        Task<EquipamentoResponseDto> Atualizar(EquipamentoRequestDto entity);
        Task<bool> Deletar(int id);
    }
}
