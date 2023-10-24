using AutoMapper;
using FilmesAPI.Dados.DTOS;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile() 
        {
            CreateMap<CriarEnderecoDTO, Endereco>();
            CreateMap<Endereco, LeiaEnderecoDTO>();
            CreateMap<AtualizaCinemaDTO, Endereco>();
        }
    }
}
