class Album {
    public  string Nome { get; }
    public Banda Banda { get; }

    private List<Musica> musicas = new List<Musica>();

    public Album(string nome, Banda banda)
    {
        Nome = nome;
        Banda = banda;
    }

    public int Duracao { get; set; }
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);

        Duracao = musica.Duracao + this.Duracao;
    }

    public void ExibirMusicas()
    {
        Console.WriteLine("Músicas do álbum " + Nome + ":");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Nome: '{musica.Nome}' Duração: {musica.Duracao / 60}:{musica.Duracao % 60}");
        }
    }
}

