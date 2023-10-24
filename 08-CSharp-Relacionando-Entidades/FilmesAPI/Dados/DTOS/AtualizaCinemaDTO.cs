﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Dados.DTOS
{
    public class AtualizaCinemaDTO
    {
        [Required(ErrorMessage = "O campo de nome é obrigatorio")]
        public string Nome { get; set; }
    }
}
