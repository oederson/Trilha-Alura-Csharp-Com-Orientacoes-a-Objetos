using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Dados.DTOS;

public class CreateFilmeDto
{
   
    [Required(ErrorMessage = "Titulo do filme é obrigatório")] //DATA ANOTATION
    public string Titulo { get; set; }

    [Required(ErrorMessage = "Genero do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero não pode passar de 50 caracteres")] // Tamanho máximo
    public string Genero { get; set; }

    [Required(ErrorMessage = "Duração do filme é obrigatório")]
    [Range(70, 600, ErrorMessage = "A duração deve ser de 70 a 600 minutos")]//De , Até
    public int Duracao { get; set; }
}
