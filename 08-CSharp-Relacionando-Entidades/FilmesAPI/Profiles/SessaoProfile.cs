using AutoMapper;
using FilmesAPI.Dados.DTOS;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CriarSessaoDTO, Sessao>();
            CreateMap<Sessao, LeiaSessaoDTO>();
        }
    }
}
