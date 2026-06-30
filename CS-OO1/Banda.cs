class Banda
    {
    public Banda (string Nome)
    {
        this.Nome = Nome;
    }
    public string Nome { get; }

    private List<Album> albuns = new List<Album>();

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirAlbuns()
    {
        Console.WriteLine("Álbuns da banda " + Nome + ":");
        foreach (var album in albuns)
        {
            Console.WriteLine($"Nome: '{album.Nome}' Duração: {album.Duracao / 60}:{album.Duracao % 60}");
        }
    }

}