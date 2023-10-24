using AutoMapper;
using FilmesAPI.Dados;
using FilmesAPI.Dados.DTOS;
using FilmesAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{

    private FilmeContext _context;
    private IMapper _mapper;

    public FilmeController(FilmeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    [HttpPost]
    public CreatedAtActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto) //FromBody indica que está recebendo pelo corpo da requisição
    {
        Filme filme = _mapper.Map<Filme>(filmeDto);
        _context.Filmes.Add(filme);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperaFilmePorId), new { id = filme.Id }, filme);
    }

    [HttpGet]
    public IEnumerable<ReadFilmeDto> RecuperarFilme([FromQuery] int skip = 0, [FromQuery] int take = 50,
        [FromQuery] string? nomeDoCinema = null) //FromQuery especifica que parametros virão atraves da query
    {
        if (nomeDoCinema == null)
        {
            return _mapper.Map<List<ReadFilmeDto>>(_context.Filmes.Skip(skip).Take(take).ToList());
        }
        return _mapper.Map<List<ReadFilmeDto>>(_context.Filmes.Skip(skip).Take(take).ToList().Where(filme => filme.Sessoes.Any(sessao => sessao.Cinema.Nome == nomeDoCinema)).ToList());
    }

    [HttpGet("{id}")] //indica que esse get irá receber o ID
    public IActionResult RecuperaFilmePorId(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        var filmeDto = _mapper.Map<ReadFilmeDto>(filme);    
        return Ok(filmeDto);
    }
    [HttpPut("{id}")]
    public IActionResult AtualizarFilme(int id, [FromBody] UpdateFilmDto filmeDto)
    {
        var filme = _context.Filmes.FirstOrDefault(
            filme => filme.Id == id);
        if (filme == null) return NotFound();
        _mapper.Map(filmeDto, filme);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPatch("{id}")]
    public IActionResult AtualizarFilmeParcial(int id, [FromBody] JsonPatchDocument<UpdateFilmDto> patch)
    {
        var filme = _context.Filmes.FirstOrDefault(
            filme => filme.Id == id);
        if (filme == null) return NotFound();
        var filmeParaAtualizar = _mapper.Map<UpdateFilmDto>(filme);
        patch.ApplyTo(filmeParaAtualizar, ModelState);
        if (!TryValidateModel(filmeParaAtualizar))
        {
            return ValidationProblem(ModelState);
        }
        _mapper.Map(filmeParaAtualizar, filme);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaFilme(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(
        filme => filme.Id == id);
        if (filme == null) return NotFound();
        _context.Remove(filme);
        _context.SaveChanges();
        return NoContent();
    }
}
