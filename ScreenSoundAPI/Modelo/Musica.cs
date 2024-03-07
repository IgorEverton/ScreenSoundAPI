using System.Text.Json.Serialization;

namespace ScreenSoundAPI.Modelo;

internal class Musica
{
    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public Musica(string? nome, string? ano, string? artista, int duracao, string? genero)
    {
        Nome = nome;
        Ano = ano;
        Artista = artista;
        Duracao = duracao;
        Genero = genero;
    }
    public Musica()
    {

    }

    public void ExibirInfor()
    {
        Console.WriteLine($"Nome da musíca: {Nome}. Artista: {Artista}. Duração: {Duracao /1000}. Genero: {Genero}");
    }
    public void PorGenero()
    {
        List<string> artista_genero_hip_hop = new List<string>();
        List<string> artista_genero_pop = new List<string>();
        List<string> artista_genero_reb = new List<string>();

        if (Genero == "hip-hop")
        {
            artista_genero_hip_hop.Add(Artista);
        }
        else if(Genero == "pop")
        {
            artista_genero_pop.Add(Artista);
        }
        else if(Genero == "R&B")
        {
            artista_genero_reb.Add(Artista);
        }
        for(int i = 0; i < artista_genero_hip_hop.Count; i++)
        {
            Console.WriteLine($"Hip-Hop: {artista_genero_hip_hop[i]}");
            Console.WriteLine($"Pop: {artista_genero_pop[i]}");
            Console.WriteLine($"R&B: {artista_genero_reb[i]}");

        }

    }
}
