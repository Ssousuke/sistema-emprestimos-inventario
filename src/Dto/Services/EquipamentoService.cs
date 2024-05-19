using AutoMapper;
using Domain.Interfaces;
using Domain.Models;
using Dto.Dto.Request;
using Dto.Dto.Response;
using Dto.Services.IServices;

namespace Dto.Services
{
    public class EquipamentoService(IBaseCrudGenerico<Equipamento> equipamentoRepository, IMapper mapper) : IEquipamentoServico
    {
        public async Task<EquipamentoResponseDto> Atualizar(EquipamentoRequestDto entity)
        {
            var result = mapper.Map<Equipamento>(entity);
            var equipamento = await equipamentoRepository.Atualizar(result);
            return mapper.Map<EquipamentoResponseDto>(equipamento);
        }

        public async Task<EquipamentoResponseDto> BuscarPorReferencia(string referencia)
        {
            var equipamento = await equipamentoRepository.BuscarPorReferencia(referencia);
            return mapper.Map<EquipamentoResponseDto>(equipamento);
        }

        public async Task<IEnumerable<EquipamentoResponseDto>> BuscarTodos()
        {
            var equipamento = await equipamentoRepository.BuscarTodos();
            return mapper.Map<IEnumerable<EquipamentoResponseDto>>(equipamento);
        }

        public async Task<EquipamentoResponseDto> Criar(EquipamentoRequestDto entity)
        {
            var result = mapper.Map<Equipamento>(entity);
            var equipamento = await equipamentoRepository.Criar(result);
            return mapper.Map<EquipamentoResponseDto>(equipamento);
        }

        public async Task<bool> Deletar(int id)
        {
            return await equipamentoRepository.Deletar(id);
        }
    }
}
