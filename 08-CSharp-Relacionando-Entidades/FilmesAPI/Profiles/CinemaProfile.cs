using AutoMapper;
using FilmesAPI.Dados.DTOS;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile() 
        {
            CreateMap<CriarCinemaDTO, Cinema>();
            CreateMap<Cinema, LeiaCinemaDTO>()
                .ForMember(cinemaDto => cinemaDto.Endereco,
                opt => opt.MapFrom(cinema => cinema.Endereco))
                .ForMember(cinemaDto => cinemaDto.Sessoes,
                opt => opt.MapFrom(cinema => cinema.Sessoes));
            CreateMap<AtualizaCinemaDTO, Cinema>();
        }
    }
}
