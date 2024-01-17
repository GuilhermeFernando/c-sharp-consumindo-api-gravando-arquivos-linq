using ScreenSoundAPI.Modelos;


namespace ScreenSoundAPI.Filtros;
internal class LinqOrdenacao
{
    public static void ExibirListaArtistaOrdenado(List<Musica>musica)
    {
        var artistaOrdenados = musica.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artistas ordenados");
        foreach(var artista in artistaOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
