using Dto.Dto.Request;
using Dto.Dto.Response;
using Dto.Services.IServices;

namespace Dto.Services
{
    public class EquipamentoService : IEquipamentoServico
    {
        public Task<EquipamentoResponseDto> Atualizar(EquipamentoRequestDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<EquipamentoResponseDto> BuscarPorReferencia(string referencia)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EquipamentoResponseDto>> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Task<EquipamentoResponseDto> Criar(EquipamentoRequestDto entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Deletar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
