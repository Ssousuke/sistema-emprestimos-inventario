using AutoMapper;
using Domain.Interfaces;
using Domain.Models;
using Dto.Dto.Request;
using Dto.Dto.Response;
using Dto.Services.IServices;

namespace Dto.Services
{
    public class CategoriaService(IBaseCrudGenerico<Categoria> _categoriaRepository, IMapper _mapper) : ICategoriaServico
    {
        public async Task<CategoriaResponseDto> Atualizar(CategoriaRequestDto entity)
        {
            var categoriaMapper = _mapper.Map<Categoria>(entity);
            var categoriaDto = await _categoriaRepository.Atualizar(categoriaMapper);
            return _mapper.Map<CategoriaResponseDto>(categoriaDto);
        }

        public async Task<CategoriaResponseDto> BuscarPorReferencia(string referencia)
        {
            var result = await _categoriaRepository.BuscarPorReferencia(referencia);
            return _mapper.Map<CategoriaResponseDto>(result);
        }

        public async Task<IEnumerable<CategoriaResponseDto>> BuscarTodos()
        {
            var result = await _categoriaRepository.BuscarTodos();
            return _mapper.Map<IEnumerable<CategoriaResponseDto>>(result);
        }

        public async Task<CategoriaResponseDto> Criar(CategoriaRequestDto entity)
        {
            var categoriaMapper = _mapper.Map<Categoria>(entity);
            var categoria = await _categoriaRepository.Criar(categoriaMapper);
            return _mapper.Map<CategoriaResponseDto>(categoria);
        }

        public async Task<bool> Deletar(int id)
        {
            return await _categoriaRepository.Deletar(id);
        }
    }
}
