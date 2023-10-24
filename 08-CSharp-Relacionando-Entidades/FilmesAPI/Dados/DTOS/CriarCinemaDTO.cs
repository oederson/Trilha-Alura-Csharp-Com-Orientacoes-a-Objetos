using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Dados.DTOS
{
    public class CriarCinemaDTO
    {
        [Required(ErrorMessage = "O campo de nome é obrigatorio")]
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
    }
}
