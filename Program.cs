using ScreenSoundAPI.Filtros;
using ScreenSoundAPI.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient()) 
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFiltro.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrdenacao.ExibirListaArtistaOrdenado(musicas);
        //LinqFiltro.FiltrarArtistaPorGeneroMusical(musicas, "pop");
       // LinqFiltro.FiltrarMusicasArtista(musicas, "Michel Teló");

        var MusicasPreferidas = new MusicasPreferidas("Guilherme");
        MusicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        MusicasPreferidas.AdicionarMusicasFavoritas(musicas[311]);
        MusicasPreferidas.AdicionarMusicasFavoritas(musicas[442]);
        MusicasPreferidas.AdicionarMusicasFavoritas(musicas[445]);

        MusicasPreferidas.ExibirMusicasFavoritas();
        MusicasPreferidas.GerarArquivoJson();
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
  

}