using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Dados.DTOS
{
    public class LeiaCinemaDTO
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public LeiaEnderecoDTO Endereco { get; set; }
        public ICollection<LeiaSessaoDTO> Sessoes { get; set; }
    }
}
