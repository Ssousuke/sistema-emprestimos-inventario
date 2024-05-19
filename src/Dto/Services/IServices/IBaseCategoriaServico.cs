using Dto.Dto.Request;
using Dto.Dto.Response;

namespace Dto.Services.IServices
{
    public interface IBaseCategoriaServico
    {
        Task<IEnumerable<CategoriaResponseDto>> BuscarTodos();
        Task<CategoriaResponseDto> BuscarPorReferencia(string referencia);
        Task<CategoriaResponseDto> Criar(CategoriaRequestDto entity);
        Task<CategoriaResponseDto> Atualizar(CategoriaRequestDto entity);
        Task<bool> Deletar(int id);
    }
}
