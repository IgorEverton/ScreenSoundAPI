using ScreenSoundAPI.Modelo;
using System.Linq;
namespace ScreenSoundAPI.FIltros;

internal class LinqFilter
{
    public static void FiltrarGenero(List<Musica> musicas)
    {
        var generosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in generosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
    public static void OrdenarArtistas(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(artistas => artistas.Artista).Select(artistas => artistas.Artista).Distinct().ToList();
        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
    public static void FiltrarArtistaGenero(List<Musica> musicas, string genero)
    {
        var artistasGenero = musicas.Where(musica => 
        musica.Genero!.Contains(genero)).Select(musica => 
        musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo artistas por genero --{genero}");
        foreach(var artista in artistasGenero)
        {
            Console.WriteLine($"- {artista}");
        }
    }
    public static void FiltrarMusicaArtista(List<Musica> musicas, string nmArtista)
    {
        var musicasArtista = musicas.Where(musica => 
        musica.Artista!.Equals(nmArtista)).Select(musica => 
        musica.Nome).Distinct().ToList();
        foreach(var artistaMusicas in musicasArtista)
        {
            Console.WriteLine($"--{artistaMusicas}");
        }
    }
    public static void FiltroAno(List<Musica> musica, string ano)
    {
        var musicasAno = musica.Where(musica => 
        musica.Ano!.Equals(ano)).Select(musica => 
        musica.Nome).ToList();
        Console.WriteLine($"Musicas do ano {ano}");
        foreach (var anoMusicas in musicasAno)
        {
            Console.WriteLine($"--{anoMusicas}");
        }
    }
}
