using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_Csharp_aplicando_a_orientacao_a_objetos.Models
{
    public class Banda
    {
        private List<Album> albums = new List<Album>();
        public Banda(string nome)
        {
            Nome = nome;
        }
        public string Nome { get;}
        public void AdicionarAlbum(Album album)
        {
            albums.Add(album);
        }
        public void ExibirDiscografia()
        {
            Console.WriteLine($"Discografia da banda {Nome}");
            foreach(Album album in albums)
            {
                Console.WriteLine($"Album : {album.Nome}");
            }
        }
    }
}