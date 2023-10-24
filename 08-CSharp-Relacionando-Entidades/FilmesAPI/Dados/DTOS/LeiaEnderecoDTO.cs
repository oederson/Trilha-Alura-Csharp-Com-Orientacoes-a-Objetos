using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Dados.DTOS
{
    public class LeiaEnderecoDTO
    {
        public int Id { get; set; }
        public string Logadouro { get; set; }
        public int Numero { get; set; }
    }
}
