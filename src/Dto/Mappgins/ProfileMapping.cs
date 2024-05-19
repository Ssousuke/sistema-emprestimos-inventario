using AutoMapper;
using Domain.Models;
using Dto.Dto.Request;
using Dto.Dto.Response;

namespace Dto.Mappgins
{
    public class ProfileMapping : Profile
    {
        public ProfileMapping()
        {
            CreateMap<Categoria, CategoriaResponseDto>().ReverseMap();
            CreateMap<Categoria, CategoriaRequestDto>().ReverseMap();
            CreateMap<CategoriaRequestDto, CategoriaResponseDto>().ReverseMap();

            CreateMap<Equipamento, EquipamentoResponseDto>().ReverseMap();
            CreateMap<Equipamento, EquipamentoRequestDto>().ReverseMap();
            CreateMap<EquipamentoRequestDto, EquipamentoResponseDto>().ReverseMap();
        }
    }
}
