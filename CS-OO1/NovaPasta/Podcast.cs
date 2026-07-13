class Podcast
{
    public string Nome { get; }
    public string Host { get; }

    public List<Episodio> episodios = new List<Episodio>();
    public Podcast(string Nome, string Host)
    {
        this.Nome = Nome;
        this.Host = Host;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    public void ExibirEpisodios()
    {
        Console.WriteLine($"Nome: {this.Nome}\nHost: {this.Host}\nEpisódeos:");
        foreach (Episodio episodio in episodios)
        {
            Console.WriteLine(episodio.Resumo);
        }
    }
}