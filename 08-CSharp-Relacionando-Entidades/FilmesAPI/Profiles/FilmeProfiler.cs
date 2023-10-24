using AutoMapper;
using FilmesAPI.Dados.DTOS;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles;

public class FilmeProfiler : Profile
{
    public FilmeProfiler()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmDto, Filme>();
        CreateMap<Filme, UpdateFilmDto>();
        CreateMap<Filme, ReadFilmeDto>();
             //.ForMember(cinemaDto => cinemaDto.Sessoes,
              //  opt => opt.MapFrom(cinema => cinema.Sessoes));
    }
}
