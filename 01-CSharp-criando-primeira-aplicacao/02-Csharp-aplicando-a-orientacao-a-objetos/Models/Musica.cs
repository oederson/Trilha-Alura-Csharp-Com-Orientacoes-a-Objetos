using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_Csharp_aplicando_a_orientacao_a_objetos.Models
{
    public class Musica
    // Pensando em uma musica o que ela tem
    //nome
    // artista
    //duração
    //disponivel
    {
        public Musica(Banda artista, string nome)
        {
            Nome = nome;
            Artista = artista;
        }
        public string Nome{get;set;} // se não for public não estará visivel para fora
        public Banda Artista{get;}
        public int Duracao{get;set;}
        public bool Disponivel{get;set;} // Propriedade
        //Propriedade lambda => No C#, lambdas são funções anônimas que podem ser usadas para criar expressões ou blocos de código compactos e concisos. Eles são especialmente úteis quando se trata de trabalhar com coleções de dados, realizar operações em uma sequência de elementos ou lidar com delegados.
        public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}";
           
        public void ExibirDadosDaMusica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Duração: {Duracao}");
            if(Disponivel) 
            {
                Console.WriteLine("Musica disponivel"); 
            }
            else
            { 
            Console.WriteLine("Musica indisponivel");
            }    
        }

    }
}