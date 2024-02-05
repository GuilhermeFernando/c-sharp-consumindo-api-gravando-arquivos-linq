using ScreenSoundAPI.Modelos;

namespace ScreenSoundAPI.Filtros;

internal class LinqFiltro
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas,string genero) 
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical: {genero}");
        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasArtista(List<Musica> musicas, string nomeArtista)
    {
        var MusicasArtista = musicas.Where(musica => musica.Artista!.Equals(nomeArtista)).ToList();
        Console.WriteLine($"Nome do artista: {nomeArtista}");
        foreach(var musica in MusicasArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    internal static void FiltraMusicasEmCsharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#")).Select(musicas => musicas.Nome).ToList();
        Console.WriteLine("Músicas em C#:");

        foreach (var musica in musicasEmCSharp)
        {
            Console.WriteLine($" -{musica}");
        }
    }
}
