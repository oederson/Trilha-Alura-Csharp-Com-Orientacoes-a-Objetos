using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_Csharp_aplicando_a_orientacao_a_objetos.Models
{
    public class Album
    {
        private List<Musica> musicas = new List<Musica>();
        public Album(string nome)
        {
            Nome = nome;
        }
        public string Nome { get;}
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }
        public void ExibirMusicaDoAlbum()
        {
            Console.WriteLine($"Lista do álbum {Nome} com a duração total {DuracaoTotal} segundos");
            foreach(var musica in musicas)
            {
                Console.WriteLine($"Música : {musica.Nome} com a duração {musica.Duracao}");
            }
        }
    }
}