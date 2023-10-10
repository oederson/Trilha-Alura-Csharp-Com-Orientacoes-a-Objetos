using _04_CSharp_Consumindo_API_gravando_arquivos_e_utlizando_o_LINQ.Modelos;
using System.Text.Json;
using _04_CSharp_Consumindo_API_gravando_arquivos_e_utlizando_o_LINQ.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        //musicas[1].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");


        //var musicasPreferidasDoJoao = new MusicasPreferidas("Joao");
        //musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoJoao.AdicionarMusicasFavoritas(musicas[1467]);

        //var musicasPreferidasMaria = new MusicasPreferidas("Maria");

        //musicasPreferidasMaria.AdicionarMusicasFavoritas(musicas[500]);
        //musicasPreferidasMaria.AdicionarMusicasFavoritas(musicas[637]);
        //musicasPreferidasMaria.AdicionarMusicasFavoritas(musicas[428]);
        //musicasPreferidasMaria.AdicionarMusicasFavoritas(musicas[13]);
        //musicasPreferidasMaria.AdicionarMusicasFavoritas(musicas[71]);

        //musicasPreferidasMaria.ExibirMusicasFavoritas();

        //musicasPreferidasMaria.GerarArquivoJson();


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
