using System.Text.Json;

namespace ScreenSoundAPI.Modelo;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> MusicasFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        MusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicaFavorita(Musica musica)
    {
        MusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        foreach(var musica in MusicasFavoritas)
        {
            Console.WriteLine($"--{musica.Nome} do artista {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = MusicasFavoritas
        });
        string nomeDoArquivo = $"Musicas-Favoritas_{Nome}"; 
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Json criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }

}
