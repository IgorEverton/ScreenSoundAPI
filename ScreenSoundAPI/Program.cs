using ScreenSoundAPI.FIltros;
using ScreenSoundAPI.Modelo;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;

        var musicasPreferidas = new MusicasPreferidas("Igor");
        musicasPreferidas.AdicionarMusicaFavorita(musicas[1]);
        musicasPreferidas.AdicionarMusicaFavorita(musicas[2]);
        musicasPreferidas.AdicionarMusicaFavorita(musicas[3]);
        musicasPreferidas.AdicionarMusicaFavorita(musicas[4]);
        musicasPreferidas.AdicionarMusicaFavorita(musicas[5]);

        musicasPreferidas.ExibirMusicasFavoritas();

    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu o erro: ", ex);
    }
}