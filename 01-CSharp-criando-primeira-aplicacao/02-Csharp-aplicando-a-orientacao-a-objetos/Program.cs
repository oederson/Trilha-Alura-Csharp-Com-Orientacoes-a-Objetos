using _02_Csharp_aplicando_a_orientacao_a_objetos.Models;

Banda queem = new Banda("Queen");

Banda u2 = new Banda("U2");

Musica musica1 = new Musica(queem,"Bohemian Rhapsody" ) // instanciando a musica ja passando o valor de Duração e disponivel
{
    Duracao = 273,
    Disponivel = true 
};
Musica musica2 = new Musica(u2,"Vertigo" );
Album albumDoQueen = new("A night at the opera");


musica1.Duracao = 273;
musica1.Disponivel = true; 


musica2.Duracao = 345;
musica2.Disponivel= false;

musica1.ExibirDadosDaMusica();
Console.WriteLine("");
musica2.ExibirDadosDaMusica();

Console.WriteLine(musica1.DescricaoResumida);
albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicaDoAlbum();



